// Copywrite 2020 RipMyPaperToShreds.com - All rights reserved
// Unauthorized copying of this file, via any medium is strictly prohibited
// Proprietary and confidential
// Written by: Joshua Trimm <trimmj@etsu.edu>, 6/18/2020
// File Name: HomeController.cs

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RipMyPaperToShreds.com.Models;
using RipMyPaperToShreds.com.Models.ViewModels;
using RipMyPaperToShreds.com.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using WordEngine;

namespace RipMyPaperToShreds.com.Controllers
{
    /// <summary>
    /// Defines the <see cref="HomeController" />.
    /// </summary>
    public class HomeController : Controller
    {
        #region Fields

        /// <summary>
        /// Defines the _logger.
        /// </summary>
        private readonly ILogger<HomeController> _logger;

        /// <summary>
        /// Defines the _paperRepo.
        /// </summary>
        private readonly IPapers _paperRepo;

        /// <summary>
        /// Defines the _shredsRepo.
        /// </summary>
        private readonly IShreds _shredsRepo;

        /// <summary>
        /// Defines the _subShredsRepo.
        /// </summary>
        private readonly ISubShreds _subShredsRepo;

        private readonly IRips _ripsRepo;
        private readonly IWebHostEnvironment _hostEnv;
        private readonly IPaperUpload _paperUploadRepo;
        private readonly IHashTags _hashTagsRepo;
        private readonly IPaperHashes _paperHashesRepo;



        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="HomeController"/> class.
        /// </summary>
        /// <param name="logger">The logger<see cref="ILogger{HomeController}"/>.</param>
        /// <param name="paperRepo">The paperRepo<see cref="IPapers"/>.</param>
        /// <param name="shredsRepo">The shredsRepo<see cref="IShreds"/>.</param>
        /// <param name="subShredsRepo">The subShredsRepo<see cref="ISubShreds"/>.</param>
        public HomeController(ILogger<HomeController> logger, IHashTags hashTagsRepo, IPaperHashes paperHashesRepo, IPaperUpload paperUploadRepo, IWebHostEnvironment hostEnv, IRips ripsRepo, IPapers paperRepo, IShreds shredsRepo, ISubShreds subShredsRepo)
        {
            _logger = logger;
            _paperRepo = paperRepo;
            _shredsRepo = shredsRepo;
            _subShredsRepo = subShredsRepo;
            _ripsRepo = ripsRepo;
            _hostEnv = hostEnv;
            _paperUploadRepo = paperUploadRepo;
            _hashTagsRepo = hashTagsRepo;
            _paperHashesRepo = paperHashesRepo;
        }

        #endregion

        #region Methods

        /// <summary>
        /// The About.
        /// </summary>
        /// <returns>The <see cref="IActionResult"/>.</returns>
        public IActionResult About()
        {
            return View();
        }

        /// <summary>
        /// The Comment.
        /// </summary>
        /// <param name="id">The id<see cref="int"/>.</param>
        /// <returns>The <see cref="Task{IActionResult}"/>.</returns>
        public IActionResult Comment(int id)
        {
            return PartialView("_Comment", new { ID = id });
        }

        /// <summary>
        /// The CommentButton.
        /// </summary>
        /// <param name="id">The id<see cref="int"/>.</param>
        /// <returns>The <see cref="Task{IActionResult}"/>.</returns>
        public IActionResult CommentButton(int id)
        {
            return PartialView("_CommentButton", new { ID = id });
        }

        /// <summary>
        /// The Contact.
        /// </summary>
        /// <returns>The <see cref="IActionResult"/>.</returns>
        public IActionResult Contact()
        {
            return View();
        }

        public async Task<IActionResult> EditPaper(int id)
        {
            var paper = await _paperRepo.Read(id);

            if (paper != null)
            {
                var paperHashes = await _paperHashesRepo.ReadAll();
                //var test = paperHashes.Join(HashTags;

                
                PaperVM papersVM = new PaperVM
                {
                    ID = paper.ID,
                    Date = paper.Date,
                    Draft = paper.Draft,
                    Paper = paper.Paper,
                    ShrederId = paper.ShrederId,
                    Title = paper.Title
                };

                if (paperHashes != null)
                {
                    var getPaperHashes = await _paperHashesRepo.ReadAll();
                    var getHashes = await _hashTagsRepo.ReadAll();

                    var found = getHashes.Join(getPaperHashes, hashTag => hashTag.ID, paperHashes => paperHashes.HashTagId, 
                        (paperHashes, hashTag) => new { HashTag = paperHashes.HashTag, PaperId = hashTag.PaperId })
                        .Where(x => x.PaperId == id).ToList();

                    StringBuilder stbuilder = new StringBuilder();

                    foreach(var item in found)
                    {
                        stbuilder.Append("#" + item.HashTag + " ");
                    }

                    papersVM.HashTags = stbuilder.ToString();

                }

                return View(papersVM);
            }

            return View();

        }

        [HttpPost]
        public async Task<IActionResult> EditPaper(PaperVM papers)
        {

            if (ModelState.IsValid)
            {
                var checkPaperHashes = await _paperHashesRepo.ReadAll();
                var checkHashes = await _hashTagsRepo.ReadAll();

                var found = checkHashes.Join(checkPaperHashes, hashTag => hashTag.ID, paperHashes => paperHashes.HashTagId,
                    (paperHashes, hashTag) => new PaperHashes { HashTagId = paperHashes.ID, PaperId = hashTag.PaperId })
                    .Where(x => x.PaperId == papers.ID).ToList();



               

                var getHashes = papers.HashTags.ToString();

                getHashes = getHashes.Replace("#", string.Empty);

                var convert = JsonConvert.DeserializeObject<List<HashTags>>(getHashes);

                List<HashTags> newTagList = new List<HashTags>();

                foreach(var tag in convert)
                {
                   
                   var newtag = await _hashTagsRepo.Create(tag);
                    newTagList.Add(newtag);
                }


                ICollection<PaperHashes> newPaperHashList = new List<PaperHashes>();
                foreach(var item in newTagList)
                {
                    PaperHashes newPaperHash = new PaperHashes
                    {
                        HashTagId = item.ID,
                        PaperId = papers.ID
                    };
                    var paperHashes = await _paperHashesRepo.Create(newPaperHash);

                    newPaperHashList.Add(paperHashes);
                }

                foreach (var relation in found)
                {
                    var check = newPaperHashList.FirstOrDefault(x => x.HashTagId == relation.HashTagId);
                    if (check == null)
                    {
                       await _paperHashesRepo.Delete(relation);
                    }
                }

                Papers newPaper = new Papers
                {
                    ID = papers.ID,
                    Date = papers.Date,
                    Draft = papers.Draft,
                    //HashTags = newTagList,
                    Paper = papers.Paper,
                    ShrederId = papers.ShrederId,
                    Title = papers.Title
                };

                await _paperRepo.Update(newPaper);
                return Content("Page successfully updated!");
            }

            return View();
        }

        /// <summary>
        /// The Error.
        /// </summary>
        /// <returns>The <see cref="IActionResult"/>.</returns>
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpPost, Authorize]
        public async Task<IActionResult> FixedButton(int shredid, bool fixedButton)
        {
            var check = await _shredsRepo.Read(shredid);

            if(check != null)
            {
                check.Fixed = fixedButton;
               var updated = await _shredsRepo.Update(check);

                return Json(updated);
            }

            return Content("Shred not found.");
        }

        /// <summary>
        /// The Index.
        /// </summary>
        /// <returns>The <see cref="IActionResult"/>.</returns>
        public IActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// The NextPage.
        /// </summary>
        /// <param name="id">The id<see cref="int"/>.</param>
        /// <returns>The <see cref="Task{IActionResult}"/>.</returns>
        public async Task<IActionResult> NextPage(int id)
        {
            var papers = await _paperRepo.NextPage(id);

            var takeFive = papers.Where(x => x.Draft != true).OrderByDescending(x => x.Date.Date).ThenByDescending(x => x.Date.Year).ThenByDescending(x => x.Date.TimeOfDay).Take(5);

            if (takeFive != null)
            {
                foreach (var paper in takeFive)
                {
                    paper.Paper = System.Text.RegularExpressions.Regex.Replace(paper.Paper, "<[^>]*(>|$)", string.Empty);
                    var length = paper.Paper.Length;

                    if (length > 50)
                    {
                        paper.Paper = paper.Paper.ToString().Substring(0, 50);
                    }
                    else
                    {
                        paper.Paper = paper.Paper.ToString().Substring(0, length);

                    }
                }

                return PartialView("_NextPage", takeFive);
            }


            return PartialView("_NextPage");
        }

        /// <summary>
        /// The Paper.
        /// </summary>
        /// <param name="id">The id<see cref="int"/>.</param>
        /// <returns>The <see cref="Task{IActionResult}"/>.</returns>
        public async Task<IActionResult> Paper(int id)
        {
            var paper = await _paperRepo.Read(id);


            if (paper != null)
            {
                var shreds = await _shredsRepo.GetAllShredsForPaper(id);



                PaperShredsCommentsVM paperAndShredsAndSubShreds = new PaperShredsCommentsVM();
                paperAndShredsAndSubShreds.Paper = paper;

                var upload = await _paperUploadRepo.ReadAll();
                if (upload != null)
                {
                    paperAndShredsAndSubShreds.PaperUpload = upload.FirstOrDefault(x => x.PaperId == paper.ID);
                }

                foreach (var shred in shreds)
                {

                    var rips = await _ripsRepo.ReadAll();
                    var trueRips = rips.Where(x => x.ShredId == shred.ID && x.Rip == true).Count();
                    var falseRips = rips.Where(x => x.ShredId == shred.ID && x.Rip == false).Count();


                    ShredCommentsVM shredCommentsVM = new ShredCommentsVM
                    {
                        Shred = shred,
                        NumberOfRips = trueRips - falseRips

                    };
                    var subShreds = await _subShredsRepo.GetAllSubShredsForShred(shred.ID);


                    if (subShreds.Count() > 0)
                    {

                        shredCommentsVM.SubShreds = subShreds;

                    }

                    paperAndShredsAndSubShreds.ShredsAndComments.Add(shredCommentsVM);
                }
                return View(paperAndShredsAndSubShreds);
            }
            return RedirectToAction("Papers");
        }

        /// <summary>
        /// The Papers.
        /// </summary>
        /// <returns>The <see cref="Task{IActionResult}"/>.</returns>
        public async Task<IActionResult> Papers()
        {
            var papers = await _paperRepo.ReadAll();

            var takeFive = papers.Where(x => x.Draft != true).OrderByDescending(x => x.Date.Date).ThenByDescending(x => x.Date.Year).ThenByDescending(x => x.Date.TimeOfDay).Take(5);

            if (takeFive != null)
            {
                foreach (var paper in takeFive)
                {
                    paper.Paper = System.Text.RegularExpressions.Regex.Replace(paper.Paper, "<[^>]*(>|$)", string.Empty);
                    var length = paper.Paper.Length;

                    if (length > 50)
                    {
                        paper.Paper = paper.Paper.ToString().Substring(0, 50);
                    }
                    else
                    {
                        paper.Paper = paper.Paper.ToString().Substring(0, length);

                    }
                }

                return View(takeFive);
            }
            return View();
        }

        /// <summary>
        /// The PaperSubmitted.
        /// </summary>
        /// <returns>The <see cref="Task{IActionResult}"/>.</returns>
        public IActionResult PaperSubmitted()
        {
            return PartialView("_PaperSubmitted");
        }

        /// <summary>
        /// The Privacy.
        /// </summary>
        /// <returns>The <see cref="IActionResult"/>.</returns>
        public IActionResult Privacy()
        {
            return View();
        }

        /// <summary>
        /// The ShredButton.
        /// </summary>
        /// <returns>The <see cref="Task{IActionResult}"/>.</returns>
        public IActionResult ShredButton()
        {
            return PartialView("_ShredButton");
        }

        /// <summary>
        /// The ShredCard.
        /// </summary>
        /// <returns>The <see cref="Task{IActionResult}"/>.</returns>
        public IActionResult ShredCard()
        {
            return PartialView("_ShredCard");
        }

        /// <summary>
        /// The ShredSection.
        /// </summary>
        /// <param name="id">The id<see cref="int"/>.</param>
        /// <returns>The <see cref="Task{IActionResult}"/>.</returns>
        public async Task<IActionResult> ShredSection(int id)
        {
            var check = await _shredsRepo.GetAllShredsForPaper(id);


            if (check != null)
            {

                List<ShredCommentsVM> shredCommentList = new List<ShredCommentsVM>();

                foreach (var shred in check)
                {
                    ShredCommentsVM shredCommentsVM = new ShredCommentsVM();
                    var subShredCheck = await _subShredsRepo.GetAllSubShredsForShred(shred.ID);

                    shredCommentsVM.Shred = shred;

                    if (subShredCheck != null)
                    {
                        shredCommentsVM.SubShreds = subShredCheck;
                    }

                    shredCommentList.Add(shredCommentsVM);

                }
                return PartialView("_ShredSection", shredCommentList);

            }
            return PartialView("_ShredSection");
        }

        /// <summary>
        /// The StartShred.
        /// </summary>
        /// <param name="id">The id<see cref="int"/>.</param>
        /// <returns>The <see cref="Task{IActionResult}"/>.</returns>
        public async Task<IActionResult> StartShred(int id)
        {
            var getPaperCreator = await _paperRepo.Read(id);

            if (getPaperCreator != null)
            {
                Shreds newShred = new Shreds
                {
                    Date = DateTime.UtcNow,
                    PaperId = id,
                    ShredyId = getPaperCreator.ShrederId

                };

                return PartialView("_StartShred", newShred);
            }
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> EditShred(int id)
        {
            var getPaperCreator = await _shredsRepo.Read(id);

            if (getPaperCreator != null)
            {
                

                return PartialView("Paper-Partials/_EditShred", getPaperCreator);
            }
            return RedirectToAction("Index");
        }

        /// <summary>
        /// The SubmitComment.
        /// </summary>
        /// <param name="sub">The sub<see cref="SubShreds"/>.</param>
        /// <returns>The <see cref="Task{IActionResult}"/>.</returns>
        [HttpPost, Authorize]
        public async Task<IActionResult> SubmitComment(SubShreds sub)
        {
            if (ModelState.IsValid)
            {
                await _subShredsRepo.Create(sub);
                return PartialView("Paper-Partials/_SubShred", sub);
            }

            return Json(sub);
        }

        /// <summary>
        /// The SubmitPaper.
        /// </summary>
        /// <returns>The <see cref="IActionResult"/>.</returns>
        public IActionResult SubmitPaper()
        {
            return View();
        }

        /// <summary>
        /// The SubmitPaper.
        /// </summary>
        /// <param name="papers">The papers<see cref="Papers"/>.</param>
        /// <returns>The <see cref="Task{IActionResult}"/>.</returns>
        [HttpPost]
        public async Task<IActionResult> SubmitPaper(PaperVM papersVM)
        {
            
            if (ModelState.IsValid)
            {
                Papers newPaper = new Papers
                {
                    ID = papersVM.ID,
                    Date = papersVM.Date,
                    Draft = papersVM.Draft,
                    //HashTags = newTagList,
                    Paper = papersVM.Paper,
                    ShrederId = papersVM.ShrederId,
                    Title = papersVM.Title
                };

                var replaceNewPaper = await _paperRepo.Create(newPaper);

                var getHashes = papersVM.HashTags.ToString();

                getHashes = getHashes.Replace("#", string.Empty).Trim();

                var convert = JsonConvert.DeserializeObject<List<HashTags>>(getHashes);

                List<HashTags> newTagList = new List<HashTags>();

                foreach (var tag in convert)
                {
                    if(!tag.HashTag.Equals(" "))
                    {
                        var newtag = await _hashTagsRepo.Create(tag);
                        newTagList.Add(newtag);
                    }

                }

                ICollection<PaperHashes> newPaperHashList = new List<PaperHashes>();
                foreach (var item in newTagList)
                {
                    
                    PaperHashes newPaperHash = new PaperHashes
                    {
                        HashTagId = item.ID,
                        PaperId = replaceNewPaper.ID
                    };

                    
                    var paperHashes = await _paperHashesRepo.Create(newPaperHash);

                    newPaperHashList.Add(paperHashes);
                }



                return PartialView("_PaperSubmitted");
            }
            return View(papersVM);
        }

        /// <summary>
        /// The SubmitShred.
        /// </summary>
        /// <param name="shredCreated">The shredCreated<see cref="Shreds"/>.</param>
        /// <returns>The <see cref="Task{IActionResult}"/>.</returns>
        [HttpPost, Authorize]
        public async Task<IActionResult> SubmitShred(Shreds shredCreated)
        {
            var shredCheck = await _shredsRepo.GetAllShredsForPaper(shredCreated.PaperId);

            if (shredCheck != null)
            {
                //check to see if the user has already submitted a shred.
                var check = shredCheck.Where(x => x.ShrederId == shredCreated.ShrederId);

                if (check.Count() == 0)
                {
                    var create = await _shredsRepo.Create(shredCreated);

                    return RedirectToAction("ShredSection", new { id = shredCreated.PaperId });
                }
                else
                {

                }

                return RedirectToAction("ShredSection", new { id = shredCreated.PaperId });
            }
            return RedirectToAction("ShredSection", new { id = shredCreated.PaperId });
        }

        [HttpPost, Authorize]
        public async Task<IActionResult> UpdateShred(Shreds shredToUpdate)
        {

            if (ModelState.IsValid)
            {

                await _shredsRepo.Update(shredToUpdate);

                return RedirectToAction("ShredSection", new { id = shredToUpdate.PaperId });

            }
            return RedirectToAction("ShredSection", new { id = shredToUpdate.PaperId });

        }

        [HttpPost, Authorize]
        public async Task<IActionResult> DeleteShred(int id)
        {
            var shred = await _shredsRepo.Read(id);
            var paperId = shred.PaperId;

            if (shred != null)
            {
                await _shredsRepo.Delete(shred);

                return RedirectToAction("ShredSection", new { id = paperId });

            }
            return RedirectToAction("ShredSection", new { id = paperId });
        }

        public async Task<IActionResult> EditComment(int id)
        {
            var comment = await _subShredsRepo.Read(id);

            if (comment != null)
            {
                return PartialView("Paper-Partials/_EditComment", comment);
            }
            return View();
        }

        [HttpPost, Authorize]
        public async Task<IActionResult> UpdateComment(SubShreds comment)
        {
            if (ModelState.IsValid)
            {
                await _subShredsRepo.Update(comment);
                return Content("Comment Updated");
            }
            return Content("Comment Not Updated");
        }
        [HttpPost, Authorize]
        public async Task<IActionResult> DeleteComment(int id)
        {
            var comment = await _subShredsRepo.Read(id);

            if (comment != null)
            {
                await _subShredsRepo.Delete(comment);
                return Content("Comment Deleted");
            }
            return Content("Comment Not deleted");
        }
        [HttpPost, Authorize]
        public async Task<IActionResult> Vote(Rips newRip)
        {
            if (ModelState.IsValid)
            {
                var check = await _ripsRepo.ReadAll();
                var find = check.FirstOrDefault(x => x.ShrederId == newRip.ShrederId && x.ShredId == newRip.ShredId);


                if(find == null)
                {
                    var createRip = await _ripsRepo.Create(newRip);
                    return Json(newRip);
                }
                else
                {
                    newRip.ID = find.ID;
                    await _ripsRepo.Update(newRip);
                    return Json(newRip);
                }
            }
            
            return Json(newRip);
        }

        [HttpPost]
        [RequestFormLimits(ValueLengthLimit = int.MaxValue, MultipartBodyLengthLimit = int.MaxValue)]
        public async Task<IActionResult> UploadFile(UploadFormVM form)
        {
            //get the file
            //var file = Request.Form.Files[0];
            if (ModelState.IsValid)
            {
                var file = form.File;

                //check if the file is there and make sure it has content
                if (file != null && file.Length > 0)
                {
                    //get the uploaded file name. 
                    var fileName = Path.GetFileName(file.FileName);

                    var setGuid = Guid.NewGuid();

                    //get the wwwroot path and append the guid dir
                    var filePath = _hostEnv.WebRootPath + "\\uploads\\" + setGuid + "\\";

                    //create the dir
                    Directory.CreateDirectory(filePath);

                    //create img dir
                    Directory.CreateDirectory(filePath + "\\imgs\\");

                    //create the path for the uploaded file
                    var path = Path.Combine(filePath, fileName);

                    //copy the uploaded file to the dir
                    using (var stream = System.IO.File.Create(path))
                    {
                        await file.CopyToAsync(stream);
                    }

                    //convert the uploaded file into html and make picture dir

                    ConvertDocToHtml newConverter = new ConvertDocToHtml(path, fileName, filePath);
                    newConverter.SetConverterSettings();
                    newConverter.Convert();
                    newConverter.CustomizeCss("quote", "span");

                    //
                    PaperUpload newUpload = new PaperUpload
                    {
                        FilePath = filePath,
                        UniqueFileName = fileName,
                        UploadDate = DateTime.UtcNow,
                        GuidId = setGuid,
                        Css = newConverter.Css
                    };

                    Papers newPaper = new Papers
                    {
                        Paper = newConverter.Html

                    };

                    PaperUploadVM newVM = new PaperUploadVM
                    {
                        PaperUpload = newUpload,
                        Paper = newPaper
                    };



                    return Json(newVM);
                }
            }

            return Json("error");
        }

        [HttpPost, Authorize]
        public async Task<IActionResult> DocxInsertedForm(SubmitPaperVM submitPaperVM)
        {
            if (ModelState.IsValid)
            {
                Papers newPaper = new Papers
                {
                    Date = submitPaperVM.Date,
                    Draft = submitPaperVM.Draft,
                    //HashTags = (ICollection<PaperHashes>)submitPaperVM.HashTags,
                    ID = 0,
                    Paper = submitPaperVM.Paper,
                    ShrederId = submitPaperVM.ShrederId,
                    Title = submitPaperVM.Title
                };

                var createdPaper = await _paperRepo.Create(newPaper);

                

                PaperUpload newUpload = new PaperUpload
                {
                    Css = submitPaperVM.Css,
                    FilePath = submitPaperVM.FilePath,
                    GuidId = submitPaperVM.GuidId,
                    ID = 0,
                    PaperId = createdPaper.ID
                };

                var createdPaperUpload = await _paperUploadRepo.Create(newUpload);

                return PartialView("_PaperSubmitted");
            }

            return View(submitPaperVM);
        }

        #endregion
    }
}

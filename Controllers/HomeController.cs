// Copywrite 2020 RipMyPaperToShreds.com - All rights reserved
// Unauthorized copying of this file, via any medium is strictly prohibited
// Proprietary and confidential
// Written by: Joshua Trimm <trimmj@etsu.edu>, 6/18/2020
// File Name: HomeController.cs

namespace RipMyPaperToShreds.com.Controllers
{
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.Logging;
    using RipMyPaperToShreds.com.Models;
    using RipMyPaperToShreds.com.Models.ViewModels;
    using RipMyPaperToShreds.com.Services.Interfaces;
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;
    using System.Threading.Tasks;

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

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="HomeController"/> class.
        /// </summary>
        /// <param name="logger">The logger<see cref="ILogger{HomeController}"/>.</param>
        /// <param name="paperRepo">The paperRepo<see cref="IPapers"/>.</param>
        /// <param name="shredsRepo">The shredsRepo<see cref="IShreds"/>.</param>
        /// <param name="subShredsRepo">The subShredsRepo<see cref="ISubShreds"/>.</param>
        public HomeController(ILogger<HomeController> logger, IRips ripsRepo, IPapers paperRepo, IShreds shredsRepo, ISubShreds subShredsRepo)
        {
            _logger = logger;
            _paperRepo = paperRepo;
            _shredsRepo = shredsRepo;
            _subShredsRepo = subShredsRepo;
            _ripsRepo = ripsRepo;
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
        public async Task<IActionResult> Comment(int id)
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
                return View(paper);
            }

            return View();

        }

        [HttpPost]
        public async Task<IActionResult> EditPaper(Papers papers)
        {
            if (ModelState.IsValid)
            {
                await _paperRepo.Update(papers);
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
        public async Task<IActionResult> PaperSubmitted()
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
        public async Task<IActionResult> ShredButton()
        {
            return PartialView("_ShredButton");
        }

        /// <summary>
        /// The ShredCard.
        /// </summary>
        /// <returns>The <see cref="Task{IActionResult}"/>.</returns>
        public async Task<IActionResult> ShredCard()
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
                return Json(sub);
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
        public async Task<IActionResult> SubmitPaper(Papers papers)
        {
            if (ModelState.IsValid)
            {
                await _paperRepo.Create(papers);

                return PartialView("_PaperSubmitted");
            }
            return View(papers);
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

        #endregion
    }
}

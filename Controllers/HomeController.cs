// Copywrite 2020 RipMyPaperToShreds.com - All rights reserved
// Unauthorized copying of this file, via any medium is strictly prohibited
// Proprietary and confidential
// Written by: Joshua Trimm <trimmj@etsu.edu>, 6/18/2020
// File Name: HomeController.cs

namespace RipMyPaperToShreds.com.Controllers
{
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.Extensions.Logging;
    using RipMyPaperToShreds.com.Models;
    using RipMyPaperToShreds.com.Models.ViewModels;
    using RipMyPaperToShreds.com.Services.Interfaces;
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;
    using System.Threading.Tasks;
    using System.Web;

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
        private readonly IPapers _paperRepo;
        private readonly IShreds _shredsRepo;
        private readonly ISubShreds _subShredsRepo;

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="HomeController"/> class.
        /// </summary>
        /// <param name="logger">The logger<see cref="ILogger{HomeController}"/>.</param>
        public HomeController(ILogger<HomeController> logger, IPapers paperRepo, IShreds shredsRepo, ISubShreds subShredsRepo)
        {
            _logger = logger;
            _paperRepo = paperRepo;
            _shredsRepo = shredsRepo;
            _subShredsRepo = subShredsRepo;
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
        /// <returns>The <see cref="Task{IActionResult}"/>.</returns>
        public async Task<IActionResult> Comment()
        {
            return PartialView("_Comment");
        }

        /// <summary>
        /// The CommentButton.
        /// </summary>
        /// <returns>The <see cref="Task{IActionResult}"/>.</returns>
        public async Task<IActionResult> CommentButton()
        {
            return PartialView("_CommentButton");
        }

        /// <summary>
        /// The Contact.
        /// </summary>
        /// <returns>The <see cref="IActionResult"/>.</returns>
        public IActionResult Contact()
        {
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

        /// <summary>
        /// The Index.
        /// </summary>
        /// <returns>The <see cref="IActionResult"/>.</returns>
        public IActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// The Paper.
        /// </summary>
        /// <returns>The <see cref="Task{IActionResult}"/>.</returns>
        public async Task<IActionResult> Paper(int id)
        {
            var paper = await _paperRepo.Read(id);
            
            
            if(paper != null)
            {
                var shreds = await _shredsRepo.GetAllShredsForPaper(id);

                PaperShredsCommentsVM paperAndShredsAndSubShreds = new PaperShredsCommentsVM();
                paperAndShredsAndSubShreds.Paper = paper;
               
                foreach(var shred in shreds)
                {
                    ShredCommentsVM shredCommentsVM = new ShredCommentsVM
                    {
                        Shred = shred,
                        
                    };
                    var subShreds = await _subShredsRepo.GetAllSubShredsForShred(shred.ID);


                    if(subShreds.Count() > 0)
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

            var takeThree = papers.Where(x => x.Draft != true).Take(5);

            if(takeThree != null)
            {
                foreach(var paper in takeThree)
                {
                    paper.Paper = System.Text.RegularExpressions.Regex.Replace(paper.Paper, "<[^>]*(>|$)", string.Empty);
                    var length = paper.Paper.Length;
                    
                    if(length > 50)
                    {
                        paper.Paper = paper.Paper.ToString().Substring(0, 50);
                    }
                    else
                    {
                        paper.Paper = paper.Paper.ToString().Substring(0, length);

                    }
                }
                
                return View(takeThree);
            }
            return View();
        }

        public async Task<IActionResult> NextPage(int id)
        {
            var papers = await _paperRepo.NextPage(id);

            var takeThree = papers.Where(x => x.Draft != true).Take(5);

            if (takeThree != null)
            {
                foreach (var paper in takeThree)
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

                return PartialView("_NextPage", takeThree);
            }


            return PartialView("_NextPage");
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
        /// <returns>The <see cref="Task{IActionResult}"/>.</returns>
        public async Task<IActionResult> ShredSection(int id)
        {
            var check = await _shredsRepo.GetAllShredsForPaper(id);


            if(check != null)
            {

                List<ShredCommentsVM> shredCommentList = new List<ShredCommentsVM>();

                foreach (var shred in check)
                {
                    ShredCommentsVM shredCommentsVM = new ShredCommentsVM();
                    var subShredCheck = await _subShredsRepo.GetAllSubShredsForShred(shred.ID);

                    shredCommentsVM.Shred = shred;

                    if(subShredCheck != null)
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
        /// <returns>The <see cref="Task{IActionResult}"/>.</returns>
        public async Task<IActionResult> StartShred(int id)
        {
            var getPaperCreator = await _paperRepo.Read(id);

            if(getPaperCreator != null)
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

        /// <summary>
        /// The SubmitPaper.
        /// </summary>
        /// <returns>The <see cref="IActionResult"/>.</returns>
        public IActionResult SubmitPaper()
        {
            return View();
        }
        public async Task<IActionResult> ShredButton()
        {
            return PartialView("_ShredButton");
        }

        [HttpPost]
        public async Task<IActionResult> SubmitPaper(Papers papers)
        {
            if(ModelState.IsValid)
            {
                await _paperRepo.Create(papers);

                return PartialView("_PaperSubmitted");
            }
            return View(papers);
        }

        public async Task<IActionResult> PaperSubmitted()
        {
            return PartialView("_PaperSubmitted");
        }

        [HttpPost, Authorize]
        public async Task<IActionResult> SubmitShred(Shreds shredCreated)
        {
            var shredCheck = await _shredsRepo.GetAllShredsForPaper(shredCreated.PaperId);

            if(shredCheck != null)
            {
                //check to see if the user has already submitted a shred.
                var check = shredCheck.Where(x => x.ShrederId == shredCreated.ShrederId);
                
                if(check.Count() == 0)
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

        #endregion
    }
}

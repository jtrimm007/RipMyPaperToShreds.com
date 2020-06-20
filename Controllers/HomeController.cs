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
    using RipMyPaperToShreds.com.Services.Interfaces;
    using System.Diagnostics;
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
        private readonly IPapers _paperRepo;

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="HomeController"/> class.
        /// </summary>
        /// <param name="logger">The logger<see cref="ILogger{HomeController}"/>.</param>
        public HomeController(ILogger<HomeController> logger, IPapers paperRepo)
        {
            _logger = logger;
            _paperRepo = paperRepo;
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
        [Authorize]
        public async Task<IActionResult> Paper()
        {
            return View();
        }

        /// <summary>
        /// The Papers.
        /// </summary>
        /// <returns>The <see cref="Task{IActionResult}"/>.</returns>
        public async Task<IActionResult> Papers()
        {
            return View();
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
        public async Task<IActionResult> ShredSection()
        {
            return PartialView("_ShredSection");
        }

        /// <summary>
        /// The StartShred.
        /// </summary>
        /// <returns>The <see cref="Task{IActionResult}"/>.</returns>
        public async Task<IActionResult> StartShred()
        {
            return PartialView("_StartShred");
        }

        /// <summary>
        /// The SubmitPaper.
        /// </summary>
        /// <returns>The <see cref="IActionResult"/>.</returns>
        public IActionResult SubmitPaper()
        {
            return View();
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

        #endregion
    }
}

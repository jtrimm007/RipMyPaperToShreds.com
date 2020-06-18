// Copywrite 2020 RipMyPaperToShreds.com - All rights reserved
// Unauthorized copying of this file, via any medium is strictly prohibited
// Proprietary and confidential
// Written by: Joshua Trimm <trimmj@etsu.edu>, 6/18/2020
// File Name: Logout.cshtml.cs

namespace RipMyPaperToShreds.com.Areas.Identity.Pages.Account
{
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.RazorPages;
    using Microsoft.Extensions.Logging;
    using RipMyPaperToShreds.com.Models;
    using System.Threading.Tasks;

    /// <summary>
    /// Defines the <see cref="LogoutModel" />.
    /// </summary>
    [AllowAnonymous]
    public class LogoutModel : PageModel
    {
        #region Fields

        /// <summary>
        /// Defines the _logger.
        /// </summary>
        private readonly ILogger<LogoutModel> _logger;

        /// <summary>
        /// Defines the _signInManager.
        /// </summary>
        private readonly SignInManager<ApplicationUser> _signInManager;

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="LogoutModel"/> class.
        /// </summary>
        /// <param name="signInManager">The signInManager<see cref="SignInManager{ApplicationUser}"/>.</param>
        /// <param name="logger">The logger<see cref="ILogger{LogoutModel}"/>.</param>
        public LogoutModel(SignInManager<ApplicationUser> signInManager, ILogger<LogoutModel> logger)
        {
            _signInManager = signInManager;
            _logger = logger;
        }

        #endregion

        #region Methods

        /// <summary>
        /// The OnGet.
        /// </summary>
        public void OnGet()
        {
        }

        /// <summary>
        /// The OnPost.
        /// </summary>
        /// <param name="returnUrl">The returnUrl<see cref="string"/>.</param>
        /// <returns>The <see cref="Task{IActionResult}"/>.</returns>
        public async Task<IActionResult> OnPost(string returnUrl = null)
        {
            await _signInManager.SignOutAsync();
            _logger.LogInformation("User logged out.");
            if (returnUrl != null)
            {
                return LocalRedirect(returnUrl);
            }
            else
            {
                return RedirectToPage();
            }
        }

        #endregion
    }
}

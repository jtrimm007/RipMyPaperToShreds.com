// Copywrite 2020 RipMyPaperToShreds.com - All rights reserved
// Unauthorized copying of this file, via any medium is strictly prohibited
// Proprietary and confidential
// Written by: Joshua Trimm <trimmj@etsu.edu>, 6/18/2020
// File Name: DeletePersonalData.cshtml.cs

namespace RipMyPaperToShreds.com.Areas.Identity.Pages.Account.Manage
{
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.RazorPages;
    using Microsoft.Extensions.Logging;
    using RipMyPaperToShreds.com.Models;
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.Threading.Tasks;

    /// <summary>
    /// Defines the <see cref="DeletePersonalDataModel" />.
    /// </summary>
    public class DeletePersonalDataModel : PageModel
    {
        #region Fields

        /// <summary>
        /// Defines the _logger.
        /// </summary>
        private readonly ILogger<DeletePersonalDataModel> _logger;

        /// <summary>
        /// Defines the _signInManager.
        /// </summary>
        private readonly SignInManager<ApplicationUser> _signInManager;

        /// <summary>
        /// Defines the _userManager.
        /// </summary>
        private readonly UserManager<ApplicationUser> _userManager;

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="DeletePersonalDataModel"/> class.
        /// </summary>
        /// <param name="userManager">The userManager<see cref="UserManager{ApplicationUser}"/>.</param>
        /// <param name="signInManager">The signInManager<see cref="SignInManager{ApplicationUser}"/>.</param>
        /// <param name="logger">The logger<see cref="ILogger{DeletePersonalDataModel}"/>.</param>
        public DeletePersonalDataModel(
            UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager,
            ILogger<DeletePersonalDataModel> logger)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _logger = logger;
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets the Input.
        /// </summary>
        [BindProperty]
        public InputModel Input { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether RequirePassword.
        /// </summary>
        public bool RequirePassword { get; set; }

        #endregion

        #region Methods

        /// <summary>
        /// The OnGet.
        /// </summary>
        /// <returns>The <see cref="Task{IActionResult}"/>.</returns>
        public async Task<IActionResult> OnGet()
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return NotFound($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
            }

            RequirePassword = await _userManager.HasPasswordAsync(user);
            return Page();
        }

        /// <summary>
        /// The OnPostAsync.
        /// </summary>
        /// <returns>The <see cref="Task{IActionResult}"/>.</returns>
        public async Task<IActionResult> OnPostAsync()
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return NotFound($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
            }

            RequirePassword = await _userManager.HasPasswordAsync(user);
            if (RequirePassword)
            {
                if (!await _userManager.CheckPasswordAsync(user, Input.Password))
                {
                    ModelState.AddModelError(string.Empty, "Incorrect password.");
                    return Page();
                }
            }

            var result = await _userManager.DeleteAsync(user);
            var userId = await _userManager.GetUserIdAsync(user);
            if (!result.Succeeded)
            {
                throw new InvalidOperationException($"Unexpected error occurred deleting user with ID '{userId}'.");
            }

            await _signInManager.SignOutAsync();

            _logger.LogInformation("User with ID '{UserId}' deleted themselves.", userId);

            return Redirect("~/");
        }

        #endregion

        /// <summary>
        /// Defines the <see cref="InputModel" />.
        /// </summary>
        public class InputModel
        {
            #region Properties

            /// <summary>
            /// Gets or sets the Password.
            /// </summary>
            [Required]
            [DataType(DataType.Password)]
            public string Password { get; set; }

            #endregion
        }
    }
}

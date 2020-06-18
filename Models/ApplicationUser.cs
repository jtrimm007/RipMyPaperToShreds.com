// Copywrite 2020 RipMyPaperToShreds.com - All rights reserved
// Unauthorized copying of this file, via any medium is strictly prohibited
// Proprietary and confidential
// Written by: Joshua Trimm <trimmj@etsu.edu>, 6/18/2020
// File Name: ApplicationUser.cs

namespace RipMyPaperToShreds.com.Models
{
    using Microsoft.AspNetCore.Identity;
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// Defines the <see cref="ApplicationUser" />.
    /// </summary>
    public class ApplicationUser : IdentityUser
    {
        #region Properties

        /// <summary>
        /// Gets or sets the ScreenName.
        /// </summary>
        [Required]
        public string ScreenName { get; set; }

        #endregion
    }
}

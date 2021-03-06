﻿// Copywrite 2020 RipMyPaperToShreds.com - All rights reserved
// Unauthorized copying of this file, via any medium is strictly prohibited
// Proprietary and confidential
// Written by: Joshua Trimm <trimmj@etsu.edu>, 6/19/2020
// File Name: ManageNavPages.cs

namespace RipMyPaperToShreds.com.Areas.Identity.Pages.Account.Manage
{
    using Microsoft.AspNetCore.Mvc.Rendering;
    using System;

    /// <summary>
    /// Defines the <see cref="ManageNavPages" />.
    /// </summary>
    public static class ManageNavPages
    {
        #region Properties

        /// <summary>
        /// Gets the ChangePassword.
        /// </summary>
        public static string ChangePassword => "ChangePassword";

        /// <summary>
        /// Gets the DeletePersonalData.
        /// </summary>
        public static string DeletePersonalData => "DeletePersonalData";

        /// <summary>
        /// Gets the DownloadPersonalData.
        /// </summary>
        public static string DownloadPersonalData => "DownloadPersonalData";

        /// <summary>
        /// Gets the Email.
        /// </summary>
        public static string Email => "Email";

        /// <summary>
        /// Gets the ExternalLogins.
        /// </summary>
        public static string ExternalLogins => "ExternalLogins";

        /// <summary>
        /// Gets the Index.
        /// </summary>
        public static string Index => "Index";

        /// <summary>
        /// Gets the MyPapers.
        /// </summary>
        public static string MyPapers => "MyPapers";

        /// <summary>
        /// Gets the MyShreds.
        /// </summary>
        public static string MyShreds => "MyShreds";

        /// <summary>
        /// Gets the PersonalData.
        /// </summary>
        public static string PersonalData => "PersonalData";

        /// <summary>
        /// Gets the TwoFactorAuthentication.
        /// </summary>
        public static string TwoFactorAuthentication => "TwoFactorAuthentication";

        #endregion

        #region Methods

        /// <summary>
        /// The ChangePasswordNavClass.
        /// </summary>
        /// <param name="viewContext">The viewContext<see cref="ViewContext"/>.</param>
        /// <returns>The <see cref="string"/>.</returns>
        public static string ChangePasswordNavClass(ViewContext viewContext) => PageNavClass(viewContext, ChangePassword);

        /// <summary>
        /// The DeletePersonalDataNavClass.
        /// </summary>
        /// <param name="viewContext">The viewContext<see cref="ViewContext"/>.</param>
        /// <returns>The <see cref="string"/>.</returns>
        public static string DeletePersonalDataNavClass(ViewContext viewContext) => PageNavClass(viewContext, DeletePersonalData);

        /// <summary>
        /// The DownloadPersonalDataNavClass.
        /// </summary>
        /// <param name="viewContext">The viewContext<see cref="ViewContext"/>.</param>
        /// <returns>The <see cref="string"/>.</returns>
        public static string DownloadPersonalDataNavClass(ViewContext viewContext) => PageNavClass(viewContext, DownloadPersonalData);

        /// <summary>
        /// The EmailNavClass.
        /// </summary>
        /// <param name="viewContext">The viewContext<see cref="ViewContext"/>.</param>
        /// <returns>The <see cref="string"/>.</returns>
        public static string EmailNavClass(ViewContext viewContext) => PageNavClass(viewContext, Email);

        /// <summary>
        /// The ExternalLoginsNavClass.
        /// </summary>
        /// <param name="viewContext">The viewContext<see cref="ViewContext"/>.</param>
        /// <returns>The <see cref="string"/>.</returns>
        public static string ExternalLoginsNavClass(ViewContext viewContext) => PageNavClass(viewContext, ExternalLogins);

        /// <summary>
        /// The IndexNavClass.
        /// </summary>
        /// <param name="viewContext">The viewContext<see cref="ViewContext"/>.</param>
        /// <returns>The <see cref="string"/>.</returns>
        public static string IndexNavClass(ViewContext viewContext) => PageNavClass(viewContext, Index);

        /// <summary>
        /// The PapersNavClass.
        /// </summary>
        /// <param name="viewContext">The viewContext<see cref="ViewContext"/>.</param>
        /// <returns>The <see cref="string"/>.</returns>
        public static string PapersNavClass(ViewContext viewContext) => PageNavClass(viewContext, MyPapers);

        /// <summary>
        /// The PersonalDataNavClass.
        /// </summary>
        /// <param name="viewContext">The viewContext<see cref="ViewContext"/>.</param>
        /// <returns>The <see cref="string"/>.</returns>
        public static string PersonalDataNavClass(ViewContext viewContext) => PageNavClass(viewContext, PersonalData);

        /// <summary>
        /// The ShredsNavClass.
        /// </summary>
        /// <param name="viewContext">The viewContext<see cref="ViewContext"/>.</param>
        /// <returns>The <see cref="string"/>.</returns>
        public static string ShredsNavClass(ViewContext viewContext) => PageNavClass(viewContext, MyShreds);

        /// <summary>
        /// The TwoFactorAuthenticationNavClass.
        /// </summary>
        /// <param name="viewContext">The viewContext<see cref="ViewContext"/>.</param>
        /// <returns>The <see cref="string"/>.</returns>
        public static string TwoFactorAuthenticationNavClass(ViewContext viewContext) => PageNavClass(viewContext, TwoFactorAuthentication);

        /// <summary>
        /// The PageNavClass.
        /// </summary>
        /// <param name="viewContext">The viewContext<see cref="ViewContext"/>.</param>
        /// <param name="page">The page<see cref="string"/>.</param>
        /// <returns>The <see cref="string"/>.</returns>
        private static string PageNavClass(ViewContext viewContext, string page)
        {
            var activePage = viewContext.ViewData["ActivePage"] as string
                ?? System.IO.Path.GetFileNameWithoutExtension(viewContext.ActionDescriptor.DisplayName);
            return string.Equals(activePage, page, StringComparison.OrdinalIgnoreCase) ? "active" : null;
        }

        #endregion
    }
}

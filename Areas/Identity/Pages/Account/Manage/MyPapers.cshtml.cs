// Copywrite 2020 RipMyPaperToShreds.com - All rights reserved
// Unauthorized copying of this file, via any medium is strictly prohibited
// Proprietary and confidential
// Written by: Joshua Trimm <trimmj@etsu.edu>, 6/19/2020
// File Name: MyPapers.cshtml.cs

namespace RipMyPaperToShreds.com.Areas.Identity.Pages.Account.Manage
{
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.RazorPages;
    using RipMyPaperToShreds.com.Models;
    using RipMyPaperToShreds.com.Services.Interfaces;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>
    /// Defines the <see cref="MyPapersModel" />.
    /// </summary>
    public class MyPapersModel : PageModel
    {
        private UserManager<ApplicationUser> _userManager;
        private IPapers _papersRepo;
        #region Methods

        public MyPapersModel(UserManager<ApplicationUser> userManager, IPapers papersRepo)
        {
            _userManager = userManager;
            _papersRepo = papersRepo;
        }

        public IList<Papers> Papers { get; set; }

        /// <summary>
        /// The OnGet.
        /// </summary>
        public async Task OnGetAsync()
        {
            var user = await _userManager.GetUserAsync(User);

            if(user != null)
            {
                var queryPapers = await _papersRepo.ReadAll();
                Papers = queryPapers.Where(x => x.ShrederId == user.Id).ToList();


            }

            
        }

        #endregion
    }
}

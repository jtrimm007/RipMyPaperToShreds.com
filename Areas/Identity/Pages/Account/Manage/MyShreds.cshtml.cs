// Copywrite 2020 RipMyPaperToShreds.com - All rights reserved
// Unauthorized copying of this file, via any medium is strictly prohibited
// Proprietary and confidential
// Written by: Joshua Trimm <trimmj@etsu.edu>, 6/19/2020
// File Name: MyShreds.cshtml.cs

namespace RipMyPaperToShreds.com.Areas.Identity.Pages.Account.Manage
{
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc.RazorPages;
    using RipMyPaperToShreds.com.Models;
    using RipMyPaperToShreds.com.Services.Interfaces;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>
    /// Defines the <see cref="MyShredsModel" />.
    /// </summary>
    public class MyShredsModel : PageModel
    {
        #region Fields

        /// <summary>
        /// Defines the _papersRepo.
        /// </summary>
        private IPapers _papersRepo;

        /// <summary>
        /// Defines the _shredsRepo.
        /// </summary>
        private IShreds _shredsRepo;

        /// <summary>
        /// Defines the _userManager.
        /// </summary>
        private UserManager<ApplicationUser> _userManager;

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="MyShredsModel"/> class.
        /// </summary>
        /// <param name="userManager">The userManager<see cref="UserManager{ApplicationUser}"/>.</param>
        /// <param name="papersRepo">The papersRepo<see cref="IPapers"/>.</param>
        /// <param name="shredsRepo">The shredsRepo<see cref="IShreds"/>.</param>
        public MyShredsModel(UserManager<ApplicationUser> userManager, IPapers papersRepo, IShreds shredsRepo)
        {
            _userManager = userManager;
            _papersRepo = papersRepo;
            _shredsRepo = shredsRepo;
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets the MyShreds.
        /// </summary>
        public IList<Shreds> Shreds { get; set; }
    

        #endregion

        #region Methods

        /// <summary>
        /// The OnGet.
        /// </summary>
        /// <returns>The <see cref="Task"/>.</returns>
        public async Task OnGetAsync()
        {
            var user = await _userManager.GetUserAsync(User);

            if (user != null)
            {
                var queryShreds = await _shredsRepo.ReadAll();
                Shreds = queryShreds.Where(x => x.ShrederId == user.Id).ToList();
               


            }
        }

        #endregion
    }
}

// Copywrite 2020 RipMyPaperToShreds.com - All rights reserved
// Unauthorized copying of this file, via any medium is strictly prohibited
// Proprietary and confidential
// Written by: Joshua Trimm <trimmj@etsu.edu>, 6/19/2020
// File Name: Papers.cs

namespace RipMyPaperToShreds.com.Services.Repos
{
    using Microsoft.EntityFrameworkCore;
    using RipMyPaperToShreds.com.Data;
    using RipMyPaperToShreds.com.Services.Interfaces;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>
    /// Defines the <see cref="Papers" />.
    /// </summary>
    public class Papers : IPapers
    {
        #region Fields

        /// <summary>
        /// Defines the _db.
        /// </summary>
        private ApplicationDbContext _db;

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="Papers"/> class.
        /// </summary>
        /// <param name="db">The db<see cref="ApplicationDbContext"/>.</param>
        public Papers(ApplicationDbContext db)
        {
            _db = db;
        }

        #endregion

        #region Methods

        /// <summary>
        /// The Create.
        /// </summary>
        /// <param name="paper">The paper<see cref="Models.Papers"/>.</param>
        /// <returns>The <see cref="Task{Models.Papers}"/>.</returns>
        public async Task<Models.Papers> Create(Models.Papers paper)
        {
            var check = await Read(paper.ID);

            if (check == null)
            {
                await _db.Papers.AddAsync(paper);
                await _db.SaveChangesAsync();
                return paper;
            }
            return paper;
        }

        /// <summary>
        /// The Delete.
        /// </summary>
        /// <param name="paper">The paper<see cref="Models.Papers"/>.</param>
        /// <returns>The <see cref="Task"/>.</returns>
        public async Task Delete(Models.Papers paper)
        {
            var check = await Read(paper.ID);

            if (check != null)
            {
                _db.Papers.Remove(paper);
                await _db.SaveChangesAsync();

            }
        }

        public async Task<ICollection<Models.Papers>> NextPage(int pageNumber)
        {
            var numberOfListings = 5;
            var numberToSkip = pageNumber * numberOfListings;

            var getListing = await _db.Papers.Where(x => x.Draft != true).Skip(numberToSkip).Take(numberOfListings).ToListAsync();

            return getListing;
        }

        /// <summary>
        /// The Read.
        /// </summary>
        /// <param name="id">The id<see cref="int"/>.</param>
        /// <returns>The <see cref="Task{Models.Papers}"/>.</returns>
        public async Task<Models.Papers> Read(int id)
        {
            return await _db.Papers.FirstOrDefaultAsync(x => x.ID == id);
        }

        /// <summary>
        /// The ReadAll.
        /// </summary>
        /// <returns>The <see cref="Task{ICollection{Models.Papers}}"/>.</returns>
        public async Task<ICollection<Models.Papers>> ReadAll()
        {
            return await _db.Papers.ToListAsync();
        }

        /// <summary>
        /// The Update.
        /// </summary>
        /// <param name="paper">The paper<see cref="Models.Papers"/>.</param>
        /// <returns>The <see cref="Task{Models.Papers}"/>.</returns>
        public async Task<Models.Papers> Update(Models.Papers paper)
        {
            var check = await Read(paper.ID);

            if (check != null)
            {
                _db.Papers.Update(paper);
                await _db.SaveChangesAsync();
                return paper;
            }
            return paper;
        }

        #endregion
    }
}

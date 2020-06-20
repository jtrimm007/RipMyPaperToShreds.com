// Copywrite 2020 RipMyPaperToShreds.com - All rights reserved
// Unauthorized copying of this file, via any medium is strictly prohibited
// Proprietary and confidential
// Written by: Joshua Trimm <trimmj@etsu.edu>, 6/19/2020
// File Name: Rips.cs

namespace RipMyPaperToShreds.com.Services.Repos
{
    using Microsoft.EntityFrameworkCore;
    using RipMyPaperToShreds.com.Data;
    using RipMyPaperToShreds.com.Services.Interfaces;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    /// <summary>
    /// Defines the <see cref="Rips" />.
    /// </summary>
    public class Rips : IRips
    {
        #region Fields

        /// <summary>
        /// Defines the _db.
        /// </summary>
        private readonly ApplicationDbContext _db;

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="Rips"/> class.
        /// </summary>
        /// <param name="db">The db<see cref="ApplicationDbContext"/>.</param>
        public Rips(ApplicationDbContext db)
        {
            _db = db;
        }

        #endregion

        #region Methods

        /// <summary>
        /// The Create.
        /// </summary>
        /// <param name="rip">The rip<see cref="Models.Rips"/>.</param>
        /// <returns>The <see cref="Task{Models.Rips}"/>.</returns>
        public async Task<Models.Rips> Create(Models.Rips rip)
        {
            var check = await Read(rip.ID);

            if (check == null)
            {
                await _db.Rips.AddAsync(rip);
                await _db.SaveChangesAsync();
                return rip;
            }
            return rip;
        }

        /// <summary>
        /// The Delete.
        /// </summary>
        /// <param name="rip">The rip<see cref="Models.Rips"/>.</param>
        /// <returns>The <see cref="Task"/>.</returns>
        public async Task Delete(Models.Rips rip)
        {
            var check = await Read(rip.ID);

            if (check != null)
            {
                _db.Rips.Remove(rip);
                await _db.SaveChangesAsync();
            }
        }

        /// <summary>
        /// The Read.
        /// </summary>
        /// <param name="id">The id<see cref="int"/>.</param>
        /// <returns>The <see cref="Task{Models.Rips}"/>.</returns>
        public async Task<Models.Rips> Read(int id)
        {
            return await _db.Rips.FirstOrDefaultAsync(x => x.ID == id);
        }

        /// <summary>
        /// The ReadAll.
        /// </summary>
        /// <returns>The <see cref="Task{ICollection{Models.Rips}}"/>.</returns>
        public async Task<ICollection<Models.Rips>> ReadAll()
        {
            return await _db.Rips.ToListAsync();
        }

        /// <summary>
        /// The Update.
        /// </summary>
        /// <param name="rip">The rip<see cref="Models.Rips"/>.</param>
        /// <returns>The <see cref="Task{Models.Rips}"/>.</returns>
        public async Task<Models.Rips> Update(Models.Rips rip)
        {
            var check = await Read(rip.ID);

            if (check != null)
            {
                _db.Rips.Update(rip);
                await _db.SaveChangesAsync();
                return rip;
            }
            return rip;
        }

        #endregion
    }
}

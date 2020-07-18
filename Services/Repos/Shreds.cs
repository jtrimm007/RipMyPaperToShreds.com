// Copywrite 2020 RipMyPaperToShreds.com - All rights reserved
// Unauthorized copying of this file, via any medium is strictly prohibited
// Proprietary and confidential
// Written by: Joshua Trimm <trimmj@etsu.edu>, 6/19/2020
// File Name: Shreds.cs

namespace RipMyPaperToShreds.com.Services.Repos
{
    using Microsoft.EntityFrameworkCore;
    using RipMyPaperToShreds.com.Data;
    using RipMyPaperToShreds.com.Services.Interfaces;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>
    /// Defines the <see cref="Shreds" />.
    /// </summary>
    public class Shreds : IShreds
    {
        #region Fields

        /// <summary>
        /// Defines the _db.
        /// </summary>
        private readonly ApplicationDbContext _db;

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="Shreds"/> class.
        /// </summary>
        /// <param name="db">The db<see cref="ApplicationDbContext"/>.</param>
        public Shreds(ApplicationDbContext db)
        {
            _db = db;
        }

        #endregion

        #region Methods

        /// <summary>
        /// The Create.
        /// </summary>
        /// <param name="shred">The shred<see cref="Models.Shreds"/>.</param>
        /// <returns>The <see cref="Task{Models.Shreds}"/>.</returns>
        public async Task<Models.Shreds> Create(Models.Shreds shred)
        {
            var check = await Read(shred.ID);

            if (check == null)
            {
                await _db.Shreds.AddAsync(shred);
                await _db.SaveChangesAsync();
                return shred;
            }

            return shred;
        }

        /// <summary>
        /// The Delete.
        /// </summary>
        /// <param name="shred">The shred<see cref="Models.Shreds"/>.</param>
        /// <returns>The <see cref="Task"/>.</returns>
        public async Task Delete(Models.Shreds shred)
        {
            var check = await Read(shred.ID);

            if (check != null)
            {
                _db.Shreds.Remove(shred);
                await _db.SaveChangesAsync();
            }
        }

        public async Task<ICollection<Models.Shreds>> GetAllShredsForPaper(int paperId)
        {
            var check = await _db.Shreds.Where(x => x.PaperId == paperId).ToListAsync();

            return check;
        }

        /// <summary>
        /// The Read.
        /// </summary>
        /// <param name="id">The id<see cref="int"/>.</param>
        /// <returns>The <see cref="Task{Models.Shreds}"/>.</returns>
        public async Task<Models.Shreds> Read(int id)
        {
            return await _db.Shreds.FirstOrDefaultAsync(x => x.ID == id);
        }

        /// <summary>
        /// The ReadAll.
        /// </summary>
        /// <returns>The <see cref="Task{ICollection{Models.Shreds}}"/>.</returns>
        public async Task<ICollection<Models.Shreds>> ReadAll()
        {
            return await _db.Shreds.ToListAsync();
        }

        /// <summary>
        /// The Update.
        /// </summary>
        /// <param name="shred">The shred<see cref="Models.Shreds"/>.</param>
        /// <returns>The <see cref="Task{Models.Shreds}"/>.</returns>
        public async Task<Models.Shreds> Update(Models.Shreds shred)
        {
            var check = await Read(shred.ID);

            if (check != null)
            {
                _db.Shreds.Update(shred);
                await _db.SaveChangesAsync();
                return shred;
            }
            return shred;
        }

        #endregion
    }
}

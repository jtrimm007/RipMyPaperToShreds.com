// Copywrite 2020 RipMyPaperToShreds.com - All rights reserved
// Unauthorized copying of this file, via any medium is strictly prohibited
// Proprietary and confidential
// Written by: Joshua Trimm <trimmj@etsu.edu>, 6/19/2020
// File Name: PaperHashes.cs

namespace RipMyPaperToShreds.com.Services.Repos
{
    using Microsoft.EntityFrameworkCore;
    using RipMyPaperToShreds.com.Data;
    using RipMyPaperToShreds.com.Services.Interfaces;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    /// <summary>
    /// Defines the <see cref="PaperHashes" />.
    /// </summary>
    public class PaperHashes : IPaperHashes
    {
        #region Fields

        /// <summary>
        /// Defines the _db.
        /// </summary>
        private readonly ApplicationDbContext _db;

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="PaperHashes"/> class.
        /// </summary>
        /// <param name="db">The db<see cref="ApplicationDbContext"/>.</param>
        public PaperHashes(ApplicationDbContext db)
        {
            _db = db;
        }

        #endregion

        #region Methods

        /// <summary>
        /// The Create.
        /// </summary>
        /// <param name="paperHashes">The paperHashes<see cref="Models.PaperHashes"/>.</param>
        /// <returns>The <see cref="Task{Models.PaperHashes}"/>.</returns>
        public async Task<Models.PaperHashes> Create(Models.PaperHashes paperHashes)
        {
            var check = await Read(paperHashes);

            if (check == null)
            {
                await _db.PaperHashes.AddAsync(paperHashes);
                await _db.SaveChangesAsync();
                return paperHashes;
            }
            return paperHashes;
        }

        /// <summary>
        /// The Delete.
        /// </summary>
        /// <param name="paperHashes">The paperHashes<see cref="Models.PaperHashes"/>.</param>
        /// <returns>The <see cref="Task"/>.</returns>
        public async Task Delete(Models.PaperHashes paperHashes)
        {
            var check = await Read(paperHashes);

            if (check != null)
            {
                _db.PaperHashes.Remove(check);
                await _db.SaveChangesAsync();

            }
        }

        /// <summary>
        /// The Read.
        /// </summary>
        /// <param name="paperHashes">The paperHashes<see cref="Models.PaperHashes"/>.</param>
        /// <returns>The <see cref="Task{Models.PaperHashes}"/>.</returns>
        public async Task<Models.PaperHashes> Read(Models.PaperHashes paperHashes)
        {
            return await _db.PaperHashes.FirstOrDefaultAsync(x => x.PaperId == paperHashes.PaperId && x.HashTagId == paperHashes.HashTagId);
        }

        /// <summary>
        /// The ReadAll.
        /// </summary>
        /// <returns>The <see cref="Task{ICollection{Models.PaperHashes}}"/>.</returns>
        public async Task<ICollection<Models.PaperHashes>> ReadAll()
        {
            return await _db.PaperHashes.ToListAsync();
        }

        /// <summary>
        /// The Update.
        /// </summary>
        /// <param name="paperHashes">The paperHashes<see cref="Models.PaperHashes"/>.</param>
        /// <returns>The <see cref="Task{Models.PaperHashes}"/>.</returns>
        public async Task<Models.PaperHashes> Update(Models.PaperHashes paperHashes)
        {
            var check = await Read(paperHashes);

            if (check != null)
            {
                _db.PaperHashes.Update(paperHashes);
                await _db.SaveChangesAsync();
                return paperHashes;
            }
            return paperHashes;
        }

        #endregion
    }
}

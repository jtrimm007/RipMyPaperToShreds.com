// Copywrite 2020 RipMyPaperToShreds.com - All rights reserved
// Unauthorized copying of this file, via any medium is strictly prohibited
// Proprietary and confidential
// Written by: Joshua Trimm <trimmj@etsu.edu>, 6/19/2020
// File Name: HashTags.cs

namespace RipMyPaperToShreds.com.Services.Repos
{
    using Microsoft.EntityFrameworkCore;
    using RipMyPaperToShreds.com.Data;
    using RipMyPaperToShreds.com.Services.Interfaces;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    /// <summary>
    /// Defines the <see cref="HashTags" />.
    /// </summary>
    public class HashTags : IHashTags
    {
        #region Fields

        /// <summary>
        /// Defines the _db.
        /// </summary>
        private readonly ApplicationDbContext _db;

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="HashTags"/> class.
        /// </summary>
        /// <param name="db">The db<see cref="ApplicationDbContext"/>.</param>
        public HashTags(ApplicationDbContext db)
        {
            _db = db;
        }

        #endregion

        #region Methods

        /// <summary>
        /// The Create.
        /// </summary>
        /// <param name="hashTag">The hashTag<see cref="Models.HashTags"/>.</param>
        /// <returns>The <see cref="Task{Models.HashTags}"/>.</returns>
        public async Task<Models.HashTags> Create(Models.HashTags hashTag)
        {
            var check = await Read(hashTag.ID);
            var nameCheck = await ReabByHashTagName(hashTag.HashTag);

            if(hashTag.ID == 0 && nameCheck != null)
            {
                return nameCheck;
            }

            if (check == null && nameCheck == null)
            {
                await _db.HashTags.AddAsync(hashTag);
                await _db.SaveChangesAsync();
                return hashTag;
            }
            return hashTag;
        }

        /// <summary>
        /// The Delete.
        /// </summary>
        /// <param name="hashTag">The hashTag<see cref="Models.HashTags"/>.</param>
        /// <returns>The <see cref="Task"/>.</returns>
        public async Task Delete(Models.HashTags hashTag)
        {
            var check = await Read(hashTag.ID);

            if (check != null)
            {
                _db.HashTags.Remove(hashTag);
                await _db.SaveChangesAsync();

            }
        }

        /// <summary>
        /// The Read.
        /// </summary>
        /// <param name="id">The id<see cref="int"/>.</param>
        /// <returns>The <see cref="Task{Models.HashTags}"/>.</returns>
        public async Task<Models.HashTags> Read(int id)
        {
            return await _db.HashTags.FirstOrDefaultAsync(x => x.ID == id);
        }

        public async Task<Models.HashTags> ReabByHashTagName(string name)
        {
            return await _db.HashTags.FirstOrDefaultAsync(x => x.HashTag.Equals(name));
        }

        /// <summary>
        /// The ReadAll.
        /// </summary>
        /// <returns>The <see cref="Task{ICollection{Models.HashTags}}"/>.</returns>
        public async Task<ICollection<Models.HashTags>> ReadAll()
        {
            return await _db.HashTags.ToListAsync();
        }

        /// <summary>
        /// The Update.
        /// </summary>
        /// <param name="hashTag">The hashTag<see cref="Models.HashTags"/>.</param>
        /// <returns>The <see cref="Task{Models.HashTags}"/>.</returns>
        public async Task<Models.HashTags> Update(Models.HashTags hashTag)
        {
            var check = await Read(hashTag.ID);

            if (check != null)
            {
                _db.HashTags.Update(hashTag);
                await _db.SaveChangesAsync();
                return hashTag;
            }
            return hashTag;
        }

        #endregion
    }
}

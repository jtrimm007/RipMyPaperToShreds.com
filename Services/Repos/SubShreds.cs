// Copywrite 2020 RipMyPaperToShreds.com - All rights reserved
// Unauthorized copying of this file, via any medium is strictly prohibited
// Proprietary and confidential
// Written by: Joshua Trimm <trimmj@etsu.edu>, 6/19/2020
// File Name: SubShreds.cs

namespace RipMyPaperToShreds.com.Services.Repos
{
    using Microsoft.EntityFrameworkCore;
    using RipMyPaperToShreds.com.Data;
    using RipMyPaperToShreds.com.Services.Interfaces;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>
    /// Defines the <see cref="SubShreds" />.
    /// </summary>
    public class SubShreds : ISubShreds
    {
        #region Fields

        /// <summary>
        /// Defines the _db.
        /// </summary>
        private readonly ApplicationDbContext _db;

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="SubShreds"/> class.
        /// </summary>
        /// <param name="db">The db<see cref="ApplicationDbContext"/>.</param>
        public SubShreds(ApplicationDbContext db)
        {
            _db = db;
        }

        #endregion

        #region Methods

        /// <summary>
        /// The Create.
        /// </summary>
        /// <param name="subShred">The subShred<see cref="Models.SubShreds"/>.</param>
        /// <returns>The <see cref="Task{Models.SubShreds}"/>.</returns>
        public async Task<Models.SubShreds> Create(Models.SubShreds subShred)
        {
            var check = await Read(subShred.ID);

            if (check == null)
            {
                await _db.SubShreds.AddAsync(subShred);
                await _db.SaveChangesAsync();

                return subShred;
            }

            return subShred;
        }

        /// <summary>
        /// The Delete.
        /// </summary>
        /// <param name="subShred">The subShred<see cref="Models.SubShreds"/>.</param>
        /// <returns>The <see cref="Task"/>.</returns>
        public async Task Delete(Models.SubShreds subShred)
        {
            var check = await Read(subShred.ID);

            if (check != null)
            {
                _db.SubShreds.Remove(subShred);
                await _db.SaveChangesAsync();
            }
        }

        public async Task<ICollection<Models.SubShreds>> GetAllSubShredsForShred(int shredId)
        {
            var check = await _db.SubShreds.Where(x => x.ShredId == shredId).ToListAsync();

            return check;
        }

        /// <summary>
        /// The Read.
        /// </summary>
        /// <param name="id">The id<see cref="int"/>.</param>
        /// <returns>The <see cref="Task{Models.SubShreds}"/>.</returns>
        public async Task<Models.SubShreds> Read(int id)
        {
            var subShred = await _db.SubShreds.FirstOrDefaultAsync(x => x.ID == id);
            return subShred;
        }

        /// <summary>
        /// The ReadAll.
        /// </summary>
        /// <returns>The <see cref="Task{ICollection{Models.SubShreds}}"/>.</returns>
        public async Task<ICollection<Models.SubShreds>> ReadAll()
        {
            return await _db.SubShreds.ToListAsync();
        }

        /// <summary>
        /// The Update.
        /// </summary>
        /// <param name="subShred">The subShred<see cref="Models.SubShreds"/>.</param>
        /// <returns>The <see cref="Task{Models.SubShreds}"/>.</returns>
        public async Task<Models.SubShreds> Update(Models.SubShreds subShred)
        {
            var check = await Read(subShred.ID);

            if (check != null)
            {
                check.SubShred = subShred.SubShred;
                
                //_db.SubShreds.Update(subShred);
                await _db.SaveChangesAsync();
                return subShred;
            }

            return subShred;
        }

        #endregion
    }
}

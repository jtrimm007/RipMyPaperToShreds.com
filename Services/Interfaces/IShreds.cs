// Copywrite 2020 RipMyPaperToShreds.com - All rights reserved
// Unauthorized copying of this file, via any medium is strictly prohibited
// Proprietary and confidential
// Written by: Joshua Trimm <trimmj@etsu.edu>, 6/19/2020
// File Name: IShreds.cs

namespace RipMyPaperToShreds.com.Services.Interfaces
{
    using RipMyPaperToShreds.com.Models;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    #region Interfaces

    /// <summary>
    /// Defines the <see cref="IShreds" />.
    /// </summary>
    interface IShreds
    {
        #region Methods

        /// <summary>
        /// The Create.
        /// </summary>
        /// <param name="shred">The shred<see cref="Shreds"/>.</param>
        /// <returns>The <see cref="Task{Shreds}"/>.</returns>
        Task<Shreds> Create(Shreds shred);

        /// <summary>
        /// The Delete.
        /// </summary>
        /// <param name="shred">The shred<see cref="Shreds"/>.</param>
        /// <returns>The <see cref="Task"/>.</returns>
        Task Delete(Shreds shred);

        /// <summary>
        /// The Read.
        /// </summary>
        /// <param name="id">The id<see cref="int"/>.</param>
        /// <returns>The <see cref="Task{Shreds}"/>.</returns>
        Task<Shreds> Read(int id);

        /// <summary>
        /// The ReadAll.
        /// </summary>
        /// <returns>The <see cref="Task{ICollection{Shreds}}"/>.</returns>
        Task<ICollection<Shreds>> ReadAll();

        /// <summary>
        /// The Update.
        /// </summary>
        /// <param name="shred">The shred<see cref="Shreds"/>.</param>
        /// <returns>The <see cref="Task{Shreds}"/>.</returns>
        Task<Shreds> Update(Shreds shred);

        #endregion
    }

    #endregion
}

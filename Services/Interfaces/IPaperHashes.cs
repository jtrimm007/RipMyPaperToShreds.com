// Copywrite 2020 RipMyPaperToShreds.com - All rights reserved
// Unauthorized copying of this file, via any medium is strictly prohibited
// Proprietary and confidential
// Written by: Joshua Trimm <trimmj@etsu.edu>, 6/19/2020
// File Name: IPaperHashes.cs

namespace RipMyPaperToShreds.com.Services.Interfaces
{
    using RipMyPaperToShreds.com.Models;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    #region Interfaces

    /// <summary>
    /// Defines the <see cref="IPaperHashes" />.
    /// </summary>
    public interface IPaperHashes
    {
        #region Methods

        /// <summary>
        /// The Create.
        /// </summary>
        /// <param name="paperHashes">The paperHashes<see cref="PaperHashes"/>.</param>
        /// <returns>The <see cref="Task{PaperHashes}"/>.</returns>
        Task<PaperHashes> Create(PaperHashes paperHashes);

        /// <summary>
        /// The Delete.
        /// </summary>
        /// <param name="paperHashes">The paperHashes<see cref="PaperHashes"/>.</param>
        /// <returns>The <see cref="Task"/>.</returns>
        Task Delete(PaperHashes paperHashes);

        /// <summary>
        /// The Read.
        /// </summary>
        /// <param name="paperHashes">The paperHashes<see cref="PaperHashes"/>.</param>
        /// <returns>The <see cref="Task{PaperHashes}"/>.</returns>
        Task<PaperHashes> Read(PaperHashes paperHashes);

        /// <summary>
        /// The ReadAll.
        /// </summary>
        /// <returns>The <see cref="Task{ICollection{PaperHashes}}"/>.</returns>
        Task<ICollection<PaperHashes>> ReadAll();

        /// <summary>
        /// The Update.
        /// </summary>
        /// <param name="paperHashes">The paperHashes<see cref="PaperHashes"/>.</param>
        /// <returns>The <see cref="Task{PaperHashes}"/>.</returns>
        Task<PaperHashes> Update(PaperHashes paperHashes);

        #endregion
    }

    #endregion
}

// Copywrite 2020 RipMyPaperToShreds.com - All rights reserved
// Unauthorized copying of this file, via any medium is strictly prohibited
// Proprietary and confidential
// Written by: Joshua Trimm <trimmj@etsu.edu>, 6/19/2020
// File Name: IHashTags.cs

namespace RipMyPaperToShreds.com.Services.Interfaces
{
    using RipMyPaperToShreds.com.Models;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    #region Interfaces

    /// <summary>
    /// Defines the <see cref="IHashTags" />.
    /// </summary>
    interface IHashTags
    {
        #region Methods

        /// <summary>
        /// The Create.
        /// </summary>
        /// <param name="hashTag">The hashTag<see cref="HashTags"/>.</param>
        /// <returns>The <see cref="Task{HashTags}"/>.</returns>
        Task<HashTags> Create(HashTags hashTag);

        /// <summary>
        /// The Delete.
        /// </summary>
        /// <param name="hashTag">The hashTag<see cref="HashTags"/>.</param>
        /// <returns>The <see cref="Task"/>.</returns>
        Task Delete(HashTags hashTag);

        /// <summary>
        /// The Read.
        /// </summary>
        /// <param name="id">The id<see cref="int"/>.</param>
        /// <returns>The <see cref="Task{HashTags}"/>.</returns>
        Task<HashTags> Read(int id);

        /// <summary>
        /// The ReadAll.
        /// </summary>
        /// <returns>The <see cref="Task{ICollection{HashTags}}"/>.</returns>
        Task<ICollection<HashTags>> ReadAll();

        /// <summary>
        /// The Update.
        /// </summary>
        /// <param name="hashTag">The hashTag<see cref="HashTags"/>.</param>
        /// <returns>The <see cref="Task{HashTags}"/>.</returns>
        Task<HashTags> Update(HashTags hashTag);

        #endregion
    }

    #endregion
}

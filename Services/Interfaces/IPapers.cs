// Copywrite 2020 RipMyPaperToShreds.com - All rights reserved
// Unauthorized copying of this file, via any medium is strictly prohibited
// Proprietary and confidential
// Written by: Joshua Trimm <trimmj@etsu.edu>, 6/19/2020
// File Name: IPapers.cs

namespace RipMyPaperToShreds.com.Services.Interfaces
{
    using RipMyPaperToShreds.com.Models;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    #region Interfaces

    /// <summary>
    /// Defines the <see cref="IPapers" />.
    /// </summary>
    public interface IPapers
    {
        #region Methods

        /// <summary>
        /// The Create.
        /// </summary>
        /// <param name="paper">The paper<see cref="Papers"/>.</param>
        /// <returns>The <see cref="Task{Papers}"/>.</returns>
        Task<Papers> Create(Papers paper);

        /// <summary>
        /// The Delete.
        /// </summary>
        /// <param name="paper">The paper<see cref="Papers"/>.</param>
        /// <returns>The <see cref="Task"/>.</returns>
        Task Delete(Papers paper);

        /// <summary>
        /// The Read.
        /// </summary>
        /// <param name="id">The id<see cref="int"/>.</param>
        /// <returns>The <see cref="Task{Papers}"/>.</returns>
        Task<Papers> Read(int id);

        /// <summary>
        /// The ReadAll.
        /// </summary>
        /// <returns>The <see cref="Task{ICollection{Papers}}"/>.</returns>
        Task<ICollection<Papers>> ReadAll();

        Task<ICollection<Papers>> NextPage(int pageNumber);

        /// <summary>
        /// The Update.
        /// </summary>
        /// <param name="paper">The paper<see cref="Papers"/>.</param>
        /// <returns>The <see cref="Task{Papers}"/>.</returns>
        Task<Papers> Update(Papers paper);

        Task<bool> IsObject(int id);

        #endregion
    }

    #endregion
}

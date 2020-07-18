// Copywrite 2020 RipMyPaperToShreds.com - All rights reserved
// Unauthorized copying of this file, via any medium is strictly prohibited
// Proprietary and confidential
// Written by: Joshua Trimm <trimmj@etsu.edu>, 6/19/2020
// File Name: IRips.cs

namespace RipMyPaperToShreds.com.Services.Interfaces
{
    using RipMyPaperToShreds.com.Models;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    #region Interfaces

    /// <summary>
    /// Defines the <see cref="IRips" />.
    /// </summary>
    public interface IRips
    {
        #region Methods

        /// <summary>
        /// The Create.
        /// </summary>
        /// <param name="rip">The rip<see cref="Rips"/>.</param>
        /// <returns>The <see cref="Task{Rips}"/>.</returns>
        Task<Rips> Create(Rips rip);

        /// <summary>
        /// The Delete.
        /// </summary>
        /// <param name="rip">The rip<see cref="Rips"/>.</param>
        /// <returns>The <see cref="Task"/>.</returns>
        Task Delete(Rips rip);

        /// <summary>
        /// The Read.
        /// </summary>
        /// <param name="id">The id<see cref="int"/>.</param>
        /// <returns>The <see cref="Task{Rips}"/>.</returns>
        Task<Rips> Read(int id);

        /// <summary>
        /// The ReadAll.
        /// </summary>
        /// <returns>The <see cref="Task{ICollection{Rips}}"/>.</returns>
        Task<ICollection<Rips>> ReadAll();

        /// <summary>
        /// The Update.
        /// </summary>
        /// <param name="rip">The rip<see cref="Rips"/>.</param>
        /// <returns>The <see cref="Task{Rips}"/>.</returns>
        Task<Rips> Update(Rips rip);

        #endregion
    }

    #endregion
}

// Copywrite 2020 RipMyPaperToShreds.com - All rights reserved
// Unauthorized copying of this file, via any medium is strictly prohibited
// Proprietary and confidential
// Written by: Joshua Trimm <trimmj@etsu.edu>, 6/19/2020
// File Name: ISubShreds.cs

namespace RipMyPaperToShreds.com.Services.Interfaces
{
    using RipMyPaperToShreds.com.Models;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    #region Interfaces

    /// <summary>
    /// Defines the <see cref="ISubShreds" />.
    /// </summary>
    public interface ISubShreds
    {
        #region Methods

        /// <summary>
        /// The Create.
        /// </summary>
        /// <param name="subShred">The subShred<see cref="SubShreds"/>.</param>
        /// <returns>The <see cref="Task{SubShreds}"/>.</returns>
        Task<SubShreds> Create(SubShreds subShred);

        /// <summary>
        /// The Delete.
        /// </summary>
        /// <param name="subShred">The subShred<see cref="SubShreds"/>.</param>
        /// <returns>The <see cref="Task"/>.</returns>
        Task Delete(SubShreds subShred);

        /// <summary>
        /// The Read.
        /// </summary>
        /// <param name="id">The id<see cref="int"/>.</param>
        /// <returns>The <see cref="Task{SubShreds}"/>.</returns>
        Task<SubShreds> Read(int id);

        /// <summary>
        /// The ReadAll.
        /// </summary>
        /// <returns>The <see cref="Task{ICollection{SubShreds}}"/>.</returns>
        Task<ICollection<SubShreds>> ReadAll();

        /// <summary>
        /// The Update.
        /// </summary>
        /// <param name="subShred">The subShred<see cref="SubShreds"/>.</param>
        /// <returns>The <see cref="Task{SubShreds}"/>.</returns>
        Task<SubShreds> Update(SubShreds subShred);

        Task<ICollection<SubShreds>> GetAllSubShredsForShred(int shredId);

        #endregion
    }

    #endregion
}

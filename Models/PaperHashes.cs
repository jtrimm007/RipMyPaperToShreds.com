// Copywrite 2020 RipMyPaperToShreds.com - All rights reserved
// Unauthorized copying of this file, via any medium is strictly prohibited
// Proprietary and confidential
// Written by: Joshua Trimm <trimmj@etsu.edu>, 6/19/2020
// File Name: PaperHashes.cs

namespace RipMyPaperToShreds.com.Models
{
    using System.ComponentModel.DataAnnotations.Schema;

    /// <summary>
    /// Defines the <see cref="PaperHashes" />.
    /// </summary>
    public class PaperHashes
    {
        #region Properties

        /// <summary>
        /// Gets or sets the HashTagId.
        /// </summary>
        [ForeignKey("HashTags")]
        public int HashTagId { get; set; }

        /// <summary>
        /// Gets or sets the PaperId.
        /// </summary>
        [ForeignKey("Papers")]
        public int PaperId { get; set; }

        #endregion
    }
}

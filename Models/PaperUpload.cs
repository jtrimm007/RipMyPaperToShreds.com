// Copywrite 2020 RipMyPaperToShreds.com - All rights reserved
// Unauthorized copying of this file, via any medium is strictly prohibited
// Proprietary and confidential
// Written by: Joshua Trimm <trimmj@etsu.edu>, 12/24/2020
// File Name: PaperUpload.cs

namespace RipMyPaperToShreds.com.Models
{
    using System;
    using System.ComponentModel.DataAnnotations.Schema;

    /// <summary>
    /// Defines the <see cref="PaperUpload" />.
    /// </summary>
    public class PaperUpload
    {
        #region Properties

        /// <summary>
        /// Gets or sets the Css.
        /// </summary>
        public string Css { get; set; }

        /// <summary>
        /// Gets or sets the FilePath.
        /// </summary>
        public string FilePath { get; set; }

        /// <summary>
        /// Gets or sets the GuidId.
        /// </summary>
        public Guid GuidId { get; set; }

        /// <summary>
        /// Gets or sets the ID.
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// Gets or sets the PaperId.
        /// </summary>
        [ForeignKey("Papers")]
        public int PaperId { get; set; }

        /// <summary>
        /// Gets or sets the UniqueFileName.
        /// </summary>
        public string UniqueFileName { get; set; }

        /// <summary>
        /// Gets or sets the UploadDate.
        /// </summary>
        public DateTime UploadDate { get; set; }

        #endregion
    }
}

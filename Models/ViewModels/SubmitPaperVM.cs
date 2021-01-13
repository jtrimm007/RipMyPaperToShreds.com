// Copywrite 2020 RipMyPaperToShreds.com - All rights reserved
// Unauthorized copying of this file, via any medium is strictly prohibited
// Proprietary and confidential
// Written by: Joshua Trimm <trimmj@etsu.edu>, 12/28/2020
// File Name: SubmitPaperVM.cs

namespace RipMyPaperToShreds.com.Models.ViewModels
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Defines the <see cref="SubmitPaperVM" />.
    /// </summary>
    public class SubmitPaperVM
    {
        #region Properties

        /// <summary>
        /// Gets or sets the Css.
        /// </summary>
        public string Css { get; set; }

        /// <summary>
        /// Gets or sets the Date.
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether Draft.
        /// </summary>
        public bool Draft { get; set; }

        /// <summary>
        /// Gets or sets the FilePath.
        /// </summary>
        public string FilePath { get; set; }

        /// <summary>
        /// Gets or sets the GuidId.
        /// </summary>
        public Guid GuidId { get; set; }

        /// <summary>
        /// Gets or sets the HashTags.
        /// </summary>
        public ICollection<HashTags> HashTags { get; set; }

        /// <summary>
        /// Gets or sets the ID.
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// Gets or sets the Paper.
        /// </summary>
        public string Paper { get; set; }

        /// <summary>
        /// Gets or sets the PaperId.
        /// </summary>
       public int PaperId { get; set; }

        /// <summary>
        /// Gets or sets the ShrederId.
        /// </summary>
        public string ShrederId { get; set; }

        /// <summary>
        /// Gets or sets the Title.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the UniqueFileName.
        /// </summary>
        public string UniqueFileName { get; set; }

        #endregion
    }
}

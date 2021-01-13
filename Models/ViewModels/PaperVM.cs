// Copywrite 2020 RipMyPaperToShreds.com - All rights reserved
// Unauthorized copying of this file, via any medium is strictly prohibited
// Proprietary and confidential
// Written by: Joshua Trimm <trimmj@etsu.edu>, 12/30/2020
// File Name: PaperVM.cs

namespace RipMyPaperToShreds.com.Models.ViewModels
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Defines the <see cref="PaperVM" />.
    /// </summary>
    public class PaperVM
    {
        #region Properties

        /// <summary>
        /// Gets or sets the Date.
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether Draft.
        /// </summary>
        public bool Draft { get; set; }

        /// <summary>
        /// Gets or sets the HashTags.
        /// </summary>
        public string HashTags { get; set; }

        /// <summary>
        /// Gets or sets the ID.
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// Gets or sets the Paper.
        /// </summary>
        public string Paper { get; set; }

        /// <summary>
        /// Gets or sets the ShrederId.
        /// </summary>
        public string ShrederId { get; set; }

        /// <summary>
        /// Gets or sets the Title.
        /// </summary>
        public string Title { get; set; }

        #endregion
    }
}

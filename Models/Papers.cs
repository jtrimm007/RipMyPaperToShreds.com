// Copywrite 2020 RipMyPaperToShreds.com - All rights reserved
// Unauthorized copying of this file, via any medium is strictly prohibited
// Proprietary and confidential
// Written by: Joshua Trimm <trimmj@etsu.edu>, 6/19/2020
// File Name: Papers.cs

namespace RipMyPaperToShreds.com.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    /// <summary>
    /// Defines the <see cref="Papers" />.
    /// </summary>
    public class Papers
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
        public ICollection<HashTags> HashTags { get; set; }

        /// <summary>
        /// Gets or sets the ID.
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// Gets or sets the Paper.
        /// </summary>
        [Required]
        public string Paper { get; set; }

        /// <summary>
        /// Gets or sets the ShrederId.
        /// </summary>
        [ForeignKey("AspNetUser")]
        public string ShrederId { get; set; }

        public string Title { get; set; }

        #endregion
    }
}

// Copywrite 2020 RipMyPaperToShreds.com - All rights reserved
// Unauthorized copying of this file, via any medium is strictly prohibited
// Proprietary and confidential
// Written by: Joshua Trimm <trimmj@etsu.edu>, 6/19/2020
// File Name: Shreds.cs

namespace RipMyPaperToShreds.com.Models
{
    using System;
    using System.ComponentModel.DataAnnotations.Schema;

    /// <summary>
    /// Defines the <see cref="Shreds" />.
    /// </summary>
    public class Shreds
    {
        #region Properties

        /// <summary>
        /// Gets or sets the Date.
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether Fixed.
        /// </summary>
        public bool Fixed { get; set; }

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
        /// Gets or sets the Shred.
        /// </summary>
        public string Shred { get; set; }

        /// <summary>
        /// Gets or sets the ShrederId.
        /// </summary>
        [ForeignKey("AspNetUser")]
        public string ShrederId { get; set; }

        /// <summary>
        /// Gets or sets the ShredyId.
        /// </summary>
        [ForeignKey("AspNetUser")]
        public string ShredyId { get; set; }

        public string Context { get; set; }

        #endregion
    }
}

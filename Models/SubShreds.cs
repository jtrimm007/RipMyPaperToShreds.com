// Copywrite 2020 RipMyPaperToShreds.com - All rights reserved
// Unauthorized copying of this file, via any medium is strictly prohibited
// Proprietary and confidential
// Written by: Joshua Trimm <trimmj@etsu.edu>, 6/19/2020
// File Name: SubShreds.cs

namespace RipMyPaperToShreds.com.Models
{
    using System;
    using System.ComponentModel.DataAnnotations.Schema;

    /// <summary>
    /// Defines the <see cref="SubShreds" />.
    /// </summary>
    public class SubShreds
    {
        #region Properties

        /// <summary>
        /// Gets or sets the Date.
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// Gets or sets the ID.
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// Gets or sets the ShrederId.
        /// </summary>
        [ForeignKey("AspNetUser")]
        public string ShrederId { get; set; }

        /// <summary>
        /// Gets or sets the ShredId.
        /// </summary>
        [ForeignKey("Shreds")]
        public int ShredId { get; set; }

        /// <summary>
        /// Gets or sets the SubShred.
        /// </summary>
        public string SubShred { get; set; }

        #endregion
    }
}

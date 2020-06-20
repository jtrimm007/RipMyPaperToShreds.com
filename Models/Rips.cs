// Copywrite 2020 RipMyPaperToShreds.com - All rights reserved
// Unauthorized copying of this file, via any medium is strictly prohibited
// Proprietary and confidential
// Written by: Joshua Trimm <trimmj@etsu.edu>, 6/19/2020
// File Name: Rips.cs

namespace RipMyPaperToShreds.com.Models
{
    using System.ComponentModel.DataAnnotations.Schema;

    /// <summary>
    /// Defines the <see cref="Rips" />.
    /// </summary>
    public class Rips
    {
        #region Properties

        /// <summary>
        /// Gets or sets the ID.
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether Rip.
        /// </summary>
        public bool Rip { get; set; }

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

        #endregion
    }
}

// Copywrite 2020 RipMyPaperToShreds.com - All rights reserved
// Unauthorized copying of this file, via any medium is strictly prohibited
// Proprietary and confidential
// Written by: Joshua Trimm <trimmj@etsu.edu>, 6/18/2020
// File Name: ErrorViewModel.cs

namespace RipMyPaperToShreds.com.Models
{
    /// <summary>
    /// Defines the <see cref="ErrorViewModel" />.
    /// </summary>
    public class ErrorViewModel
    {
        #region Properties

        /// <summary>
        /// Gets or sets the RequestId.
        /// </summary>
        public string RequestId { get; set; }

        /// <summary>
        /// Gets a value indicating whether ShowRequestId.
        /// </summary>
        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);

        #endregion
    }
}

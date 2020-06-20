// Copywrite 2020 RipMyPaperToShreds.com - All rights reserved
// Unauthorized copying of this file, via any medium is strictly prohibited
// Proprietary and confidential
// Written by: Joshua Trimm <trimmj@etsu.edu>, 6/19/2020
// File Name: ShredsHub.cs

namespace RipMyPaperToShreds.com.Services.Hubs
{
    using Microsoft.AspNetCore.SignalR;
    using System.Threading.Tasks;

    /// <summary>
    /// Defines the <see cref="ShredsHub" />.
    /// </summary>
    public class ShredsHub : Hub
    {
        #region Methods

        /// <summary>
        /// The SendToAll.
        /// </summary>
        /// <param name="message">The message<see cref="string"/>.</param>
        /// <returns>The <see cref="Task"/>.</returns>
        public async Task SendToAll(string message)
        {
            await Clients.All.SendAsync("ShredUpdated", message);
        }

        #endregion
    }
}

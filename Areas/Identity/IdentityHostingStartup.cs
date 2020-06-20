// Copywrite 2020 RipMyPaperToShreds.com - All rights reserved
// Unauthorized copying of this file, via any medium is strictly prohibited
// Proprietary and confidential
// Written by: Joshua Trimm <trimmj@etsu.edu>, 6/18/2020
// File Name: IdentityHostingStartup.cs

[assembly: Microsoft.AspNetCore.Hosting.HostingStartup(typeof(RipMyPaperToShreds.com.Areas.Identity.IdentityHostingStartup))]
namespace RipMyPaperToShreds.com.Areas.Identity
{
    using Microsoft.AspNetCore.Hosting;

    /// <summary>
    /// Defines the <see cref="IdentityHostingStartup" />.
    /// </summary>
    public class IdentityHostingStartup : IHostingStartup
    {
        #region Methods

        /// <summary>
        /// The Configure.
        /// </summary>
        /// <param name="builder">The builder<see cref="IWebHostBuilder"/>.</param>
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) =>
            {
            });
        }

        #endregion
    }
}

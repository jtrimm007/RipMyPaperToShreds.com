// Copywrite 2020 RipMyPaperToShreds.com - All rights reserved
// Unauthorized copying of this file, via any medium is strictly prohibited
// Proprietary and confidential
// Written by: Joshua Trimm <trimmj@etsu.edu>, 6/18/2020
// File Name: ApplicationDbContext.cs

namespace RipMyPaperToShreds.com.Data
{
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;
    using RipMyPaperToShreds.com.Models;

    /// <summary>
    /// Defines the <see cref="ApplicationDbContext" />.
    /// </summary>
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="ApplicationDbContext"/> class.
        /// </summary>
        /// <param name="options">The options<see cref="DbContextOptions{ApplicationDbContext}"/>.</param>
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets the HashTags.
        /// </summary>
        public DbSet<HashTags> HashTags { get; set; }

        /// <summary>
        /// Gets or sets the PaperHashes.
        /// </summary>
        public DbSet<PaperHashes> PaperHashes { get; set; }

        /// <summary>
        /// Gets or sets the Papers.
        /// </summary>
        public DbSet<Papers> Papers { get; set; }

        /// <summary>
        /// Gets or sets the Rips.
        /// </summary>
        public DbSet<Rips> Rips { get; set; }

        /// <summary>
        /// Gets or sets the Shreds.
        /// </summary>
        public DbSet<Shreds> Shreds { get; set; }

        /// <summary>
        /// Gets or sets the SubShreds.
        /// </summary>
        public DbSet<SubShreds> SubShreds { get; set; }

        #endregion

        #region Methods

        /// <summary>
        /// The OnModelCreating.
        /// </summary>
        /// <param name="builder">The builder<see cref="ModelBuilder"/>.</param>
        protected override void OnModelCreating(ModelBuilder builder)
        {

            base.OnModelCreating(builder);
            builder.Entity<PaperHashes>(ph =>
            {
                ph.HasNoKey();
            });
        }

        #endregion
    }
}

// Copywrite 2020 RipMyPaperToShreds.com - All rights reserved
// Unauthorized copying of this file, via any medium is strictly prohibited
// Proprietary and confidential
// Written by: Joshua Trimm <trimmj@etsu.edu>, 6/18/2020
// File Name: ApplicationDbContext.cs

namespace RipMyPaperToShreds.com.Data
{
    using Microsoft.AspNetCore.Identity;
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

        protected override void OnModelCreating(ModelBuilder builder)
        {

            base.OnModelCreating(builder);
            builder.Entity<PaperHashes>(ph =>
            {
                ph.HasNoKey();
            });

        }

        public DbSet<SubShreds> SubShreds { get; set; }
        public DbSet<Shreds> Shreds { get; set; }
        public DbSet<Rips> Rips { get; set; }
        public DbSet<Papers> Papers { get; set; }
        public DbSet<HashTags> HashTags { get; set; }
        public DbSet<PaperHashes> PaperHashes { get; set; }


        #endregion
    }
}

//// Copywrite 2020 RipMyPaperToShreds.com - All rights reserved
//// Unauthorized copying of this file, via any medium is strictly prohibited
//// Proprietary and confidential
//// Written by: Joshua Trimm <trimmj@etsu.edu>, 6/19/2020
//// File Name: 20200619184551_Mig.cs

//namespace RipMyPaperToShreds.com.Migrations
//{
//    using Microsoft.EntityFrameworkCore.Migrations;
//    using System;

//    /// <summary>
//    /// Defines the <see cref="Mig" />.
//    /// </summary>
//    public partial class Mig : Migration
//    {
//        #region Methods

//        /// <summary>
//        /// The Down.
//        /// </summary>
//        /// <param name="migrationBuilder">The migrationBuilder<see cref="MigrationBuilder"/>.</param>
//        protected override void Down(MigrationBuilder migrationBuilder)
//        {
//            //migrationBuilder.DropTable(
//            //    name: "AspNetRoleClaims");

//            //migrationBuilder.DropTable(
//            //    name: "AspNetUserClaims");

//            //migrationBuilder.DropTable(
//            //    name: "AspNetUserLogins");

//            //migrationBuilder.DropTable(
//            //    name: "AspNetUserRoles");

//            //migrationBuilder.DropTable(
//            //    name: "AspNetUserTokens");

//            migrationBuilder.DropTable(
//                name: "HashTags");

//            migrationBuilder.DropTable(
//                name: "PaperHashes");

//            migrationBuilder.DropTable(
//                name: "Rips");

//            migrationBuilder.DropTable(
//                name: "Shreds");

//            migrationBuilder.DropTable(
//                name: "SubShreds");

//            //migrationBuilder.DropTable(
//            //    name: "AspNetRoles");

//            //migrationBuilder.DropTable(
//            //    name: "AspNetUsers");

//            migrationBuilder.DropTable(
//                name: "Papers");
//        }

//        /// <summary>
//        /// The Up.
//        /// </summary>
//        /// <param name="migrationBuilder">The migrationBuilder<see cref="MigrationBuilder"/>.</param>
//        protected override void Up(MigrationBuilder migrationBuilder)
//        {
//            //migrationBuilder.CreateTable(
//            //    name: "AspNetRoles",
//            //    columns: table => new
//            //    {
//            //        Id = table.Column<string>(nullable: false),
//            //        Name = table.Column<string>(maxLength: 256, nullable: true),
//            //        NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
//            //        ConcurrencyStamp = table.Column<string>(nullable: true)
//            //    },
//            //    constraints: table =>
//            //    {
//            //        table.PrimaryKey("PK_AspNetRoles", x => x.Id);
//            //    });

//            //migrationBuilder.CreateTable(
//            //    name: "AspNetUsers",
//            //    columns: table => new
//            //    {
//            //        Id = table.Column<string>(nullable: false),
//            //        UserName = table.Column<string>(maxLength: 256, nullable: true),
//            //        NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
//            //        Email = table.Column<string>(maxLength: 256, nullable: true),
//            //        NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
//            //        EmailConfirmed = table.Column<bool>(nullable: false),
//            //        PasswordHash = table.Column<string>(nullable: true),
//            //        SecurityStamp = table.Column<string>(nullable: true),
//            //        ConcurrencyStamp = table.Column<string>(nullable: true),
//            //        PhoneNumber = table.Column<string>(nullable: true),
//            //        PhoneNumberConfirmed = table.Column<bool>(nullable: false),
//            //        TwoFactorEnabled = table.Column<bool>(nullable: false),
//            //        LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
//            //        LockoutEnabled = table.Column<bool>(nullable: false),
//            //        AccessFailedCount = table.Column<int>(nullable: false),
//            //        ScreenName = table.Column<string>(nullable: false)
//            //    },
//            //    constraints: table =>
//            //    {
//            //        table.PrimaryKey("PK_AspNetUsers", x => x.Id);
//            //    });

//            migrationBuilder.CreateTable(
//                name: "PaperHashes",
//                columns: table => new
//                {
//                    PaperId = table.Column<int>(nullable: false),
//                    HashTagId = table.Column<int>(nullable: false)
//                },
//                constraints: table =>
//                {
//                });

//            migrationBuilder.CreateTable(
//                name: "Papers",
//                columns: table => new
//                {
//                    ID = table.Column<int>(nullable: false)
//                        .Annotation("SqlServer:Identity", "1, 1"),
//                    ShrederId = table.Column<string>(nullable: true),
//                    Paper = table.Column<string>(nullable: false),
//                    Draft = table.Column<bool>(nullable: false),
//                    Date = table.Column<DateTime>(nullable: false)
//                },
//                constraints: table =>
//                {
//                    table.PrimaryKey("PK_Papers", x => x.ID);
//                });

//            migrationBuilder.CreateTable(
//                name: "Rips",
//                columns: table => new
//                {
//                    ID = table.Column<int>(nullable: false)
//                        .Annotation("SqlServer:Identity", "1, 1"),
//                    ShredId = table.Column<int>(nullable: false),
//                    ShrederId = table.Column<string>(nullable: true),
//                    Rip = table.Column<bool>(nullable: false)
//                },
//                constraints: table =>
//                {
//                    table.PrimaryKey("PK_Rips", x => x.ID);
//                });

//            migrationBuilder.CreateTable(
//                name: "Shreds",
//                columns: table => new
//                {
//                    ID = table.Column<int>(nullable: false)
//                        .Annotation("SqlServer:Identity", "1, 1"),
//                    ShrederId = table.Column<string>(nullable: true),
//                    ShredyId = table.Column<string>(nullable: true),
//                    Fixed = table.Column<bool>(nullable: false),
//                    Shred = table.Column<string>(nullable: true),
//                    Date = table.Column<DateTime>(nullable: false)
//                },
//                constraints: table =>
//                {
//                    table.PrimaryKey("PK_Shreds", x => x.ID);
//                });

//            migrationBuilder.CreateTable(
//                name: "SubShreds",
//                columns: table => new
//                {
//                    ID = table.Column<int>(nullable: false)
//                        .Annotation("SqlServer:Identity", "1, 1"),
//                    ShrederId = table.Column<string>(nullable: true),
//                    ShredId = table.Column<int>(nullable: false),
//                    SubShred = table.Column<string>(nullable: true),
//                    Date = table.Column<DateTime>(nullable: false)
//                },
//                constraints: table =>
//                {
//                    table.PrimaryKey("PK_SubShreds", x => x.ID);
//                });

//            //migrationBuilder.CreateTable(
//            //    name: "AspNetRoleClaims",
//            //    columns: table => new
//            //    {
//            //        Id = table.Column<int>(nullable: false)
//            //            .Annotation("SqlServer:Identity", "1, 1"),
//            //        RoleId = table.Column<string>(nullable: false),
//            //        ClaimType = table.Column<string>(nullable: true),
//            //        ClaimValue = table.Column<string>(nullable: true)
//            //    },
//            //    constraints: table =>
//            //    {
//            //        table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
//            //        table.ForeignKey(
//            //            name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
//            //            column: x => x.RoleId,
//            //            principalTable: "AspNetRoles",
//            //            principalColumn: "Id",
//            //            onDelete: ReferentialAction.Cascade);
//            //    });

//            //migrationBuilder.CreateTable(
//            //    name: "AspNetUserClaims",
//            //    columns: table => new
//            //    {
//            //        Id = table.Column<int>(nullable: false)
//            //            .Annotation("SqlServer:Identity", "1, 1"),
//            //        UserId = table.Column<string>(nullable: false),
//            //        ClaimType = table.Column<string>(nullable: true),
//            //        ClaimValue = table.Column<string>(nullable: true)
//            //    },
//            //    constraints: table =>
//            //    {
//            //        table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
//            //        table.ForeignKey(
//            //            name: "FK_AspNetUserClaims_AspNetUsers_UserId",
//            //            column: x => x.UserId,
//            //            principalTable: "AspNetUsers",
//            //            principalColumn: "Id",
//            //            onDelete: ReferentialAction.Cascade);
//            //    });

//            //migrationBuilder.CreateTable(
//            //    name: "AspNetUserLogins",
//            //    columns: table => new
//            //    {
//            //        LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
//            //        ProviderKey = table.Column<string>(maxLength: 128, nullable: false),
//            //        ProviderDisplayName = table.Column<string>(nullable: true),
//            //        UserId = table.Column<string>(nullable: false)
//            //    },
//            //    constraints: table =>
//            //    {
//            //        table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
//            //        table.ForeignKey(
//            //            name: "FK_AspNetUserLogins_AspNetUsers_UserId",
//            //            column: x => x.UserId,
//            //            principalTable: "AspNetUsers",
//            //            principalColumn: "Id",
//            //            onDelete: ReferentialAction.Cascade);
//            //    });

//            //migrationBuilder.CreateTable(
//            //    name: "AspNetUserRoles",
//            //    columns: table => new
//            //    {
//            //        UserId = table.Column<string>(nullable: false),
//            //        RoleId = table.Column<string>(nullable: false)
//            //    },
//            //    constraints: table =>
//            //    {
//            //        table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
//            //        table.ForeignKey(
//            //            name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
//            //            column: x => x.RoleId,
//            //            principalTable: "AspNetRoles",
//            //            principalColumn: "Id",
//            //            onDelete: ReferentialAction.Cascade);
//            //        table.ForeignKey(
//            //            name: "FK_AspNetUserRoles_AspNetUsers_UserId",
//            //            column: x => x.UserId,
//            //            principalTable: "AspNetUsers",
//            //            principalColumn: "Id",
//            //            onDelete: ReferentialAction.Cascade);
//            //    });

//            //migrationBuilder.CreateTable(
//            //    name: "AspNetUserTokens",
//            //    columns: table => new
//            //    {
//            //        UserId = table.Column<string>(nullable: false),
//            //        LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
//            //        Name = table.Column<string>(maxLength: 128, nullable: false),
//            //        Value = table.Column<string>(nullable: true)
//            //    },
//            //    constraints: table =>
//            //    {
//            //        table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
//            //        table.ForeignKey(
//            //            name: "FK_AspNetUserTokens_AspNetUsers_UserId",
//            //            column: x => x.UserId,
//            //            principalTable: "AspNetUsers",
//            //            principalColumn: "Id",
//            //            onDelete: ReferentialAction.Cascade);
//            //    });

//            migrationBuilder.CreateTable(
//                name: "HashTags",
//                columns: table => new
//                {
//                    ID = table.Column<int>(nullable: false)
//                        .Annotation("SqlServer:Identity", "1, 1"),
//                    HashTag = table.Column<string>(nullable: true),
//                    PapersID = table.Column<int>(nullable: true)
//                },
//                constraints: table =>
//                {
//                    table.PrimaryKey("PK_HashTags", x => x.ID);
//                    table.ForeignKey(
//                        name: "FK_HashTags_Papers_PapersID",
//                        column: x => x.PapersID,
//                        principalTable: "Papers",
//                        principalColumn: "ID",
//                        onDelete: ReferentialAction.Restrict);
//                });

//            //migrationBuilder.CreateIndex(
//            //    name: "IX_AspNetRoleClaims_RoleId",
//            //    table: "AspNetRoleClaims",
//            //    column: "RoleId");

//            //migrationBuilder.CreateIndex(
//            //    name: "RoleNameIndex",
//            //    table: "AspNetRoles",
//            //    column: "NormalizedName",
//            //    unique: true,
//            //    filter: "[NormalizedName] IS NOT NULL");

//            //migrationBuilder.CreateIndex(
//            //    name: "IX_AspNetUserClaims_UserId",
//            //    table: "AspNetUserClaims",
//            //    column: "UserId");

//            //migrationBuilder.CreateIndex(
//            //    name: "IX_AspNetUserLogins_UserId",
//            //    table: "AspNetUserLogins",
//            //    column: "UserId");

//            //migrationBuilder.CreateIndex(
//            //    name: "IX_AspNetUserRoles_RoleId",
//            //    table: "AspNetUserRoles",
//            //    column: "RoleId");

//            //migrationBuilder.CreateIndex(
//            //    name: "EmailIndex",
//            //    table: "AspNetUsers",
//            //    column: "NormalizedEmail");

//            //migrationBuilder.CreateIndex(
//            //    name: "UserNameIndex",
//            //    table: "AspNetUsers",
//            //    column: "NormalizedUserName",
//            //    unique: true,
//            //    filter: "[NormalizedUserName] IS NOT NULL");

//            migrationBuilder.CreateIndex(
//                name: "IX_HashTags_PapersID",
//                table: "HashTags",
//                column: "PapersID");
//        }

//        #endregion
//    }
//}

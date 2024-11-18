using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Concert400.Migrations
{
    /// <inheritdoc />
    public partial class initialcreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Artists",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("NTi:Identity", "1, 1"),
                    Name = table.Column<string>(type: "VARGRAPHIC(1024)  CCSID 1200", nullable: true),
                    Description = table.Column<string>(type: "VARGRAPHIC(1024)  CCSID 1200", nullable: true),
                    Picture = table.Column<byte[]>(type: "BLOB(3M)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Artists", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "VARCHAR(900) ", nullable: false),
                    Name = table.Column<string>(type: "VARCHAR(256) ", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "VARCHAR(900) ", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "VARCHAR(512) ", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "VARCHAR(900) ", nullable: false),
                    FirstName = table.Column<string>(type: "VARGRAPHIC(1024)  CCSID 1200", nullable: true),
                    LastName = table.Column<string>(type: "VARGRAPHIC(1024)  CCSID 1200", nullable: true),
                    Address1 = table.Column<string>(type: "VARGRAPHIC(1024)  CCSID 1200", nullable: true),
                    Address2 = table.Column<string>(type: "VARGRAPHIC(1024)  CCSID 1200", nullable: true),
                    Zip = table.Column<string>(type: "VARGRAPHIC(1024)  CCSID 1200", nullable: true),
                    City = table.Column<string>(type: "VARGRAPHIC(1024)  CCSID 1200", nullable: true),
                    Country = table.Column<string>(type: "VARGRAPHIC(1024)  CCSID 1200", nullable: true),
                    Picture = table.Column<byte[]>(type: "BLOB(3M)", nullable: true),
                    UserName = table.Column<string>(type: "VARCHAR(256) ", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "VARCHAR(900) ", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "VARCHAR(256) ", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "VARCHAR(900) ", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "SMALLINT", nullable: false),
                    PasswordHash = table.Column<string>(type: "VARCHAR(512) ", nullable: true),
                    SecurityStamp = table.Column<string>(type: "VARCHAR(512) ", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "VARCHAR(512) ", nullable: true),
                    PhoneNumber = table.Column<string>(type: "VARCHAR(512) ", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "SMALLINT", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "SMALLINT", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "CHAR(33)", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "SMALLINT", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Places",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("NTi:Identity", "1, 1"),
                    Name = table.Column<string>(type: "VARGRAPHIC(1024)  CCSID 1200", nullable: true),
                    Description = table.Column<string>(type: "VARGRAPHIC(1024)  CCSID 1200", nullable: true),
                    PhoneNumber = table.Column<string>(type: "VARCHAR(512) ", nullable: true),
                    Address1 = table.Column<string>(type: "VARGRAPHIC(1024)  CCSID 1200", nullable: true),
                    Address2 = table.Column<string>(type: "VARGRAPHIC(1024)  CCSID 1200", nullable: true),
                    Zip = table.Column<string>(type: "VARGRAPHIC(1024)  CCSID 1200", nullable: true),
                    City = table.Column<string>(type: "VARGRAPHIC(1024)  CCSID 1200", nullable: true),
                    Country = table.Column<string>(type: "VARGRAPHIC(1024)  CCSID 1200", nullable: true),
                    Picture = table.Column<byte[]>(type: "BLOB(3M)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Places", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("NTi:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "VARCHAR(900) ", nullable: false),
                    ClaimType = table.Column<string>(type: "VARCHAR(512) ", nullable: true),
                    ClaimValue = table.Column<string>(type: "VARCHAR(512) ", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("NTi:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "VARCHAR(900) ", nullable: false),
                    ClaimType = table.Column<string>(type: "VARCHAR(512) ", nullable: true),
                    ClaimValue = table.Column<string>(type: "VARCHAR(512) ", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "VARCHAR(900) ", nullable: false),
                    ProviderKey = table.Column<string>(type: "VARCHAR(900) ", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "VARCHAR(512) ", nullable: true),
                    UserId = table.Column<string>(type: "VARCHAR(900) ", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "VARCHAR(900) ", nullable: false),
                    RoleId = table.Column<string>(type: "VARCHAR(900) ", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "VARCHAR(900) ", nullable: false),
                    LoginProvider = table.Column<string>(type: "VARCHAR(900) ", nullable: false),
                    Name = table.Column<string>(type: "VARCHAR(900) ", nullable: false),
                    Value = table.Column<string>(type: "VARCHAR(512) ", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Concerts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("NTi:Identity", "1, 1"),
                    Name = table.Column<string>(type: "VARGRAPHIC(1024)  CCSID 1200", nullable: true),
                    Description = table.Column<string>(type: "VARGRAPHIC(1024)  CCSID 1200", nullable: true),
                    PlaceId = table.Column<int>(type: "INTEGER", nullable: true),
                    Date = table.Column<DateTime>(type: "timestamp(6)", nullable: true),
                    Picture = table.Column<byte[]>(type: "BLOB(3M)", nullable: true),
                    Price = table.Column<decimal>(type: "DECIMAL(18, 2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Concerts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Concerts_Places_PlaceId",
                        column: x => x.PlaceId,
                        principalTable: "Places",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ArtistConcert",
                columns: table => new
                {
                    ArtistsId = table.Column<int>(type: "INTEGER", nullable: false),
                    ConcertsId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArtistConcert", x => new { x.ArtistsId, x.ConcertsId });
                    table.ForeignKey(
                        name: "FK_ArtistConcert_Artists_ArtistsId",
                        column: x => x.ArtistsId,
                        principalTable: "Artists",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ArtistConcert_Concerts_ConcertsId",
                        column: x => x.ConcertsId,
                        principalTable: "Concerts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tickets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("NTi:Identity", "1, 1"),
                    Price = table.Column<decimal>(type: "DECIMAL(18, 2)", nullable: true),
                    Checked = table.Column<bool>(type: "SMALLINT", nullable: false),
                    CheckedOn = table.Column<DateTime>(type: "timestamp(6)", nullable: true),
                    FirstName = table.Column<string>(type: "VARGRAPHIC(1024)  CCSID 1200", nullable: true),
                    LastName = table.Column<string>(type: "VARGRAPHIC(1024)  CCSID 1200", nullable: true),
                    ConcertId = table.Column<int>(type: "INTEGER", nullable: true),
                    UserId = table.Column<string>(type: "VARCHAR(900) ", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tickets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tickets_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Tickets_Concerts_ConcertId",
                        column: x => x.ConcertId,
                        principalTable: "Concerts",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_ArtistConcert_ConcertsId",
                table: "ArtistConcert",
                column: "ConcertsId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Concerts_PlaceId",
                table: "Concerts",
                column: "PlaceId");

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_ConcertId",
                table: "Tickets",
                column: "ConcertId");

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_UserId",
                table: "Tickets",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ArtistConcert");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Tickets");

            migrationBuilder.DropTable(
                name: "Artists");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Concerts");

            migrationBuilder.DropTable(
                name: "Places");
        }
    }
}

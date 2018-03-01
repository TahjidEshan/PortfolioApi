using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace PortFolio2017.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<Guid>(nullable: false),
                    UserName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "Addresses",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    City = table.Column<string>(maxLength: 50, nullable: false),
                    Country = table.Column<string>(maxLength: 50, nullable: false),
                    CreatedByUserId = table.Column<Guid>(nullable: true),
                    CreatedOn = table.Column<DateTime>(nullable: true),
                    HouseNumber = table.Column<string>(maxLength: 50, nullable: false),
                    RoadNumber = table.Column<string>(maxLength: 50, nullable: false),
                    UpdatedByUserId = table.Column<Guid>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Addresses_Users_CreatedByUserId",
                        column: x => x.CreatedByUserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Addresses_Users_UpdatedByUserId",
                        column: x => x.UpdatedByUserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Authors",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedByUserId = table.Column<Guid>(nullable: true),
                    CreatedOn = table.Column<DateTime>(nullable: true),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    UpdatedByUserId = table.Column<Guid>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    Url = table.Column<string>(nullable: true),
                    UserId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Authors_Users_CreatedByUserId",
                        column: x => x.CreatedByUserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Authors_Users_UpdatedByUserId",
                        column: x => x.UpdatedByUserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Authors_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Educations",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedByUserId = table.Column<Guid>(nullable: true),
                    CreatedOn = table.Column<DateTime>(nullable: true),
                    CurrentlyEnrolled = table.Column<bool>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    FromDate = table.Column<DateTime>(nullable: false),
                    LifeEvent = table.Column<int>(nullable: false),
                    Title = table.Column<string>(nullable: false),
                    ToDate = table.Column<DateTime>(nullable: false),
                    UpdatedByUserId = table.Column<Guid>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    Url = table.Column<string>(nullable: true),
                    UrlText = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Educations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Educations_Users_CreatedByUserId",
                        column: x => x.CreatedByUserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Educations_Users_UpdatedByUserId",
                        column: x => x.UpdatedByUserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Emails",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedByUserId = table.Column<Guid>(nullable: true),
                    CreatedOn = table.Column<DateTime>(nullable: true),
                    EmailAddress = table.Column<string>(nullable: false),
                    UpdatedByUserId = table.Column<Guid>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Emails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Emails_Users_CreatedByUserId",
                        column: x => x.CreatedByUserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Emails_Users_UpdatedByUserId",
                        column: x => x.UpdatedByUserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Expertises",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedByUserId = table.Column<Guid>(nullable: true),
                    CreatedOn = table.Column<DateTime>(nullable: true),
                    Details = table.Column<string>(nullable: true),
                    Title = table.Column<string>(nullable: false),
                    UpdatedByUserId = table.Column<Guid>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Expertises", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Expertises_Users_CreatedByUserId",
                        column: x => x.CreatedByUserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Expertises_Users_UpdatedByUserId",
                        column: x => x.UpdatedByUserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "GeneralSkills",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedByUserId = table.Column<Guid>(nullable: true),
                    CreatedOn = table.Column<DateTime>(nullable: true),
                    Percentage = table.Column<int>(nullable: false),
                    Text = table.Column<string>(nullable: false),
                    UpdatedByUserId = table.Column<Guid>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GeneralSkills", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GeneralSkills_Users_CreatedByUserId",
                        column: x => x.CreatedByUserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_GeneralSkills_Users_UpdatedByUserId",
                        column: x => x.UpdatedByUserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Headers",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedByUserId = table.Column<Guid>(nullable: true),
                    CreatedOn = table.Column<DateTime>(nullable: true),
                    Text = table.Column<string>(nullable: false),
                    UpdatedByUserId = table.Column<Guid>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Headers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Headers_Users_CreatedByUserId",
                        column: x => x.CreatedByUserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Headers_Users_UpdatedByUserId",
                        column: x => x.UpdatedByUserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Images",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedByUserId = table.Column<Guid>(nullable: true),
                    CreatedOn = table.Column<DateTime>(nullable: true),
                    Location = table.Column<string>(nullable: false),
                    Title = table.Column<string>(nullable: true),
                    UpdatedByUserId = table.Column<Guid>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Images", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Images_Users_CreatedByUserId",
                        column: x => x.CreatedByUserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Images_Users_UpdatedByUserId",
                        column: x => x.UpdatedByUserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Mottos",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedByUserId = table.Column<Guid>(nullable: true),
                    CreatedOn = table.Column<DateTime>(nullable: true),
                    Text = table.Column<string>(nullable: false),
                    UpdatedByUserId = table.Column<Guid>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mottos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Mottos_Users_CreatedByUserId",
                        column: x => x.CreatedByUserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Mottos_Users_UpdatedByUserId",
                        column: x => x.UpdatedByUserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Phones",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedByUserId = table.Column<Guid>(nullable: true),
                    CreatedOn = table.Column<DateTime>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: false),
                    UpdatedByUserId = table.Column<Guid>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Phones", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Phones_Users_CreatedByUserId",
                        column: x => x.CreatedByUserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Phones_Users_UpdatedByUserId",
                        column: x => x.UpdatedByUserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Publications",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedByUserId = table.Column<Guid>(nullable: true),
                    CreatedOn = table.Column<DateTime>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    LifeEvent = table.Column<int>(nullable: false),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    UpdatedByUserId = table.Column<Guid>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    Url = table.Column<string>(nullable: true),
                    UrlText = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Publications", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Publications_Users_CreatedByUserId",
                        column: x => x.CreatedByUserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Publications_Users_UpdatedByUserId",
                        column: x => x.UpdatedByUserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SocialServices",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedByUserId = table.Column<Guid>(nullable: true),
                    CreatedOn = table.Column<DateTime>(nullable: true),
                    Icon = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    SocialLinkType = table.Column<int>(nullable: false),
                    UpdatedByUserId = table.Column<Guid>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    Url = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SocialServices", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SocialServices_Users_CreatedByUserId",
                        column: x => x.CreatedByUserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SocialServices_Users_UpdatedByUserId",
                        column: x => x.UpdatedByUserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SpecialSkills",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedByUserId = table.Column<Guid>(nullable: true),
                    CreatedOn = table.Column<DateTime>(nullable: true),
                    DisplayType = table.Column<int>(nullable: false),
                    Percentage = table.Column<int>(nullable: false),
                    Title = table.Column<string>(nullable: false),
                    UpdatedByUserId = table.Column<Guid>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SpecialSkills", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SpecialSkills_Users_CreatedByUserId",
                        column: x => x.CreatedByUserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SpecialSkills_Users_UpdatedByUserId",
                        column: x => x.UpdatedByUserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Works",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedByUserId = table.Column<Guid>(nullable: true),
                    CreatedOn = table.Column<DateTime>(nullable: true),
                    CurrentlyEmployed = table.Column<bool>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    FromDate = table.Column<DateTime>(nullable: false),
                    LifeEvent = table.Column<int>(nullable: false),
                    Title = table.Column<string>(nullable: false),
                    ToDate = table.Column<DateTime>(nullable: false),
                    UpdatedByUserId = table.Column<Guid>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    Url = table.Column<string>(nullable: true),
                    UrlText = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Works", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Works_Users_CreatedByUserId",
                        column: x => x.CreatedByUserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Works_Users_UpdatedByUserId",
                        column: x => x.UpdatedByUserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SentMails",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Comments = table.Column<string>(nullable: false),
                    CreatedByUserId = table.Column<Guid>(nullable: true),
                    CreatedOn = table.Column<DateTime>(nullable: true),
                    EmailAddressId = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    PhoneId = table.Column<Guid>(nullable: false),
                    Subject = table.Column<string>(nullable: true),
                    ToEmailAddressId = table.Column<Guid>(nullable: false),
                    UpdatedByUserId = table.Column<Guid>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SentMails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SentMails_Users_CreatedByUserId",
                        column: x => x.CreatedByUserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SentMails_Emails_EmailAddressId",
                        column: x => x.EmailAddressId,
                        principalTable: "Emails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SentMails_Phones_PhoneId",
                        column: x => x.PhoneId,
                        principalTable: "Phones",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SentMails_Emails_ToEmailAddressId",
                        column: x => x.ToEmailAddressId,
                        principalTable: "Emails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SentMails_Users_UpdatedByUserId",
                        column: x => x.UpdatedByUserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PublicationAuthors",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    AuthorId = table.Column<Guid>(nullable: false),
                    CreatedByUserId = table.Column<Guid>(nullable: true),
                    CreatedOn = table.Column<DateTime>(nullable: true),
                    PublicationId = table.Column<Guid>(nullable: false),
                    UpdatedByUserId = table.Column<Guid>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PublicationAuthors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PublicationAuthors_Authors_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "Authors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PublicationAuthors_Users_CreatedByUserId",
                        column: x => x.CreatedByUserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PublicationAuthors_Publications_PublicationId",
                        column: x => x.PublicationId,
                        principalTable: "Publications",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PublicationAuthors_Users_UpdatedByUserId",
                        column: x => x.UpdatedByUserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Events",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedByUserId = table.Column<Guid>(nullable: true),
                    CreatedOn = table.Column<DateTime>(nullable: true),
                    EducationId = table.Column<Guid>(nullable: true),
                    PublicationId = table.Column<Guid>(nullable: true),
                    UpdatedByUserId = table.Column<Guid>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    WorkId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Events", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Events_Users_CreatedByUserId",
                        column: x => x.CreatedByUserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Events_Educations_EducationId",
                        column: x => x.EducationId,
                        principalTable: "Educations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Events_Publications_PublicationId",
                        column: x => x.PublicationId,
                        principalTable: "Publications",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Events_Users_UpdatedByUserId",
                        column: x => x.UpdatedByUserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Events_Works_WorkId",
                        column: x => x.WorkId,
                        principalTable: "Works",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_CreatedByUserId",
                table: "Addresses",
                column: "CreatedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_UpdatedByUserId",
                table: "Addresses",
                column: "UpdatedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Authors_CreatedByUserId",
                table: "Authors",
                column: "CreatedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Authors_UpdatedByUserId",
                table: "Authors",
                column: "UpdatedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Authors_UserId",
                table: "Authors",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Educations_CreatedByUserId",
                table: "Educations",
                column: "CreatedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Educations_UpdatedByUserId",
                table: "Educations",
                column: "UpdatedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Emails_CreatedByUserId",
                table: "Emails",
                column: "CreatedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Emails_UpdatedByUserId",
                table: "Emails",
                column: "UpdatedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Events_CreatedByUserId",
                table: "Events",
                column: "CreatedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Events_EducationId",
                table: "Events",
                column: "EducationId");

            migrationBuilder.CreateIndex(
                name: "IX_Events_PublicationId",
                table: "Events",
                column: "PublicationId");

            migrationBuilder.CreateIndex(
                name: "IX_Events_UpdatedByUserId",
                table: "Events",
                column: "UpdatedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Events_WorkId",
                table: "Events",
                column: "WorkId");

            migrationBuilder.CreateIndex(
                name: "IX_Expertises_CreatedByUserId",
                table: "Expertises",
                column: "CreatedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Expertises_UpdatedByUserId",
                table: "Expertises",
                column: "UpdatedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_GeneralSkills_CreatedByUserId",
                table: "GeneralSkills",
                column: "CreatedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_GeneralSkills_UpdatedByUserId",
                table: "GeneralSkills",
                column: "UpdatedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Headers_CreatedByUserId",
                table: "Headers",
                column: "CreatedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Headers_UpdatedByUserId",
                table: "Headers",
                column: "UpdatedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Images_CreatedByUserId",
                table: "Images",
                column: "CreatedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Images_UpdatedByUserId",
                table: "Images",
                column: "UpdatedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Mottos_CreatedByUserId",
                table: "Mottos",
                column: "CreatedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Mottos_UpdatedByUserId",
                table: "Mottos",
                column: "UpdatedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Phones_CreatedByUserId",
                table: "Phones",
                column: "CreatedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Phones_UpdatedByUserId",
                table: "Phones",
                column: "UpdatedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_PublicationAuthors_AuthorId",
                table: "PublicationAuthors",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_PublicationAuthors_CreatedByUserId",
                table: "PublicationAuthors",
                column: "CreatedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_PublicationAuthors_PublicationId",
                table: "PublicationAuthors",
                column: "PublicationId");

            migrationBuilder.CreateIndex(
                name: "IX_PublicationAuthors_UpdatedByUserId",
                table: "PublicationAuthors",
                column: "UpdatedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Publications_CreatedByUserId",
                table: "Publications",
                column: "CreatedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Publications_UpdatedByUserId",
                table: "Publications",
                column: "UpdatedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_SentMails_CreatedByUserId",
                table: "SentMails",
                column: "CreatedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_SentMails_EmailAddressId",
                table: "SentMails",
                column: "EmailAddressId");

            migrationBuilder.CreateIndex(
                name: "IX_SentMails_PhoneId",
                table: "SentMails",
                column: "PhoneId");

            migrationBuilder.CreateIndex(
                name: "IX_SentMails_ToEmailAddressId",
                table: "SentMails",
                column: "ToEmailAddressId");

            migrationBuilder.CreateIndex(
                name: "IX_SentMails_UpdatedByUserId",
                table: "SentMails",
                column: "UpdatedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_SocialServices_CreatedByUserId",
                table: "SocialServices",
                column: "CreatedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_SocialServices_UpdatedByUserId",
                table: "SocialServices",
                column: "UpdatedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_SpecialSkills_CreatedByUserId",
                table: "SpecialSkills",
                column: "CreatedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_SpecialSkills_UpdatedByUserId",
                table: "SpecialSkills",
                column: "UpdatedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Works_CreatedByUserId",
                table: "Works",
                column: "CreatedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Works_UpdatedByUserId",
                table: "Works",
                column: "UpdatedByUserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Addresses");

            migrationBuilder.DropTable(
                name: "Events");

            migrationBuilder.DropTable(
                name: "Expertises");

            migrationBuilder.DropTable(
                name: "GeneralSkills");

            migrationBuilder.DropTable(
                name: "Headers");

            migrationBuilder.DropTable(
                name: "Images");

            migrationBuilder.DropTable(
                name: "Mottos");

            migrationBuilder.DropTable(
                name: "PublicationAuthors");

            migrationBuilder.DropTable(
                name: "SentMails");

            migrationBuilder.DropTable(
                name: "SocialServices");

            migrationBuilder.DropTable(
                name: "SpecialSkills");

            migrationBuilder.DropTable(
                name: "Educations");

            migrationBuilder.DropTable(
                name: "Works");

            migrationBuilder.DropTable(
                name: "Authors");

            migrationBuilder.DropTable(
                name: "Publications");

            migrationBuilder.DropTable(
                name: "Emails");

            migrationBuilder.DropTable(
                name: "Phones");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}

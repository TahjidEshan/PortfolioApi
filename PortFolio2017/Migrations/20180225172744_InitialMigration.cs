using Microsoft.EntityFrameworkCore.Metadata;
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
                name: "Addresses",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    City = table.Column<string>(maxLength: 50, nullable: false),
                    Country = table.Column<string>(maxLength: 50, nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    CreatedOn = table.Column<DateTime>(nullable: true),
                    HouseNumber = table.Column<string>(maxLength: 50, nullable: false),
                    RoadNumber = table.Column<string>(maxLength: 50, nullable: false),
                    UpdatedBy = table.Column<string>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Authors",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedBy = table.Column<string>(nullable: true),
                    CreatedOn = table.Column<DateTime>(nullable: true),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    UpdatedBy = table.Column<string>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    Url = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EducationHistory",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedBy = table.Column<string>(nullable: true),
                    CreatedOn = table.Column<DateTime>(nullable: true),
                    CurrentlyEnrolled = table.Column<bool>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    FromDate = table.Column<DateTime>(nullable: false),
                    LifeEvent = table.Column<int>(nullable: false),
                    Title = table.Column<string>(nullable: false),
                    ToDate = table.Column<DateTime>(nullable: false),
                    UpdatedBy = table.Column<string>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    Url = table.Column<string>(nullable: true),
                    UrlText = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EducationHistory", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Emails",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedBy = table.Column<string>(nullable: true),
                    CreatedOn = table.Column<DateTime>(nullable: true),
                    EmailAddress = table.Column<string>(nullable: false),
                    UpdatedBy = table.Column<string>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Emails", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GeneralSkills",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedBy = table.Column<string>(nullable: true),
                    CreatedOn = table.Column<DateTime>(nullable: true),
                    Percentage = table.Column<int>(nullable: false),
                    Text = table.Column<string>(nullable: false),
                    UpdatedBy = table.Column<string>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GeneralSkills", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Headers",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedBy = table.Column<string>(nullable: true),
                    CreatedOn = table.Column<DateTime>(nullable: true),
                    Text = table.Column<string>(nullable: false),
                    UpdatedBy = table.Column<string>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Headers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Images",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedBy = table.Column<string>(nullable: true),
                    CreatedOn = table.Column<DateTime>(nullable: true),
                    Location = table.Column<string>(nullable: false),
                    UpdatedBy = table.Column<string>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Images", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Mottos",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedBy = table.Column<string>(nullable: true),
                    CreatedOn = table.Column<DateTime>(nullable: true),
                    Text = table.Column<string>(nullable: false),
                    UpdatedBy = table.Column<string>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mottos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Phones",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedBy = table.Column<string>(nullable: true),
                    CreatedOn = table.Column<DateTime>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: false),
                    UpdatedBy = table.Column<string>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Phones", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Publications",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedBy = table.Column<string>(nullable: true),
                    CreatedOn = table.Column<DateTime>(nullable: true),
                    LifeEvent = table.Column<int>(nullable: false),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    UpdatedBy = table.Column<string>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    Url = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Publications", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SocialService",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedBy = table.Column<string>(nullable: true),
                    CreatedOn = table.Column<DateTime>(nullable: true),
                    Icon = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    SocialLinkType = table.Column<int>(nullable: false),
                    UpdatedBy = table.Column<string>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    Url = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SocialService", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WorkHistory",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedBy = table.Column<string>(nullable: true),
                    CreatedOn = table.Column<DateTime>(nullable: true),
                    CurrentlyEmployed = table.Column<bool>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    FromDate = table.Column<DateTime>(nullable: false),
                    LifeEvent = table.Column<int>(nullable: false),
                    Title = table.Column<string>(nullable: false),
                    ToDate = table.Column<DateTime>(nullable: false),
                    UpdatedBy = table.Column<string>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    Url = table.Column<string>(nullable: true),
                    UrlText = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkHistory", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PublicationAuthors",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AuthorId = table.Column<long>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    CreatedOn = table.Column<DateTime>(nullable: true),
                    PublicationId = table.Column<long>(nullable: false),
                    UpdatedBy = table.Column<string>(nullable: true),
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
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PublicationAuthors_Authors_PublicationId",
                        column: x => x.PublicationId,
                        principalTable: "Authors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SentMails",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Comments = table.Column<string>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    CreatedOn = table.Column<DateTime>(nullable: true),
                    EmailAddressId = table.Column<long>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    PhoneId = table.Column<long>(nullable: false),
                    Subject = table.Column<string>(nullable: true),
                    ToEmailAddressId = table.Column<long>(nullable: false),
                    UpdatedBy = table.Column<string>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SentMails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SentMails_Emails_EmailAddressId",
                        column: x => x.EmailAddressId,
                        principalTable: "Emails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SentMails_Phones_PhoneId",
                        column: x => x.PhoneId,
                        principalTable: "Phones",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SentMails_Emails_ToEmailAddressId",
                        column: x => x.ToEmailAddressId,
                        principalTable: "Emails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Events",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedBy = table.Column<string>(nullable: true),
                    CreatedOn = table.Column<DateTime>(nullable: true),
                    EducationId = table.Column<long>(nullable: true),
                    LifeEvent = table.Column<int>(nullable: false),
                    PublicationId = table.Column<long>(nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    WorkId = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Events", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Events_EducationHistory_EducationId",
                        column: x => x.EducationId,
                        principalTable: "EducationHistory",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Events_Publications_PublicationId",
                        column: x => x.PublicationId,
                        principalTable: "Publications",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Events_WorkHistory_WorkId",
                        column: x => x.WorkId,
                        principalTable: "WorkHistory",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Events_EducationId",
                table: "Events",
                column: "EducationId");

            migrationBuilder.CreateIndex(
                name: "IX_Events_PublicationId",
                table: "Events",
                column: "PublicationId");

            migrationBuilder.CreateIndex(
                name: "IX_Events_WorkId",
                table: "Events",
                column: "WorkId");

            migrationBuilder.CreateIndex(
                name: "IX_PublicationAuthors_AuthorId",
                table: "PublicationAuthors",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_PublicationAuthors_PublicationId",
                table: "PublicationAuthors",
                column: "PublicationId");

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Addresses");

            migrationBuilder.DropTable(
                name: "Events");

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
                name: "SocialService");

            migrationBuilder.DropTable(
                name: "EducationHistory");

            migrationBuilder.DropTable(
                name: "Publications");

            migrationBuilder.DropTable(
                name: "WorkHistory");

            migrationBuilder.DropTable(
                name: "Authors");

            migrationBuilder.DropTable(
                name: "Emails");

            migrationBuilder.DropTable(
                name: "Phones");
        }
    }
}

using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace PortFolio2017.Migrations
{
    public partial class User : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "WorkHistory");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "WorkHistory");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "SocialService");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "SocialService");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "SentMails");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "SentMails");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Publications");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "Publications");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "PublicationAuthors");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "PublicationAuthors");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Phones");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "Phones");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Mottos");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "Mottos");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Images");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "Images");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Headers");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "Headers");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "GeneralSkills");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "GeneralSkills");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Emails");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "Emails");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "EducationHistory");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "EducationHistory");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Authors");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "Authors");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Addresses");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "Addresses");

            migrationBuilder.AddColumn<long>(
                name: "CreatedByUserId",
                table: "WorkHistory",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "UpdatedByUserId",
                table: "WorkHistory",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "CreatedByUserId",
                table: "SocialService",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "UpdatedByUserId",
                table: "SocialService",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "CreatedByUserId",
                table: "SentMails",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "UpdatedByUserId",
                table: "SentMails",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "CreatedByUserId",
                table: "Publications",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "UpdatedByUserId",
                table: "Publications",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "CreatedByUserId",
                table: "PublicationAuthors",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "UpdatedByUserId",
                table: "PublicationAuthors",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "CreatedByUserId",
                table: "Phones",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "UpdatedByUserId",
                table: "Phones",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "CreatedByUserId",
                table: "Mottos",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "UpdatedByUserId",
                table: "Mottos",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "CreatedByUserId",
                table: "Images",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "UpdatedByUserId",
                table: "Images",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "CreatedByUserId",
                table: "Headers",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "UpdatedByUserId",
                table: "Headers",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "CreatedByUserId",
                table: "GeneralSkills",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "UpdatedByUserId",
                table: "GeneralSkills",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "CreatedByUserId",
                table: "Events",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "UpdatedByUserId",
                table: "Events",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "CreatedByUserId",
                table: "Emails",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "UpdatedByUserId",
                table: "Emails",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "CreatedByUserId",
                table: "EducationHistory",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "UpdatedByUserId",
                table: "EducationHistory",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "CreatedByUserId",
                table: "Authors",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "UpdatedByUserId",
                table: "Authors",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "CreatedByUserId",
                table: "Addresses",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "UpdatedByUserId",
                table: "Addresses",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    UserId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.UserId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_WorkHistory_CreatedByUserId",
                table: "WorkHistory",
                column: "CreatedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkHistory_UpdatedByUserId",
                table: "WorkHistory",
                column: "UpdatedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_SocialService_CreatedByUserId",
                table: "SocialService",
                column: "CreatedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_SocialService_UpdatedByUserId",
                table: "SocialService",
                column: "UpdatedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_SentMails_CreatedByUserId",
                table: "SentMails",
                column: "CreatedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_SentMails_UpdatedByUserId",
                table: "SentMails",
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
                name: "IX_PublicationAuthors_CreatedByUserId",
                table: "PublicationAuthors",
                column: "CreatedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_PublicationAuthors_UpdatedByUserId",
                table: "PublicationAuthors",
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
                name: "IX_Mottos_CreatedByUserId",
                table: "Mottos",
                column: "CreatedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Mottos_UpdatedByUserId",
                table: "Mottos",
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
                name: "IX_Headers_CreatedByUserId",
                table: "Headers",
                column: "CreatedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Headers_UpdatedByUserId",
                table: "Headers",
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
                name: "IX_Events_CreatedByUserId",
                table: "Events",
                column: "CreatedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Events_UpdatedByUserId",
                table: "Events",
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
                name: "IX_EducationHistory_CreatedByUserId",
                table: "EducationHistory",
                column: "CreatedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_EducationHistory_UpdatedByUserId",
                table: "EducationHistory",
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
                name: "IX_Addresses_CreatedByUserId",
                table: "Addresses",
                column: "CreatedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_UpdatedByUserId",
                table: "Addresses",
                column: "UpdatedByUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Addresses_User_CreatedByUserId",
                table: "Addresses",
                column: "CreatedByUserId",
                principalTable: "User",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Addresses_User_UpdatedByUserId",
                table: "Addresses",
                column: "UpdatedByUserId",
                principalTable: "User",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Authors_User_CreatedByUserId",
                table: "Authors",
                column: "CreatedByUserId",
                principalTable: "User",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Authors_User_UpdatedByUserId",
                table: "Authors",
                column: "UpdatedByUserId",
                principalTable: "User",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_EducationHistory_User_CreatedByUserId",
                table: "EducationHistory",
                column: "CreatedByUserId",
                principalTable: "User",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_EducationHistory_User_UpdatedByUserId",
                table: "EducationHistory",
                column: "UpdatedByUserId",
                principalTable: "User",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Emails_User_CreatedByUserId",
                table: "Emails",
                column: "CreatedByUserId",
                principalTable: "User",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Emails_User_UpdatedByUserId",
                table: "Emails",
                column: "UpdatedByUserId",
                principalTable: "User",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Events_User_CreatedByUserId",
                table: "Events",
                column: "CreatedByUserId",
                principalTable: "User",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Events_User_UpdatedByUserId",
                table: "Events",
                column: "UpdatedByUserId",
                principalTable: "User",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_GeneralSkills_User_CreatedByUserId",
                table: "GeneralSkills",
                column: "CreatedByUserId",
                principalTable: "User",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_GeneralSkills_User_UpdatedByUserId",
                table: "GeneralSkills",
                column: "UpdatedByUserId",
                principalTable: "User",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Headers_User_CreatedByUserId",
                table: "Headers",
                column: "CreatedByUserId",
                principalTable: "User",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Headers_User_UpdatedByUserId",
                table: "Headers",
                column: "UpdatedByUserId",
                principalTable: "User",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Images_User_CreatedByUserId",
                table: "Images",
                column: "CreatedByUserId",
                principalTable: "User",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Images_User_UpdatedByUserId",
                table: "Images",
                column: "UpdatedByUserId",
                principalTable: "User",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Mottos_User_CreatedByUserId",
                table: "Mottos",
                column: "CreatedByUserId",
                principalTable: "User",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Mottos_User_UpdatedByUserId",
                table: "Mottos",
                column: "UpdatedByUserId",
                principalTable: "User",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Phones_User_CreatedByUserId",
                table: "Phones",
                column: "CreatedByUserId",
                principalTable: "User",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Phones_User_UpdatedByUserId",
                table: "Phones",
                column: "UpdatedByUserId",
                principalTable: "User",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PublicationAuthors_User_CreatedByUserId",
                table: "PublicationAuthors",
                column: "CreatedByUserId",
                principalTable: "User",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PublicationAuthors_User_UpdatedByUserId",
                table: "PublicationAuthors",
                column: "UpdatedByUserId",
                principalTable: "User",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Publications_User_CreatedByUserId",
                table: "Publications",
                column: "CreatedByUserId",
                principalTable: "User",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Publications_User_UpdatedByUserId",
                table: "Publications",
                column: "UpdatedByUserId",
                principalTable: "User",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SentMails_User_CreatedByUserId",
                table: "SentMails",
                column: "CreatedByUserId",
                principalTable: "User",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SentMails_User_UpdatedByUserId",
                table: "SentMails",
                column: "UpdatedByUserId",
                principalTable: "User",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SocialService_User_CreatedByUserId",
                table: "SocialService",
                column: "CreatedByUserId",
                principalTable: "User",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SocialService_User_UpdatedByUserId",
                table: "SocialService",
                column: "UpdatedByUserId",
                principalTable: "User",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_WorkHistory_User_CreatedByUserId",
                table: "WorkHistory",
                column: "CreatedByUserId",
                principalTable: "User",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_WorkHistory_User_UpdatedByUserId",
                table: "WorkHistory",
                column: "UpdatedByUserId",
                principalTable: "User",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Addresses_User_CreatedByUserId",
                table: "Addresses");

            migrationBuilder.DropForeignKey(
                name: "FK_Addresses_User_UpdatedByUserId",
                table: "Addresses");

            migrationBuilder.DropForeignKey(
                name: "FK_Authors_User_CreatedByUserId",
                table: "Authors");

            migrationBuilder.DropForeignKey(
                name: "FK_Authors_User_UpdatedByUserId",
                table: "Authors");

            migrationBuilder.DropForeignKey(
                name: "FK_EducationHistory_User_CreatedByUserId",
                table: "EducationHistory");

            migrationBuilder.DropForeignKey(
                name: "FK_EducationHistory_User_UpdatedByUserId",
                table: "EducationHistory");

            migrationBuilder.DropForeignKey(
                name: "FK_Emails_User_CreatedByUserId",
                table: "Emails");

            migrationBuilder.DropForeignKey(
                name: "FK_Emails_User_UpdatedByUserId",
                table: "Emails");

            migrationBuilder.DropForeignKey(
                name: "FK_Events_User_CreatedByUserId",
                table: "Events");

            migrationBuilder.DropForeignKey(
                name: "FK_Events_User_UpdatedByUserId",
                table: "Events");

            migrationBuilder.DropForeignKey(
                name: "FK_GeneralSkills_User_CreatedByUserId",
                table: "GeneralSkills");

            migrationBuilder.DropForeignKey(
                name: "FK_GeneralSkills_User_UpdatedByUserId",
                table: "GeneralSkills");

            migrationBuilder.DropForeignKey(
                name: "FK_Headers_User_CreatedByUserId",
                table: "Headers");

            migrationBuilder.DropForeignKey(
                name: "FK_Headers_User_UpdatedByUserId",
                table: "Headers");

            migrationBuilder.DropForeignKey(
                name: "FK_Images_User_CreatedByUserId",
                table: "Images");

            migrationBuilder.DropForeignKey(
                name: "FK_Images_User_UpdatedByUserId",
                table: "Images");

            migrationBuilder.DropForeignKey(
                name: "FK_Mottos_User_CreatedByUserId",
                table: "Mottos");

            migrationBuilder.DropForeignKey(
                name: "FK_Mottos_User_UpdatedByUserId",
                table: "Mottos");

            migrationBuilder.DropForeignKey(
                name: "FK_Phones_User_CreatedByUserId",
                table: "Phones");

            migrationBuilder.DropForeignKey(
                name: "FK_Phones_User_UpdatedByUserId",
                table: "Phones");

            migrationBuilder.DropForeignKey(
                name: "FK_PublicationAuthors_User_CreatedByUserId",
                table: "PublicationAuthors");

            migrationBuilder.DropForeignKey(
                name: "FK_PublicationAuthors_User_UpdatedByUserId",
                table: "PublicationAuthors");

            migrationBuilder.DropForeignKey(
                name: "FK_Publications_User_CreatedByUserId",
                table: "Publications");

            migrationBuilder.DropForeignKey(
                name: "FK_Publications_User_UpdatedByUserId",
                table: "Publications");

            migrationBuilder.DropForeignKey(
                name: "FK_SentMails_User_CreatedByUserId",
                table: "SentMails");

            migrationBuilder.DropForeignKey(
                name: "FK_SentMails_User_UpdatedByUserId",
                table: "SentMails");

            migrationBuilder.DropForeignKey(
                name: "FK_SocialService_User_CreatedByUserId",
                table: "SocialService");

            migrationBuilder.DropForeignKey(
                name: "FK_SocialService_User_UpdatedByUserId",
                table: "SocialService");

            migrationBuilder.DropForeignKey(
                name: "FK_WorkHistory_User_CreatedByUserId",
                table: "WorkHistory");

            migrationBuilder.DropForeignKey(
                name: "FK_WorkHistory_User_UpdatedByUserId",
                table: "WorkHistory");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropIndex(
                name: "IX_WorkHistory_CreatedByUserId",
                table: "WorkHistory");

            migrationBuilder.DropIndex(
                name: "IX_WorkHistory_UpdatedByUserId",
                table: "WorkHistory");

            migrationBuilder.DropIndex(
                name: "IX_SocialService_CreatedByUserId",
                table: "SocialService");

            migrationBuilder.DropIndex(
                name: "IX_SocialService_UpdatedByUserId",
                table: "SocialService");

            migrationBuilder.DropIndex(
                name: "IX_SentMails_CreatedByUserId",
                table: "SentMails");

            migrationBuilder.DropIndex(
                name: "IX_SentMails_UpdatedByUserId",
                table: "SentMails");

            migrationBuilder.DropIndex(
                name: "IX_Publications_CreatedByUserId",
                table: "Publications");

            migrationBuilder.DropIndex(
                name: "IX_Publications_UpdatedByUserId",
                table: "Publications");

            migrationBuilder.DropIndex(
                name: "IX_PublicationAuthors_CreatedByUserId",
                table: "PublicationAuthors");

            migrationBuilder.DropIndex(
                name: "IX_PublicationAuthors_UpdatedByUserId",
                table: "PublicationAuthors");

            migrationBuilder.DropIndex(
                name: "IX_Phones_CreatedByUserId",
                table: "Phones");

            migrationBuilder.DropIndex(
                name: "IX_Phones_UpdatedByUserId",
                table: "Phones");

            migrationBuilder.DropIndex(
                name: "IX_Mottos_CreatedByUserId",
                table: "Mottos");

            migrationBuilder.DropIndex(
                name: "IX_Mottos_UpdatedByUserId",
                table: "Mottos");

            migrationBuilder.DropIndex(
                name: "IX_Images_CreatedByUserId",
                table: "Images");

            migrationBuilder.DropIndex(
                name: "IX_Images_UpdatedByUserId",
                table: "Images");

            migrationBuilder.DropIndex(
                name: "IX_Headers_CreatedByUserId",
                table: "Headers");

            migrationBuilder.DropIndex(
                name: "IX_Headers_UpdatedByUserId",
                table: "Headers");

            migrationBuilder.DropIndex(
                name: "IX_GeneralSkills_CreatedByUserId",
                table: "GeneralSkills");

            migrationBuilder.DropIndex(
                name: "IX_GeneralSkills_UpdatedByUserId",
                table: "GeneralSkills");

            migrationBuilder.DropIndex(
                name: "IX_Events_CreatedByUserId",
                table: "Events");

            migrationBuilder.DropIndex(
                name: "IX_Events_UpdatedByUserId",
                table: "Events");

            migrationBuilder.DropIndex(
                name: "IX_Emails_CreatedByUserId",
                table: "Emails");

            migrationBuilder.DropIndex(
                name: "IX_Emails_UpdatedByUserId",
                table: "Emails");

            migrationBuilder.DropIndex(
                name: "IX_EducationHistory_CreatedByUserId",
                table: "EducationHistory");

            migrationBuilder.DropIndex(
                name: "IX_EducationHistory_UpdatedByUserId",
                table: "EducationHistory");

            migrationBuilder.DropIndex(
                name: "IX_Authors_CreatedByUserId",
                table: "Authors");

            migrationBuilder.DropIndex(
                name: "IX_Authors_UpdatedByUserId",
                table: "Authors");

            migrationBuilder.DropIndex(
                name: "IX_Addresses_CreatedByUserId",
                table: "Addresses");

            migrationBuilder.DropIndex(
                name: "IX_Addresses_UpdatedByUserId",
                table: "Addresses");

            migrationBuilder.DropColumn(
                name: "CreatedByUserId",
                table: "WorkHistory");

            migrationBuilder.DropColumn(
                name: "UpdatedByUserId",
                table: "WorkHistory");

            migrationBuilder.DropColumn(
                name: "CreatedByUserId",
                table: "SocialService");

            migrationBuilder.DropColumn(
                name: "UpdatedByUserId",
                table: "SocialService");

            migrationBuilder.DropColumn(
                name: "CreatedByUserId",
                table: "SentMails");

            migrationBuilder.DropColumn(
                name: "UpdatedByUserId",
                table: "SentMails");

            migrationBuilder.DropColumn(
                name: "CreatedByUserId",
                table: "Publications");

            migrationBuilder.DropColumn(
                name: "UpdatedByUserId",
                table: "Publications");

            migrationBuilder.DropColumn(
                name: "CreatedByUserId",
                table: "PublicationAuthors");

            migrationBuilder.DropColumn(
                name: "UpdatedByUserId",
                table: "PublicationAuthors");

            migrationBuilder.DropColumn(
                name: "CreatedByUserId",
                table: "Phones");

            migrationBuilder.DropColumn(
                name: "UpdatedByUserId",
                table: "Phones");

            migrationBuilder.DropColumn(
                name: "CreatedByUserId",
                table: "Mottos");

            migrationBuilder.DropColumn(
                name: "UpdatedByUserId",
                table: "Mottos");

            migrationBuilder.DropColumn(
                name: "CreatedByUserId",
                table: "Images");

            migrationBuilder.DropColumn(
                name: "UpdatedByUserId",
                table: "Images");

            migrationBuilder.DropColumn(
                name: "CreatedByUserId",
                table: "Headers");

            migrationBuilder.DropColumn(
                name: "UpdatedByUserId",
                table: "Headers");

            migrationBuilder.DropColumn(
                name: "CreatedByUserId",
                table: "GeneralSkills");

            migrationBuilder.DropColumn(
                name: "UpdatedByUserId",
                table: "GeneralSkills");

            migrationBuilder.DropColumn(
                name: "CreatedByUserId",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "UpdatedByUserId",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "CreatedByUserId",
                table: "Emails");

            migrationBuilder.DropColumn(
                name: "UpdatedByUserId",
                table: "Emails");

            migrationBuilder.DropColumn(
                name: "CreatedByUserId",
                table: "EducationHistory");

            migrationBuilder.DropColumn(
                name: "UpdatedByUserId",
                table: "EducationHistory");

            migrationBuilder.DropColumn(
                name: "CreatedByUserId",
                table: "Authors");

            migrationBuilder.DropColumn(
                name: "UpdatedByUserId",
                table: "Authors");

            migrationBuilder.DropColumn(
                name: "CreatedByUserId",
                table: "Addresses");

            migrationBuilder.DropColumn(
                name: "UpdatedByUserId",
                table: "Addresses");

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "WorkHistory",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                table: "WorkHistory",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "SocialService",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                table: "SocialService",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "SentMails",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                table: "SentMails",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Publications",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                table: "Publications",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "PublicationAuthors",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                table: "PublicationAuthors",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Phones",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                table: "Phones",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Mottos",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                table: "Mottos",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Images",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                table: "Images",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Headers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                table: "Headers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "GeneralSkills",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                table: "GeneralSkills",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Events",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                table: "Events",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Emails",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                table: "Emails",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "EducationHistory",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                table: "EducationHistory",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Authors",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                table: "Authors",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Addresses",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                table: "Addresses",
                nullable: true);
        }
    }
}

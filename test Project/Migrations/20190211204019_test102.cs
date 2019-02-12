using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace testProject.Migrations
{
    public partial class test102 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BlogsModel_Videos_VideoID",
                table: "BlogsModel");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BlogsModel",
                table: "BlogsModel");

            migrationBuilder.RenameTable(
                name: "BlogsModel",
                newName: "Blogs");

            migrationBuilder.RenameIndex(
                name: "IX_BlogsModel_VideoID",
                table: "Blogs",
                newName: "IX_Blogs_VideoID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Blogs",
                table: "Blogs",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "News",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Guid = table.Column<Guid>(nullable: true),
                    DateCreated = table.Column<DateTime>(nullable: true),
                    LastUpdate = table.Column<DateTime>(nullable: true),
                    Timestamp = table.Column<byte[]>(nullable: true),
                    Deleted = table.Column<bool>(nullable: true),
                    UserGuid = table.Column<Guid>(nullable: true),
                    Title = table.Column<string>(maxLength: 150, nullable: true),
                    Image = table.Column<string>(maxLength: 50, nullable: true),
                    VideoID = table.Column<int>(nullable: true),
                    Keywords = table.Column<string>(maxLength: 50, nullable: true),
                    Source = table.Column<string>(maxLength: 100, nullable: true),
                    Article = table.Column<string>(nullable: true),
                    IsFeatured = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_News", x => x.Id);
                    table.ForeignKey(
                        name: "FK_News_Videos_VideoID",
                        column: x => x.VideoID,
                        principalTable: "Videos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_News_VideoID",
                table: "News",
                column: "VideoID");

            migrationBuilder.AddForeignKey(
                name: "FK_Blogs_Videos_VideoID",
                table: "Blogs",
                column: "VideoID",
                principalTable: "Videos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Blogs_Videos_VideoID",
                table: "Blogs");

            migrationBuilder.DropTable(
                name: "News");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Blogs",
                table: "Blogs");

            migrationBuilder.RenameTable(
                name: "Blogs",
                newName: "BlogsModel");

            migrationBuilder.RenameIndex(
                name: "IX_Blogs_VideoID",
                table: "BlogsModel",
                newName: "IX_BlogsModel_VideoID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BlogsModel",
                table: "BlogsModel",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_BlogsModel_Videos_VideoID",
                table: "BlogsModel",
                column: "VideoID",
                principalTable: "Videos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

namespace testProject.Migrations
{
    public partial class New : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Blogs_Videos_VideoID",
                table: "Blogs");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddForeignKey(
                name: "FK_Blogs_Videos_VideoID",
                table: "Blogs",
                column: "VideoID",
                principalTable: "Videos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

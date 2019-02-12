using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace testProject.Migrations
{
    public partial class Conference : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Conferences",
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
                    Name = table.Column<string>(maxLength: 50, nullable: true),
                    Venue = table.Column<string>(maxLength: 50, nullable: true),
                    City = table.Column<string>(maxLength: 75, nullable: true),
                    State = table.Column<string>(maxLength: 2, nullable: true),
                    StartDate = table.Column<DateTime>(nullable: true),
                    EndDate = table.Column<DateTime>(nullable: true),
                    URL = table.Column<string>(maxLength: 300, nullable: true),
                    Image = table.Column<string>(maxLength: 50, nullable: true),
                    IsFeatured = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Conferences", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Conferences");
        }
    }
}

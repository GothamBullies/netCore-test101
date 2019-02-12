using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace testProject.Migrations
{
    public partial class webcasts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Webcasts",
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
                    Subtitle = table.Column<string>(maxLength: 150, nullable: true),
                    Body = table.Column<string>(nullable: true),
                    Alert = table.Column<string>(maxLength: 150, nullable: true),
                    Contributors = table.Column<string>(maxLength: 500, nullable: true),
                    MediaFile = table.Column<string>(maxLength: 150, nullable: true),
                    Date = table.Column<DateTime>(nullable: false),
                    Image = table.Column<string>(nullable: true),
                    IsFeatured = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Webcasts", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Webcasts");
        }
    }
}

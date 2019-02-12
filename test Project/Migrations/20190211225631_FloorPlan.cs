using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace testProject.Migrations
{
    public partial class FloorPlan : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FloorPlans",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Guid = table.Column<Guid>(nullable: true),
                    DateCreated = table.Column<DateTime>(nullable: true),
                    LastUpdate = table.Column<DateTime>(nullable: true),
                    Timestamp = table.Column<byte[]>(nullable: true),
                    Deleted = table.Column<bool>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Bedrooms = table.Column<decimal>(nullable: false),
                    FullBathrooms = table.Column<decimal>(nullable: false),
                    HalfBathrooms = table.Column<decimal>(nullable: false),
                    SquareFeetLow = table.Column<decimal>(nullable: false),
                    SquareFeetHigh = table.Column<decimal>(nullable: false),
                    RentLow = table.Column<decimal>(nullable: false),
                    RentHigh = table.Column<decimal>(nullable: false),
                    DepositLow = table.Column<decimal>(nullable: false),
                    DepositHigh = table.Column<decimal>(nullable: false),
                    ApplicationFeeLow = table.Column<decimal>(nullable: false),
                    ApplicationFeeHigh = table.Column<decimal>(nullable: false),
                    LeaseTermLow = table.Column<decimal>(nullable: false),
                    LeaseTermHigh = table.Column<decimal>(nullable: false),
                    TotalUnits = table.Column<int>(nullable: false),
                    AvailableUnits = table.Column<int>(nullable: false),
                    AvailableDate = table.Column<DateTime>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    Url = table.Column<string>(nullable: true),
                    AvailabilityUrl = table.Column<string>(nullable: true),
                    UnitCount = table.Column<string>(nullable: true),
                    PropertiesGuid = table.Column<Guid>(nullable: false),
                    Photos = table.Column<string>(nullable: true),
                    Amenities = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FloorPlans", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FloorPlans");
        }
    }
}

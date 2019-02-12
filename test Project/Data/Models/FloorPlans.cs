using System;
using System.ComponentModel.DataAnnotations;

namespace test_Project.Data.Models
{
    public class FloorPlansModel : BaseEntity
    {
        public string Name { get; set; }
        public Decimal Bedrooms { get; set; }
        public Decimal FullBathrooms { get; set; }
        public Decimal HalfBathrooms { get; set; }
        public Decimal SquareFeetLow { get; set; }
        public Decimal SquareFeetHigh { get; set; }
        public Decimal RentLow { get; set; }
        public Decimal RentHigh { get; set; }
        public Decimal DepositLow { get; set; }
        public Decimal DepositHigh { get; set; }
        public Decimal ApplicationFeeLow { get; set; }
        public Decimal ApplicationFeeHigh { get; set; }
        public Decimal LeaseTermLow { get; set; }
        public Decimal LeaseTermHigh { get; set; }
        public int TotalUnits { get; set; }
        public int AvailableUnits { get; set; }
        public DateTime AvailableDate { get; set; }
        public string Description { get; set; }
        public string Url { get; set; }
        public string AvailabilityUrl { get; set; }
        public string UnitCount { get; set; }
        public Guid PropertiesGuid { get; set; }
        public string Photos { get; set; }
        public string Amenities { get; set; }
    }
}
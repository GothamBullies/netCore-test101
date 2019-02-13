using System;
using System.ComponentModel.DataAnnotations;

namespace netCore_test101.Data.Models
{
    public class PropertiesModel : BaseEntity
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public string Url { get; set; }
        public string Content { get; set; }
        public string Amenities { get; set; }
        public string Address_Line1 { get; set; }
        public string Address_Line2 { get; set; }
        public string Address_City { get; set; }
        public string Address_State { get; set; }
        public string Address_PostalCode { get; set; }
        public string Address_Country { get; set; }
        public Double Address_Latitude { get; set; }
        public Double Address_Longitude { get; set; }
        public string Phone_Number { get; set; }
        public string Phone_Extension { get; set; }
        public string Phone_Type { get; set; }
        public string Photo { get; set; }
        public string PropertyPhoto { get; set; }
        public string OfficeHours_Week_Open { get; set; }
        public string OfficeHours_Week_Close { get; set; }
        public string OfficeHours_Week_Status { get; set; }
        public string OfficeHours_Sat_Open { get; set; }
        public string OfficeHours_Sat_Close { get; set; }
        public string OfficeHours_Sat_Status { get; set; }
        public string OfficeHours_Sun_Open { get; set; }
        public string OfficeHours_Sun_Close { get; set; }
        public string OfficeHours_Sun_Status { get; set; }
        public string PetPolicy { get; set; }
        public bool IsFeatured { get; set; }
        public DateTime? Featured_SetDate { get; set; }
    }
}
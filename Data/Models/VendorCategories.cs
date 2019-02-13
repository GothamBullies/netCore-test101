using System;
using System.ComponentModel.DataAnnotations; 

namespace netCore_test101.Data.Models
{
    public class VendorCategoriesModel :BaseEntity
    {
        public int Parent  { get; set; }  
        [StringLength(75)]
        public string Description { get; set; }
    }
}
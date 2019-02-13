using System;
using System.ComponentModel.DataAnnotations; 

namespace netCore_test101.Data.Models
{
    public class VendorsModel : BaseEntity
    {
        public Guid? UserGuid { get; set; }

        [Display(Name = "Video")]
        public int? VideoID { get; set; } 

        [StringLength(50)]
        public string Company { get; set; } 

        [StringLength(50)]
        public string Contact { get; set; } 

        [StringLength(50)]
        public string Address { get; set; } 

        [StringLength(50)]
        public string Address2 { get; set; } 

        [StringLength(75)]
        public string City { get; set; } 

        [StringLength(2)]
        public string State { get; set; } 

        [Display(Name = "Zip Code")]
        [StringLength(5)]
        public string Zip { get; set; } 

        [StringLength(50)]
        public string Phone { get; set; } 

        [StringLength(150)]
        public string Email { get; set; } 

        [StringLength(300)]
        [Display(Name = "Website")]
        public string URL { get; set; } 
        
        public int? Category { get; set; } 

        public int? SubCategory1 { get; set; } 

        public int? SubCategory2 { get; set; } 

        public int? SubCategory3 { get; set; }  

        [StringLength(4000)]
        public string About { get; set; } 
        public bool IsFeatured { get; set; }

       public VendorCategoriesModel VendorCategories { get; set; }
    }
}
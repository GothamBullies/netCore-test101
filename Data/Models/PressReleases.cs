using System;
using System.ComponentModel.DataAnnotations; 

namespace netCore_test101.Data.Models
{
    public class PressReleasesModel : BaseEntity
    {
        public Guid? UserGuid { get; set; }
        
        [StringLength(150)]
        public string Title { get; set; }
        [StringLength(50)]
        public string Keywords { get; set; }
        [StringLength(50)]
        public string Company { get; set; }
        [StringLength(75)]
        public string City { get; set; }
        [StringLength(2)]
        public string State { get; set; }

        [Display(Name = "Zip Code")]
        [StringLength(5)]
        public string Zip { get; set; }
        [StringLength(50)]
        public string Phone { get; set; }
        [StringLength(50)]
        public string Address { get; set; }
        [StringLength(50)]
        public string Address2 { get; set; }

        [Display(Name = "Website")]
        [StringLength(300)]
        public string URL { get; set; }
        [StringLength(150)]
        public string Email { get; set; }

        [Display(Name = "Post")]
        public string Message { get; set; }
        public bool Active { get; set; }
        public bool IsFeatured { get; set; }
    }
}
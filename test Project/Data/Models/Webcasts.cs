using System;
using System.ComponentModel.DataAnnotations; 

namespace test_Project.Data.Models
{
    public class WebcastsModel : BaseEntity
    {
        public Guid? UserGuid { get; set; }
        
        [StringLength(150)]
        public string Title { get; set; }
        [StringLength(150)]
        public string Subtitle { get; set; }
        public string Body { get; set; }
        [StringLength(150)]
        public string Alert { get; set; }
        [StringLength(500)]
        public string Contributors { get; set; }
        [StringLength(150)]
        public string MediaFile { get; set; }
        public DateTime Date { get; set; }
        public string Image { get; set; }
        public bool IsFeatured { get; set; }
    }
}
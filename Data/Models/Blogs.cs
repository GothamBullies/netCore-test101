using System;
using System.ComponentModel.DataAnnotations;


namespace netCore_test101.Data.Models
{
    public class BlogsModel : BaseEntity
    {
        public Guid? UserGuid { get; set; }
        public bool Active { get; set; }
        [StringLength(50)]
        public string Keywords { get; set; }
        [StringLength(150)]
        public string Title { get; set; }
        [StringLength(50)]
        public string Image { get; set; }
        public int? VideoID { get; set; }
        public string Message { get; set; }
        public bool IsFeatured { get; set; }

        public VideosModel Video { get; set; } 
    }
}
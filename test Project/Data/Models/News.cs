using System;
using System.ComponentModel.DataAnnotations; 


namespace test_Project.Data.Models
{
    public class NewsModel : BaseEntity
    {
        public Guid? UserGuid { get; set; }
        
        [StringLength(150)]
        public string Title { get; set; }
        [StringLength(50)]
        public string Image { get; set; }

        [Display(Name = "Video URL")]
        public int? VideoID { get; set; }
        [StringLength(50)]
        public string Keywords { get; set; }
        [StringLength(100)]
        public string Source { get; set; }
        public string Article { get; set; }
        public bool IsFeatured { get; set; }

        public VideosModel Video { get; set; }
    }
}
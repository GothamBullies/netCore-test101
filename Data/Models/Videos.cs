using System;
using System.ComponentModel.DataAnnotations; 


namespace netCore_test101.Data.Models
{
    public class VideosModel : BaseEntity
    {
        public Guid? UserGuid { get; set; }
        
        [StringLength(50)]
        public string Title { get; set; }
        [StringLength(50)]
        public string Site { get; set; }
        [StringLength(50)]
        public string Code { get; set; }
        public int? Views { get; set; }
        [StringLength(500)]
        public string Description { get; set; }
        public bool Gallery { get; set; }
        public bool IsFeatured { get; set; }
    }
}
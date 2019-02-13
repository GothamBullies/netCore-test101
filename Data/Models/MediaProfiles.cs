using System;
using System.ComponentModel.DataAnnotations; 

namespace netCore_test101.Data.Models
{
    public class MediaProfilesModel : BaseEntity
    {
        public Guid? UserGuid { get; set; }
        
        [StringLength(50)]
        public string Alias { get; set; }
        [StringLength(50)]
        public string Image { get; set; }
        [StringLength(50)]
        public string Company { get; set; }
        public string Profile { get; set; }
        public string Links { get; set; }
        public bool IsFeatured { get; set; }
    }
}
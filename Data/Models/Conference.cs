
using System;
using System.ComponentModel.DataAnnotations; 

namespace netCore_test101.Data.Models
{
    public class ConferenceModel : BaseEntity
    {
        public Guid? UserGuid { get; set; }
        
        [StringLength(50)]
        public string Name  { get; set; }
        [StringLength(50)]
        public string Venue  { get; set; }
        [StringLength(75)]
        public string City  { get; set; }
        [StringLength(2)]
        public string State  { get; set; }
        public DateTime? StartDate  { get; set; }
        public DateTime? EndDate  { get; set; }
        [StringLength(300)]
        public string URL  { get; set; }
        [StringLength(50)]
        public string Image  { get; set; }
        public bool IsFeatured { get; set; }
    }
}
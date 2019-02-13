using System;
using System.ComponentModel.DataAnnotations; 

namespace netCore_test101.Data.Models
{
    public class ZipCodesModel : BaseEntity
    {
        [StringLength(5)] 
        public string ZipCode { get; set; }
        [StringLength(75)]
        public string City { get; set; }
        [StringLength(2)]
        public string State { get; set; }
    }
}
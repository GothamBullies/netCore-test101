using System;
using System.ComponentModel.DataAnnotations; 

namespace netCore_test101.Data.Models
{
    public class UsagePagesModel : BaseEntity
    {
        [StringLength(50)]
        public string Section { get; set; }
        [StringLength(50)]
        public string PageName { get; set; }
    }
}
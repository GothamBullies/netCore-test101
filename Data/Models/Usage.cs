using System;
using System.ComponentModel.DataAnnotations; 

namespace netCore_test101.Data.Models
{
    public class UsageModel : BaseEntity
    {
        public int? UsagePagesId { get; set; }
        public DateTime? Date { get; set; }
        public int? Count { get; set; }

        public UsagePagesModel UsagePages { get; set; }
    }
}
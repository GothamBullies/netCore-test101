using System;
using System.ComponentModel.DataAnnotations; 


namespace netCore_test101.Data.Models
{
    public class OldUser
    {
        public int Id  { get; set; }
        public int UserID  { get; set; }
        public Guid? UserGuid  { get; set; }
        [StringLength(50)]
        public string UserName { get; set; }
        [StringLength(50)]
        public string Password { get; set; }
        [StringLength(100)]
        public string Roles  { get; set; }
        [StringLength(150)]
        public string Email  { get; set; }
        [StringLength(100)]
        public string Name  { get; set; }
        [StringLength(100)] 
        public string Company  { get; set; }
        public DateTime? LastLogin  { get; set; } 
        public DateTime? RecentLogin  { get; set; } 
        [StringLength(50)]
        public string ConfirmCode  { get; set; }
        public DateTime? DateCreated  { get; set; } 
    }
}
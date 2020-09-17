using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LocalMealManagement.Models
{
    public class GroupMessage
    {
        [Key]
        public int Id { get; set; }
        public string Message { get; set; }
        public string UserId { get; set; }
        public DateTime CreateDate { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsUpdated { get; set; }
        public int GroupId { get; set; }
        public IdentityUser User { get; set; }
        public Groups Groups { get; set; } 
    }
}

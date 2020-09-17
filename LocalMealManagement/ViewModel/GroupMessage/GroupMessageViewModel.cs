using LocalMealManagement.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LocalMealManagement.ViewModel.GroupMessage
{
    public class GroupMessageViewModel
    {
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

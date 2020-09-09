using LocalMealManagement.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LocalMealManagement.Models
{
    public class Groups
    {
        [Key]
        public int GroupId { get; set; }
        [Required]
        [StringLength(256)]
        public string GroupName { get; set; }
    }

    public class CommonGroups
    {
        public CommonGroups()
        {
            Groups = new List<Groups>();
            groupViewModel = new GroupViewModel();
        }
        public List<Groups> Groups { get; set; }
        public GroupViewModel  groupViewModel { get; set; }
    }
}

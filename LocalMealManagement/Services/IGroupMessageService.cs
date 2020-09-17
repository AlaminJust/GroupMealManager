using LocalMealManagement.Models;
using LocalMealManagement.ViewModel.GroupMessage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LocalMealManagement.Services
{
    public interface IGroupMessageService
    {
        List<GroupMessageViewModel> GetGroupMessagesByGroupId(int groupId);
        GroupMessage AddGroupMessage(GroupMessage groupMessage);
        
    }
}

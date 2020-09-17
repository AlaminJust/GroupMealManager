using LocalMealManagement.Models;
using LocalMealManagement.ViewModel.GroupMessage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LocalMealManagement.Factories
{
    public interface IGroupMessageFactory 
    {
        GroupMessage PrepareGroupMessage(GroupMessageViewModel model, bool isUpdate, string userName);
    }
}

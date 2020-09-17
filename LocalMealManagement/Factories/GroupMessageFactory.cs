using LocalMealManagement.Models;
using LocalMealManagement.Services;
using LocalMealManagement.ViewModel.GroupMessage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LocalMealManagement.Factories
{
    public class GroupMessageFactory : IGroupMessageFactory
    {
        #region CTOR
        private readonly IManageGroupRepository _manageGroupRepository;
        private readonly IUserInformationService _userInformationService;

        public GroupMessageFactory
            (
                IManageGroupRepository manageGroupRepository,
                IUserInformationService userInformationService
            )
        {
            _manageGroupRepository = manageGroupRepository;
            _userInformationService = userInformationService;
        }
        #endregion

        #region Method
        public GroupMessage PrepareGroupMessage(GroupMessageViewModel model , bool isUpdate, string userName)
        {
            var groupMessage = new GroupMessage
            {
                IsDeleted = false,
                IsUpdated = isUpdate,
                Message = model.Message,
                CreateDate = DateTime.Now,
                GroupId = model.GroupId,
                Groups = _manageGroupRepository.GetGroupById(model.GroupId),
                User = _userInformationService.GetIdentityByUserName(userName),
                UserId = _userInformationService.GetIdentityByUserName(userName).Id
            };
            return groupMessage;
        }
        #endregion
    }
}

using LocalMealManagement.Models;
using LocalMealManagement.ViewModel.GroupMessage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LocalMealManagement.Services
{
    public class GroupMessageService : IGroupMessageService
    {
        #region CTOR
        private readonly AppDbContext _context;

        public GroupMessageService
            (
                AppDbContext context
            )
        {
            _context = context;
        }

        #endregion

        #region PrepareModel

        private List<GroupMessageViewModel> PrepareGroupMessageViewModel(List<GroupMessage> groupMessage)
        {
            var groupMessages = new List<GroupMessageViewModel>();

            foreach(var message in groupMessage)
            {
                var msg = new GroupMessageViewModel
                {
                    Id = message.Id,
                    Message = message.Message,
                    CreateDate = message.CreateDate,
                    IsDeleted = message.IsDeleted,
                    IsUpdated = message.IsUpdated,
                    GroupId = message.GroupId,
                    Groups = message.Groups,
                    User = message.User,
                    UserId = message.UserId
                };
                groupMessages.Add(msg);
            }
            return groupMessages;
        }

        #endregion

        public List<GroupMessageViewModel> GetGroupMessagesByGroupId(int groupId)
        {
            if (groupId <= 0)
                throw new NullReferenceException(nameof(groupId));

            var groupMessages = _context.GroupMessages.Where(x => x.GroupId == groupId && !x.IsDeleted).ToList();
            return PrepareGroupMessageViewModel(groupMessages);
        }

        public GroupMessage AddGroupMessage(GroupMessage groupMessage)
        {
            if (groupMessage == null)
                throw new NullReferenceException(nameof(groupMessage));

            _context.GroupMessages.Add(groupMessage);
            _context.SaveChanges();
            return groupMessage;
        }
    }
}

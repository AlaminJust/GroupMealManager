﻿using LocalMealManagement.Models;
using LocalMealManagement.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LocalMealManagement.Services
{
    public interface IGroupRepository
    {
        public Task<Boolean> CreateGroup(string groupName);
        public Task<Boolean> AddRoleOfGroupMember(string userName , string groupId , string roleName);
        public Task<Boolean> AssignUserInRole(string userName , string RoleName);
        public string GetGroupId(string groupName);
        public Task<List<Groups>> AllGroupOfUser(string UserName);
        public List<SubGroupViewModel> AllSubGroupsInAGroup(string groupId); 
        public Task<Boolean> save();
        public Boolean IsUserAlreadyInGroup(string groupId , string userName, bool checkRole = false);
    }
}

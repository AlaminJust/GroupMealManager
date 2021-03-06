﻿using LocalMealManagement.Models;
using LocalMealManagement.ViewModel;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LocalMealManagement.Services
{
    public class GroupRepository : IGroupRepository
    {
        private readonly AppDbContext context;
        private readonly UserManager<IdentityUser> userManager;
        private readonly SignInManager<IdentityUser> signInManager;
        private readonly RoleManager<IdentityRole> roleManager;

        public GroupRepository(AppDbContext Context , UserManager<IdentityUser> userManager,
            SignInManager<IdentityUser> signInManager,
            RoleManager<IdentityRole> roleManager
            )
        {
            context = Context;
            this.userManager = userManager;
            this.signInManager = signInManager;
            this.roleManager = roleManager;
        }

        public async Task<Boolean> AddRoleOfGroupMember(string userName, string groupId , string roleName)
        {
            var groups = context.groups.Where(x => x.GroupId.ToString() == groupId).FirstOrDefault();
            if (groups == null) return false; /// groups not create
            var users = await userManager.FindByNameAsync(userName);
            var role = await roleManager.FindByNameAsync(roleName);
            if (users == null || role == null) return false;  /// username is not exist
            UsersGroups usersGroups = new UsersGroups
            {
                Groups = groups,
                IdentityUser = users,
                IdentityRole = role
            };
            await context.usersGroups.AddAsync(usersGroups);  // add user and group in usergroup table
            await save();
            return true;
        }

        public async Task< List<Groups> > AllGroupOfUser(string UserName)
        {
            var user = await userManager.FindByNameAsync(UserName);
            var groups = (from u in context.usersGroups
                          join g in context.groups on u.Groups.GroupId equals g.GroupId
                          where (u.IdentityUser.Id == user.Id)
                          select new Groups
                          {
                              GroupId = g.GroupId,
                              GroupName = g.GroupName
                          }).ToList();
            return groups;
        }
        // Return All subgroup in a group
        public List<SubGroupViewModel> AllSubGroupsInAGroup(string groupId)
        {
            var subgroups = (from g in context.groups
                            join sg in context.subGroups on g.GroupId equals sg.Groups.GroupId
                            where(g.GroupId.ToString() == groupId)
                            select new SubGroupViewModel
                            {
                                SubGroupId = sg.Id,
                                SubGroupName = sg.SubGroupName,
                                SubGroupCreateDate = sg.CreateDate,
                                startDate = (DateTime)sg.StartDate,
                                EndDate = (DateTime)sg.EndDate
                            }).ToList();
            return subgroups;
        }

        public async Task<Boolean> AssignUserInRole(string userName, string RoleName)
        {
            var user = await userManager.FindByNameAsync(userName);
            if (user == null) return false; // User Is not exist
            await userManager.AddToRoleAsync(user, RoleName);  // User Is assign in his given role
            await save();
            return true;
        }

        public async Task<Boolean> CreateGroup(string groupName)
        {
            var groups = context.groups.Where(x => x.GroupName == groupName).FirstOrDefault();
            if (groups != null) return false; // Group name already exist
            Groups group = new Groups
            {
                GroupName = groupName
            };
            await context.groups.AddAsync(group);
            await save();
            return true;
        }

        public string GetGroupId(string groupName)
        {
            var group = context.groups.Where(x => x.GroupName == groupName).FirstOrDefault();
            if (group == null) return "Invalid";
            else return group.GroupId.ToString();
        }

        public bool IsUserAlreadyInGroup(string groupId, string userName, bool checkRole)
        {
            var group = context.usersGroups.Where(x => x.Groups.GroupId.ToString() == groupId && x.IdentityUser.UserName == userName).ToList();
            
            if (group.Count == 0)
                return false;

            if (checkRole)
            {
                var roleGroup = context.usersGroups.Where(x => x.Groups.GroupId.ToString() == groupId && x.IdentityUser.UserName == userName && x.IdentityRole.Name == "SuperAdmin").ToList();

                if (roleGroup.Count == 0)
                    return false;
                else return true;
            }
            return true;
        }

        public async Task<Boolean> save()
        {
            await context.SaveChangesAsync();
            return true;
        }
    }
}

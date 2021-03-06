﻿using LocalMealManagement.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LocalMealManagement.Secuirity
{
    public class IsGroupSuper : AuthorizationHandler<ManageGroupSuperAdminClaims>
    {
        private readonly AppDbContext appDbContext;
        private readonly IHttpContextAccessor _httpContextAccessor;
        public IsGroupSuper(IHttpContextAccessor httpContextAccessor, AppDbContext appDbContext)
        {
             
            this._httpContextAccessor = httpContextAccessor;
            this.appDbContext = appDbContext;
        }

        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, ManageGroupSuperAdminClaims requirement)
        {
            var authFilterContext = _httpContextAccessor.HttpContext.Request;
            if (authFilterContext == null)
            {
                return Task.CompletedTask;
            }
            string ID = authFilterContext.Query["groupId"].ToString();
            var currentUser = _httpContextAccessor.HttpContext.User.Identity.Name;

            var res = appDbContext.usersGroups.Where(x => x.Groups.GroupId.ToString() == ID && x.IdentityUser.UserName == currentUser && (x.IdentityRole.Name == "SuperAdmin")).FirstOrDefault();
            if (currentUser == null || res == null)
            {
                return Task.CompletedTask;
            }
            else
            {
                context.Succeed(requirement);
            }
            return Task.CompletedTask;
        }
    }
}

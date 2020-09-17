using LocalMealManagement.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LocalMealManagement.Services
{
    public class UserInformationService : IUserInformationService
    {
        private readonly UserManager<IdentityUser> userManager;
        private readonly AppDbContext appDbContext;

        public UserInformationService
            (UserManager<IdentityUser> userManager,
            AppDbContext appDbContext
            )
        {
            this.userManager = userManager;
            this.appDbContext = appDbContext;
        }

        #region Utilities Method

        public IdentityUser GetIdentityByUserName(string UserName)
        {
            var user = userManager.Users.Where(x => x.UserName == UserName).FirstOrDefault();
            return user;
        }

        #endregion

        public CustomerInfo GetCustomerInfoByCustomerName(string userName)
        {
            var user = GetIdentityByUserName(userName);
            var customerInfo = appDbContext.CustomerInfos.Where(x => x.UserId == user.Id).FirstOrDefault();
            return customerInfo;
        }

        public IdentityUser GetUserById(string userId)
        {
            if (userId == null)
                throw new NullReferenceException(nameof(userId));

            var user = userManager.Users.Where(x => x.Id == userId).FirstOrDefault();
            return user;
        }
    }
}

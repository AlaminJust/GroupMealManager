using LocalMealManagement.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LocalMealManagement.Services
{
    public interface IUserInformationService
    {
        public CustomerInfo GetCustomerInfoByCustomerName(string userName);
        public IdentityUser GetIdentityByUserName(string UserName);
    }
}

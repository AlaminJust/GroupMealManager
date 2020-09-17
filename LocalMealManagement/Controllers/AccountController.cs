using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LocalMealManagement.Models;
using LocalMealManagement.Services;
using LocalMealManagement.ViewModel;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace LocalMealManagement.Controllers
{
    public class AccountController : Controller
    {
        private readonly IAccountRepository accountRepository;
        private readonly AppDbContext context;
        private readonly UserManager<IdentityUser> userManager;
        private readonly IUserInformationService userInformationService;

        public AccountController
            (
            IAccountRepository accountRepository,
            AppDbContext context,
            UserManager<IdentityUser> userManager,
            IUserInformationService userInformationService
            )
        {
            this.accountRepository = accountRepository;
            this.context = context;
            this.userManager = userManager;
            this.userInformationService = userInformationService;
        }

        public IAccountRepository AccountRepository { get; }

        [HttpPost]
        public async Task<IActionResult> AddBalance(AccountViewModel model)
        {
            if (ModelState.IsValid)
            {
                string AddedBy = User.Identity.Name;
                if (await accountRepository.AddBalance(model, AddedBy))
                {
                    return Json( model );
                }
            }
            ModelState.AddModelError("", "Something Going Wrong");
            return View(model);
        }
        public IActionResult ProfileInfo()
        {
            var customerInfo = userInformationService.GetCustomerInfoByCustomerName(User.Identity.Name);
            if (customerInfo == null)
                customerInfo = new CustomerInfo();

            var model = new CustomerViewModel
            {
                FirstName = customerInfo.FirstName,
                LastName = customerInfo.LastName,
                StreatAddress1 = customerInfo.StreatAddress1,
                StreatAddress2 = customerInfo.StreatAddress2,
                City = customerInfo.City,
                State = customerInfo.State,
                Zip = customerInfo.Zip,
                PhoneNumber = customerInfo.PhoneNumber,
                Email = customerInfo.Email,
                HowYouKnowAboutUs = customerInfo.HowYouKnowAboutUs,
                FeedBack = customerInfo.FeedBack,
                SuggestionsToImprove = customerInfo.SuggestionsToImprove,
                WillYOuRecomand = customerInfo.WillYOuRecomand,
                UserId = customerInfo.UserId,
                Id = customerInfo.Id
            };
            return View(model);
        }
        [HttpPost]
        public IActionResult ProfileInfo(CustomerViewModel model)
        {
            if (ModelState.IsValid)
            {
                var userName = User.Identity.Name;
                var user = userManager.Users.Where(x => x.UserName == userName).FirstOrDefault();
                var customerInfo = new CustomerInfo
                {
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    StreatAddress1 = model.StreatAddress1,
                    StreatAddress2 = model.StreatAddress2,
                    City = model.City,
                    State = model.State,
                    Zip = model.Zip,
                    PhoneNumber = model.PhoneNumber,
                    Email = model.Email,
                    HowYouKnowAboutUs = model.HowYouKnowAboutUs,
                    FeedBack = model.FeedBack,
                    SuggestionsToImprove = model.SuggestionsToImprove,
                    WillYOuRecomand = model.WillYOuRecomand,
                    UserId = user?.Id
                };
                context.CustomerInfos.Add(customerInfo);
            }
            return View(model);
        }
    }
}
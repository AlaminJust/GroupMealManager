using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LocalMealManagement.Models;
using LocalMealManagement.Services;
using LocalMealManagement.ViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace LocalMealManagement.Controllers
{
    public class ManageGroupController : Controller
    {
        private readonly IManageGroupRepository manageGroupRepository;
        private readonly ISubGroupRepository subGroupRepository;
        private readonly UserManager<IdentityUser> userManager;

        public ManageGroupController(
            IManageGroupRepository manageGroupRepository ,
            ISubGroupRepository subGroupRepository ,
            UserManager<IdentityUser> userManager
            )
        {
            this.manageGroupRepository = manageGroupRepository;
            this.subGroupRepository = subGroupRepository;
            this.userManager = userManager;
        }
        [HttpGet]
        [Authorize(Policy = "SuparAdminOrMember")]
        public IActionResult AddMemberInGroup(string groupId)
        {
            ViewBag.groupId = groupId;
            return View();
        }
        [HttpPost]
        [Authorize(Policy = "SuparAdminOrMember")]
        public async Task<IActionResult> AddMemberInGroup(string groupId , UserNameViewModel model)
        {
            ViewBag.groupId = groupId;
            if (ModelState.IsValid)
            {
                var result = await manageGroupRepository.AddMemberInGroup(groupId, model.UserName);
                if(result == "Memeber Added")
                {
                    return RedirectToAction("AllGroups", "GroupAdministration");
                }
                else
                {
                    ModelState.AddModelError("", result);
                }
            }
            return View(model);
        }
        [HttpGet]
        [Authorize(Policy = "SuparAdminOrMember")]
        public IActionResult MembersInGroup(string groupId, string subGroupId="NULL")
        {
            ViewBag.groupId = groupId;
            ViewBag.subGroupId = subGroupId;
            var users = manageGroupRepository.UsersInGroup(groupId,subGroupId);
            return View(users);
        }
        [HttpGet]
        [Authorize(Policy = "SuparAdminOrMember")]
        public async Task<IActionResult> KickOutUserFromGroup(string userId , int? groupId)
        {
            if(userId == null || groupId == null)
            {
                return BadRequest();
            }
            if (await manageGroupRepository.KickOutUser(userId, groupId))
            {
                return RedirectToAction("MembersInGroup" , new { groupId = groupId});
            }
            return BadRequest();
        }
        [HttpGet]
        public IActionResult CostList(string groupId , string subGroupId)
        {
            var costList = subGroupRepository.CostList(subGroupId);
            return View(costList); 
        }
        [HttpGet]
        public IActionResult AllCalculation(string groupId , string subGroupId)
        {
            var allCalculation = subGroupRepository.allCalculations(subGroupId);
            return View(allCalculation);
        }
        [HttpPost]
        public JsonResult AllUsersName(string Prefix)
        {
            var userNameList = userManager.Users.Where(x=>x.UserName.StartsWith(Prefix)).Select(x => x.UserName).ToList();
            return Json(userNameList);
        }
    }
}
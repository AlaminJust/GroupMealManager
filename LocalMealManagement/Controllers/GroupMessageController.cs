using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using LocalMealManagement.Factories;
using LocalMealManagement.Migrations;
using LocalMealManagement.Models;
using LocalMealManagement.Services;
using LocalMealManagement.ViewModel.GroupMessage;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LocalMealManagement.Controllers
{
    public class GroupMessageController : Controller
    {
        private readonly IGroupMessageService _groupMessageService;
        private readonly IGroupMessageFactory _groupMessageFactory;


        #region CTOR

        public GroupMessageController
            (
                IGroupMessageService groupMessageService,
                IGroupMessageFactory groupMessageFactory
            )
        {
            _groupMessageService = groupMessageService;
            _groupMessageFactory = groupMessageFactory;
        }

        #endregion


        #region Utilities Method

        #endregion
        [HttpGet]
        [Authorize(Policy = "SuparAdminOrMember")]
        public IActionResult GroupChat(int groupId)
        {
            var allMessage = _groupMessageService.GetGroupMessagesByGroupId(groupId);
            ViewBag.GroupId = groupId;
            return View(allMessage); 
        }

        [HttpPost]
        [Authorize(Policy = "SuparAdminOrMember")]
        public JsonResult AddMessage(int groupId , GroupMessageViewModel model)
        {
            ViewBag.groupId = model.GroupId;
            var groupMessage = _groupMessageFactory.PrepareGroupMessage(model, false, User.Identity.Name);
            if (groupMessage == null)
                return Json(new { message = "bad request" });
            _groupMessageService.AddGroupMessage(groupMessage);
            return Json(new { groupId = model.GroupId});
        }
    }
}
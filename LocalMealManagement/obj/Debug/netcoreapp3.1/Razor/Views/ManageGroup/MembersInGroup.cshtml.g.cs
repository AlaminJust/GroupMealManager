#pragma checksum "D:\Manager-master\LocalMealManagement\Views\ManageGroup\MembersInGroup.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0a3c093706a064580ba8afa497cced0a9cc06bb2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ManageGroup_MembersInGroup), @"mvc.1.0.view", @"/Views/ManageGroup/MembersInGroup.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "D:\Manager-master\LocalMealManagement\Views\_ViewImports.cshtml"
using LocalMealManagement;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Manager-master\LocalMealManagement\Views\_ViewImports.cshtml"
using LocalMealManagement.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Manager-master\LocalMealManagement\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Manager-master\LocalMealManagement\Views\ManageGroup\MembersInGroup.cshtml"
using LocalMealManagement.Services;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0a3c093706a064580ba8afa497cced0a9cc06bb2", @"/Views/ManageGroup/MembersInGroup.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"81e2c03bedf592383936a8a10f3095d85336899f", @"/Views/_ViewImports.cshtml")]
    public class Views_ManageGroup_MembersInGroup : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<LocalMealManagement.ViewModel.UserViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/balanceAdd.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 5 "D:\Manager-master\LocalMealManagement\Views\ManageGroup\MembersInGroup.cshtml"
   
    var currentUserName = User.Identity.Name;
    var isGroupSuperAdminCurrentUser = groupRepository.IsUserAlreadyInGroup(ViewBag.groupId, currentUserName, true);

#line default
#line hidden
#nullable disable
            WriteLiteral("<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0a3c093706a064580ba8afa497cced0a9cc06bb24561", async() => {
                WriteLiteral("\r\n    <title>MembersInGroup</title>\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0a3c093706a064580ba8afa497cced0a9cc06bb24860", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0a3c093706a064580ba8afa497cced0a9cc06bb26663", async() => {
                WriteLiteral(@"
    <table class=""table table-bordered table-striped"">
        <thead>
            <tr>
                <th>
                    Username
                </th>
                <th>
                    Action
                </th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 27 "D:\Manager-master\LocalMealManagement\Views\ManageGroup\MembersInGroup.cshtml"
              
                string groupId = @ViewBag.groupId;
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "D:\Manager-master\LocalMealManagement\Views\ManageGroup\MembersInGroup.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
#nullable restore
#line 34 "D:\Manager-master\LocalMealManagement\Views\ManageGroup\MembersInGroup.cshtml"
                   Write(Html.DisplayFor(modelItem => item.UserName));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n");
#nullable restore
#line 37 "D:\Manager-master\LocalMealManagement\Views\ManageGroup\MembersInGroup.cshtml"
                         if (item.subGroupId != "NULL")
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <div class=\"row\">\r\n                                <div class=\"col-md-5\">\r\n                                    <input class=\"form-control\"");
                BeginWriteAttribute("id", " id=", 1282, "", 1300, 1);
#nullable restore
#line 41 "D:\Manager-master\LocalMealManagement\Views\ManageGroup\MembersInGroup.cshtml"
WriteAttributeValue("", 1286, item.UserName, 1286, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" placeholder=\"Enter Balance\" onkeyup=\"pulsar(this)\" />\r\n                                </div>\r\n                                <div class=\"col-md-5\">\r\n                                    <button class=\"btn btn-primary\"");
                BeginWriteAttribute("onclick", " onclick=\"", 1519, "\"", 1604, 12);
                WriteAttributeValue("", 1529, "saveBalance(", 1529, 12, true);
                WriteAttributeValue(" ", 1541, "\'$", 1542, 3, true);
#nullable restore
#line 44 "D:\Manager-master\LocalMealManagement\Views\ManageGroup\MembersInGroup.cshtml"
WriteAttributeValue("", 1544, item.UserName, 1544, 14, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 1558, "\'", 1558, 1, true);
                WriteAttributeValue(" ", 1559, ",", 1560, 2, true);
                WriteAttributeValue(" ", 1561, "\'$", 1562, 3, true);
#nullable restore
#line 44 "D:\Manager-master\LocalMealManagement\Views\ManageGroup\MembersInGroup.cshtml"
WriteAttributeValue("", 1564, item.subGroupId, 1564, 16, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 1580, "\',", 1580, 2, true);
                WriteAttributeValue(" ", 1582, "\'$", 1583, 3, true);
#nullable restore
#line 44 "D:\Manager-master\LocalMealManagement\Views\ManageGroup\MembersInGroup.cshtml"
WriteAttributeValue("", 1585, ViewBag.groupId, 1585, 16, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 1601, "\'", 1601, 1, true);
                WriteAttributeValue(" ", 1602, ")", 1603, 2, true);
                EndWriteAttribute();
                WriteLiteral("> Submit </button>\r\n                                </div>\r\n                            </div>\r\n");
#nullable restore
#line 47 "D:\Manager-master\LocalMealManagement\Views\ManageGroup\MembersInGroup.cshtml"
                        }
                        else
                        {
                            var isGroupSuperAdmin = groupRepository.IsUserAlreadyInGroup(ViewBag.groupId, item.UserName, true);
                            
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 52 "D:\Manager-master\LocalMealManagement\Views\ManageGroup\MembersInGroup.cshtml"
                             if (isGroupSuperAdminCurrentUser)
                            {
                                if (isGroupSuperAdmin)
                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    <a");
                BeginWriteAttribute("href", " href=\"", 2168, "\"", 2253, 4);
                WriteAttributeValue("", 2175, "/ManageGroup/KickOutUserFromGroup?userId=", 2175, 41, true);
#nullable restore
#line 56 "D:\Manager-master\LocalMealManagement\Views\ManageGroup\MembersInGroup.cshtml"
WriteAttributeValue("", 2216, item.UserId, 2216, 12, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 2228, "&groupId=", 2228, 9, true);
#nullable restore
#line 56 "D:\Manager-master\LocalMealManagement\Views\ManageGroup\MembersInGroup.cshtml"
WriteAttributeValue("", 2237, ViewBag.groupId, 2237, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"not-allowed\" onclick=\"return false;\">Kick out</a>\r\n");
#nullable restore
#line 57 "D:\Manager-master\LocalMealManagement\Views\ManageGroup\MembersInGroup.cshtml"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    <a");
                BeginWriteAttribute("href", " href=\"", 2459, "\"", 2544, 4);
                WriteAttributeValue("", 2466, "/ManageGroup/KickOutUserFromGroup?userId=", 2466, 41, true);
#nullable restore
#line 60 "D:\Manager-master\LocalMealManagement\Views\ManageGroup\MembersInGroup.cshtml"
WriteAttributeValue("", 2507, item.UserId, 2507, 12, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 2519, "&groupId=", 2519, 9, true);
#nullable restore
#line 60 "D:\Manager-master\LocalMealManagement\Views\ManageGroup\MembersInGroup.cshtml"
WriteAttributeValue("", 2528, ViewBag.groupId, 2528, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" onclick=\"return confirm(\'Are you sure you want to kick out!\')\">Kick out</a>\r\n");
#nullable restore
#line 61 "D:\Manager-master\LocalMealManagement\Views\ManageGroup\MembersInGroup.cshtml"
                                }
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 64 "D:\Manager-master\LocalMealManagement\Views\ManageGroup\MembersInGroup.cshtml"
                             if (User.Identity.Name == item.UserName)
                            {
                                if (isGroupSuperAdmin)
                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    <a");
                BeginWriteAttribute("href", " href=\"", 2922, "\"", 3007, 4);
                WriteAttributeValue("", 2929, "/ManageGroup/KickOutUserFromGroup?userId=", 2929, 41, true);
#nullable restore
#line 68 "D:\Manager-master\LocalMealManagement\Views\ManageGroup\MembersInGroup.cshtml"
WriteAttributeValue("", 2970, item.UserId, 2970, 12, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 2982, "&groupId=", 2982, 9, true);
#nullable restore
#line 68 "D:\Manager-master\LocalMealManagement\Views\ManageGroup\MembersInGroup.cshtml"
WriteAttributeValue("", 2991, ViewBag.groupId, 2991, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"not-allowed\" onclick=\"return false;\">Leave</a>\r\n");
#nullable restore
#line 69 "D:\Manager-master\LocalMealManagement\Views\ManageGroup\MembersInGroup.cshtml"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    <a");
                BeginWriteAttribute("href", " href=\"", 3210, "\"", 3295, 4);
                WriteAttributeValue("", 3217, "/ManageGroup/KickOutUserFromGroup?userId=", 3217, 41, true);
#nullable restore
#line 72 "D:\Manager-master\LocalMealManagement\Views\ManageGroup\MembersInGroup.cshtml"
WriteAttributeValue("", 3258, item.UserId, 3258, 12, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 3270, "&groupId=", 3270, 9, true);
#nullable restore
#line 72 "D:\Manager-master\LocalMealManagement\Views\ManageGroup\MembersInGroup.cshtml"
WriteAttributeValue("", 3279, ViewBag.groupId, 3279, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" onclick=\"return confirm(\'Are you sure you want to Leave!\')\">Leave</a>\r\n");
#nullable restore
#line 73 "D:\Manager-master\LocalMealManagement\Views\ManageGroup\MembersInGroup.cshtml"
                                }
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 74 "D:\Manager-master\LocalMealManagement\Views\ManageGroup\MembersInGroup.cshtml"
                             
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 78 "D:\Manager-master\LocalMealManagement\Views\ManageGroup\MembersInGroup.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </tbody>\r\n    </table>\r\n\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IGroupRepository groupRepository { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<LocalMealManagement.ViewModel.UserViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591

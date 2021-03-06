#pragma checksum "D:\Manager-master\LocalMealManagement\Views\GroupAdministration\SubGroupsAllUsersMeals.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "57f52f1dc87f4f720586f92f92a5d1e143cac0ec"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_GroupAdministration_SubGroupsAllUsersMeals), @"mvc.1.0.view", @"/Views/GroupAdministration/SubGroupsAllUsersMeals.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"57f52f1dc87f4f720586f92f92a5d1e143cac0ec", @"/Views/GroupAdministration/SubGroupsAllUsersMeals.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"81e2c03bedf592383936a8a10f3095d85336899f", @"/Views/_ViewImports.cshtml")]
    public class Views_GroupAdministration_SubGroupsAllUsersMeals : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<LocalMealManagement.ViewModel.MealModelWithUserNameView>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "D:\Manager-master\LocalMealManagement\Views\GroupAdministration\SubGroupsAllUsersMeals.cshtml"
  
    double Dinnar = 0, Lunch = 0, Morning = 0;
    ViewData["Title"] = "SubGroupsAllUsersMeals";
    var groupByUsername = from s in Model
                          group s by s.IdentityUser.UserName
                          into g
                          select new
                          {
                              UserName = g.Key,
                              Dinnar = g.Sum(x => x.Dinnar),
                              Lunch = g.Sum(x => x.Lunch),
                              Morning = g.Sum(x => x.Morning)
                          };

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<table class=\"table table-striped table-bordered\">\n    <thead>\n        <tr>\n            <th>Username</th>\n            <th>Morning</th>\n            <th>Dinnar</th>\n            <th>Lunch</th>\n        </tr>\n    </thead>\n    <tbody>\n\n");
#nullable restore
#line 29 "D:\Manager-master\LocalMealManagement\Views\GroupAdministration\SubGroupsAllUsersMeals.cshtml"
         foreach (var meal in groupByUsername)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\n                <td>");
#nullable restore
#line 32 "D:\Manager-master\LocalMealManagement\Views\GroupAdministration\SubGroupsAllUsersMeals.cshtml"
               Write(meal.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>");
#nullable restore
#line 33 "D:\Manager-master\LocalMealManagement\Views\GroupAdministration\SubGroupsAllUsersMeals.cshtml"
               Write(meal.Morning);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>");
#nullable restore
#line 34 "D:\Manager-master\LocalMealManagement\Views\GroupAdministration\SubGroupsAllUsersMeals.cshtml"
               Write(meal.Dinnar);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>");
#nullable restore
#line 35 "D:\Manager-master\LocalMealManagement\Views\GroupAdministration\SubGroupsAllUsersMeals.cshtml"
               Write(meal.Lunch);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            </tr>\n");
#nullable restore
#line 37 "D:\Manager-master\LocalMealManagement\Views\GroupAdministration\SubGroupsAllUsersMeals.cshtml"
            Dinnar += (double)meal.Dinnar;
            Lunch += (double)meal.Lunch;
            Morning += (double)meal.Morning;
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\n    <tfoot>\n        <tr>\n            <th>Username</th>\n            <th>");
#nullable restore
#line 45 "D:\Manager-master\LocalMealManagement\Views\GroupAdministration\SubGroupsAllUsersMeals.cshtml"
           Write(Morning);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n            <th>");
#nullable restore
#line 46 "D:\Manager-master\LocalMealManagement\Views\GroupAdministration\SubGroupsAllUsersMeals.cshtml"
           Write(Dinnar);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n            <th>");
#nullable restore
#line 47 "D:\Manager-master\LocalMealManagement\Views\GroupAdministration\SubGroupsAllUsersMeals.cshtml"
           Write(Lunch);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n        </tr>\n    </tfoot>\n</table>\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<LocalMealManagement.ViewModel.MealModelWithUserNameView>> Html { get; private set; }
    }
}
#pragma warning restore 1591

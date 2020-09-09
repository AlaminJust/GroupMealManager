#pragma checksum "D:\Manager-master\LocalMealManagement\Views\GroupAdministration\AllUsersMonthlyMeals.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1d5cf7a6b50d201560fe117eb67a51eded1fa6e9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_GroupAdministration_AllUsersMonthlyMeals), @"mvc.1.0.view", @"/Views/GroupAdministration/AllUsersMonthlyMeals.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1d5cf7a6b50d201560fe117eb67a51eded1fa6e9", @"/Views/GroupAdministration/AllUsersMonthlyMeals.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"81e2c03bedf592383936a8a10f3095d85336899f", @"/Views/_ViewImports.cshtml")]
    public class Views_GroupAdministration_AllUsersMonthlyMeals : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<LocalMealManagement.ViewModel.MealModelWithUserNameView>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "D:\Manager-master\LocalMealManagement\Views\GroupAdministration\AllUsersMonthlyMeals.cshtml"
  
    double Dinnar = 0, Lunch = 0, Morning = 0;
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
            WriteLiteral("\n<table class=\"table table-bordered table-striped\">\n    <thead>\n        <tr>\n            <th>Username</th>\n            <th>Morning</th>\n            <th>Dinnar</th>\n            <th>Lunch</th>\n        </tr>\n    </thead>\n    <tbody>\n\n");
#nullable restore
#line 28 "D:\Manager-master\LocalMealManagement\Views\GroupAdministration\AllUsersMonthlyMeals.cshtml"
         foreach (var meal in groupByUsername)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\n                <td>");
#nullable restore
#line 31 "D:\Manager-master\LocalMealManagement\Views\GroupAdministration\AllUsersMonthlyMeals.cshtml"
               Write(meal.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>");
#nullable restore
#line 32 "D:\Manager-master\LocalMealManagement\Views\GroupAdministration\AllUsersMonthlyMeals.cshtml"
               Write(meal.Morning);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>");
#nullable restore
#line 33 "D:\Manager-master\LocalMealManagement\Views\GroupAdministration\AllUsersMonthlyMeals.cshtml"
               Write(meal.Dinnar);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>");
#nullable restore
#line 34 "D:\Manager-master\LocalMealManagement\Views\GroupAdministration\AllUsersMonthlyMeals.cshtml"
               Write(meal.Lunch);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            </tr>\n");
#nullable restore
#line 36 "D:\Manager-master\LocalMealManagement\Views\GroupAdministration\AllUsersMonthlyMeals.cshtml"
            Dinnar += (double)meal.Dinnar;
            Lunch += (double)meal.Lunch;
            Morning += (double)meal.Morning;
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\n    <tfoot>\n        <tr>\n            <th>Username</th>\n            <th>");
#nullable restore
#line 44 "D:\Manager-master\LocalMealManagement\Views\GroupAdministration\AllUsersMonthlyMeals.cshtml"
           Write(Morning);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n            <th>");
#nullable restore
#line 45 "D:\Manager-master\LocalMealManagement\Views\GroupAdministration\AllUsersMonthlyMeals.cshtml"
           Write(Dinnar);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n            <th>");
#nullable restore
#line 46 "D:\Manager-master\LocalMealManagement\Views\GroupAdministration\AllUsersMonthlyMeals.cshtml"
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

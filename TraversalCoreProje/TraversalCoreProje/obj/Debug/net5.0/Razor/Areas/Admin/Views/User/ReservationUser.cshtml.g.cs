#pragma checksum "C:\Users\Pc\source\repos\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\User\ReservationUser.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6125dd3454ef1b52b631a6dc8f3006ede86aa1dc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_User_ReservationUser), @"mvc.1.0.view", @"/Areas/Admin/Views/User/ReservationUser.cshtml")]
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
#line 1 "C:\Users\Pc\source\repos\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\_ViewImports.cshtml"
using TraversalCoreProje;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Pc\source\repos\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\_ViewImports.cshtml"
using TraversalCoreProje.Areas.Member.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Pc\source\repos\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\User\ReservationUser.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6125dd3454ef1b52b631a6dc8f3006ede86aa1dc", @"/Areas/Admin/Views/User/ReservationUser.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"32ec19881daa9c406a3e822741c8d3bb751aacdf", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_User_ReservationUser : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Reservation>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Pc\source\repos\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\User\ReservationUser.cshtml"
  
    ViewData["Title"] = "ReservationUser";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";
    int count = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Kullanıcının Geçmiş Rezervasyonları </h1>

<table class=""table table-bordered"">
    <tr>
        <th>#</th>
        <th>Misafir Ad Soyad</th>
        <th>Rota</th>
        <th>Kişi Sayısı</th>
        <th>Tarih</th>
        <th>Detaylar</th>
    </tr>
");
#nullable restore
#line 20 "C:\Users\Pc\source\repos\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\User\ReservationUser.cshtml"
     foreach (var item in Model)
    {
        {count += 1;}

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\n            <td>");
#nullable restore
#line 24 "C:\Users\Pc\source\repos\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\User\ReservationUser.cshtml"
           Write(count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td>*</td>\n            <td>");
#nullable restore
#line 26 "C:\Users\Pc\source\repos\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\User\ReservationUser.cshtml"
           Write(item.Destination.City);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td>");
#nullable restore
#line 27 "C:\Users\Pc\source\repos\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\User\ReservationUser.cshtml"
           Write(item.PersonCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td>");
#nullable restore
#line 28 "C:\Users\Pc\source\repos\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\User\ReservationUser.cshtml"
           Write(item.RezervastionDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td><a href=\"#\" class=\"btn btn-outline-primary\">Detaylar</a></td>\n        </tr>\n");
#nullable restore
#line 31 "C:\Users\Pc\source\repos\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\User\ReservationUser.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Reservation>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
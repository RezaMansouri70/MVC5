﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASP
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Optimization;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    
    #line 1 "..\..\Views\Shared\_Noty.cshtml"
    using Common.Controller.NotyHelper;
    
    #line default
    #line hidden
    using ViewModel;
    using Web;
    
    #line 2 "..\..\Views\Shared\_Noty.cshtml"
    using Web.RazorHelpers;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Shared/_Noty.cshtml")]
    public partial class _Views_Shared__Noty_cshtml : System.Web.Mvc.WebViewPage<dynamic>
    {
        public _Views_Shared__Noty_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 3 "..\..\Views\Shared\_Noty.cshtml"
 if (TempData.ContainsKey(Noty.TempDataKey))
{
    var noty = TempData[Noty.TempDataKey] as Noty;
    
            
            #line default
            #line hidden
            
            #line 6 "..\..\Views\Shared\_Noty.cshtml"
Write(NotyBuilder.ShowNotyMessages(noty));

            
            #line default
            #line hidden
            
            #line 6 "..\..\Views\Shared\_Noty.cshtml"
                                       ;
}

            
            #line default
            #line hidden
WriteLiteral("\r\n");

        }
    }
}
#pragma warning restore 1591

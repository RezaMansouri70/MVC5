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

namespace Web.RazorHelpers
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    
    #line 2 "..\..\RazorHelpers\CheckBoxListBuilder.cshtml"
    using System.Web.Mvc;
    
    #line default
    #line hidden
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    public static class CheckBoxListBuilder
    {

public static System.Web.WebPages.HelperResult CheckBoxList(string name, List<SelectListItem> items)
{
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {



#line 5 "..\..\RazorHelpers\CheckBoxListBuilder.cshtml"
 

#line default
#line hidden

WebViewPage.WriteLiteralTo(@__razor_helper_writer, "    <div class=\"row\">\r\n");



#line 7 "..\..\RazorHelpers\CheckBoxListBuilder.cshtml"
         foreach (var item in items)
        {

#line default
#line hidden

WebViewPage.WriteLiteralTo(@__razor_helper_writer, "            ");



#line 9 "..\..\RazorHelpers\CheckBoxListBuilder.cshtml"
                  WebViewPage.WriteLiteralTo(@__razor_helper_writer, "\r\n                <div class=\"col-md-4\">\r\n                    <input type=\"checkb" +
"ox\" ");

#line default
#line hidden


#line 11 "..\..\RazorHelpers\CheckBoxListBuilder.cshtml"
                                            if (item.Selected) {
#line default
#line hidden

WebViewPage.WriteLiteralTo(@__razor_helper_writer, " ");

WebViewPage.WriteLiteralTo(@__razor_helper_writer, " checked=\"checked\" ");

WebViewPage.WriteLiteralTo(@__razor_helper_writer, "  ");



#line 11 "..\..\RazorHelpers\CheckBoxListBuilder.cshtml"
                                                                                                   }

#line default
#line hidden

WebViewPage.WriteLiteralTo(@__razor_helper_writer, "                           id=\"");



#line 12 "..\..\RazorHelpers\CheckBoxListBuilder.cshtml"
WebViewPage.WriteTo(@__razor_helper_writer, item.Value);

#line default
#line hidden

WebViewPage.WriteLiteralTo(@__razor_helper_writer, "\" name=\"");



#line 12 "..\..\RazorHelpers\CheckBoxListBuilder.cshtml"
       WebViewPage.WriteTo(@__razor_helper_writer, name);

#line default
#line hidden

WebViewPage.WriteLiteralTo(@__razor_helper_writer, "\" value=\"");



#line 12 "..\..\RazorHelpers\CheckBoxListBuilder.cshtml"
                     WebViewPage.WriteTo(@__razor_helper_writer, item.Value);

#line default
#line hidden

WebViewPage.WriteLiteralTo(@__razor_helper_writer, "\" class=\"checkbox-inline\" />\r\n                    <label for=\"");



#line 13 "..\..\RazorHelpers\CheckBoxListBuilder.cshtml"
WebViewPage.WriteTo(@__razor_helper_writer, item.Value);

#line default
#line hidden

WebViewPage.WriteLiteralTo(@__razor_helper_writer, "\" class=\"control-label\">");



#line 13 "..\..\RazorHelpers\CheckBoxListBuilder.cshtml"
                        WebViewPage.WriteTo(@__razor_helper_writer, item.Text);

#line default
#line hidden

WebViewPage.WriteLiteralTo(@__razor_helper_writer, "</label>\r\n                </div>\r\n            ");

WebViewPage.WriteLiteralTo(@__razor_helper_writer, "\r\n");



#line 16 "..\..\RazorHelpers\CheckBoxListBuilder.cshtml"
        }

#line default
#line hidden

WebViewPage.WriteLiteralTo(@__razor_helper_writer, "    </div>\r\n");



#line 18 "..\..\RazorHelpers\CheckBoxListBuilder.cshtml"

#line default
#line hidden

});

}


    }
}
#pragma warning restore 1591
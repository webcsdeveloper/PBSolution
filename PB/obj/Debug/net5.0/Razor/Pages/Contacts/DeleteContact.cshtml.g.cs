#pragma checksum "C:\Users\webcsdeveloper\source\repos\PBSolution\PB\Pages\Contacts\DeleteContact.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "92aba7b0397acf62a553d2a4c5d8c2d58cb8e5e5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(PBMain.Pages.Contacts.Pages_Contacts_DeleteContact), @"mvc.1.0.razor-page", @"/Pages/Contacts/DeleteContact.cshtml")]
namespace PBMain.Pages.Contacts
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
#line 1 "C:\Users\webcsdeveloper\source\repos\PBSolution\PB\Pages\_ViewImports.cshtml"
using PBMain;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemMetadataAttribute("RouteTemplate", "{contactId:int}")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"92aba7b0397acf62a553d2a4c5d8c2d58cb8e5e5", @"/Pages/Contacts/DeleteContact.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6999df61f3b14fd10e067945dea2acc1b0420264", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Contacts_DeleteContact : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 6 "C:\Users\webcsdeveloper\source\repos\PBSolution\PB\Pages\Contacts\DeleteContact.cshtml"
 if (Model.IsDBChanged == true)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h2>?????????????? ???????? ");
#nullable restore
#line 8 "C:\Users\webcsdeveloper\source\repos\PBSolution\PB\Pages\Contacts\DeleteContact.cshtml"
                Write(Model.Contact.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 8 "C:\Users\webcsdeveloper\source\repos\PBSolution\PB\Pages\Contacts\DeleteContact.cshtml"
                                         Write(Model.Contact.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ???? ?????????? ?????? ??????????</h2>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "92aba7b0397acf62a553d2a4c5d8c2d58cb8e5e55110", async() => {
                WriteLiteral("?????????? ???? ???????? ?????????????? ????????");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 10 "C:\Users\webcsdeveloper\source\repos\PBSolution\PB\Pages\Contacts\DeleteContact.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h2>?????? ???? ?????? ?????????????? ?????????? ???? ");
#nullable restore
#line 13 "C:\Users\webcsdeveloper\source\repos\PBSolution\PB\Pages\Contacts\DeleteContact.cshtml"
                               Write(Model.Contact.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 13 "C:\Users\webcsdeveloper\source\repos\PBSolution\PB\Pages\Contacts\DeleteContact.cshtml"
                                                        Write(Model.Contact.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 13 "C:\Users\webcsdeveloper\source\repos\PBSolution\PB\Pages\Contacts\DeleteContact.cshtml"
                                                                                Write(Model.Contact.Role);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ?????????????? ????????????</h2>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "92aba7b0397acf62a553d2a4c5d8c2d58cb8e5e57500", async() => {
                WriteLiteral("\r\n        <div class=\"form-group\">\r\n            <div class=\"input-group\">\r\n                <input type=\"hidden\" name=\"isforconfirm\" value=\"1\" />\r\n                <input type=\"hidden\" name=\"contactId\"");
                BeginWriteAttribute("value", " value=\"", 660, "\"", 692, 1);
#nullable restore
#line 18 "C:\Users\webcsdeveloper\source\repos\PBSolution\PB\Pages\Contacts\DeleteContact.cshtml"
WriteAttributeValue("", 668, Model.Contact.ContactID, 668, 24, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                <button type=\"submit\" class=\"btn btn-success\">\r\n                    ???????? ?????????? ????????\r\n                </button>\r\n            </div>\r\n        </div>\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            WriteLiteral("    <div>\r\n        ??????????: ");
#nullable restore
#line 27 "C:\Users\webcsdeveloper\source\repos\PBSolution\PB\Pages\Contacts\DeleteContact.cshtml"
          Write(Model.Contact.ContactID);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <div>\r\n        ??????: ");
#nullable restore
#line 30 "C:\Users\webcsdeveloper\source\repos\PBSolution\PB\Pages\Contacts\DeleteContact.cshtml"
        Write(Model.Contact.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <div>\r\n        ?????? ????????????????: ");
#nullable restore
#line 33 "C:\Users\webcsdeveloper\source\repos\PBSolution\PB\Pages\Contacts\DeleteContact.cshtml"
                 Write(Model.Contact.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <div>\r\n        ???? ??????: ");
#nullable restore
#line 36 "C:\Users\webcsdeveloper\source\repos\PBSolution\PB\Pages\Contacts\DeleteContact.cshtml"
           Write(Model.Contact.NationalCode);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <div>\r\n        ???? ????????????: ");
#nullable restore
#line 39 "C:\Users\webcsdeveloper\source\repos\PBSolution\PB\Pages\Contacts\DeleteContact.cshtml"
              Write(Model.Contact.PersonalCode);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <div>\r\n        ???????? ??????????????: ");
#nullable restore
#line 42 "C:\Users\webcsdeveloper\source\repos\PBSolution\PB\Pages\Contacts\DeleteContact.cshtml"
                 Write(Model.Contact.Unit);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <div>\r\n        ??????: ");
#nullable restore
#line 45 "C:\Users\webcsdeveloper\source\repos\PBSolution\PB\Pages\Contacts\DeleteContact.cshtml"
        Write(Model.Contact.Role);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <div>\r\n        ???????? ??????: ");
#nullable restore
#line 48 "C:\Users\webcsdeveloper\source\repos\PBSolution\PB\Pages\Contacts\DeleteContact.cshtml"
             Write(Model.Contact.WPhoneNo);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <div>\r\n        ?????????? ??????????: ");
#nullable restore
#line 51 "C:\Users\webcsdeveloper\source\repos\PBSolution\PB\Pages\Contacts\DeleteContact.cshtml"
                Write(Model.Contact.WInternalNo);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <div>\r\n        ???????? ?????? ??????: ");
#nullable restore
#line 54 "C:\Users\webcsdeveloper\source\repos\PBSolution\PB\Pages\Contacts\DeleteContact.cshtml"
                 Write(Model.Contact.WAddrDesc);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <div>\r\n        ???? ???????? ?????? ??????: ");
#nullable restore
#line 57 "C:\Users\webcsdeveloper\source\repos\PBSolution\PB\Pages\Contacts\DeleteContact.cshtml"
                    Write(Model.Contact.WPostalCode);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <div>\r\n        ?????????? ????????????: ");
#nullable restore
#line 60 "C:\Users\webcsdeveloper\source\repos\PBSolution\PB\Pages\Contacts\DeleteContact.cshtml"
                 Write(Model.Contact.CPNo);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <div>\r\n        ???????? ????????: ");
#nullable restore
#line 63 "C:\Users\webcsdeveloper\source\repos\PBSolution\PB\Pages\Contacts\DeleteContact.cshtml"
              Write(Model.Contact.HPhoneNo);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <div>\r\n        ???????? ????????: ");
#nullable restore
#line 66 "C:\Users\webcsdeveloper\source\repos\PBSolution\PB\Pages\Contacts\DeleteContact.cshtml"
              Write(Model.Contact.HAddrDesc);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <div>\r\n        ???? ???????? ????????: ");
#nullable restore
#line 69 "C:\Users\webcsdeveloper\source\repos\PBSolution\PB\Pages\Contacts\DeleteContact.cshtml"
                 Write(Model.Contact.HPostalCode);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
#nullable restore
#line 71 "C:\Users\webcsdeveloper\source\repos\PBSolution\PB\Pages\Contacts\DeleteContact.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PB.Pages.Contacts.DeleteContactModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<PB.Pages.Contacts.DeleteContactModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<PB.Pages.Contacts.DeleteContactModel>)PageContext?.ViewData;
        public PB.Pages.Contacts.DeleteContactModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591

#pragma checksum "C:\Users\CavelVellenoweth\source\repos\FinancialApp\FinancialApp\Views\Home\Payment.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1d653e75d621466716ca047269873e50f1c9c465"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Payment), @"mvc.1.0.view", @"/Views/Home/Payment.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Payment.cshtml", typeof(AspNetCore.Views_Home_Payment))]
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
#line 1 "C:\Users\CavelVellenoweth\source\repos\FinancialApp\FinancialApp\Views\_ViewImports.cshtml"
using FinancialApp;

#line default
#line hidden
#line 2 "C:\Users\CavelVellenoweth\source\repos\FinancialApp\FinancialApp\Views\_ViewImports.cshtml"
using FinancialApp.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1d653e75d621466716ca047269873e50f1c9c465", @"/Views/Home/Payment.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"84780e5404561d069f0ab22308edd4d36332c8f0", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Payment : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "MakePayment", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CancelPayment", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\CavelVellenoweth\source\repos\FinancialApp\FinancialApp\Views\Home\Payment.cshtml"
  

    ViewData["Title"] = "Payment";
    IEnumerable<FinanceContext.Account> myAccount = null;
    List<int> availableAccounts = new List<int>();
    IEnumerable<FinanceContext.Transaction> transactions = null;
    if (ViewContext.RouteData.Values["filterType"].ToString() == "New")
    {
        myAccount = ViewData["MyAccount"] as IEnumerable<FinanceContext.Account>;
        availableAccounts = ViewData["AvailableAccounts"] as List<int>;
    }
    else
    {
        transactions = ViewData["Transactions"] as IEnumerable<FinanceContext.Transaction>;
    }

#line default
#line hidden
            BeginContext(584, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 19 "C:\Users\CavelVellenoweth\source\repos\FinancialApp\FinancialApp\Views\Home\Payment.cshtml"
 if (ViewContext.RouteData.Values["filterType"].ToString() == "New")
{
    var available = myAccount.FirstOrDefault().Balance + myAccount.FirstOrDefault().Overdraft;

#line default
#line hidden
            BeginContext(755, 239, true);
            WriteLiteral("    <h2>New Payment</h2>\r\n    <table class=\"table-bordered\">\r\n        <thead>\r\n            <tr>\r\n                <th>Balance</th>\r\n                <th>Available</th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n            <tr>\r\n");
            EndContext();
#line 32 "C:\Users\CavelVellenoweth\source\repos\FinancialApp\FinancialApp\Views\Home\Payment.cshtml"
                 if (myAccount.FirstOrDefault().Balance.ToString().EndsWith("00") == true)
                {


#line default
#line hidden
            BeginContext(1107, 50, true);
            WriteLiteral("                    <td>\r\n                        ");
            EndContext();
            BeginContext(1159, 58, false);
#line 36 "C:\Users\CavelVellenoweth\source\repos\FinancialApp\FinancialApp\Views\Home\Payment.cshtml"
                    Write((myAccount.FirstOrDefault().Balance / 100m).ToString("C0"));

#line default
#line hidden
            EndContext();
            BeginContext(1218, 29, true);
            WriteLiteral("\r\n                    </td>\r\n");
            EndContext();
#line 38 "C:\Users\CavelVellenoweth\source\repos\FinancialApp\FinancialApp\Views\Home\Payment.cshtml"

                }
                else
                {

#line default
#line hidden
            BeginContext(1309, 50, true);
            WriteLiteral("                    <td>\r\n                        ");
            EndContext();
            BeginContext(1361, 57, false);
#line 43 "C:\Users\CavelVellenoweth\source\repos\FinancialApp\FinancialApp\Views\Home\Payment.cshtml"
                    Write((myAccount.FirstOrDefault().Balance / 100m).ToString("C"));

#line default
#line hidden
            EndContext();
            BeginContext(1419, 29, true);
            WriteLiteral("\r\n                    </td>\r\n");
            EndContext();
#line 45 "C:\Users\CavelVellenoweth\source\repos\FinancialApp\FinancialApp\Views\Home\Payment.cshtml"
                }

#line default
#line hidden
            BeginContext(1467, 16, true);
            WriteLiteral("                ");
            EndContext();
#line 46 "C:\Users\CavelVellenoweth\source\repos\FinancialApp\FinancialApp\Views\Home\Payment.cshtml"
                 if (available.ToString().EndsWith("00") == true)
                {


#line default
#line hidden
            BeginContext(1555, 50, true);
            WriteLiteral("                    <td>\r\n                        ");
            EndContext();
            BeginContext(1607, 33, false);
#line 50 "C:\Users\CavelVellenoweth\source\repos\FinancialApp\FinancialApp\Views\Home\Payment.cshtml"
                    Write((available / 100m).ToString("C0"));

#line default
#line hidden
            EndContext();
            BeginContext(1641, 29, true);
            WriteLiteral("\r\n                    </td>\r\n");
            EndContext();
#line 52 "C:\Users\CavelVellenoweth\source\repos\FinancialApp\FinancialApp\Views\Home\Payment.cshtml"

                }
                else
                {

#line default
#line hidden
            BeginContext(1732, 50, true);
            WriteLiteral("                    <td>\r\n                        ");
            EndContext();
            BeginContext(1784, 32, false);
#line 57 "C:\Users\CavelVellenoweth\source\repos\FinancialApp\FinancialApp\Views\Home\Payment.cshtml"
                    Write((available / 100m).ToString("C"));

#line default
#line hidden
            EndContext();
            BeginContext(1817, 29, true);
            WriteLiteral("\r\n                    </td>\r\n");
            EndContext();
#line 59 "C:\Users\CavelVellenoweth\source\repos\FinancialApp\FinancialApp\Views\Home\Payment.cshtml"
                }

#line default
#line hidden
            BeginContext(1865, 51, true);
            WriteLiteral("            </tr>\r\n        </tbody>\r\n    </table>\r\n");
            EndContext();
            BeginContext(1918, 4, true);
            WriteLiteral("    ");
            EndContext();
            BeginContext(1922, 746, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d91f2de2fc684c29927ba7c297c1e375", async() => {
                BeginContext(1989, 47, true);
                WriteLiteral("\r\n        <input type=\"hidden\" name=\"myAccount\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 2036, "\"", 2081, 1);
#line 65 "C:\Users\CavelVellenoweth\source\repos\FinancialApp\FinancialApp\Views\Home\Payment.cshtml"
WriteAttributeValue("", 2044, myAccount.FirstOrDefault().AccountID, 2044, 37, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2082, 21, true);
                WriteLiteral("  /> <br />\r\n        ");
                EndContext();
                BeginContext(2104, 200, false);
#line 66 "C:\Users\CavelVellenoweth\source\repos\FinancialApp\FinancialApp\Views\Home\Payment.cshtml"
   Write(Html.DropDownList("ID",
                            new SelectList((availableAccounts)),
                            "Select AccountID",
                            new { @class = "form-control" }));

#line default
#line hidden
                EndContext();
                BeginContext(2304, 137, true);
                WriteLiteral("\r\n\r\n        <input type=\"text\" name=\"Amount\" value=\"Enter Value\" /> <br />\r\n        <input type=\"date\" name=\"Date\" min=\"2018-18-10\"><br> ");
                EndContext();
                BeginContext(2495, 166, true);
                WriteLiteral("\r\n        <input type=\"checkbox\" id =\"isRecurring\" name=\"isRecurring\" value=\"True\"> Recurring Payment<br>\r\n        <button type=\"submit\">Submit Payment</button>\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2668, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 76 "C:\Users\CavelVellenoweth\source\repos\FinancialApp\FinancialApp\Views\Home\Payment.cshtml"
}
else
{

#line default
#line hidden
            BeginContext(2682, 301, true);
            WriteLiteral(@"    <h2>Cancel Payment</h2>
     <table class=""table-bordered"">
        <thead>
            <tr>
                <th>Transaction ID</th>
                <th>To Account</th>
                <th>Amount</th>
                <th>Due Date</th>
            </tr>
        </thead>
        <tbody>
");
            EndContext();
#line 90 "C:\Users\CavelVellenoweth\source\repos\FinancialApp\FinancialApp\Views\Home\Payment.cshtml"
             foreach (var transaction in transactions)
            {

#line default
#line hidden
            BeginContext(3054, 60, true);
            WriteLiteral("            <tr>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(3115, 25, false);
#line 94 "C:\Users\CavelVellenoweth\source\repos\FinancialApp\FinancialApp\Views\Home\Payment.cshtml"
               Write(transaction.TransactionID);

#line default
#line hidden
            EndContext();
            BeginContext(3140, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(3208, 23, false);
#line 97 "C:\Users\CavelVellenoweth\source\repos\FinancialApp\FinancialApp\Views\Home\Payment.cshtml"
               Write(transaction.ToAccountID);

#line default
#line hidden
            EndContext();
            BeginContext(3231, 25, true);
            WriteLiteral("\r\n                </td>\r\n");
            EndContext();
#line 99 "C:\Users\CavelVellenoweth\source\repos\FinancialApp\FinancialApp\Views\Home\Payment.cshtml"
                 if (transaction.Amount.ToString().EndsWith("00") == true)
                {


#line default
#line hidden
            BeginContext(3353, 50, true);
            WriteLiteral("                    <td>\r\n                        ");
            EndContext();
            BeginContext(3405, 42, false);
#line 103 "C:\Users\CavelVellenoweth\source\repos\FinancialApp\FinancialApp\Views\Home\Payment.cshtml"
                    Write((transaction.Amount / 100m).ToString("C0"));

#line default
#line hidden
            EndContext();
            BeginContext(3448, 29, true);
            WriteLiteral("\r\n                    </td>\r\n");
            EndContext();
#line 105 "C:\Users\CavelVellenoweth\source\repos\FinancialApp\FinancialApp\Views\Home\Payment.cshtml"

                }
                else
                {

#line default
#line hidden
            BeginContext(3539, 50, true);
            WriteLiteral("                    <td>\r\n                        ");
            EndContext();
            BeginContext(3591, 41, false);
#line 110 "C:\Users\CavelVellenoweth\source\repos\FinancialApp\FinancialApp\Views\Home\Payment.cshtml"
                    Write((transaction.Amount / 100m).ToString("C"));

#line default
#line hidden
            EndContext();
            BeginContext(3633, 29, true);
            WriteLiteral("\r\n                    </td>\r\n");
            EndContext();
#line 112 "C:\Users\CavelVellenoweth\source\repos\FinancialApp\FinancialApp\Views\Home\Payment.cshtml"
                }

#line default
#line hidden
            BeginContext(3681, 42, true);
            WriteLiteral("                <td>\r\n                    ");
            EndContext();
            BeginContext(3724, 36, false);
#line 114 "C:\Users\CavelVellenoweth\source\repos\FinancialApp\FinancialApp\Views\Home\Payment.cshtml"
               Write(transaction.Date.ToShortDateString());

#line default
#line hidden
            EndContext();
            BeginContext(3760, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(3827, 557, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b3825f473494483fbd15188e21f522a0", async() => {
                BeginContext(3896, 67, true);
                WriteLiteral("\r\n                        <input type=\"hidden\" name=\"transactionID\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 3963, "\"", 3997, 1);
#line 118 "C:\Users\CavelVellenoweth\source\repos\FinancialApp\FinancialApp\Views\Home\Payment.cshtml"
WriteAttributeValue("", 3971, transaction.TransactionID, 3971, 26, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3998, 63, true);
                WriteLiteral(" />\r\n                        <input type=\"hidden\" name=\"fromID\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 4061, "\"", 4095, 1);
#line 119 "C:\Users\CavelVellenoweth\source\repos\FinancialApp\FinancialApp\Views\Home\Payment.cshtml"
WriteAttributeValue("", 4069, transaction.FromAccountID, 4069, 26, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(4096, 61, true);
                WriteLiteral(" />\r\n                        <input type=\"hidden\" name=\"toID\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 4157, "\"", 4189, 1);
#line 120 "C:\Users\CavelVellenoweth\source\repos\FinancialApp\FinancialApp\Views\Home\Payment.cshtml"
WriteAttributeValue("", 4165, transaction.ToAccountID, 4165, 24, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(4190, 63, true);
                WriteLiteral(" />\r\n                        <input type=\"hidden\" name=\"Amount\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 4253, "\"", 4280, 1);
#line 121 "C:\Users\CavelVellenoweth\source\repos\FinancialApp\FinancialApp\Views\Home\Payment.cshtml"
WriteAttributeValue("", 4261, transaction.Amount, 4261, 19, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(4281, 96, true);
                WriteLiteral(" />\r\n                        <button type=\"submit\">Cancel Payment</button>\r\n                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4384, 68, true);
            WriteLiteral("\r\n                    \r\n                </td>\r\n\r\n            </tr>\r\n");
            EndContext();
#line 128 "C:\Users\CavelVellenoweth\source\repos\FinancialApp\FinancialApp\Views\Home\Payment.cshtml"
            }

#line default
#line hidden
            BeginContext(4467, 32, true);
            WriteLiteral("        </tbody>\r\n    </table>\r\n");
            EndContext();
#line 131 "C:\Users\CavelVellenoweth\source\repos\FinancialApp\FinancialApp\Views\Home\Payment.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
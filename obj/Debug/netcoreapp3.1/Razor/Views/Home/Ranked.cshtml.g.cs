#pragma checksum "C:\Users\nuryn\Desktop\CodingProjects\SmiteAPIWebsite\Views\Home\Ranked.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b5ace92bf3ae84f55b9bbb27e46ee6af927d4f0e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Ranked), @"mvc.1.0.view", @"/Views/Home/Ranked.cshtml")]
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
#line 1 "C:\Users\nuryn\Desktop\CodingProjects\SmiteAPIWebsite\Views\_ViewImports.cshtml"
using SmiteAPIWebsite;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\nuryn\Desktop\CodingProjects\SmiteAPIWebsite\Views\_ViewImports.cshtml"
using SmiteAPIWebsite.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b5ace92bf3ae84f55b9bbb27e46ee6af927d4f0e", @"/Views/Home/Ranked.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a099de83da058b5cea0b2e062015ec9a22b3b343", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Ranked : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "PlayerSummary", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("nav-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Ranked", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "MatchHistory", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!doctype html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b5ace92bf3ae84f55b9bbb27e46ee6af927d4f0e5537", async() => {
                WriteLiteral("\r\n    <meta charset=\"utf-8\">\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1, shrink-to-fit=no\">\r\n    <meta name=\"description\"");
                BeginWriteAttribute("content", " content=\"", 191, "\"", 201, 0);
                EndWriteAttribute();
                WriteLiteral(@">
    <meta name=""author"" content=""Mark Otto, Jacob Thornton, and Bootstrap contributors"">
    <meta name=""generator"" content=""Jekyll v4.1.1"">
    <title>Dashboard Template · Bootstrap</title>

    <link rel=""canonical"" href=""https://getbootstrap.com/docs/4.5/examples/dashboard/"">

    <!-- Bootstrap core CSS -->
    <link href=""../assets/dist/css/bootstrap.min.css"" rel=""stylesheet"">

    <style>
        .bd-placeholder-img {
            font-size: 1.125rem;
            text-anchor: middle;
            -webkit-user-select: none;
            -moz-user-select: none;
            -ms-user-select: none;
            user-select: none;
        }
    </style>
    <!-- Custom styles for this template -->
    <link href=""dashboard.css"" rel=""stylesheet"">
");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b5ace92bf3ae84f55b9bbb27e46ee6af927d4f0e7616", async() => {
                WriteLiteral("\r\n    <nav class=\"navbar navbar-dark sticky-top bg-dark flex-md-nowrap p-0 shadow\">\r\n        <a class=\"navbar-brand col-md-3 col-lg-2 mr-0 px-3\" href=\"#\">");
#nullable restore
#line 31 "C:\Users\nuryn\Desktop\CodingProjects\SmiteAPIWebsite\Views\Home\Ranked.cshtml"
                                                                Write(Smite.player[0].Name);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</a>
        <button class=""navbar-toggler position-absolute d-md-none collapsed"" type=""button"" data-toggle=""collapse"" data-target=""#sidebarMenu"" aria-controls=""sidebarMenu"" aria-expanded=""false"" aria-label=""Toggle navigation"">
            <span class=""navbar-toggler-icon""></span>
        </button>

    </nav>

    <div class=""container-fluid"">
        <div class=""row"">
            <nav id=""sidebarMenu"" class=""col-md-3 col-lg-2 d-md-block bg-light sidebar collapse"">
                <div class=""sidebar-sticky pt-3"">
                    <ul class=""nav flex-column"">
                        <li class=""nav-item"">
                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b5ace92bf3ae84f55b9bbb27e46ee6af927d4f0e9011", async() => {
                    WriteLiteral("\r\n                                <input type=\"text\"");
                    BeginWriteAttribute("value", " value=\"", 1946, "\"", 1973, 1);
#nullable restore
#line 45 "C:\Users\nuryn\Desktop\CodingProjects\SmiteAPIWebsite\Views\Home\Ranked.cshtml"
WriteAttributeValue("", 1954, Smite.previousName, 1954, 19, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(" name=\"playerToSearch\" hidden />\r\n                                <button type=\"submit\" class=\"btn btn-link\">Summary</button>\r\n                            ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                        </li>\r\n                        <li class=\"nav-item\">\r\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b5ace92bf3ae84f55b9bbb27e46ee6af927d4f0e11658", async() => {
                    WriteLiteral("\r\n                                <span data-feather=\"file\"></span>\r\n                                Ranked\r\n                            ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                        </li>\r\n                        <li class=\"nav-item\">\r\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b5ace92bf3ae84f55b9bbb27e46ee6af927d4f0e13430", async() => {
                    WriteLiteral("\r\n                                <span data-feather=\"shopping-cart\"></span>\r\n                                Match History\r\n                            ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                        </li>
                        
                    </ul>
                </div>
            </nav>

            <main role=""main"" class=""col-md-9 ml-sm-auto col-lg-10 px-md-4"">
                <div class=""d-flex justify-content-between flex-wrap flex-md-nowrap align-items-center pt-3 pb-2 mb-3 border-bottom"">
                    <h1 class=""h2"">Ranked: Season ");
#nullable restore
#line 68 "C:\Users\nuryn\Desktop\CodingProjects\SmiteAPIWebsite\Views\Home\Ranked.cshtml"
                                             Write(Smite.player[0].RankedConquestController.Season);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</h1>
                </div>
                <div class=""row d-flex justify-content-around"">
                    <div class=""col-xl-3 col-sm-6 col-12 mb-3 account-created"">
                        <div class=""card"">
                            <div class=""card-content"">
                                <div class=""card-body"">
                                    <div class=""media d-flex"">
                                        <div class=""align-self-center"">
                                            <i class=""fa fa-users primary font-large-2 float-left""></i>
                                        </div>
                                        <div class=""media-body text-right"">
                                            <h3 class=""primary"">");
#nullable restore
#line 80 "C:\Users\nuryn\Desktop\CodingProjects\SmiteAPIWebsite\Views\Home\Ranked.cshtml"
                                                           Write(Smite.player[0].Rank_Stat_Conquest_Controller);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</h3>
                                            <span>Conquest MMR</span>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class=""col-xl-3 col-sm-6 col-12 last-login"">
                        <div class=""card"">
                            <div class=""card-content"">
                                <div class=""card-body"">
                                    <div class=""media d-flex"">
                                        <div class=""align-self-center"">
                                            <i class=""fa fa-sign-language primary font-large-2 float-left""></i>
                                        </div>
                                        <div class=""media-body text-right"">
                                            <h3 class=""primary"">");
#nullable restore
#line 97 "C:\Users\nuryn\Desktop\CodingProjects\SmiteAPIWebsite\Views\Home\Ranked.cshtml"
                                                           Write(Smite.player[0].Rank_Stat_Joust_Controller);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</h3>
                                            <span>Joust MMR</span>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class=""col-xl-3 col-sm-6 col-12"">
                        <div class=""card"">
                            <div class=""card-content"">
                                <div class=""card-body"">
                                    <div class=""media d-flex"">
                                        <div class=""align-self-center"">
                                            <i class=""fa fa fa-balance-scale info font-large-2 float-left""></i>
                                        </div>
                                        <div class=""media-body text-right"">
                                            <h3 class=""info"">");
#nullable restore
#line 114 "C:\Users\nuryn\Desktop\CodingProjects\SmiteAPIWebsite\Views\Home\Ranked.cshtml"
                                                        Write(Smite.player[0].Rank_Stat_Duel_Controller);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</h3>
                                            <span>Duel MMR</span>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                <div class=""ranked-table"">
                    <h1>Conquest</h1>
                    <div class=""tbl-header"">
                        <table cellpadding=""0"" cellspacing=""0"" border=""0"">
                            <thead>
                                <tr>
                                    <th>Matches</th>
                                    <th>Wins</th>
                                    <th>Losses</th>
                                    <th>Disconnects</th>
                                    <th>TP</th>
                                    <th>Variance</th>
                                </tr>
                            </thead>
                     ");
                WriteLiteral(@"   </table>
                    </div>
                    <div class=""tbl-content"">
                        <table cellpadding=""0"" cellspacing=""0"" border=""0"">
                            <tbody>
                                <tr>
                                    <td>");
#nullable restore
#line 143 "C:\Users\nuryn\Desktop\CodingProjects\SmiteAPIWebsite\Views\Home\Ranked.cshtml"
                                    Write(Smite.player[0].RankedConquestController.Wins + Smite.player[0].RankedConquestController.Losses);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 144 "C:\Users\nuryn\Desktop\CodingProjects\SmiteAPIWebsite\Views\Home\Ranked.cshtml"
                                   Write(Smite.player[0].RankedConquestController.Wins);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 145 "C:\Users\nuryn\Desktop\CodingProjects\SmiteAPIWebsite\Views\Home\Ranked.cshtml"
                                   Write(Smite.player[0].RankedConquestController.Losses);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 146 "C:\Users\nuryn\Desktop\CodingProjects\SmiteAPIWebsite\Views\Home\Ranked.cshtml"
                                   Write(Smite.player[0].RankedConquestController.Leaves);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 147 "C:\Users\nuryn\Desktop\CodingProjects\SmiteAPIWebsite\Views\Home\Ranked.cshtml"
                                   Write(Smite.player[0].RankedConquestController.Points);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 148 "C:\Users\nuryn\Desktop\CodingProjects\SmiteAPIWebsite\Views\Home\Ranked.cshtml"
                                   Write(Smite.player[0].RankedConquestController.Rank_Variance);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</td>
                                </tr>
                        </table>
                    </div>
                </div>
                <div class=""ranked-table"">
                    <h1>Joust</h1>
                    <div class=""tbl-header"">
                        <table cellpadding=""0"" cellspacing=""0"" border=""0"">
                            <thead>
                                <tr>
                                    <th>Matches</th>
                                    <th>Wins</th>
                                    <th>Losses</th>
                                    <th>Disconnects</th>
                                    <th>TP</th>
                                    <th>Variance</th>
                                </tr>
                            </thead>
                        </table>
                    </div>
                    <div class=""tbl-content"">
                        <table cellpadding=""0"" cellspacing=""0"" border=""0"">
                            <tbod");
                WriteLiteral("y>\r\n                                <tr>\r\n                                    <td>");
#nullable restore
#line 173 "C:\Users\nuryn\Desktop\CodingProjects\SmiteAPIWebsite\Views\Home\Ranked.cshtml"
                                    Write(Smite.player[0].RankedJoustController.Wins + Smite.player[0].RankedJoustController.Losses);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 174 "C:\Users\nuryn\Desktop\CodingProjects\SmiteAPIWebsite\Views\Home\Ranked.cshtml"
                                   Write(Smite.player[0].RankedJoustController.Wins);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 175 "C:\Users\nuryn\Desktop\CodingProjects\SmiteAPIWebsite\Views\Home\Ranked.cshtml"
                                   Write(Smite.player[0].RankedJoustController.Losses);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 176 "C:\Users\nuryn\Desktop\CodingProjects\SmiteAPIWebsite\Views\Home\Ranked.cshtml"
                                   Write(Smite.player[0].RankedJoustController.Leaves);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 177 "C:\Users\nuryn\Desktop\CodingProjects\SmiteAPIWebsite\Views\Home\Ranked.cshtml"
                                   Write(Smite.player[0].RankedJoustController.Points);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 178 "C:\Users\nuryn\Desktop\CodingProjects\SmiteAPIWebsite\Views\Home\Ranked.cshtml"
                                   Write(Smite.player[0].RankedJoustController.Rank_Variance);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</td>
                                </tr>
                        </table>
                    </div>
                </div>
                <div class=""ranked-table"">
                    <h1>Duel</h1>
                    <div class=""tbl-header"">
                        <table cellpadding=""0"" cellspacing=""0"" border=""0"">
                            <thead>
                                <tr>
                                    <th>Matches</th>
                                    <th>Wins</th>
                                    <th>Losses</th>
                                    <th>Disconnects</th>
                                    <th>TP</th>
                                    <th>Variance</th>
                                </tr>
                            </thead>
                        </table>
                    </div>
                    <div class=""tbl-content"">
                        <table cellpadding=""0"" cellspacing=""0"" border=""0"">
                            <tbody");
                WriteLiteral(">\r\n                                <tr>\r\n                                    <td>");
#nullable restore
#line 203 "C:\Users\nuryn\Desktop\CodingProjects\SmiteAPIWebsite\Views\Home\Ranked.cshtml"
                                    Write(Smite.player[0].RankedDuelController.Wins + Smite.player[0].RankedDuelController.Losses);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 204 "C:\Users\nuryn\Desktop\CodingProjects\SmiteAPIWebsite\Views\Home\Ranked.cshtml"
                                   Write(Smite.player[0].RankedDuelController.Wins);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 205 "C:\Users\nuryn\Desktop\CodingProjects\SmiteAPIWebsite\Views\Home\Ranked.cshtml"
                                   Write(Smite.player[0].RankedDuelController.Losses);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 206 "C:\Users\nuryn\Desktop\CodingProjects\SmiteAPIWebsite\Views\Home\Ranked.cshtml"
                                   Write(Smite.player[0].RankedDuelController.Leaves);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 207 "C:\Users\nuryn\Desktop\CodingProjects\SmiteAPIWebsite\Views\Home\Ranked.cshtml"
                                   Write(Smite.player[0].RankedDuelController.Points);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 208 "C:\Users\nuryn\Desktop\CodingProjects\SmiteAPIWebsite\Views\Home\Ranked.cshtml"
                                   Write(Smite.player[0].RankedDuelController.Rank_Variance);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</td>
                                </tr>
                        </table>
                    </div>
                </div>


                <div class=""d-flex justify-content-between flex-wrap flex-md-nowrap align-items-center pt-3 pb-2 mb-3 border-bottom"">
                    <h1 class=""h2"">Top 5 Gods(Ranked)</h1>
                </div>
                <div class=""table-ranked-gods"">
                    <table cellspacing=""0"">
                        <tr>
                            <th></th>
                            <th>God</th>
                            <th>KDA</th>
                            <th>Kills</th>
                            <th>Deaths</th>
                            <th>Assists</th>
                            <th>Matches</th>
                            <th>Wins</th>
                            <th>Losses</th>
                        </tr>
");
#nullable restore
#line 231 "C:\Users\nuryn\Desktop\CodingProjects\SmiteAPIWebsite\Views\Home\Ranked.cshtml"
                         for (int i = 0; i <= 4; i++)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <tr>\r\n                                <td><img");
                BeginWriteAttribute("src", " src=\"", 12305, "\"", 12379, 1);
#nullable restore
#line 234 "C:\Users\nuryn\Desktop\CodingProjects\SmiteAPIWebsite\Views\Home\Ranked.cshtml"
WriteAttributeValue("", 12311, Smite.godsDictionary[Smite.playerRankedConquest[i].God].godIcon_URL, 12311, 68, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("alt", " alt=\"", 12380, "\"", 12386, 0);
                EndWriteAttribute();
                WriteLiteral(" /></td>\r\n                                <td>");
#nullable restore
#line 235 "C:\Users\nuryn\Desktop\CodingProjects\SmiteAPIWebsite\Views\Home\Ranked.cshtml"
                               Write(Smite.playerRankedConquest[i].God);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 236 "C:\Users\nuryn\Desktop\CodingProjects\SmiteAPIWebsite\Views\Home\Ranked.cshtml"
                                Write(((Smite.playerRankedConquest[i].Kills + (Smite.playerRankedConquest[i].Assists / 2)) / Smite.playerRankedConquest[i].Deaths).ToString(".0###"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 237 "C:\Users\nuryn\Desktop\CodingProjects\SmiteAPIWebsite\Views\Home\Ranked.cshtml"
                               Write(Smite.playerRankedConquest[i].Kills);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 238 "C:\Users\nuryn\Desktop\CodingProjects\SmiteAPIWebsite\Views\Home\Ranked.cshtml"
                               Write(Smite.playerRankedConquest[i].Deaths);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 239 "C:\Users\nuryn\Desktop\CodingProjects\SmiteAPIWebsite\Views\Home\Ranked.cshtml"
                               Write(Smite.playerRankedConquest[i].Assists);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 240 "C:\Users\nuryn\Desktop\CodingProjects\SmiteAPIWebsite\Views\Home\Ranked.cshtml"
                               Write(Smite.playerRankedConquest[i].Matches);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 241 "C:\Users\nuryn\Desktop\CodingProjects\SmiteAPIWebsite\Views\Home\Ranked.cshtml"
                               Write(Smite.playerRankedConquest[i].Wins);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 242 "C:\Users\nuryn\Desktop\CodingProjects\SmiteAPIWebsite\Views\Home\Ranked.cshtml"
                               Write(Smite.playerRankedConquest[i].Losses);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                            </tr>\r\n");
#nullable restore
#line 244 "C:\Users\nuryn\Desktop\CodingProjects\SmiteAPIWebsite\Views\Home\Ranked.cshtml"
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                    </table>
                </div>
            </main>
        </div>
    </div>
    <script src=""https://code.jquery.com/jquery-3.5.1.slim.min.js"" integrity=""sha384-DfXdz2htPH0lsSSs5nCTpuj/zy4C+OGpamoFVy38MVBnE+IbbVYUew+OrCXaRkfj"" crossorigin=""anonymous""></script>
    <script>window.jQuery || document.write('<script src=""../assets/js/vendor/jquery.slim.min.js""><\/script>')</script>
    <script src=""../assets/dist/js/bootstrap.bundle.min.js""></script>
    <script src=""https://cdnjs.cloudflare.com/ajax/libs/feather-icons/4.9.0/feather.min.js""></script>
    <script src=""https://cdnjs.cloudflare.com/ajax/libs/Chart.js/2.7.3/Chart.min.js""></script>
    <script src=""dashboard.js""></script>
");
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
            WriteLiteral("\r\n</html>");
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

#pragma checksum "D:\Projetos\Estudo.NetCore\ITDeveloper\src\Cooperchip.ITDeveloper.Mvc\Views\Shared\PartialViews\_rightsidebar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7e83ec39074e0df0d76a002bcb93178e8a592f5e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_PartialViews__rightsidebar), @"mvc.1.0.view", @"/Views/Shared/PartialViews/_rightsidebar.cshtml")]
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
#line 1 "D:\Projetos\Estudo.NetCore\ITDeveloper\src\Cooperchip.ITDeveloper.Mvc\Views\_ViewImports.cshtml"
using Cooperchip.ITDeveloper.Mvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Projetos\Estudo.NetCore\ITDeveloper\src\Cooperchip.ITDeveloper.Mvc\Views\_ViewImports.cshtml"
using Cooperchip.ITDeveloper.Mvc.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7e83ec39074e0df0d76a002bcb93178e8a592f5e", @"/Views/Shared/PartialViews/_rightsidebar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1b3e663f05881c1a02705e8d4fa32659c73b82bf", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_PartialViews__rightsidebar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-vertical chat-search"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("chat-write-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-vertical"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"        <!-- Start #right-sidebar -->
<aside id=""right-sidebar"" class=""right-sidebar hidden-md hidden-sm hidden-xs"">
    <!-- Start .sidebar-inner -->
    <div class=""sidebar-inner"">
        <!-- Start .sidebar-scrollarea -->
        <div class=""sidebar-scrollarea"">
            <div class=""tabs"">
                <!-- Start .rs tabs -->
                <ul id=""rstab"" class=""nav nav-tabs nav-justified"">
                    <li class=""active"">
                        <a href=""#activity"" data-toggle=""tab""><i class=""glyphicon glyphicon-bullhorn""></i> </a>
                    </li>
                    <li>
                        <a href=""#users"" data-toggle=""tab""><i class=""fa fa-comments""></i> </a>
                    </li>
                </ul>
                <div id=""rstab-content"" class=""tab-content"">
                    <div class=""tab-pane fade active in"" id=""activity"">
                        <ul class=""timeline timeline-icons timeline-sm"">
                            <li>
              ");
            WriteLiteral(@"                  <p>
                                    <a href=""#"">Jonh Doe</a> attached new <a href=""#"">file</a>
                                    <span class=""timeline-icon""><i class=""fa fa-file-text-o""></i></span>
                                    <span class=""timeline-date"">Dec 10, 22:00</span>
                                </p>
                            </li>
                            <li>
                                <p>
                                    <a href=""#"">Admin</a> approved <a href=""#"">3 new comments</a>
                                    <span class=""timeline-icon""><i class=""fa fa-comment""></i></span>
                                    <span class=""timeline-date"">Dec 8, 13:35</span>
                                </p>
                            </li>
                            <li>
                                <p>
                                    <a href=""#"">Jonh Smith</a> deposit 300$
                                    <span class=""timeline-icon");
            WriteLiteral(@"""><i class=""fa fa-money color-green""></i></span>
                                    <span class=""timeline-date"">Dec 6, 10:17</span>
                                </p>
                            </li>
                            <li>
                                <p>
                                    <a href=""#"">Serena Williams</a> purchase <a href=""#"">3 items</a>
                                    <span class=""timeline-icon""><i class=""fa fa-shopping-cart color-red""></i></span>
                                    <span class=""timeline-date"">Dec 5, 04:36</span>
                                </p>
                            </li>
                            <li>
                                <p>
                                    <a href=""#"">1 support </a> request is received from <a href=""#"">Klaudia Chambers</a>
                                    <span class=""timeline-icon""><i class=""fa fa-life-ring color-gray-light""></i></span>
                                    <span class=""time");
            WriteLiteral(@"line-date"">Dec 4, 18:40</span>
                                </p>
                            </li>
                            <li>
                                <p>
                                    You received 136 new likes for <a href=""#"">your page</a>
                                    <span class=""timeline-icon""><i class=""glyphicon glyphicon-thumbs-up""></i></span>
                                    <span class=""timeline-date"">Dec 4, 12:00</span>
                                </p>
                            </li>
                            <li>
                                <p>
                                    <a href=""#"">12 settings </a> are changed from <a href=""#"">Master Admin</a>
                                    <span class=""timeline-icon""><i class=""glyphicon glyphicon-cog""></i></span>
                                    <span class=""timeline-date"">Dec 3, 23:17</span>
                                </p>
                            </li>
                         ");
            WriteLiteral(@"   <li>
                                <p>
                                    <a href=""#"">Klaudia Chambers</a> change your photo
                                    <span class=""timeline-icon""><i class=""l-basic-photo""></i></span>
                                    <span class=""timeline-date"">Dec 2, 05:17</span>
                                </p>
                            </li>
                            <li>
                                <p>
                                    <a href=""#"">Master server </a> is down for 10 min.
                                    <span class=""timeline-icon""><i class=""l-basic-server2""></i></span>
                                    <span class=""timeline-date"">Dec 2, 04:56</span>
                                </p>
                            </li>
                            <li>
                                <p>
                                    <a href=""#"">12 links </a> are broken
                                    <span class=""timeline-icon"">");
            WriteLiteral(@"<i class=""fa fa-unlink""></i></span>
                                    <span class=""timeline-date"">Dec 1, 22:13</span>
                                </p>
                            </li>
                            <li>
                                <p>
                                    <a href=""#"">Last backup </a> is restored by <a href=""#"">Master admin</a>
                                    <span class=""timeline-icon""><i class=""fa fa-undo color-red""></i></span>
                                    <span class=""timeline-date"">Dec 1, 17:42</span>
                                </p>
                            </li>
                        </ul>
                    </div>
                    <div class=""tab-pane fade"" id=""users"">
                        <div class=""chat-user-list"">
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7e83ec39074e0df0d76a002bcb93178e8a592f5e11084", async() => {
                WriteLiteral(@"
                                <div class=""form-group"">
                                    <div class=""input-group"">
                                        <input type=""text"" class=""form-control input-sm"" placeholder=""Search ..."">
                                        <span class=""input-group-btn"">
                                            <button class=""btn btn-default btn-sm"" type=""submit""><i class=""fa fa-search""></i></button>
                                        </span>
                                    </div>
                                </div>
                                <!-- End .form-group  -->
                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                            <ul class=""user-list list-group"">
                                <li class=""list-group-item clearfix"">
                                    <a href=""#"">
                                        <img src=""img/avatars/2.jpg"" alt=""avatar"" class=""avatar"">
                                        <span class=""name"">Dean Huges</span>
                                        <span class=""status status-online"">online</span>
                                    </a>
                                    <div class=""chat-messages"">
                                        <ul>
                                            <li class=""chat-back"">
                                                <a href=""#"">Back <i class=""fa fa-chevron-right ml5""></i> </a>
                                            </li>
                                            <li>
                                                <div class=""avatar"">
                                                    <img src=""img/av");
            WriteLiteral(@"atars/2.jpg"" alt=""chadengle"">
                                                </div>
                                                <p class=""chat-name"">
                                                    Dean Huges <span class=""chat-time"">15 sec ago</span>
                                                </p>
                                                <div class=""message"">
                                                    <p class=""chat-txt"">We need to meet today. I have some things to show you.</p>
                                                </div>
                                            </li>
                                            <li class=""chat-me"">
                                                <div class=""avatar"">
                                                    <img src=""img/avatars/1.jpg"" alt=""jonhdoe"">
                                                </div>
                                                <p class=""chat-name"">
                                    ");
            WriteLiteral(@"                SuggeElson <span class=""chat-time"">10 sec ago</span>
                                                </p>
                                                <div class=""message message-info"">
                                                    <p class=""chat-txt"">I have tons of work today maybe tomorrow will be fine</p>
                                                </div>
                                            </li>
                                            <li>
                                                <div class=""avatar"">
                                                    <img src=""img/avatars/2.jpg"" alt=""chadengle"">
                                                </div>
                                                <p class=""chat-name"">
                                                    Dean Huges <span class=""chat-time"">just now</span>
                                                </p>
                                                <div class=""message"">
   ");
            WriteLiteral(@"                                                 <p class=""chat-txt"">Okay i will wait..</p>
                                                </div>
                                            </li>
                                        </ul>
                                    </div>
                                </li>
                                <li class=""list-group-item clearfix"">
                                    <a href=""#"">
                                        <img src=""img/avatars/4.jpg"" alt=""avatar"" class=""avatar"">
                                        <span class=""name"">Selena Jones</span>
                                        <span class=""status status-offline"">offline from 1 Dec</span>
                                    </a>
                                    <div class=""chat-messages"">
                                        <ul>
                                            <li class=""chat-back"">
                                                <a href=""#"">Back <i cl");
            WriteLiteral(@"ass=""fa fa-chevron-right ml5""></i> </a>
                                            </li>
                                            <li class=""no-messages"">
                                                <p class=""text-center color-red"">No messages are found</p>
                                            </li>
                                        </ul>
                                    </div>
                                </li>
                                <li class=""list-group-item clearfix"">
                                    <a href=""#"">
                                        <img src=""img/avatars/5.jpg"" alt=""avatar"" class=""avatar"">
                                        <span class=""name"">Mike Tomas</span>
                                        <span class=""status status-online"">online</span>
                                    </a>
                                    <div class=""chat-messages"">
                                        <ul>
                                ");
            WriteLiteral(@"            <li class=""chat-back"">
                                                <a href=""#"">Back <i class=""fa fa-chevron-right ml5""></i> </a>
                                            </li>
                                            <li class=""no-messages"">
                                                <p class=""text-center color-red"">No messages are found</p>
                                            </li>
                                        </ul>
                                    </div>
                                </li>
                                <li class=""list-group-item clearfix"">
                                    <a href=""#"">
                                        <img src=""img/avatars/6.jpg"" alt=""avatar"" class=""avatar"">
                                        <span class=""name"">Jim Kerry</span>
                                        <span class=""status status-online"">online</span>
                                    </a>
                                    <d");
            WriteLiteral(@"iv class=""chat-messages"">
                                        <ul>
                                            <li class=""chat-back"">
                                                <a href=""#"">Back <i class=""fa fa-chevron-right ml5""></i> </a>
                                            </li>
                                            <li class=""no-messages"">
                                                <p class=""text-center color-red"">No messages are found</p>
                                            </li>
                                        </ul>
                                    </div>
                                </li>
                                <li class=""list-group-item clearfix"">
                                    <a href=""#"">
                                        <img src=""img/avatars/7.jpg"" alt=""avatar"" class=""avatar"">
                                        <span class=""name"">Little Jonh</span>
                                        <span class=""status sta");
            WriteLiteral(@"tus-online"">online</span>
                                    </a>
                                    <div class=""chat-messages"">
                                        <ul>
                                            <li class=""chat-back"">
                                                <a href=""#"">Back <i class=""fa fa-chevron-right ml5""></i> </a>
                                            </li>
                                            <li class=""no-messages"">
                                                <p class=""text-center color-red"">No messages are found</p>
                                            </li>
                                        </ul>
                                    </div>
                                </li>
                                <li class=""list-group-item clearfix"">
                                    <a href=""#"">
                                        <img src=""img/avatars/8.jpg"" alt=""avatar"" class=""avatar"">
                                   ");
            WriteLiteral(@"     <span class=""name"">Keith Smith</span>
                                        <span class=""status status-online"">online</span>
                                    </a>
                                    <div class=""chat-messages"">
                                        <ul>
                                            <li class=""chat-back"">
                                                <a href=""#"">Back <i class=""fa fa-chevron-right ml5""></i> </a>
                                            </li>
                                            <li class=""no-messages"">
                                                <p class=""text-center color-red"">No messages are found</p>
                                            </li>
                                        </ul>
                                    </div>
                                </li>
                                <li class=""list-group-item clearfix"">
                                    <a href=""#"">
                           ");
            WriteLiteral(@"             <img src=""img/avatars/9.jpg"" alt=""avatar"" class=""avatar"">
                                        <span class=""name"">Tracy Miller</span>
                                        <span class=""status status-online"">online</span>
                                    </a>
                                    <div class=""chat-messages"">
                                        <ul>
                                            <li class=""chat-back"">
                                                <a href=""#"">Back <i class=""fa fa-chevron-right ml5""></i> </a>
                                            </li>
                                            <li class=""no-messages"">
                                                <p class=""text-center color-red"">No messages are found</p>
                                            </li>
                                        </ul>
                                    </div>
                                </li>
                                <li clas");
            WriteLiteral(@"s=""list-group-item clearfix"">
                                    <a href=""#"">
                                        <img src=""img/avatars/10.jpg"" alt=""avatar"" class=""avatar"">
                                        <span class=""name"">Peter Petrovski</span>
                                        <span class=""status status-online"">online</span>
                                    </a>
                                    <div class=""chat-messages"">
                                        <ul>
                                            <li class=""chat-back"">
                                                <a href=""#"">Back <i class=""fa fa-chevron-right ml5""></i> </a>
                                            </li>
                                            <li class=""no-messages"">
                                                <p class=""text-center color-red"">No messages are found</p>
                                            </li>
                                        </ul>
           ");
            WriteLiteral(@"                         </div>
                                </li>
                                <li class=""list-group-item clearfix"">
                                    <a href=""#"">
                                        <img src=""img/avatars/11.jpg"" alt=""avatar"" class=""avatar"">
                                        <span class=""name"">Kim Lee</span>
                                        <span class=""status status-online"">online</span>
                                    </a>
                                    <div class=""chat-messages"">
                                        <ul>
                                            <li class=""chat-back"">
                                                <a href=""#"">Back <i class=""fa fa-chevron-right ml5""></i> </a>
                                            </li>
                                            <li class=""no-messages"">
                                                <p class=""text-center color-red"">No messages are found</p>
     ");
            WriteLiteral(@"                                       </li>
                                        </ul>
                                    </div>
                                </li>
                            </ul>
                            <div id=""chat-write"">
                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7e83ec39074e0df0d76a002bcb93178e8a592f5e26405", async() => {
                WriteLiteral(@"
                                    <div class=""form-group mb5"">
                                        <textarea name=""writetext"" id=""chatwritearea"" rows=""3"" class=""form-control"" placeholder=""Type message ...""></textarea>
                                    </div>
                                    <!-- End .form-group  -->
                                    <div class=""form-group mb0"">
                                        <a href=""#"" class=""btn btn-link btn-sm p0 mr5 color-gray""><i class=""fa fa-picture-o""></i> </a>
                                        <a href=""#"" class=""btn btn-link btn-sm p0 color-gray""><i class=""fa fa-file""></i> </a>
                                        <a href=""#"" class=""btn btn-default btn-sm pull-right"">Send</a>
                                    </div>
                                    <!-- End .form-group  -->
                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <!-- End .rs tabs -->
        </div>
        <!-- End .sidebar-scrollarea -->
    </div>
    <!-- End .sidebar-inner -->
</aside>
<!-- End #right-sidebar -->");
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

#pragma checksum "C:\Users\nwisu\source\repos\UturuAbiaNews\UturuAbiaNews\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f773b0f95a67a63a245b54b467c4b9c320c695cb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "C:\Users\nwisu\source\repos\UturuAbiaNews\UturuAbiaNews\Views\_ViewImports.cshtml"
using UturuAbiaNews;

#line default
#line hidden
#line 2 "C:\Users\nwisu\source\repos\UturuAbiaNews\UturuAbiaNews\Views\_ViewImports.cshtml"
using UturuAbiaNews.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f773b0f95a67a63a245b54b467c4b9c320c695cb", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bf363aa339933f28a90e20a6179b67b609ac89f6", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<UturuAbiaNews.Controllers.HomeViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\nwisu\source\repos\UturuAbiaNews\UturuAbiaNews\Views\Home\Index.cshtml"
  
	ViewData["Title"] = "Home Page";
	int j = 0;
	

#line default
#line hidden
            BeginContext(106, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 23 "C:\Users\nwisu\source\repos\UturuAbiaNews\UturuAbiaNews\Views\Home\Index.cshtml"
 if (Model.Headlines.Count != 0)
{

#line default
#line hidden
            BeginContext(371, 181, true);
            WriteLiteral("<div class=\"col-md-8 no-padding\">\r\n\t<h3>Headlines</h3>\r\n\t<div id=\"myCarousel\" class=\"carousel slide\" data-ride=\"carousel\" data-interval=\"3000\">\r\n\t\t<ol class=\"carousel-indicators\">\r\n");
            EndContext();
#line 29 "C:\Users\nwisu\source\repos\UturuAbiaNews\UturuAbiaNews\Views\Home\Index.cshtml"
             for (int i = 0; i < Model.Headlines.Count; i++)
			{
				if (i == 2)
				{ break; }

#line default
#line hidden
            BeginContext(644, 49, true);
            WriteLiteral("\t\t\t\t<li data-target=\"#myCarousel\" data-slide-to=\"");
            EndContext();
            BeginContext(694, 1, false);
#line 33 "C:\Users\nwisu\source\repos\UturuAbiaNews\UturuAbiaNews\Views\Home\Index.cshtml"
                                                        Write(i);

#line default
#line hidden
            EndContext();
            BeginContext(695, 1, true);
            WriteLiteral("\"");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 696, "\"", 720, 1);
#line 33 "C:\Users\nwisu\source\repos\UturuAbiaNews\UturuAbiaNews\Views\Home\Index.cshtml"
WriteAttributeValue("", 704, ReturnActive(i), 704, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(721, 8, true);
            WriteLiteral("></li>\r\n");
            EndContext();
#line 34 "C:\Users\nwisu\source\repos\UturuAbiaNews\UturuAbiaNews\Views\Home\Index.cshtml"
				
			}

#line default
#line hidden
            BeginContext(741, 56, true);
            WriteLiteral("\t\t</ol>\r\n\t\t<div class=\"carousel-inner\" role=\"listbox\">\r\n");
            EndContext();
#line 38 "C:\Users\nwisu\source\repos\UturuAbiaNews\UturuAbiaNews\Views\Home\Index.cshtml"
             foreach (var item in Model.Headlines)
			{

#line default
#line hidden
            BeginContext(846, 8, true);
            WriteLiteral("\t\t\t\t<div");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 854, "\"", 877, 1);
#line 40 "C:\Users\nwisu\source\repos\UturuAbiaNews\UturuAbiaNews\Views\Home\Index.cshtml"
WriteAttributeValue("", 862, ReturnClass(j), 862, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(878, 12, true);
            WriteLiteral(">\r\n\t\t\t\t\t<img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 890, "\"", 910, 1);
#line 41 "C:\Users\nwisu\source\repos\UturuAbiaNews\UturuAbiaNews\Views\Home\Index.cshtml"
WriteAttributeValue("", 896, item.ImageUrl, 896, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 911, "\"", 935, 1);
#line 41 "C:\Users\nwisu\source\repos\UturuAbiaNews\UturuAbiaNews\Views\Home\Index.cshtml"
WriteAttributeValue("", 917, item.ContentTitle, 917, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(936, 112, true);
            WriteLiteral(" class=\"img-responsive carousel-image\" />\r\n\t\t\t\t\t<div class=\"carousel-caption\" role=\"option\">\r\n\t\t\t\t\t\t<p>\r\n\t\t\t\t\t\t\t");
            EndContext();
            BeginContext(1049, 21, false);
#line 44 "C:\Users\nwisu\source\repos\UturuAbiaNews\UturuAbiaNews\Views\Home\Index.cshtml"
                       Write(item.ShortDescription);

#line default
#line hidden
            EndContext();
            BeginContext(1070, 38, true);
            WriteLiteral("\r\n\r\n\t\t\t\t\t\t\t<a class=\"btn btn-default\" ");
            EndContext();
            BeginContext(1109, 55, false);
#line 46 "C:\Users\nwisu\source\repos\UturuAbiaNews\UturuAbiaNews\Views\Home\Index.cshtml"
                                                  Write(Url.Action("Details", "Contents", new { id = item.ID }));

#line default
#line hidden
            EndContext();
            BeginContext(1164, 73, true);
            WriteLiteral(">\r\n\t\t\t\t\t\t\t\tLearn More\r\n\t\t\t\t\t\t\t</a>\r\n\t\t\t\t\t\t</p>\r\n\t\t\t\t\t</div>\r\n\t\t\t\t</div>\r\n");
            EndContext();
#line 52 "C:\Users\nwisu\source\repos\UturuAbiaNews\UturuAbiaNews\Views\Home\Index.cshtml"
				j++;
				if (j == 2)
				{
					break;
				}
			}

#line default
#line hidden
            BeginContext(1297, 534, true);
            WriteLiteral(@"		</div>
		<a class=""left carousel-control"" href=""#myCarousel"" role=""button"" data-slide=""prev"">
			<span class=""glyphicon glyphicon-chevron-left"" aria-hidden=""true""></span>
			<span class=""sr-only"">Previous</span>
		</a>
		<a class=""right carousel-control"" href=""#myCarousel"" role=""button"" data-slide=""next"">
			<span class=""glyphicon glyphicon-chevron-right"" aria-hidden=""true""></span>
			<span class=""sr-only"">Next</span>
		</a>
	</div>
</div>
<div class=""col-md-4 add-padding-left-30-right-0"">
	<h3>Breaking News</h3>
");
            EndContext();
#line 71 "C:\Users\nwisu\source\repos\UturuAbiaNews\UturuAbiaNews\Views\Home\Index.cshtml"
     if (Model.Headlines.Count > 2)
	{
		foreach (var item in Model.Headlines.Skip(2))
		{

#line default
#line hidden
            BeginContext(1923, 56, true);
            WriteLiteral("\t\t\t<div class=\"col-md-12 margin-bottom-5  no-padding\">\r\n");
            EndContext();
#line 76 "C:\Users\nwisu\source\repos\UturuAbiaNews\UturuAbiaNews\Views\Home\Index.cshtml"
                  string url = item.ImageUrl;
					url = url.Replace('\\', '/');
				

#line default
#line hidden
            BeginContext(2057, 8, true);
            WriteLiteral("\t\t\t\t<div");
            EndContext();
            BeginWriteAttribute("style", " style=\"", 2065, "\"", 2184, 12);
            WriteAttributeValue("", 2073, "background-image:", 2073, 17, true);
            WriteAttributeValue(" ", 2090, "url(\'", 2091, 6, true);
#line 79 "C:\Users\nwisu\source\repos\UturuAbiaNews\UturuAbiaNews\Views\Home\Index.cshtml"
WriteAttributeValue("", 2096, url, 2096, 4, false);

#line default
#line hidden
            WriteAttributeValue("", 2100, "\');", 2100, 3, true);
            WriteAttributeValue(" ", 2103, "background-repeat:", 2104, 19, true);
            WriteAttributeValue(" ", 2122, "no-repeat;", 2123, 11, true);
            WriteAttributeValue(" ", 2133, "background-size:", 2134, 17, true);
            WriteAttributeValue(" ", 2150, "cover;", 2151, 7, true);
            WriteAttributeValue(" ", 2157, "width:", 2158, 7, true);
            WriteAttributeValue(" ", 2164, "100%;", 2165, 6, true);
            WriteAttributeValue(" ", 2170, "height:", 2171, 8, true);
            WriteAttributeValue(" ", 2178, "200px", 2179, 6, true);
            EndWriteAttribute();
            BeginContext(2185, 8, true);
            WriteLiteral(">\r\n\t\t\t\t\t");
            EndContext();
            BeginContext(2194, 83, false);
#line 80 "C:\Users\nwisu\source\repos\UturuAbiaNews\UturuAbiaNews\Views\Home\Index.cshtml"
               Write(Html.ActionLink(item.ShortDescription, "Details", "Contents", new { id = item.ID }));

#line default
#line hidden
            EndContext();
            BeginContext(2277, 45, true);
            WriteLiteral("\r\n\t\t\t\t\t\r\n\t\t\t\t\t\r\n\t\t\t\t</div>\r\n\t\t\t\t\r\n\t\t\t</div>\r\n");
            EndContext();
#line 86 "C:\Users\nwisu\source\repos\UturuAbiaNews\UturuAbiaNews\Views\Home\Index.cshtml"
		}
	}

#line default
#line hidden
            BeginContext(2331, 8, true);
            WriteLiteral("</div>\r\n");
            EndContext();
#line 89 "C:\Users\nwisu\source\repos\UturuAbiaNews\UturuAbiaNews\Views\Home\Index.cshtml"
	
}

#line default
#line hidden
            BeginContext(2345, 44, true);
            WriteLiteral("<div class=\"row\">\r\n\t<div class=\"col-md-8\">\r\n");
            EndContext();
#line 93 "C:\Users\nwisu\source\repos\UturuAbiaNews\UturuAbiaNews\Views\Home\Index.cshtml"
         foreach (var item in Model.Categories)
		{

#line default
#line hidden
            BeginContext(2437, 57, true);
            WriteLiteral("\t\t<div class=\"row\">\r\n\t\t\t<div class=\"col-md-12\">\r\n\t\t\t\t<h3>");
            EndContext();
            BeginContext(2495, 17, false);
#line 97 "C:\Users\nwisu\source\repos\UturuAbiaNews\UturuAbiaNews\Views\Home\Index.cshtml"
               Write(item.CategoryName);

#line default
#line hidden
            EndContext();
            BeginContext(2512, 7, true);
            WriteLiteral("</h3>\r\n");
            EndContext();
#line 98 "C:\Users\nwisu\source\repos\UturuAbiaNews\UturuAbiaNews\Views\Home\Index.cshtml"
                 foreach (var content in item.Contents)
				{

#line default
#line hidden
            BeginContext(2571, 64, true);
            WriteLiteral("\t\t\t\t<div class=\"col-md-6 clearfix no-padding standard-height\">\r\n");
            EndContext();
#line 101 "C:\Users\nwisu\source\repos\UturuAbiaNews\UturuAbiaNews\Views\Home\Index.cshtml"
                     if (!string.IsNullOrEmpty(content.ImageUrl))
					{

#line default
#line hidden
            BeginContext(2695, 9, true);
            WriteLiteral("\t\t\t\t\t<img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 2704, "\"", 2727, 1);
#line 103 "C:\Users\nwisu\source\repos\UturuAbiaNews\UturuAbiaNews\Views\Home\Index.cshtml"
WriteAttributeValue("", 2710, content.ImageUrl, 2710, 17, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2728, 43, true);
            WriteLiteral(" class=\"img-responsive content-images\" />\r\n");
            EndContext();
#line 104 "C:\Users\nwisu\source\repos\UturuAbiaNews\UturuAbiaNews\Views\Home\Index.cshtml"
					}

#line default
#line hidden
            BeginContext(2779, 8, true);
            WriteLiteral("\t\t\t\t\t<p>");
            EndContext();
            BeginContext(2788, 20, false);
#line 105 "C:\Users\nwisu\source\repos\UturuAbiaNews\UturuAbiaNews\Views\Home\Index.cshtml"
                  Write(content.ContentTitle);

#line default
#line hidden
            EndContext();
            BeginContext(2808, 11, true);
            WriteLiteral("</p>\r\n\t\t\t\t\t");
            EndContext();
            BeginContext(2820, 89, false);
#line 106 "C:\Users\nwisu\source\repos\UturuAbiaNews\UturuAbiaNews\Views\Home\Index.cshtml"
               Write(Html.ActionLink(content.ShortDescription, "Details", "Contents", new { id = content.ID }));

#line default
#line hidden
            EndContext();
            BeginContext(2909, 14, true);
            WriteLiteral("\r\n\t\t\t\t</div>\r\n");
            EndContext();
#line 108 "C:\Users\nwisu\source\repos\UturuAbiaNews\UturuAbiaNews\Views\Home\Index.cshtml"
					
				}

#line default
#line hidden
            BeginContext(2937, 26, true);
            WriteLiteral("\t\t\t</div>\r\n\t\t\t\r\n\t\t</div>\r\n");
            EndContext();
#line 113 "C:\Users\nwisu\source\repos\UturuAbiaNews\UturuAbiaNews\Views\Home\Index.cshtml"
			

		}

#line default
#line hidden
            BeginContext(2975, 20, true);
            WriteLiteral("\t</div>\r\n\t\r\n</div>\r\n");
            EndContext();
        }
        #pragma warning restore 1998
#line 8 "C:\Users\nwisu\source\repos\UturuAbiaNews\UturuAbiaNews\Views\Home\Index.cshtml"
           
	string ReturnClass(int i)
	{
		string result = (i == 0) ? "item active" : "item";
		return result;
	}

	string ReturnActive(int i)
	{
		if (i == 0) 
			return "active";
		return string.Empty;
	}


#line default
#line hidden
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<UturuAbiaNews.Controllers.HomeViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
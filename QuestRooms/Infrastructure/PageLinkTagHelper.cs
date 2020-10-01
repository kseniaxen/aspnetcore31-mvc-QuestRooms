using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;
using QuestRooms.Models.ViewModels;
using System.Collections.Generic;

namespace QuestRooms.Infrastructure
{
    [HtmlTargetElement("div", Attributes = "page-model")]
    public class PageLinkTagHelper : TagHelper
    {
        private IUrlHelperFactory urlHelperFactory;
        public PageLinkTagHelper(IUrlHelperFactory helperFactory)
        {
            urlHelperFactory = helperFactory;
        }
        [ViewContext]
        [HtmlAttributeNotBound]
        public ViewContext ViewContext { get; set; }
        public PagingInfo PageModel { get; set; }
        public string PageAction { get; set; }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            IUrlHelper urlHelper = urlHelperFactory.GetUrlHelper(ViewContext);

            TagBuilder result = new TagBuilder("nav");
            result.Attributes.Add(new KeyValuePair<string, string>("aria-label","Page navigation example"));
            TagBuilder ul = new TagBuilder("ul");
            ul.Attributes["class"] = "pagination justify-content-center";

            for (int i = 1; i <= PageModel.TotalPages; i++)
            {
                TagBuilder li = new TagBuilder("li");
                li.Attributes["class"] = "page-item";

                TagBuilder tag = new TagBuilder("a"); 
                tag.Attributes["class"] = "page-link";
                tag.Attributes["href"] = urlHelper.Action(PageAction, new { roomPage = i });
                tag.InnerHtml.Append(i.ToString());
                li.InnerHtml.AppendHtml(tag);
                ul.InnerHtml.AppendHtml(li);
            }
            result.InnerHtml.AppendHtml(ul);
            output.Content.AppendHtml(result.InnerHtml);
        }
    }
} 
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace a_1._0.Ders1.Extensions
{
    static class Extensions
    {
        public static IHtmlContent custumtextbox(this IHtmlHelper htmlHelper,string? name,string? value)
        {
           return htmlHelper.TextBox(name, value,new 
           {
               style="background-color:green;color:white;font-size:11px",
               @class="form-input",
               a="a",
               b="b"
           });
        }
    }
}

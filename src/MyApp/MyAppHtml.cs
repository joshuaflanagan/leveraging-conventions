using FubuMVC.UI;
using MyApp.Models;

namespace MyApp
{
    public class MyAppHtml : HtmlConventionRegistry
    {
		public MyAppHtml()
		{
			Editors.AddClassForAttribute<RequiredAttribute>("required");
            Editors.ModifyForAttribute<MaximumLengthAttribute>((tag, attr) => tag.Attr("maxlength", attr.Length));
		}
    }
}
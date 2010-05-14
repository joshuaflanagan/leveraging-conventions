using FubuMVC.UI;

namespace MyApp
{
    public class MyAppHtml : HtmlConventionRegistry
    {
        public MyAppHtml()
        {
            Editors.Always.Modify((field, tag) =>
            {
                var helpLink = new HelpLinkTag(field.Accessor.Name);
                tag.Next = helpLink;
            });
        }
    }
}
using HtmlTags;

namespace MyApp
{
    public class HelpLinkTag : LinkTag
    {
        public HelpLinkTag(string topic) : base("?", "#")
        {
            AddClass("helpLink");
            MetaData("helpTopic", topic);
        }
    }
}
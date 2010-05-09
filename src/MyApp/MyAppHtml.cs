using System;
using System.Text.RegularExpressions;
using FubuMVC.UI;

namespace MyApp
{
    public class MyAppHtml : HtmlConventionRegistry
    {
        public MyAppHtml()
        {
            Editors.Always.Modify((info, tag) => tag.Id(makeId(info.Accessor.Name)));
            Editors.IfPropertyIs<DateTime>().Modify(tag => tag.AddClass("date"));
        }

        private string makeId(string name)
        {
            return Regex.Replace(name, "([a-z])([A-Z])", "$1-$2").ToLower();
        }
    }
}
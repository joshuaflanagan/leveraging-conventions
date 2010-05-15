using System;
using System.Text.RegularExpressions;
using FubuMVC.UI;

namespace MyApp
{
    public class MyAppHtml : HtmlConventionRegistry
    {
        public MyAppHtml()
        {
            Editors.Always.Modify((field, tag) =>
            {
                tag.Id(makeId(field.Accessor.Name));
            });

            Editors.IfPropertyIs<DateTime>().Modify((field, tag) =>
            {
                tag.AddClass("date");
                if (field.Accessor.FieldName.EndsWith("Time"))
                {
                    tag.AddClass("time");
                }
            });
        }

        private string makeId(string name)
        {
            return Regex.Replace(name, "([a-z])([A-Z])", "$1-$2").ToLower();
        }
    }
}
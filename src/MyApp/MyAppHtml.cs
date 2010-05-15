using System;
using System.Text.RegularExpressions;
using FubuMVC.UI;
using MyApp.Models;

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

            Editors.Always.Modify((field, tag) =>
            {
                var helpLinkTag = new HelpLinkTag(field.Accessor.Name);
                tag.Next = helpLinkTag;
                
            });

            Editors.ModifyForAttribute<StringLengthAttribute>((tag, attr) => tag.Attr("maxlength", attr.Length));
            Editors.ModifyForAttribute<RequiredAttribute>(tag => tag.AddClass("required"));
        }

        private string makeId(string name)
        {
            return Regex.Replace(name, "([a-z])([A-Z])", "$1-$2").ToLower();
        }
    }
}
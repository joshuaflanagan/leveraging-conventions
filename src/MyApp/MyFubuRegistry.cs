using System.Text.RegularExpressions;
using FubuCore;
using FubuMVC.Core;
using FubuMVC.Core.View;
using HtmlTags;
using MyApp.Actions;
using FubuMVC.UI;

namespace MyApp
{
    public class MyFubuRegistry : FubuRegistry
    {
        public MyFubuRegistry()
        {
            IncludeDiagnostics(true);
            Applies.ToThisAssembly();
            Actions.IncludeTypes(type => type.Namespace == typeof(Home).Namespace).ExcludeTypes(type => type.CanBeCastTo<IFubuView>());

            Views.TryToAttach(view => view.by_ViewModel());
            HomeIs<Home>(x => x.Index());
            Routes.IgnoreControllerNamespaceEntirely().IgnoreControllerNamesEntirely();
            this.UseDefaultHtmlConventions();
            this.HtmlConvention<MyAppHtmlConventions>();
        }
    }

    public class MyAppHtmlConventions : HtmlConventionRegistry
    {
        public MyAppHtmlConventions()
        {
            Labels.Always.BuildBy(req => new HtmlTag("label").Text(breakUpCamelCase(req.Accessor.FieldName)));
        }

        private static string breakUpCamelCase(string fieldName)
        {
            return Regex.Replace(fieldName, "([a-z])([A-Z])", "$1 $2");
        }
    }
}
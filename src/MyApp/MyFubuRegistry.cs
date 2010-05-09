using FubuCore;
using FubuMVC.Core;
using FubuMVC.Core.View;
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
            this.HtmlConvention<MyAppHtml>();
        }
    }
}
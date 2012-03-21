using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Practices.Prism.UnityExtensions;
using Microsoft.Practices.Prism.Modularity;
using Shell.View;
using Microsoft.Practices.Unity;

namespace Shell
{
    public class Bootstrapper : UnityBootstrapper
    {
        protected override DependencyObject CreateShell()
        {
            this.Container.RegisterType<DependencyObject, ShellView>("ShellView");
            return this.Container.Resolve<ShellView>();
        }

        protected override void InitializeShell()
        {

            Application.Current.RootVisual = (UIElement)this.Shell;
        }

        protected override IModuleCatalog CreateModuleCatalog()
        {
            return Microsoft.Practices.Prism.Modularity.ModuleCatalog.CreateFromXaml(
            new Uri("/Shell;component/ModulesCatalog.xaml", UriKind.Relative));
        }
    }
}

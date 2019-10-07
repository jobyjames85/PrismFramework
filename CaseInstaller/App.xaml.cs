using System.Windows;
using CaseInstaller.View;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Unity;

namespace CaseInstaller
{
    public partial class App : PrismApplication
    {

        protected override Window CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {

        }

        ////protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog)
        ////{
        ////    moduleCatalog.AddModule<ModuleAModule>();
        ////}
    }
}

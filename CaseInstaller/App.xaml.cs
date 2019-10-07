using System.Windows;
using CaseInstaller.View;
using CaseInstaller.Views;
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
            containerRegistry.RegisterForNavigation<TrueManagementInstall>();
            containerRegistry.RegisterForNavigation<TrueManagementSetting>();
        }

        public void OnInitialized(IContainerProvider containerProvider)
        {

        }

        protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog)
        {
           
        }
    }
}

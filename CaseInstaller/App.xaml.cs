using System.Windows;
using CaseInstaller.Views;
using log4net;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Unity;
using MainWindow = CaseInstaller.Views.MainWindow;
using Prism.Logging;
using Prism.Services.Dialogs;

namespace CaseInstaller
{
    public partial class App : PrismApplication
    {
        
        protected override Window CreateShell()
        {
            return Container.Resolve<MainWindow>();    
           
        }

        public void OnInitialized(IContainerProvider containerProvider)
        {
           
            containerProvider.Resolve<CaseInstallerLogger>();
            containerProvider.Resolve<DialogueService>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<TrueManagementInstall>();
            containerRegistry.RegisterForNavigation<TrueManagementSetting>();
            containerRegistry.RegisterForNavigation<TrueManagementOptions>();
            containerRegistry.RegisterForNavigation<TrueManagementLegal>();
            containerRegistry.RegisterForNavigation<TrueManagementFinal>();  
        }
    
        protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog)
        {
            
        }

        private void PrismApplication_DispatcherUnhandledException(object sender, System.Windows.Threading.DispatcherUnhandledExceptionEventArgs e)
        {   
            e.Handled = true;
        }
        protected override void OnStartup(StartupEventArgs e)
        {
            log4net.Config.XmlConfigurator.Configure();
            base.OnStartup(e);
        }

        
    }
}

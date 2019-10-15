using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;
using System;
using Prism.Logging;
using System.Diagnostics;
using System.Windows.Input;
using System.IO;
using System.Windows;


namespace CaseInstaller.ViewModels
{
    public class MainWindowViewModel : CaseInstallerBase
    {
        private readonly IRegionManager regionManager;
        public CaseInstallerLogger loggerFacade;                   
        private string _title = "Prism Unity Application";

        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }
        
        public DelegateCommand<string> WindowLoadCommand { get; private set; }
        public DelegateCommand<string> CloseCommand { get; private set; }


        public MainWindowViewModel(IRegionManager regionManager,CaseInstallerLogger loggerFacade)
        {
            this.regionManager = regionManager;
            this.loggerFacade = loggerFacade ;    
            this.loggerFacade.Log("Debug",Category.Debug,Priority.High);
            this.WindowLoadCommand= new DelegateCommand<string>(Navigate);
            this.CloseCommand = new DelegateCommand<string>(PerformCloseAction);
        }
    
        string path = @"D:\DotNET\test";
        private void Navigate(string navigatePath)
        {
            if (!Directory.Exists(path))
            { 

                navigatePath = "TrueManagementInstall";
                if (navigatePath != null)
                {
                    this.regionManager.RequestNavigate("ContentRegion", navigatePath);
                    Directory.CreateDirectory(path);
                }
            }
            else
            {
                navigatePath = "TrueManagementSetting";
                if (navigatePath != null)
                {
                    this.regionManager.RequestNavigate("ContentRegion", navigatePath);
                }
            }
        }

        private void PerformCloseAction(object Parameter)
        {
            Application.Current.MainWindow.Close();
        }
    }
}





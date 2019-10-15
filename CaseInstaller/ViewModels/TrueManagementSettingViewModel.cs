using Prism.Commands;
using Prism.Regions;
using CaseInstaller;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace CaseInstaller.ViewModels
{
    class TrueManagementSettingViewModel : CaseInstallerBase
    {
        private readonly IRegionManager regionManager;
        private readonly DialogueService dialogservice;
        public DelegateCommand<string> ModifyCommand { get; private set; }
        public DelegateCommand GoForwardCommand { get; private set; }
        public DelegateCommand<string> UninstallCommand { get; private set; }


        public TrueManagementSettingViewModel(IRegionManager regionManager,DialogueService dialogService)
        {
            this.regionManager = regionManager;
            this.dialogservice = dialogService;
            this.ModifyCommand = new DelegateCommand<string>(Navigate);
            this.GoForwardCommand = new DelegateCommand(GoForward);
            this.UninstallCommand = new DelegateCommand<string>(uninstall);
        }

        private void Navigate(string navigatePath)
        {
            if (navigatePath != null)
            {
                this.regionManager.RequestNavigate("ContentRegion", navigatePath);
            }
        }


        string path = @"D:\DotNET\test";
        private void uninstall(string navigatePath)
        {
           
             if (Directory.Exists(path))
            {
                if (navigatePath != null)
                {
                    dialogservice.ShowMessage();
                    if (dialogservice.Confirm == true)
                    {
                        this.regionManager.RequestNavigate("ContentRegion", navigatePath);
                        Directory.Delete(path,true);
                    }
                    
                }
            }
        }
    }
}

using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prism.Logging;

namespace CaseInstaller.ViewModels
{
    public class TrueManagementInstallViewModel : CaseInstallerBase
    {
        private readonly IRegionManager regionManager;
        public DelegateCommand<string>InstallCommand { get; private set; }
        public TrueManagementInstallViewModel(IRegionManager regionManager)
        {
            this.regionManager = regionManager;
            this.InstallCommand = new DelegateCommand<string>(Navigate);
            
        }

        private void Navigate(string navigatePath)
        {          
                if (navigatePath != null)
                {
                    this.regionManager.RequestNavigate("ContentRegion", navigatePath);
                }    
        }

    }
}

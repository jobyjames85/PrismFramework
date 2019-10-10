using Prism.Commands;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseInstaller.ViewModels
{
    class TrueManagementSettingViewModel:CaseInstallerBase
    {
        private readonly IRegionManager regionManager;
        public DelegateCommand<string> ModifyCommand { get; private set; }
        public TrueManagementSettingViewModel(IRegionManager regionManager)
        {
            this.regionManager = regionManager;
            this.ModifyCommand = new DelegateCommand<string>(Navigate);

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

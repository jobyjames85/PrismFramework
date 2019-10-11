using Prism.Commands;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseInstaller.ViewModels
{
    class TrueManagementLegalViewModel:CaseInstallerBase
    {
        private readonly IRegionManager regionManager;

        public DelegateCommand GoBackCommand { get; private set; }

        public DelegateCommand<string> AcceptCommand { get; private set; }

        public TrueManagementLegalViewModel(IRegionManager regionManager)
        {
            this.regionManager = regionManager;
            this.GoBackCommand = new DelegateCommand(GoBack);
            this.AcceptCommand = new DelegateCommand<string>(Navigate);
        }

        public void Navigate(string navigatePath)
        {
            if (navigatePath != null)
            {
                this.regionManager.RequestNavigate("ContentRegion", navigatePath);
            }
        }
    }
}

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
        

        public CaseInstallerBase caseInstaller;

        public CaseInstallerLogger caseLogger;

        public new ILoggerFacade LoggerFacade
        {
            get

            {
                return caseLogger;

            }
        }

        public DelegateCommand GoBackCommand { get; set; }
        public TrueManagementInstallViewModel()
        {

            GoBackCommand = new DelegateCommand(GoBack);

        }

        

        private void GoBack()
        {
           _journal.GoBack();
        }
    }
}

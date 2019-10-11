using Prism.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace CaseInstaller.ViewModels
{
    class TrueManagementFinalViewModel:CaseInstallerBase
    {
        public DelegateCommand CloseCommand { get; private set; }

        TrueManagementFinalViewModel()
        {
            this.CloseCommand = new DelegateCommand(CloseAction);

        }

        public void CloseAction()
        {
            Application.Current.MainWindow.Close();
        }
    }
}

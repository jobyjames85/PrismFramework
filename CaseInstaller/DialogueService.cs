using Microsoft.Win32;
using Prism.Regions;
using Prism.Services.Dialogs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace CaseInstaller
{
    class DialogueService: IDialogService
    {

        public bool Confirm; 

        public void Show(string name, IDialogParameters parameters, Action<IDialogResult> callback)
        {
            throw new NotImplementedException();
        }

        public void ShowDialog(string name, IDialogParameters parameters, Action<IDialogResult> callback)
        {
            throw new NotImplementedException();
        }
        
        public void ShowMessage()
        {
            MessageBoxResult messageBoxResult = System.Windows.MessageBox.Show("Are you sure to uninstall?", "Uninstall Confirmation", System.Windows.MessageBoxButton.YesNo);
            if (messageBoxResult == MessageBoxResult.Yes)
            {
                Confirm = true;
            }
            else if (messageBoxResult == MessageBoxResult.No)
            {
                Confirm = false;
            }
        }
        
    }
}

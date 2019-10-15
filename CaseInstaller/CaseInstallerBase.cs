using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseInstaller
{
    public class CaseInstallerBase : BindableBase, INavigationAware
    {
        public IRegionNavigationJournal _journal;
        public IRegionManager _regionManager;
     
        public bool IsNavigationTarget(NavigationContext navigationContext)
        {
            return true;    
        }

        public void OnNavigatedFrom(NavigationContext navigationContext)
        {
            
           
        }
        public interface ICloseable
        {
            void Close();
        }

        public void OnNavigatedTo(NavigationContext navigationContext)
        {
            
            _journal = navigationContext.NavigationService.Journal;
            
        }

        public void GoBack()
        {
            if (_journal.CanGoBack)
            {
                _journal.GoBack();
            }
        }
        public void GoForward()
        {
            if (_journal.CanGoForward)
            {
                _journal.GoForward();
            }
        }

       public  bool CanGoBack { get; }
    }
}

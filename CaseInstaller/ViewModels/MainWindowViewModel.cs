using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;
using CaseInstaller.Views;
using System;
using Prism.Logging;

namespace CaseInstaller.ViewModels
{
    public class MainWindowViewModel : CaseInstallerBase
    {
        private readonly IRegionManager _regionManager;
        public CaseInstallerLogger caseLogger;

        private string _title = "Prism Unity Application";
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }
        public Prism.Logging.ILoggerFacade LoggerFacade
        {
            get

            {
                return caseLogger;

            }
        }

        public DelegateCommand<string> NavigateCommand { get; private set; }



        public MainWindowViewModel(IRegionManager regionManager)
        {
            _regionManager = regionManager;


            
            NavigateCommand = new DelegateCommand<string>(Navigate);

           
        }

        private void Navigate(string navigatePath)
        {
            
            if (navigatePath != null)
                
            _regionManager.RequestNavigate("ContentRegion",navigatePath);
        }

        
    }
}





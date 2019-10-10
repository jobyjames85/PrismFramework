using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;
using Microsoft.Extensions.Logging;
using Prism.Mvvm;
using Prism.Logging;


namespace CaseInstaller
{
   public class CaseInstallerLogger : ILoggerFacade
    {
        #region ILoggerFacade Members

         
        protected static readonly ILog log = LogManager.GetLogger(typeof(CaseInstallerLogger));

        public void Log(string message, Category category, Priority priority)
        {
            
            switch (category)
            {
                case Category.Debug:
                    log.Debug(message);
                    break;
                case Category.Warn:
                    log.Warn(message);
                    break;
                case Category.Exception:
                    log.Error(message);
                    break;
                case Category.Info:
                    log.Info(message);
                    break;
   
            }
        }
   }

}
        #endregion
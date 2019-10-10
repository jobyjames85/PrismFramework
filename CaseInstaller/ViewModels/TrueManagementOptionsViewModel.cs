using CaseInstaller.Models;
using Microsoft.Win32;
using Prism.Commands;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace CaseInstaller.ViewModels
{
    class TrueManagementOptionsViewModel:CaseInstallerBase 
    {
        private readonly IRegionManager regionManager;
        public OptionData optionData;


        public DelegateCommand<string> GoBackCommand { get; private set; }

        public DelegateCommand<string> MakeXml { get; private set; }

        private string trueurl;
        private string authorization;
        private string sqlserver;
        private string sqluser;
        private string sqlpassword;


        public TrueManagementOptionsViewModel()
        {
            this.MakeXml = new DelegateCommand<string>(createxml);
        }


        public string Authorization
        {
            get { return authorization; }
            set
            {
                SetProperty(ref authorization, value);
            }
        }

        public string TrueURL
        {
            get { return trueurl; }
            set
                 {
                    SetProperty(ref trueurl, value);
                 }
        }

        public string SQL_Server
        {
            get { return sqlserver; }
            set
            {
                SetProperty(ref sqlserver, value);
            }
        }

        public string SQL_User
        {
            get { return sqluser; }
            set
            {
                SetProperty(ref sqluser, value);
            }
        }

        public string SQL_Password
        {
            get { return sqlpassword; }
            set
            {
                SetProperty(ref sqlpassword, value);
            }
        }


        public void createxml(object serialiseData)
        {
            optionData = new OptionData();
            optionData.TrueCare_Url = this.TrueURL ;
            optionData.OAuth2_ClientID = this.Authorization;
            optionData.MSSQL_Server = this.SQL_Server;
            optionData.MSSQL_User = this.SQL_User;
            optionData.MSSQL_Password = this.SQL_Password;

            serialiseData = optionData;

            StringWriter sw = new StringWriter();
            XmlTextWriter tw = null;
            try
            {
                XmlSerializer serializer = new XmlSerializer(serialiseData.GetType());
                tw = new XmlTextWriter(sw);
                serializer.Serialize(tw, serialiseData);
            }
            finally
            {
                sw.Close();
                if (tw != null)
                {
                    tw.Close();
                }
                XmlDocument xdoc = new XmlDocument();
                xdoc.LoadXml(sw.ToString());
                xdoc.Save("D:\\DotNET\\test\\CaseInstaller.xml");
            }
           
            
        }


       
    }
}

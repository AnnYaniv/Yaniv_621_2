using System;
using System.Configuration;

namespace CarInterface
{
    // ToDo: #3 Class to read Config files. Create properties to allow and deny adding and removing
    public class ConfigReader
    {
        private static ConfigReader configReader; 
        private ConfigReader() 
        {
            
        }

        public static ConfigReader getInstance()
        {
            if (configReader == null) configReader = new ConfigReader();
            return configReader;
        }

        public bool AllowAddWithFK
        {
            get 
            {
                return Convert.ToBoolean(ConfigurationManager.AppSettings.Get("AllowAddWithFK")); ;
            }
            set
            {
                Configuration configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                KeyValueConfigurationCollection settings = configFile.AppSettings.Settings;

                settings["AllowAddWithFK"].Value = value.ToString();

                configFile.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection(configFile.AppSettings.SectionInformation.Name);
            }
        }
        
        public bool AllowDeleteWithFK //каскадне видалення
        {
            get
            {
                return Convert.ToBoolean(ConfigurationManager.AppSettings.Get("AllowDeleteWithFK"));
            }
            set
            {
                Configuration configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                KeyValueConfigurationCollection settings = configFile.AppSettings.Settings;

                settings["AllowDeleteWithFK"].Value = value.ToString();

                configFile.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection(configFile.AppSettings.SectionInformation.Name);
            }
        }

        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Virus_Studio
{
    class Configuration
    {
        lang userLanguage;

        public enum lang
        {
            english,
            español
        }

        public void read()
        {
            var configFile = File.ReadAllLines("config.bin");

            foreach(var line in configFile)
            {
                //Read language
                if (line.Contains("Lang: 1"))
                    userLanguage = lang.español;
                else if (line.Contains("Lang: 0"))
                    userLanguage = lang.english;
            }
        }

        public void setLanguage(lang language)
        {
            userLanguage = language;
        }
    }
}

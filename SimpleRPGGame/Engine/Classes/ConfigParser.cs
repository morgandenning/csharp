using System;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;

namespace Engine.Classes
{
    public class ConfigParser
    {
        string sConfigPath;
        string sDefaultIniName = "settings";
        string sDefaultSection = null;

        string sSection = null;

        [DllImport("kernel32")]
        static extern long WritePrivateProfileString(string Section, string Key, string Value, string FilePath);

        [DllImport("kernel32")]
        static extern int GetPrivateProfileString(string Section, string Key, string Default, StringBuilder RetVal, int Size, string FilePath);

        public ConfigParser(string ConfigPath = null, string Section = null, bool bThrowExceptionOnNotExists = false)
        {
            sSection = Section ?? sDefaultSection;
            sConfigPath = new FileInfo(ConfigPath ?? sDefaultIniName + ".ini").FullName.ToString();
            if (!File.Exists(sConfigPath) && bThrowExceptionOnNotExists)
            {
                throw new Exception("Does Not Exist");
            }
        }

        public string Read(string Key, string Section = null)
        {
            var RetVal = new StringBuilder(255);
            GetPrivateProfileString(Section ?? sSection, Key, "", RetVal, 255, sConfigPath);
            return RetVal.ToString();
        }

        public void Write(string Key, string Value, string Section = null)
        {
            WritePrivateProfileString(Section ?? sSection, Key, Value, sConfigPath);
        }

        public void DeleteKey(string Key, string Section = null)
        {
            Write(Key, null, Section ?? sSection);
        }
        public void DeleteSection(string Section = null)
        {
            Write(null, null, Section ?? sSection);
        }

        public bool KeyExists(string Key, string Section = null)
        {
            return Read(Key, Section).Length > 0;
        }
    }
}

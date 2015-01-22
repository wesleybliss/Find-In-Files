using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FindInFiles.Properties;

namespace FindInFiles {

    class SettingsHelper {

        private static string APP_DATA_NAME = "FindInFiles";

        // Keys for accessing properties array (System)
        public static string KEY_SNIPPER_LENGTH = "SnippetLength";

        // Default values for some settings
        public static int DEFAULT_SNIPPET_LENGTH = 10;

        public bool setSettingDefault( string key, int value ) {
            try {
                Settings.Default[key] = value;
                Settings.Default.Save();
                return true;
            }
            catch { return false; }
        }

        public bool setSettingDefault( string key, string value ) {
            try {
                Settings.Default[key] = value;
                Settings.Default.Save();
                return true;
            }
            catch { return false; }
        }

        public bool setSettingDefault( string key, bool value ) {
            try {
                Settings.Default[key] = value;
                Settings.Default.Save();
                return true;
            }
            catch { return false; }
        }

        public int getSettingDefault( string key, int fallback = 0 ) {
            try { return (int) Settings.Default[key]; }
            catch { return (int) fallback; }
        }

        public string getSettingDefault( string key, string fallback = "" ) {
            try { return (string) Settings.Default[key]; }
            catch { return (string) fallback; }
        }

        public bool getSettingDefault( string key, bool fallback = false ) {
            try { return (bool) Settings.Default[key]; }
            catch { return (bool) fallback; }
        }

    }

}

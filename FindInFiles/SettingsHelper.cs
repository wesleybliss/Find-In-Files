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
        public static string KEY_SNIPPET_LENGTH = "SnippetLength";
        public static string KEY_WINDOW_WIDTH = "WindowWidth";
        public static string KEY_WINDOW_HEIGHT = "WindowHeight";
        public static string KEY_WINDOW_POS_X = "WindowPosX";
        public static string KEY_WINDOW_POS_Y = "WindowPosY";
        public static string KEY_LAST_QUERY = "LastQuery";
        public static string KEY_REMEMBER_LAST_QUERY = "RememberLastQuery";
        public static string KEY_ANDROID_PROJECTS_DIRECTORY = "AndroidProjectsDirectory";

        // Default values for some settings
        public static int DEFAULT_SNIPPET_LENGTH = 10;
        public static int DEFAULT_WINDOW_WIDTH = 863;
        public static int DEFAULT_WINDOW_HEIGHT = 761;
        public static int DEFAULT_WINDOW_POS_X = 20;
        public static int DEFAULT_WINDOW_POS_Y = 20;
        public static string DEFAULT_LAST_QUERY = "";
        public static bool DEFAULT_REMEMBER_LAST_QUERY = true;
        public static string DEFAULT_ANDROID_PROJECTS_DIRECTORY = "";

        public static bool setSettingDefault( string key, int value ) {
            try {
                Settings.Default[key] = value;
                Settings.Default.Save();
                return true;
            }
            catch { return false; }
        }

        public static bool setSettingDefault( string key, string value ) {
            try {
                Settings.Default[key] = value;
                Settings.Default.Save();
                return true;
            }
            catch { return false; }
        }

        public static bool setSettingDefault( string key, bool value ) {
            try {
                Settings.Default[key] = value;
                Settings.Default.Save();
                return true;
            }
            catch { return false; }
        }

        public static int getSettingDefault( string key, int fallback = 0 ) {
            try { return (int) Settings.Default[key]; }
            catch { return (int) fallback; }
        }

        public static string getSettingDefault( string key, string fallback = "" ) {
            try { return (string) Settings.Default[key]; }
            catch { return (string) fallback; }
        }

        public static bool getSettingDefault( string key, bool fallback = false ) {
            try { return (bool) Settings.Default[key]; }
            catch { return (bool) fallback; }
        }

    }

}

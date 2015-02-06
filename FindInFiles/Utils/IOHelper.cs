using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace FindInFiles.Utils {

    class IOHelper {

        // @todo Move these to settings dialog
        public static readonly string ANDROID_STUDIO_TITLE = "Android Studio";
        public static readonly string ANDROID_STUDIO_EXECUTABLE =
            @"C:\Program Files\Android\Android Studio\bin\studio64.exe";

        [DllImport( "user32.dll" )]
        private static extern bool SetForegroundWindow( IntPtr hWnd );
        
        /// <summary>
        /// Gets a full file path from a path & filename, accounting for trailing slashes in the path.
        /// </summary>
        /// <param name="path">Path without filename</param>
        /// <param name="filename">Filename without path</param>
        /// <returns>Concatenated path + filename, with proper trailing slash in path.</returns>
        public static string getFullFilePath( string path, string filename ) {
            path = path.EndsWith( "\\" ) ? path : ( path + "\\" );
            return ( path + filename );
        }

        public static string getAndroidProjectPath( string path ) {

            string androidProjectsPath = SettingsHelper.getSettingDefault(
                SettingsHelper.KEY_ANDROID_PROJECTS_DIRECTORY, ""
            );

            // Make sure path is in Android projects directory
            if ( !path.ToUpper().StartsWith( androidProjectsPath.ToUpper() ) ) {
                return null;
            }

            // Remove projects directory
            path = path.Substring( androidProjectsPath.Length );

            // Remove leading space
            if ( path.StartsWith( "\\" ) ) {
                path = path.Substring( 1 );
            }

            // We should now have project dir + trailing dirs, e.g.
            // myproject\src\foo\bar\possibly_file_name.java

            // Edge case. Original path would have to be something like
            // \path\to\projects\myproject
            // in which case, we just return "myproject"
            if ( path.Contains( "\\" ) ) {
                // Grab just the first part of the directory, e.g.
                // myproject - from myproject\src\foo\etc.
                path = path.Substring( 0, path.IndexOf( "\\" ) );
            }

            return ( androidProjectsPath + "\\" + path );

        }

        /// <summary>
        /// Opens a file in an external application.
        /// </summary>
        /// <param name="executable">Path to app executable</param>
        /// <param name="path">Path of the file to open (without filename)</param>
        /// <param name="filename">Filename of file to open</param>
        /// <param name="preArgs">Arguments that come before the path</param>
        /// <param name="postArgs">Arguments that come after the filename</param>
        public static void openFileExternal( string executable, string path, string filename, string preArgs, string postArgs ) {

            preArgs = ( String.IsNullOrWhiteSpace( preArgs ) ) ? "" : ( preArgs + " " );
            postArgs = ( String.IsNullOrWhiteSpace( postArgs ) ) ? "" : ( "" + postArgs );

            ProcessStartInfo psi = new ProcessStartInfo();
            psi.FileName = executable;
            psi.Arguments = preArgs + "\"" + getFullFilePath( path, filename ) + "\"" + postArgs;

            Process.Start( psi );

        }

        /// <summary>
        /// Opens a file in Intellij, reusing an open editor if one exists with the same project path.
        /// </summary>
        /// <param name="path">Path to file (without filename)</param>
        /// <param name="filename">Filename of file to open</param>
        /// <param name="lineNumber">Optional line number to jump to</param>
        public static void openFileIntelliJ( string path, string filename, int lineNumber ) {

            string androidProjectsPath = SettingsHelper.getSettingDefault(
                SettingsHelper.KEY_ANDROID_PROJECTS_DIRECTORY, ""
            );

            if ( String.IsNullOrWhiteSpace( androidProjectsPath ) ) {
                return;
            }

            string line = ( lineNumber < 1 ) ?
                "" : ( " --line " + lineNumber.ToString() );

            openFileExternal(
                ANDROID_STUDIO_EXECUTABLE,
                path,
                filename,
                "\"" + getAndroidProjectPath( path ) + "\"" + line,
                ""
            );

        }

        /// <summary>
        /// Activates a window by it's title.
        /// 
        /// @todo Note this isn't really working with AS yet, not sure why.
        /// </summary>
        /// <param name="title">A partial title query to find the window.</param>
        public static void activateWindow( string title ) {
            Process[] processList = Process.GetProcesses();
            foreach ( Process proc in processList ) {
                Debug.WriteLine( proc.MainWindowTitle );
                if ( proc.MainWindowTitle.Contains( title ) ) {
                    SetForegroundWindow( proc.MainWindowHandle );
                }
            }
        }

    }

}

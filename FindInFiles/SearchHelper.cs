using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;

namespace FindInFiles {

    class SearchHelper {

        private static SettingsHelper settingsHelper = new SettingsHelper();

        /// <summary>
        /// Recursively searches a path for files matching a pattern
        /// </summary>
        /// <param name="path">Starting directory to search down into</param>
        /// <param name="pattern">File name filter (e.g. *.java)</param>
        /// <returns></returns>
        public static List<string> searchDirectories( string path, List<string> extensions ) {
            return Directory
                .GetFiles( path, "*.*", SearchOption.AllDirectories )
                .Where( file => extensions.Any( x => file.EndsWith( x ) ) )
                .ToList();
        }

        /// <summary>
        /// Searches for <paramref name="query"/> inside each file in <paramref name="files"/>
        /// </summary>
        /// <param name="files"></param>
        /// <param name="query"></param>
        /// <returns></returns>
        public static List<FileMatch> searchFiles( List<string> files, string query ) {
            List<FileMatch> matches = new List<FileMatch>();
            foreach ( string file in files ) {
                List<FileMatch> fms = searchFile( file, query );
                if ( fms != null ) {
                    foreach ( FileMatch fm in fms ) {
                        matches.Add( fm );
                    }
                }
            }
            return matches;
        }

        /// <summary>
        /// Searches within a file for <paramref name="query"/> text
        /// </summary>
        /// <param name="file"></param>
        /// <param name="query"></param>
        public static List<FileMatch> searchFile( string file, string query ) {

            List<FileMatch> localMatches = new List<FileMatch>();

            // Matches are all case insensitive
            // @todo Maybe add an option later in settings
            // @todo LinQ might be faster than manually looping here
            //      https://msdn.microsoft.com/en-us/library/dd383503(v=vs.110).aspx
            query = query.ToLower();
            int lineIndex = 1;

            foreach ( string line in File.ReadLines( file ) ) {

                if ( line.ToLower().Contains( query ) ) {

                    localMatches.Add( new FileMatch(
                        Path.GetFileNameWithoutExtension( file ),
                        lineIndex, line.IndexOf( query ), file,
                        getLineSample( line, query )
                    ) );

                }

                lineIndex++;

            }

            Debug.WriteLine( "Searched " + lineIndex + " lines in " + file );
            return localMatches;

        }

        /// <summary>
        /// Gets a sample of a line N chars before & after query, or to the end of the line.
        /// E.g., line = "The quick brown fox jumped over the lazy dog."
        /// Asserting: getLineSample( line, "brown fox" );
        /// Result: "The quick brown fox jumped ov"
        /// </summary>
        /// <param name="line"></param>
        /// <param name="query"></param>
        /// <returns></returns>
        public static string getLineSample( string line, string query ) {
            int snippetLength = settingsHelper.getSettingDefault(
                SettingsHelper.KEY_SNIPPET_LENGTH, 10
            );

            int x = line.IndexOf( query ) - snippetLength;
            int y = ( query.Length + ( snippetLength * 2 ) );
            if ( x < 0 ) x = 0;
            if ( ( x + y ) > line.Length - 1 ) y = ( line.Length - x );
            return line.Substring( x, y );
        }

        /// <summary>
        /// Groups a list of FileMatch objects by their filename.
        /// </summary>
        /// <param name="matches">A list of FileMatch objects.</param>
        /// <returns>The same input matches, but grouped by filename.</returns>
        public static Dictionary<string, List<FileMatch>> groupMatches( List<FileMatch> matches ) {
            
            Dictionary<string, List<FileMatch>> groups = new Dictionary<string, List<FileMatch>>();

            foreach ( FileMatch match in matches ) {

                List<FileMatch> groupList;

                // Add the group/key if it doesn't exist yet
                if ( !groups.ContainsKey( match.getName() ) ) {
                    groupList = new List<FileMatch>();
                    groups.Add( match.getName(), groupList );
                }
                else {
                    groupList = groups[match.getName()];
                }

                groupList.Add( match );

            }

            return groups;

        }

    } // class

}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Runtime.InteropServices;

/*
 * @todo
 * 
 *      Ability to cancel a running search
 * 
 * 
 */

namespace FindInFiles {

    public partial class MainForm : Form {

        // @todo Move these to settings dialog
        public static readonly string ANDROID_STUDIO_TITLE = "*Android Studio*";
        public static readonly string ANDROID_STUDIO_EXECUTABLE =
            @"C:\Program Files\Android\Android Studio\bin\studio64.exe";

        [DllImport( "user32.dll" )]
        private static extern bool SetForegroundWindow( IntPtr hWnd );

        private SettingsHelper settingsHelper;
        private List<FileMatch> matches;


        public MainForm() {
            InitializeComponent();
            settingsHelper = new SettingsHelper();
        }

        /// <summary>
        /// Retrieves relevant settings and performs any necessary pre-layout for the window.
        /// </summary>
        private void MainForm_Load( object sender, EventArgs e ) {

            // Set window size based on memory, if available

            int windowWidth = settingsHelper.getSettingDefault(
                SettingsHelper.KEY_WINDOW_WIDTH,
                SettingsHelper.DEFAULT_WINDOW_WIDTH
            );

            int windowHeight = settingsHelper.getSettingDefault(
                SettingsHelper.KEY_WINDOW_HEIGHT,
                SettingsHelper.DEFAULT_WINDOW_HEIGHT
            );

            this.Size = new Size( windowWidth, windowHeight );

            // Set window location based on memory, if available

            int windowPosX = settingsHelper.getSettingDefault(
                SettingsHelper.KEY_WINDOW_POS_X,
                SettingsHelper.DEFAULT_WINDOW_POS_X
            );

            int windowPosY = settingsHelper.getSettingDefault(
                SettingsHelper.KEY_WINDOW_POS_Y,
                SettingsHelper.DEFAULT_WINDOW_POS_Y
            );

            this.Location = new Point( windowPosX, windowPosY );

            // Set last query, if available
            bool showLastQuery = settingsHelper.getSettingDefault(
                SettingsHelper.KEY_REMEMBER_LAST_QUERY,
                SettingsHelper.DEFAULT_REMEMBER_LAST_QUERY
            );
            if ( showLastQuery ) {
                textQuery.Text = settingsHelper.getSettingDefault(
                    SettingsHelper.KEY_LAST_QUERY,
                    SettingsHelper.DEFAULT_LAST_QUERY
                );
            }

            this.ActiveControl = textQuery;

        }

        /// <summary>
        /// Handles button click to execute the search routine.
        /// </summary>
        private void buttonRun_Click( object sender, EventArgs e ) {

            List<string> files = SearchHelper
                .searchDirectories( textPath.Text, new List<string>() { ".java" } );

            listMatches.Items.Clear();

            if ( files == null || files.Count() < 1 ) {
                MessageBox.Show( "No files" );
                return;
            }

            List<FileMatch> matches = SearchHelper.searchFiles( files, textQuery.Text );
            if ( matches == null || matches.Count() < 1 ) {
                MessageBox.Show( "No matches" );
                return;
            }

            this.matches = matches;
            populateList();

        }

        /// <summary>
        /// Retrieves a match (FileMatch) at a specified index.
        /// Matches' indices correspond to the indices of the listbox.
        /// </summary>
        /// <param name="listIndex">The indice to look for.</param>
        /// <returns>Null if no match found at the specified indice.</returns>
        private FileMatch getMatchAt( int listIndex ) {
            if ( (listMatches.Items.Count - 1) < listIndex ) return null;
            return matches[listIndex];
        }

        /// <summary>
        /// Gets the match that corresponds to the current list view selected item.
        /// </summary>
        /// <returns>Null if nothing selected; else the corresponding match.</returns>
        private FileMatch getSelectedMatch() {
            return getMatchAt( listMatches.SelectedIndices[0] );
        }

        /// <summary>
        /// Gets a new item to add to a list view
        /// </summary>
        /// <param name="name">Match name</param>
        /// <param name="line">Match line</param>
        /// <param name="sample">Sample snippet from matched line</param>
        /// <returns></returns>
        private ListViewItem getNewListItem( string name, string line, string sample ) {
            ListViewItem listViewItem = new ListViewItem( name );
            listViewItem.SubItems.Add( line );
            listViewItem.SubItems.Add( sample );
            return listViewItem;
        }

        /// <summary>
        /// Populates the list view with matches
        /// </summary>
        private void populateList() {

            foreach ( FileMatch match in matches ) {
                listMatches.Items.Add(
                    getNewListItem(
                        match.getName(),
                        match.getLine().ToString(),
                        match.getSample()
                    )
                );
            }

        }

        /// <summary>
        /// If a list item is selected, opens the match file in the default editor (Android Studio).
        /// </summary>
        private void listMatches_DoubleClick( object sender, EventArgs e ) {

            if ( listMatches.SelectedItems.Count > 0 ) {

                FileMatch match = getSelectedMatch();

                if ( match == null ) {
                    return;
                }

                Process.Start(
                    ANDROID_STUDIO_EXECUTABLE, 
                    match.getPath()
                );

                activateWindow( ANDROID_STUDIO_TITLE );

            }

        }

        /// <summary>
        /// Activates a window by it's title.
        /// 
        /// @todo Note this isn't really working with AS yet, not sure why.
        /// </summary>
        /// <param name="title">A partial title query to find the window.</param>
        private void activateWindow( string title ) {
            var prc = Process.GetProcessesByName( title );
            if ( prc.Any() ) {
                SetForegroundWindow( prc.First().MainWindowHandle );
            }
        }

        /// <summary>
        /// Handles key events in the query text box.
        /// </summary>
        private void textQuery_KeyDown( object sender, KeyEventArgs e ) {
            if ( e.KeyCode.Equals( Keys.Enter ) ) {
                e.Handled = true;
                buttonRun_Click( null, null );
            }
        }

        /// <summary>
        /// Show the settings dialog when the menu is clicked.
        /// </summary>
        private void menuFileSettings_Click( object sender, EventArgs e ) {
            ( new SettingsForm() ).ShowDialog( this );
        }

        /// <summary>
        /// Exit the application when the menu is clicked.
        /// </summary>
        private void menuFileExit_Click( object sender, EventArgs e ) {
            Application.Exit();
        }

        /// <summary>
        /// Copies the full path of the match when the context menu is clicked.
        /// </summary>
        private void contextMenuListMatchesCopyFull_Click( object sender, EventArgs e ) {
            FileMatch match = getSelectedMatch();
            if ( match != null ) {
                Clipboard.Clear();
                Clipboard.SetText( match.getPath(), TextDataFormat.Text );
            }
        }

        /// <summary>
        /// Copies just the filename of the match when the context menu is clicked.
        /// </summary>
        private void contextMenuListMatchesCopyFilename_Click( object sender, EventArgs e ) {
            FileMatch match = getSelectedMatch();
            if ( match != null ) {
                Clipboard.Clear();
                Clipboard.SetText( match.getName(), TextDataFormat.Text );
            }
        }

        /// <summary>
        /// Allows limited filtering of results by letting the user exclude a particular
        /// file from the result set. The list is locked while updating.
        /// </summary>
        private void contextMenuListMatchesExcludeFile_Click( object sender, EventArgs e ) {

            FileMatch selectedMatch = getSelectedMatch();
            if ( selectedMatch == null ) {
                MessageBox.Show( "no sel match" );
                return;
            }

            matches.RemoveAll( x => x.getName().Equals( selectedMatch.getName() ) );

            listMatches.Items.Clear();
            populateList();

        }

        /// <summary>
        /// Captures the window closing event and saves any relevant settings before exiting.
        /// </summary>
        private void MainForm_FormClosing( object sender, FormClosingEventArgs e ) {

            // Save window size

            settingsHelper.setSettingDefault(
                SettingsHelper.KEY_WINDOW_WIDTH,
                this.Size.Width
            );

            settingsHelper.setSettingDefault(
                SettingsHelper.KEY_WINDOW_HEIGHT,
                this.Size.Height
            );

            // Save window location

            settingsHelper.setSettingDefault(
                SettingsHelper.KEY_WINDOW_POS_X,
                this.Location.X
            );

            settingsHelper.setSettingDefault(
                SettingsHelper.KEY_WINDOW_POS_Y,
                this.Location.Y
            );

        }


    } // class

}

﻿using System;
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
using FindInFiles.Utils;

/*
 * @todo
 * 
 *      Ability to cancel a running search
 * 
 * 
 */

namespace FindInFiles {

    public partial class MainForm : Form {

        private List<FileMatch> matches;
        private Dictionary<string, List<FileMatch>> groupedMatches;


        public MainForm() {
            InitializeComponent();
        }

        /// <summary>
        /// Retrieves relevant settings and performs any necessary pre-layout for the window.
        /// </summary>
        private void MainForm_Load( object sender, EventArgs e ) {

            // Set window size based on memory, if available

            int windowWidth = SettingsHelper.getSettingDefault(
                SettingsHelper.KEY_WINDOW_WIDTH,
                SettingsHelper.DEFAULT_WINDOW_WIDTH
            );

            int windowHeight = SettingsHelper.getSettingDefault(
                SettingsHelper.KEY_WINDOW_HEIGHT,
                SettingsHelper.DEFAULT_WINDOW_HEIGHT
            );

            this.Size = new Size( windowWidth, windowHeight );

            // Set window location based on memory, if available

            int windowPosX = SettingsHelper.getSettingDefault(
                SettingsHelper.KEY_WINDOW_POS_X,
                SettingsHelper.DEFAULT_WINDOW_POS_X
            );

            int windowPosY = SettingsHelper.getSettingDefault(
                SettingsHelper.KEY_WINDOW_POS_Y,
                SettingsHelper.DEFAULT_WINDOW_POS_Y
            );

            this.Location = new Point( windowPosX, windowPosY );

            // Set last query, if available
            bool showLastQuery = SettingsHelper.getSettingDefault(
                SettingsHelper.KEY_REMEMBER_LAST_QUERY,
                SettingsHelper.DEFAULT_REMEMBER_LAST_QUERY
            );
            if ( showLastQuery ) {
                // Set the last query text
                textQuery.Text = SettingsHelper.getSettingDefault(
                    SettingsHelper.KEY_LAST_QUERY,
                    SettingsHelper.DEFAULT_LAST_QUERY
                );
                // Automatically run the search
                if ( !String.IsNullOrWhiteSpace( textQuery.Text ) ) {
                    buttonRun_Click( null, null );
                }
            }

            this.ActiveControl = textQuery;

        }

        /// <summary>
        /// Handles button click to execute the search routine.
        /// </summary>
        private void buttonRun_Click( object sender, EventArgs e ) {
            labelStatus.Text = "Searching";
            listMatches.Items.Clear();
            backgroundWorkerSearch.RunWorkerAsync();
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

            foreach ( KeyValuePair<string, List<FileMatch>> group in groupedMatches ) {

                // Start by assuming this is a new group
                ListViewGroup currentGroup = null;

                // Check if the group already exists
                foreach ( ListViewGroup listGroup in listMatches.Groups ) {
                    if ( listGroup.Header.Equals( group.Key ) ) {
                        // Use the existing group
                        currentGroup = listGroup;
                        break;
                    }
                }

                if ( currentGroup == null ) {
                    currentGroup = new ListViewGroup( group.Key );
                    listMatches.Groups.Add( currentGroup );
                }

                foreach ( FileMatch match in group.Value ) {

                    ListViewItem lvi = getNewListItem(
                        match.getName(),
                        match.getLine().ToString(),
                        match.getSample()
                    );
                    lvi.Group = currentGroup;

                    listMatches.Items.Add( lvi );

                }

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

                IOHelper.openFileIntelliJ(
                    Path.GetDirectoryName( match.getPath() ), 
                    match.getName(),
                    match.getLine()
                );

                IOHelper.activateWindow( IOHelper.ANDROID_STUDIO_TITLE );

            }

        }

        /// <summary>
        /// Triggers the double-click action if an item is selected and the key is Enter.
        /// </summary>
        private void listMatches_KeyUp( object sender, KeyEventArgs e ) {
            if ( e.KeyCode.Equals( Keys.Enter ) && listMatches.SelectedIndices.Count > 0 ) {
                e.Handled = true;
                listMatches_DoubleClick( null, null );
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
            else if ( e.KeyCode.Equals( Keys.Down ) ) {
                e.Handled = true;
                if ( listMatches.Items.Count > 0 ) {
                    listMatches.SelectedIndices.Clear();
                    listMatches.SelectedIndices.Add( 0 );
                    this.ActiveControl = listMatches;
                }
            }
        }

        #region Menu Event Handlers
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
        #endregion

        /// <summary>
        /// Captures the window closing event and saves any relevant settings before exiting.
        /// </summary>
        private void MainForm_FormClosing( object sender, FormClosingEventArgs e ) {

            // Save window size

            SettingsHelper.setSettingDefault(
                SettingsHelper.KEY_WINDOW_WIDTH,
                this.Size.Width
            );

            SettingsHelper.setSettingDefault(
                SettingsHelper.KEY_WINDOW_HEIGHT,
                this.Size.Height
            );

            // Save window location

            SettingsHelper.setSettingDefault(
                SettingsHelper.KEY_WINDOW_POS_X,
                this.Location.X
            );

            SettingsHelper.setSettingDefault(
                SettingsHelper.KEY_WINDOW_POS_Y,
                this.Location.Y
            );

        }

        /// <summary>
        /// Allows the search to run in a background task
        /// so we don't lock the main UI thread
        /// </summary>
        private void backgroundWorkerSearch_DoWork( object sender, DoWorkEventArgs e ) {

            List<string> files = SearchHelper
                .searchDirectories( textPath.Text, new List<string>() { ".java" } );

            if ( files == null || files.Count() < 1 ) {
                MessageBox.Show( "No files" );
                return;
            }

            List<FileMatch> matches = e.Argument as List<FileMatch>;
            matches = SearchHelper.searchFiles( files, textQuery.Text );

            e.Result = matches;

        }

        /// <summary>
        /// @todo
        /// </summary>
        private void backgroundWorkerSearch_ProgressChanged( object sender, ProgressChangedEventArgs e ) {
            
        }

        /// <summary>
        /// Event that is fired when background search is complete
        /// </summary>
        private void backgroundWorkerSearch_RunWorkerCompleted( object sender, RunWorkerCompletedEventArgs e ) {

            List<FileMatch> matches = (List<FileMatch>) e.Result;

            if ( matches == null || matches.Count() < 1 ) {
                MessageBox.Show( "No matches" );
                return;
            }

            this.matches = matches;
            this.groupedMatches = SearchHelper.groupMatches( matches );

            labelStatus.Text = "Ready";

            populateList();

        }

    } // class

}

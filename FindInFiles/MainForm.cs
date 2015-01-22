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

        public static readonly string ANDROID_STUDIO_TITLE = "*Android Studio*";
        public static readonly string ANDROID_STUDIO_EXECUTABLE =
            @"C:\Program Files\Android\Android Studio\bin\studio64.exe";

        [DllImport( "user32.dll" )]
        private static extern bool SetForegroundWindow( IntPtr hWnd );

        private List<FileMatch> matches;


        public MainForm() {
            InitializeComponent();
        }

        private void MainForm_Load( object sender, EventArgs e ) {
            
        }

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

        private ListViewItem getNewListItem( string name, string line, string sample ) {
            ListViewItem listViewItem = new ListViewItem();
            listViewItem.SubItems.Add( name );
            listViewItem.SubItems.Add( line );
            listViewItem.SubItems.Add( sample );
            return listViewItem;
        }

        private void populateList() {

            foreach ( FileMatch match in matches ) {
                ListViewItem lvi = new ListViewItem( match.getName() );
                lvi.SubItems.Add( match.getOffset().ToString() );
                lvi.SubItems.Add( match.getSample() );
                listMatches.Items.Add( lvi );
            }

        }

        private void listMatches_DoubleClick( object sender, EventArgs e ) {
            if ( listMatches.SelectedItems.Count > 0 ) {
                Process.Start(
                    ANDROID_STUDIO_EXECUTABLE, 
                    matches[listMatches.SelectedIndices[0]].getPath()
                );
                activateWindow( ANDROID_STUDIO_TITLE );
            }
        }

        private void activateWindow( string title ) {
            var prc = Process.GetProcessesByName( title );
            if ( prc.Any() ) {
                SetForegroundWindow( prc.First().MainWindowHandle );
            }
        }

        private void textQuery_KeyDown( object sender, KeyEventArgs e ) {
            if ( e.KeyCode.Equals( Keys.Enter ) ) {
                e.Handled = true;
                buttonRun_Click( null, null );
            }
        }

        private void menuFileSettings_Click( object sender, EventArgs e ) {
            ( new SettingsForm() ).ShowDialog( this );
        }

        private void menuFileExit_Click( object sender, EventArgs e ) {
            Application.Exit();
        }

    } // class

}

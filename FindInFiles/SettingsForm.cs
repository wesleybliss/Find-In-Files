using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FindInFiles {

    public partial class SettingsForm : Form {

        private SettingsHelper settingsHelper;

        public SettingsForm() {
            InitializeComponent();
            settingsHelper = new SettingsHelper();
        }

        private void SettingsForm_Load( object sender, EventArgs e ) {

            textSnippetSize.Text = settingsHelper.getSettingDefault(
                SettingsHelper.KEY_SNIPPET_LENGTH, 10
            ).ToString();

            checkRememberLastQuery.Checked = settingsHelper.getSettingDefault(
                SettingsHelper.KEY_REMEMBER_LAST_QUERY, true
            );

            textAndroidProjectsDir.Text = settingsHelper.getSettingDefault(
                SettingsHelper.KEY_ANDROID_PROJECTS_DIRECTORY, ""
            );

        }

        private void buttonBrowsetextAndroidProjectsDir_Click( object sender, EventArgs e ) {
            
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.ShowDialog( this );

            if ( !String.IsNullOrWhiteSpace( fbd.SelectedPath ) ) {
                textAndroidProjectsDir.Text = fbd.SelectedPath;
            }

        }

        private void buttonSave_Click( object sender, EventArgs e ) {

            settingsHelper.setSettingDefault(
                SettingsHelper.KEY_SNIPPET_LENGTH,
                Int32.Parse( textSnippetSize.Text )
            );

            settingsHelper.setSettingDefault(
                SettingsHelper.KEY_REMEMBER_LAST_QUERY,
                checkRememberLastQuery.Checked
            );

            settingsHelper.setSettingDefault(
                SettingsHelper.KEY_ANDROID_PROJECTS_DIRECTORY,
                textAndroidProjectsDir.Text
            );

            this.Close();

        }

        

    }

}

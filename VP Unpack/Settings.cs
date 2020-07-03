using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VP_Unpack
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
            LoadSettings();
        }

        void LoadSettings()
        {
            vpPCDirO.Text = UserPaths.vpPCDirO;
            vpXBDirO.Text = UserPaths.vpXBDirO;
            vpTIPDirO.Text = UserPaths.vpTIPDirO;
            bkNBDirO.Text = UserPaths.bkNbDirO;
        }

        private void CloseSettings(object sender, EventArgs e)
        {
            Close();
        }

        private void ApplySettings(object sender, EventArgs e)
        {
            UserPaths.vpPCDirO = vpPCDirO.Text;
            UserPaths.vpXBDirO = vpXBDirO.Text;
            UserPaths.vpTIPDirO = vpTIPDirO.Text;
            UserPaths.bkNbDirO = bkNBDirO.Text;

            UserPrefs.Write();
            Close();
        }

        private void BrowseFolderDialog(object sender, EventArgs e)
        {
            var browseButton = sender as Button;
            FolderBrowserDialog folderBrowse = new FolderBrowserDialog();
            folderBrowse.ShowDialog();

            if (string.IsNullOrEmpty(folderBrowse.SelectedPath))
                return;

            switch (browseButton.Name)
            {
                case "button_VPPCO":
                    vpPCDirO.Text = folderBrowse.SelectedPath;
                    break;
                case "button_VPXBO":
                    vpXBDirO.Text = folderBrowse.SelectedPath;
                    break;
                case "button_VPTIPO":
                    vpTIPDirO.Text = folderBrowse.SelectedPath;
                    break;
                case "button_BKNBO":
                    bkNBDirO.Text = folderBrowse.SelectedPath;
                    break;
            }
        }
    }
}

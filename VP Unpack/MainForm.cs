using System;
using System.Windows.Forms;
using System.IO;
using System.Collections.Generic;
using System.IO.Compression;

namespace VP_Unpack
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            UserPrefs.Init();
        }

        private void OpenSettingsForm(object sender, EventArgs e)
        {
            Settings settings = new Settings();
            settings.ShowDialog();
        }

        private void menuItem_OpenPKG(object sender, EventArgs e)
        {
            OpenFileDialog dialog_OpenPKG = new OpenFileDialog();
            dialog_OpenPKG.ShowDialog();

            Pkg pkg = new Pkg();
            pkg.Init(dialog_OpenPKG.FileName);
        }
    }
}

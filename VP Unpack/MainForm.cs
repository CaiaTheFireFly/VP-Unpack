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

            //////Set Global form variables.
            VP_Unpack.Globals.mainForm = this;
            Globals.caffHeaderControl = new CaffHeaderControl();
            //////

            ResetForm();
            OutputConsole.SendMessage("Welcome to VP Unpack!");

            UserPrefs.Init();
        }

        private void OpenSettingsForm(object sender, EventArgs e)
        {
            Settings settings = new Settings();
            settings.ShowDialog();
        }

        private void OpenPKG(object sender, EventArgs e)
        {
            OpenFileDialog dialogUnpackPkg = new OpenFileDialog();
            DialogResult result = dialogUnpackPkg.ShowDialog();

            if (result == DialogResult.OK)
            {
                ResetForm();

                foreach (string pkgPath in dialogUnpackPkg.FileNames)
                {
                    if (Globals.currentPkg != null) { Globals.currentPkg.pkg.Dispose(); } //Makes sure that any previous Stream is closed.
                    Globals.currentPkg = new Pkg(pkgPath);
                }
            }
        }

        private void ExitProgram(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Resets the Form and Output Log (If the user has opted to clear log on new file opened).
        /// </summary>
        private void ResetForm()
        {
            Globals.mainForm.Text = "Viva Pinata Unpack";
            treeView.Nodes.Clear();
            filePathLabel.Text = null;

            if (Globals.clearLogCheck) { outputConsole.Text = "Welcome to VP Unpack!"; }

        }

        private void unpackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileStream vpltFile = new FileStream(Path.Combine(Path.Combine(System.Reflection.Assembly.GetExecutingAssembly().Location,
                ".."), "VPPC_LUT.vplt"), FileMode.Open);
            Globals.vpltMem = new MemoryStream();
            vpltFile.CopyTo(Globals.vpltMem);
            vpltFile.Dispose();
            Globals.vpltBR = new BinaryReader(Globals.vpltMem);

            OpenFileDialog dialogUnpackPkg = new OpenFileDialog();
            dialogUnpackPkg.Multiselect = true;
            DialogResult result = dialogUnpackPkg.ShowDialog();

            if (result == DialogResult.OK)
            {
                foreach (string pkgPath in dialogUnpackPkg.FileNames)
                {
                    Pkg pkg = new Pkg(pkgPath);
                }
            }

            Globals.vpltMem.Dispose();
        } //To be removed.

        private void dumpOffsetsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //    FileStream vpltFile = new FileStream(Path.Combine(Path.Combine(System.Reflection.Assembly.GetExecutingAssembly().Location,
            //        ".."), "VPPC_LUT.vplt"), FileMode.Open);
            //    Globals.vpltMem = new MemoryStream();
            //    vpltFile.CopyTo(Globals.vpltMem);
            //    vpltFile.Dispose();
            //    Globals.vpltBR = new BinaryReader(Globals.vpltMem);
            //    Globals.vpltBW = new BinaryWriter(Globals.vpltMem);

            //    OpenFileDialog dialogUnpackPkg = new OpenFileDialog();
            //    dialogUnpackPkg.Multiselect = true;
            //    DialogResult result = dialogUnpackPkg.ShowDialog();

            //    if (result == DialogResult.OK)
            //    {
            //        foreach (string pkgPath in dialogUnpackPkg.FileNames)
            //        {
            //            Pkg pkg = new Pkg(pkgPath);
            //        }
            //    }

            //    FileStream output = new FileStream(Path.Combine(Path.Combine(System.Reflection.Assembly.GetExecutingAssembly().Location,
            //        ".."), "VPPC_LUT.vplt.bak"), FileMode.Create);
            //    Globals.vpltMem.Seek(0, SeekOrigin.Begin);
            //    Globals.vpltMem.CopyTo(output);
            //    Globals.vpltMem.Dispose();
            //    Globals.vpltBW.Dispose();
            //    output.Dispose();
        } //To be removed.

        private void ClearLogCheck(object sender, EventArgs e)
        {
            (sender as ToolStripMenuItem).Checked = !(sender as ToolStripMenuItem).Checked;
            Globals.clearLogCheck = (sender as ToolStripMenuItem).Checked;
        } //Option to clear the output log between new file operations.

        /// <summary>
        /// Retrieves the main TreeView.
        /// </summary>
        /// <returns></returns>
        public TreeView GetTreeView()
        {
            return treeView;
        }

        /// <summary>
        /// Retrieves the main Panel.
        /// </summary>
        /// <returns></returns>
        public Panel GetMainPanel()
        {
            return mainSC.Panel2;
        }

        /// <summary>
        /// Sets the current filepath to a label.
        /// </summary>
        /// <param name="s">Input filepath.</param>
        public void SetFilePathLabelText(string s)
        {
            filePathLabel.Text = s;
        }

        private void TreeViewSelection(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node.Level == 0) //Make sure the Node selected is at the root level.
            {
                Globals.currentPkg.GetCaffHeaderInfo(e.Node.Index, e.Node); //Update the main Panel with the relevant selected Node index.
            }
        }
    }
}

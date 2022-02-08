using System;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Data;
using System.Windows.Forms;
using System.Collections.Generic;

namespace VP_Unpack
{

    public class Pkg
    {
        private string pkgPath;
        public string pkgName;
        public FileStream pkg;

        private BinaryReader pkgBR;

        private uint caffCount = 0;

        private PkgHeader[] pkgHeaderInfo;
        private CaffHeader[] caffHeaderInfo;

        private Caff[] caffs;

        public Pkg(string filePath)
        {
            pkgPath = filePath;
            pkgName = Path.GetFileName(filePath);
            OutputConsole.SendMessage($"Opening: {pkgPath}");
            pkg = new FileStream(pkgPath, FileMode.Open);
            pkgBR = new BinaryReader(pkg);

            ////Check file MD5.
            ////

            Globals.mainForm.SetFilePathLabelText(pkgPath);

            pkg.Seek(4, SeekOrigin.Begin);
            caffCount = pkgBR.ReadUInt32();

            pkgHeaderInfo = Headers.GeneratePkgHeaders(pkgBR, caffCount);
            UpdateTreeView();

            caffHeaderInfo = Headers.GenerateCaffHeaders(pkgBR, pkgHeaderInfo, caffCount);

            caffs = new Caff[caffCount];

            for (int i = 0; i < caffCount; i++)
            {
                caffs[i] = new Caff(pkgBR, caffHeaderInfo[i], pkgHeaderInfo[i].caffOffset, i);
            }
            UpdateMainPanel(0);
        }

        public void GetCaffHeaderInfo(int index, TreeNode node)
        {
            UpdateMainPanel(index);
        }

        private void UpdateTreeView()
        {
            int i = 0;
            foreach (PkgHeader hnfo in pkgHeaderInfo)
            {
                Globals.mainForm.GetTreeView().Nodes.Add($"Caff {i}");
                i++;
            }
        }

        private void UpdateMainPanel(int index)
        {
            if (!Globals.mainForm.GetMainPanel().Controls.Contains(Globals.caffHeaderControl))
            {
                Globals.mainForm.GetMainPanel().Controls.Add(Globals.caffHeaderControl);
            }
            else
            {
                if (!Globals.caffHeaderControl.Enabled)
                {
                    Globals.caffHeaderControl.Enabled = true;
                }
            }
            Globals.caffHeaderControl.UpdateInfo(pkgHeaderInfo[index], caffHeaderInfo[index], index);
        }
    }
}

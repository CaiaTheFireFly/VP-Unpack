using System;
using System.IO;
using System.IO.Compression;
using System.Xml.Linq;
using System.Linq;
using System.Security.Cryptography;
using System.Data;

namespace VP_Unpack
{
    public class Pkg
    {
        XDocument xml;
        XElement pkgRoot;
        XElement[] pkgStreams;

        FileStream openedPkg;
        string pkgPath;

        public void Init(string filePath)
        {
            pkgPath = filePath;
            openedPkg = new FileStream(pkgPath, FileMode.Open);

            FileStream xmlRaw = new FileStream(Path.Combine(Path.Combine(System.Reflection.Assembly.GetExecutingAssembly().Location,
                ".."), "VPPC_OFFSETS.xml"), FileMode.Open);
            xml = XDocument.Load(xmlRaw);
            xmlRaw.Dispose();
            pkgRoot = xml.Descendants().Where(x => (string)x.Attribute("Checksum") == GetMD5()).FirstOrDefault();
            pkgStreams = pkgRoot.Descendants("Stream").ToArray();

            openedPkg.Close();
            ProcessPkg();
        }

        void ProcessPkg()
        {
            string[] extension = { ".vref", ".vunk", ".vnfo", ".vdat" };

            string pkgFolder = Path.Combine(UserPaths.vpPCDirO, pkgRoot.Attribute("Name").Value);
            Directory.CreateDirectory(pkgFolder);
            string caffFolder = "You hecked up";

            int caffIndex = 0;
            int extensionIndex = 0;
            for (int i = 0; i < pkgStreams.Length; i++)
            {

                Directory.CreateDirectory(Path.Combine(pkgFolder, pkgRoot.Attribute("Name").Value + " Caff " + caffIndex));
                caffFolder = Path.Combine(pkgFolder, pkgRoot.Attribute("Name").Value + " Caff " + caffIndex);

                openedPkg = new FileStream(pkgPath, FileMode.Open);
                openedPkg.Seek(Convert.ToInt32(pkgStreams[i].Attribute("Offset").Value, 16) + 2, SeekOrigin.Begin);

                using (DeflateStream deflateStream = new DeflateStream(openedPkg, CompressionMode.Decompress))
                {
                    using (FileStream output = new FileStream(Path.Combine(caffFolder, pkgRoot.Attribute("Name").Value + " Caff " + caffIndex + extension[extensionIndex]),
                        FileMode.Create))
                    {
                        deflateStream.CopyTo(output);
                    }
                }
                extensionIndex++;
                if (extensionIndex == 4)
                {
                    extensionIndex = 0;
                }

                if (i != 0 & (i + 1) % 4 == 0)
                {
                    caffIndex++;
                }
            }
        }

        string GetMD5()
        {
            using (var md5 = MD5.Create())
            {
                string m = BitConverter.ToString(md5.ComputeHash(openedPkg)).Replace("-", string.Empty);
                openedPkg.Seek(0, SeekOrigin.Begin);
                return m;
            }
        }
    }
}

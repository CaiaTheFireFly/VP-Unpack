using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace VP_Unpack
{
    static class UserPaths
    {
        public static string vpPCDirO = "...";
        public static string vpXBDirO = "...";
        public static string vpTIPDirO = "...";
        public static string bkNbDirO = "...";
    }

    static class UserPrefs
    {
        static string appPath;
        static public FileStream userPrefs;

        static BinaryReader userPrefsBR;
        static BinaryWriter userPrefsBW;

        static public void Init()
        {
            appPath = Path.Combine(System.Reflection.Assembly.GetExecutingAssembly().Location, "..");
            userPrefs = new FileStream(Path.Combine(appPath, "userPrefs.bin"),
            FileMode.OpenOrCreate, FileAccess.ReadWrite);

            userPrefsBR = new BinaryReader(userPrefs);
            userPrefsBW = new BinaryWriter(userPrefs);
            ReadAll();
        }

        static public void ReadAll()
        {
            try
            {
                userPrefsBW.BaseStream.Seek(0, SeekOrigin.Begin);

                short pathLength;

                pathLength = userPrefsBR.ReadInt16();
                UserPaths.vpPCDirO = Denc(pathLength);
                pathLength = userPrefsBR.ReadInt16();
                UserPaths.vpXBDirO = Denc(pathLength);
                pathLength = userPrefsBR.ReadInt16();
                UserPaths.vpTIPDirO = Denc(pathLength);
                pathLength = userPrefsBR.ReadInt16();
                UserPaths.bkNbDirO = Denc(pathLength);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please set your game paths in Settings.\nException: " + ex.Message);
                Write();
            }
        }

        static public void Write()
        {
            userPrefsBW.BaseStream.Seek(0, SeekOrigin.Begin);

            userPrefsBW.Write((short)Enc(UserPaths.vpPCDirO).Length);
            userPrefsBW.Write(Enc(UserPaths.vpPCDirO));
            userPrefsBW.Write((short)Enc(UserPaths.vpXBDirO).Length);
            userPrefsBW.Write(Enc(UserPaths.vpXBDirO));
            userPrefsBW.Write((short)Enc(UserPaths.vpTIPDirO).Length);
            userPrefsBW.Write(Enc(UserPaths.vpTIPDirO));
            userPrefsBW.Write((short)Enc(UserPaths.bkNbDirO).Length);
            userPrefsBW.Write(Enc(UserPaths.bkNbDirO));
        }

        static byte[] Enc(string s)
        {
            return Encoding.ASCII.GetBytes(s);
        }

        static string Denc(short i)
        {
            return ASCIIEncoding.ASCII.GetString(userPrefsBR.ReadBytes(i));
        }
    }
}

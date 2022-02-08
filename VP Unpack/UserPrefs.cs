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

        /// <summary>
        /// Initialize the User Preferences, creating a new userPrefs.bin if none exist.
        /// </summary>
        static public void Init()
        {
            appPath = Path.Combine(System.Reflection.Assembly.GetExecutingAssembly().Location, ".."); //Get the current application path.
            userPrefs = new FileStream(Path.Combine(appPath, "userPrefs.bin"),
            FileMode.OpenOrCreate, FileAccess.ReadWrite);

            userPrefsBR = new BinaryReader(userPrefs);
            userPrefsBW = new BinaryWriter(userPrefs);
            ReadAll();
        }

        /// <summary>
        /// Reads the paths from userPrefs.bin.
        /// </summary>
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
                MessageBox.Show("Please set your game paths in Settings. (Ignore this for the moment).\nException: " + ex.Message); //Warning that userPrefs.bin is corrupted or needs to be filled.
                Write();
            }
        }

        /// <summary>
        /// Write paths to userPrefs.bin.
        /// </summary>
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
            return Encoding.ASCII.GetString(userPrefsBR.ReadBytes(i));
        }
    }
}

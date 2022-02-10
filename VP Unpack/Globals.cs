using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.IO;
using System.Security.Cryptography;
using System.Text.RegularExpressions;

namespace VP_Unpack
{
    public static class Globals
    {
        public static MainForm mainForm;
        public static CaffHeaderControl caffHeaderControl;

        public static Pkg currentPkg;

        //View options.
        public static bool clearLogCheck = false;

        ////To be removed.
        public static MemoryStream vpltMem;
        public static BinaryReader vpltBR;
        public static BinaryWriter vpltBW;
        ////

        public static int GetMD5Record(byte[] input)
        {
            vpltMem.Seek(32, SeekOrigin.Begin);

            for (int i = 0; i < 491; i++)
            {
                byte[] b = vpltBR.ReadBytes(16);

                if (b.SequenceEqual(input))
                {
                    return i;
                }
            }

            return -1;
        }//Unused for the moment.

        public static byte[] GenerateMD5(FileStream fileStream)
        {
            using (var md5 = MD5.Create())
            {
                byte[] result = md5.ComputeHash(fileStream);
                return result;
            }
        }//Unused for the moment.

        /// <summary>
        /// Copies a Stream for a set length.
        /// </summary>
        /// <param name="input">The Stream to be copied.</param>
        /// <param name="output">The output Stream.</param>
        /// <param name="bytes">Length of bytes to be copied.</param>
        public static void CopyStream(Stream input, Stream output, int bytes)
        {
            byte[] buffer = new byte[64*1024];
            int read;
            while (bytes > 0 && (read = input.Read(buffer, 0, Math.Min(buffer.Length, bytes))) > 0)
            {
                output.Write(buffer, 0, read);
                bytes -= read;
            }
            output.Seek(0, SeekOrigin.Begin);
        }

        /// <summary>
        /// Reads a string from a Stream from the current position, until a null byte is found.
        /// </summary>
        /// <param name="br">The input BinaryReader (Make sure to start from the beginning position of the string.</param>
        /// <returns>The output string.</returns>
        public static string ReadNullTerminatedString(BinaryReader br)
        {
            string str = "";
            char ch;
            while ((ch = br.ReadChar()) != 0)
            {
                str = str + ch;
            }
            return str;
        }

        /// <summary>
        /// Strips the date and other unneeded info from a chunk name.
        /// </summary>
        /// <param name="str">The string to be stripped.</param>
        /// <returns>The output string.</returns>
        public static string StripChunkName(string str)
        {
            Regex rx0 = new Regex(@",.*?(?=\()"); //Regex voodoo (Will expand on this when I remember how it works).
            Regex rx1 = new Regex(@",.*?$");
            if (rx0.IsMatch(str)) { return rx0.Replace(str, ""); }
            else { return rx1.Replace(str, ""); }
        }

        /// <summary>
        /// Hashes a chunk name using a PJW hashing function.
        /// </summary>
        /// <returns>The hashed name (in hex)</returns>
        public static string MakeFileNameHash() //Unused for the moment. Need clarification that this is actually used by the EXE in any way.
        {
            string str = "doctorclinicopen";
            byte[] b = Encoding.ASCII.GetBytes(str); //To byte array, length 24.

            uint output = 0;

            for (int i = 0; i < b.Length; i++)
            {
                output = 16 * output + (Convert.ToUInt32(b[i]) & 0xDF);

                uint hiBit = output & 0xF0000000;
                if (hiBit != 0) //Doesn't get hit, assume this is correct but I'd have to do it by hand to make sure.
                {
                    output ^= hiBit | (hiBit >> 24);
                }
            }

            return output.ToString("X8"); //1264...
        }

        /// <summary>
        /// Sorts Chunk names into the TreeView via a directory format.
        /// </summary>
        /// <param name="names">Chunk names to be sorted.</param>
        /// <param name="index">Index of CAFF file.</param>
        public static void SortTreeView(string[] names, int index) //Duplicate Chunk names are currently not considered.
        {
            foreach (string s in names)
            {
                string[] nameSplit = s.Split('_');
                TreeNode parentNode = mainForm.GetTreeView().Nodes[index];

                for (int i = 0; i < nameSplit.Length; i++)
                {
                    if (parentNode.Nodes.ContainsKey(nameSplit[i]))
                    {
                        parentNode = parentNode.Nodes[parentNode.Nodes.IndexOfKey(nameSplit[i])];
                    }
                    else
                    {
                        parentNode = parentNode.Nodes.Add(nameSplit[i], nameSplit[i]);
                    }
                }
            }
        }
    }
}

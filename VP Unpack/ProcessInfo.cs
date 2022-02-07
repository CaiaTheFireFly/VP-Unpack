using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace VP_Unpack
{
    class ProcessInfo
    {
        BinaryReader vindxBR;
        BinaryReader vdatBR;
        List<int> stringLengths = new List<int>();
        int stringBlockSize;
        List<string> strings = new List<string>();
        string[] test = { "aid_", "pool" };

        public void Init(MemoryStream[] vfileStruct)
        {
            vindxBR = new BinaryReader(vfileStruct[0]);
            vdatBR = new BinaryReader(vfileStruct[3]);
            GetStrings();
            GetModelData();
        } 

        void GetStrings()
        {
            vindxBR.BaseStream.Seek(77, SeekOrigin.Begin);
            stringBlockSize = BitConverter.ToInt32(vindxBR.ReadBytes(4), 0);

            vindxBR.ReadBytes(4);
            byte[] buffer;

            bool stringsFinished = false;
            while (!stringsFinished)
            {
                buffer = vindxBR.ReadBytes(4);
                
                if (!test.Any(Encoding.ASCII.GetString(buffer).Contains))
                {
                    Console.WriteLine(BitConverter.ToInt32(buffer, 0));
                    try
                    {
                        stringLengths.Add(BitConverter.ToInt32(buffer, 0));
                    }
                    catch
                    {
                        stringsFinished = true;
                    }
                }
                else
                {
                    stringsFinished = true;
                }
            }

            vindxBR.BaseStream.Seek(vindxBR.BaseStream.Position - 4, SeekOrigin.Begin);

            int previousLength = 0;
            foreach (int i in stringLengths)
            {
                buffer = vindxBR.ReadBytes(i - previousLength);
                strings.Add(Encoding.ASCII.GetString(buffer));
                previousLength = i;
            }
            buffer = vindxBR.ReadBytes(stringBlockSize - previousLength);
            strings.Add(Encoding.ASCII.GetString(buffer));
        }

        void GetModelData()
        {
            byte[] buffer;
            byte[] bufferHindsight = null;
            vindxBR.ReadBytes(4);

            for (int i = 0; i < strings.Count; i++)
            {
                buffer = vindxBR.ReadBytes(14);
                if (buffer.Length == 14)
                {
                    if (buffer[12] == 2)
                    {
                        Console.WriteLine("Found ref to vdat file @ " + (vindxBR.BaseStream.Position - 14));

                        if (BitConverter.ToInt32(bufferHindsight, 8) == 80)
                        {
                            vdatBR.BaseStream.Seek(BitConverter.ToInt32(buffer, 4) + 4, SeekOrigin.Begin);
                            MemoryStream asset = new MemoryStream(vdatBR.ReadBytes(BitConverter.ToInt32(buffer, 8)));

                            FileStream output = new FileStream(@"C:\Users\sunst\Desktop\output\" + i + ".dds", FileMode.Create);
                            asset.CopyTo(output);
                            output.Close();
                        }
                        i--;
                    }
                    else { bufferHindsight = buffer; }
                }
            }
        }
    }
}

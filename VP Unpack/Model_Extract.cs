using System;
using System.Windows.Forms;
using System.IO;
using System.Text;
using System.Collections.Generic;

namespace VP_Unpack
{
    class Model_Extract
    {
        int vOffset = 84288; //0
        int vLength = 369; //635
        int fOffset = 103488; //33024
        int fLength = 418; //960

        public void ExtractModel()
        {
            byte[] buffer;
            List<VCoord> vcoordSet = new List<VCoord>();
            List<UVCoord> uvCoordSet = new List<UVCoord>();
            List<FaceLoop> faceIDSet = new List<FaceLoop>();

            FileStream openedCaff = new FileStream(@"C:\\Users\\sunst\\Desktop\\VP\\Python\3 Dump\0000 dump\0003 decompressed",
                FileMode.Open, FileAccess.Read);
            FileStream testOBJ = new FileStream(@"C:\\Users\\sunst\\Desktop\\testOBJ.obj", FileMode.Create, FileAccess.Write);

            BinaryReader readerCaff = new BinaryReader(openedCaff);
            BinaryWriter writeOBJ = new BinaryWriter(testOBJ);

            readerCaff.BaseStream.Seek(vOffset, SeekOrigin.Begin);
            int i = 0;
            while (i < vLength)
            {
                vcoordSet.Add(new VCoord());
                uvCoordSet.Add(new UVCoord());

                buffer = readerCaff.ReadBytes(4);
                vcoordSet[i].x = buffer;
                buffer = readerCaff.ReadBytes(4);
                vcoordSet[i].z = buffer;
                buffer = readerCaff.ReadBytes(4);
                vcoordSet[i].y = buffer;

                readerCaff.ReadBytes(4 * 4); //6
                buffer = readerCaff.ReadBytes(4);
                uvCoordSet[i].x = buffer;
                buffer = readerCaff.ReadBytes(4);
                uvCoordSet[i].y = buffer;
                readerCaff.ReadBytes(4 * 4);
                i++;
            }

            byte b = 10;
            writeOBJ.Write(Encoding.ASCII.GetBytes("o VPObject"));
            writeOBJ.Write(b);

            foreach (VCoord vCoord in vcoordSet)
            {
                writeOBJ.Write(Encoding.ASCII.GetBytes("v "));
                writeOBJ.Write(Encoding.ASCII.GetBytes(BitConverter.ToSingle(vCoord.x, 0).ToString() + " "));
                writeOBJ.Write(Encoding.ASCII.GetBytes(BitConverter.ToSingle(vCoord.y, 0).ToString() + " "));
                writeOBJ.Write(Encoding.ASCII.GetBytes((BitConverter.ToSingle(vCoord.z, 0).ToString())));
                writeOBJ.Write(b);
            }

            foreach (UVCoord uvCoord in uvCoordSet)
            {
                writeOBJ.Write(Encoding.ASCII.GetBytes("vt "));
                writeOBJ.Write(Encoding.ASCII.GetBytes(BitConverter.ToSingle(uvCoord.x, 0).ToString() + " "));
                writeOBJ.Write(Encoding.ASCII.GetBytes(BitConverter.ToSingle(uvCoord.y, 0).ToString()));
                writeOBJ.Write(b);
            }

            readerCaff.BaseStream.Seek(fOffset, SeekOrigin.Begin);

            int w = 0;
            int bufferInt;
            while (w < fLength)
            {
                faceIDSet.Add(new FaceLoop());
                bufferInt = readerCaff.ReadUInt16();
                faceIDSet[w].a = bufferInt;
                bufferInt = readerCaff.ReadUInt16();
                faceIDSet[w].b = bufferInt;
                bufferInt = readerCaff.ReadUInt16();
                faceIDSet[w].c = bufferInt;
                w++;
            }


            foreach (FaceLoop faceID in faceIDSet)
            {
                writeOBJ.Write(Encoding.ASCII.GetBytes("f "));
                writeOBJ.Write(Encoding.ASCII.GetBytes((faceID.a + 1).ToString() + "/"));
                writeOBJ.Write(Encoding.ASCII.GetBytes((faceID.a + 1).ToString() + "/1 "));

                writeOBJ.Write(Encoding.ASCII.GetBytes((faceID.b + 1).ToString() + "/"));
                writeOBJ.Write(Encoding.ASCII.GetBytes((faceID.b + 1).ToString() + "/1 "));

                writeOBJ.Write(Encoding.ASCII.GetBytes((faceID.c + 1).ToString() + "/"));
                writeOBJ.Write(Encoding.ASCII.GetBytes((faceID.c + 1).ToString() + "/1"));

                writeOBJ.Write(b);
            }
        }
    }

    class VCoord
    {
        public byte[] x;
        public byte[] y;
        public byte[] z;
    }

    class UVCoord
    {
        public byte[] x;
        public byte[] y;
    }

    class FaceLoop
    {
        public int a;
        public int b;
        public int c;
    }
}

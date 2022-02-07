using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace VP_Unpack
{
    public static class Headers
    {
        public static PkgHeader[] GeneratePkgHeaders(BinaryReader br, uint count)
        {
            br.BaseStream.Seek(8, SeekOrigin.Begin);

            PkgHeader[] header = new PkgHeader[count];

            for (int i = 0; i < count; i++)
            {
                header[i] = new PkgHeader();

                header[i].unk0 = br.ReadUInt32();
                header[i].caffOffset = br.ReadUInt32();
                header[i].caffSize = br.ReadUInt32();
            }

            return header;
        }

        public static CaffHeader[] GenerateCaffHeaders(BinaryReader br, PkgHeader[] pkgHeader, uint count)
        {
            CaffHeader[] headers = new CaffHeader[count];

            for (int i = 0; i < count; i++)
            {
                headers[i] = new CaffHeader();

                br.BaseStream.Seek(pkgHeader[i].caffOffset, SeekOrigin.Begin);

                headers[i].magic = br.ReadBytes(4);
                headers[i].version = br.ReadBytes(13).ToString();
                br.ReadBytes(3);
                headers[i].stream0Offset = br.ReadUInt32();
                headers[i].unk0 = br.ReadBytes(4);
                headers[i].chunkCount = br.ReadUInt32();
                headers[i].chunkSpreadCount = br.ReadUInt32();
                headers[i].unk1 = br.ReadBytes(44);
                headers[i].stream0UncSize = br.ReadUInt32();
                headers[i].unk2 = br.ReadBytes(12);
                headers[i].stream0CSize = br.ReadUInt32();
                headers[i].stream1UncSize = br.ReadUInt32();
                headers[i].unk2 = br.ReadBytes(12);
                headers[i].stream1CSize = br.ReadUInt32();
            }
            return headers;
        }
    }

    public class PkgHeader
    {
        public uint unk0; //Checksum?
        public uint caffOffset;
        public uint caffSize;
    }

    public class CaffHeader
    {
        public byte[] magic;
        public string version;
        public uint stream0Offset;
        public byte[] unk0; //Checksum?
        public uint chunkCount;
        public uint chunkSpreadCount;
        public byte[] unk1; //44.
        public uint stream0UncSize;
        public byte[] unk2; //12.
        public uint stream0CSize;
        public uint stream1UncSize;
        public byte[] unk3; //12;
        public uint stream1CSize;
        //
        public uint stream2UncSize;
        public uint stream2CSize;
        public uint stream3UncSize;
        public uint stream3CSize;
    }

    public struct RefHeader
    {
        public byte[] unk0;
        public byte[] unk1; //File identification?
                            //Pad 1 byte.
        public uint streamUncSize;
        //Pad 16 bytes.
        public uint streamCSize;
        public string extension;

    }

    public static class StreamType
    {
        public static readonly byte[] data = { 02, 00, 00, 00 };
        public static readonly byte[] gpu = { 05, 01, 00, 00 };
        public static readonly byte[] stream = { 0xC, 00, 00, 00 };
    }
}

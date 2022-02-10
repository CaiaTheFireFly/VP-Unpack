using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.IO.Compression;

namespace VP_Unpack
{
    public class Caff
    {
        private CaffHeader m_header;
        private int m_index;
        private MemoryStream[] streams = new MemoryStream[4];
        private RefHeader[] refHeaders;
        private string[] chunkNames;

        public Caff(BinaryReader br, CaffHeader header, uint caffOffset, int index)
        {
            m_header = header;
            m_index = index;
            br.BaseStream.Seek(m_header.stream0Offset + caffOffset, SeekOrigin.Begin);

            streams[0] = new MemoryStream();

            if (m_header.stream0CSize != m_header.stream0UncSize)
            {
                MemoryStream tempStream = new MemoryStream();
                Globals.CopyStream(br.BaseStream, tempStream, (int)m_header.stream0CSize);

                tempStream.Seek(2, SeekOrigin.Begin);
                using (DeflateStream deflateStream = new DeflateStream(tempStream, CompressionMode.Decompress))
                {
                    deflateStream.CopyTo(streams[0]);
                    deflateStream.Dispose();
                }
            }

            GetChunkStrings();
        }

        private void GetChunkStrings()
        {
            chunkNames = new string[m_header.chunkCount];

            BinaryReader streamBr = new BinaryReader(streams[0]);

            streams[0].Seek(37, SeekOrigin.Begin);
            byte[] streamCheck = streamBr.ReadBytes(4);
            if (streamCheck.SequenceEqual(StreamType.data) | streamCheck.SequenceEqual(StreamType.gpu) | streamCheck.SequenceEqual(StreamType.stream))
            {
                refHeaders = new RefHeader[2];
                OutputConsole.SendMessage("2");
            }
            else
            {
                refHeaders = new RefHeader[1];
                OutputConsole.SendMessage("1");
            }

            streams[0].Seek(0, SeekOrigin.Begin);
            for (int i = 0; i < refHeaders.Length; i++)
            {
                streamBr.ReadBytes(9);
                refHeaders[i].streamUncSize = streamBr.ReadUInt32();
                streamBr.ReadBytes(16);
                refHeaders[i].streamCSize = streamBr.ReadUInt32();
            }
            m_header.stream2CSize = refHeaders[0].streamCSize;
            m_header.stream2UncSize = refHeaders[0].streamUncSize;
            if (refHeaders.Length > 1)
            {
                m_header.stream3CSize = refHeaders[1].streamCSize;
                m_header.stream3UncSize = refHeaders[1].streamUncSize;
            }
            for (int i = 0; i < refHeaders.Length; i++) { refHeaders[i].extension = Globals.ReadNullTerminatedString(streamBr); }

            streams[0].Seek((int)m_header.chunkCount * 4 + 4, SeekOrigin.Current);
            for (int i = 0; i < m_header.chunkCount; i++)
            {
                chunkNames[i] = Globals.ReadNullTerminatedString(streamBr);
                chunkNames[i] = Globals.StripChunkName(chunkNames[i]);
            }
            Globals.SortTreeView(chunkNames, m_index);
        }
    }
}
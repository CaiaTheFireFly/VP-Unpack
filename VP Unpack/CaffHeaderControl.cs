using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VP_Unpack
{
    public partial class CaffHeaderControl : UserControl
    {
        private Label[] streamOffsets = new Label[4];
        private Label[] streamSizes = new Label[4];

        public CaffHeaderControl()
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
        }

        public void UpdateInfo(PkgHeader pkgHeader, CaffHeader caffHeader, int index)
        {
            CaffName.Text = $"Caff {index}";

            CaffSize.Text = $"Size(bytes): {pkgHeader.caffSize}";
            CaffOffset.Text = $"Offset(h): {pkgHeader.caffOffset}";

            DataChunkCount.Text = $".DATA chunk count: {caffHeader.chunkCount}";
            GpuChunkCount.Text = $".GPU chunk count: {caffHeader.chunkSpreadCount - caffHeader.chunkCount}";

            //for (int i = 0; i < 4; i++)
            //{
            //    streamOffsets[i].Text = $"{i} offset(h): {caffHeader.stream0Offset}";
            //    streamSizes[i].Text = $"0 size(bytes) - Compressed: {caffHeader.stream0CSize} -> Uncompressed: {caffHeader.stream0UncSize}";
            //}
            Stream0Offset.Text = $"0 offset(h): {caffHeader.stream0Offset}";
            Stream0Size.Text = $"0 size(bytes) - Compressed: {caffHeader.stream0CSize} -> Uncompressed: {caffHeader.stream0UncSize}";

            Stream1Offset.Text = $"1 offset(h): {caffHeader.stream0Offset + caffHeader.stream0CSize + pkgHeader.caffOffset}";
            Stream1Size.Text = $"1 size(bytes) - Compressed: {caffHeader.stream1CSize} -> Uncompressed: {caffHeader.stream1UncSize}";

            Stream2Size.Text = $"2 size(bytes) - Compressed: {caffHeader.stream2CSize} -> Uncompressed: {caffHeader.stream2UncSize}";

            Stream3Size.Text = $"3 size(bytes) - Compressed: {caffHeader.stream3CSize} -> Uncompressed: {caffHeader.stream3UncSize}";
        }
    }
}

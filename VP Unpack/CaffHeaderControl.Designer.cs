
namespace VP_Unpack
{
    partial class CaffHeaderControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CaffName = new System.Windows.Forms.Label();
            this.DataChunkCount = new System.Windows.Forms.Label();
            this.GpuChunkCount = new System.Windows.Forms.Label();
            this.CaffSize = new System.Windows.Forms.Label();
            this.Stream0Offset = new System.Windows.Forms.Label();
            this.StreamGroupBox = new System.Windows.Forms.GroupBox();
            this.Stream3Size = new System.Windows.Forms.Label();
            this.Stream3Offset = new System.Windows.Forms.Label();
            this.Stream2Size = new System.Windows.Forms.Label();
            this.Stream2Offset = new System.Windows.Forms.Label();
            this.Stream1Size = new System.Windows.Forms.Label();
            this.Stream1Offset = new System.Windows.Forms.Label();
            this.Stream0Size = new System.Windows.Forms.Label();
            this.CaffOffset = new System.Windows.Forms.Label();
            this.CaffInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.StreamGroupBox.SuspendLayout();
            this.CaffInfoGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // CaffName
            // 
            this.CaffName.AutoSize = true;
            this.CaffName.Dock = System.Windows.Forms.DockStyle.Top;
            this.CaffName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CaffName.Location = new System.Drawing.Point(0, 0);
            this.CaffName.Name = "CaffName";
            this.CaffName.Size = new System.Drawing.Size(130, 29);
            this.CaffName.TabIndex = 2;
            this.CaffName.Text = "Caff name";
            // 
            // DataChunkCount
            // 
            this.DataChunkCount.AutoSize = true;
            this.DataChunkCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataChunkCount.Location = new System.Drawing.Point(6, 78);
            this.DataChunkCount.Name = "DataChunkCount";
            this.DataChunkCount.Size = new System.Drawing.Size(162, 17);
            this.DataChunkCount.TabIndex = 3;
            this.DataChunkCount.Text = ".DATA chunk count: 126";
            // 
            // GpuChunkCount
            // 
            this.GpuChunkCount.AutoSize = true;
            this.GpuChunkCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GpuChunkCount.Location = new System.Drawing.Point(6, 104);
            this.GpuChunkCount.Name = "GpuChunkCount";
            this.GpuChunkCount.Size = new System.Drawing.Size(155, 17);
            this.GpuChunkCount.TabIndex = 4;
            this.GpuChunkCount.Text = ".GPU chunk count: 129";
            // 
            // CaffSize
            // 
            this.CaffSize.AutoSize = true;
            this.CaffSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CaffSize.Location = new System.Drawing.Point(6, 25);
            this.CaffSize.Name = "CaffSize";
            this.CaffSize.Size = new System.Drawing.Size(119, 17);
            this.CaffSize.TabIndex = 5;
            this.CaffSize.Text = "Size(bytes): 9999";
            // 
            // Stream0Offset
            // 
            this.Stream0Offset.AutoSize = true;
            this.Stream0Offset.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Stream0Offset.Location = new System.Drawing.Point(6, 18);
            this.Stream0Offset.Name = "Stream0Offset";
            this.Stream0Offset.Size = new System.Drawing.Size(118, 17);
            this.Stream0Offset.TabIndex = 7;
            this.Stream0Offset.Text = "0 offset(h) - 99a9";
            // 
            // StreamGroupBox
            // 
            this.StreamGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StreamGroupBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.StreamGroupBox.Controls.Add(this.Stream3Size);
            this.StreamGroupBox.Controls.Add(this.Stream3Offset);
            this.StreamGroupBox.Controls.Add(this.Stream2Size);
            this.StreamGroupBox.Controls.Add(this.Stream2Offset);
            this.StreamGroupBox.Controls.Add(this.Stream1Size);
            this.StreamGroupBox.Controls.Add(this.Stream1Offset);
            this.StreamGroupBox.Controls.Add(this.Stream0Size);
            this.StreamGroupBox.Controls.Add(this.Stream0Offset);
            this.StreamGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StreamGroupBox.Location = new System.Drawing.Point(0, 167);
            this.StreamGroupBox.Name = "StreamGroupBox";
            this.StreamGroupBox.Size = new System.Drawing.Size(791, 185);
            this.StreamGroupBox.TabIndex = 8;
            this.StreamGroupBox.TabStop = false;
            this.StreamGroupBox.Text = "Streams";
            // 
            // Stream3Size
            // 
            this.Stream3Size.AutoSize = true;
            this.Stream3Size.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Stream3Size.Location = new System.Drawing.Point(6, 164);
            this.Stream3Size.Name = "Stream3Size";
            this.Stream3Size.Size = new System.Drawing.Size(338, 17);
            this.Stream3Size.TabIndex = 14;
            this.Stream3Size.Text = "0 size(h) - Compressed: 99a9. Uncompressed: 99a9";
            // 
            // Stream3Offset
            // 
            this.Stream3Offset.AutoSize = true;
            this.Stream3Offset.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Stream3Offset.Location = new System.Drawing.Point(6, 147);
            this.Stream3Offset.Name = "Stream3Offset";
            this.Stream3Offset.Size = new System.Drawing.Size(118, 17);
            this.Stream3Offset.TabIndex = 13;
            this.Stream3Offset.Text = "0 offset(h) - 99a9";
            // 
            // Stream2Size
            // 
            this.Stream2Size.AutoSize = true;
            this.Stream2Size.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Stream2Size.Location = new System.Drawing.Point(6, 121);
            this.Stream2Size.Name = "Stream2Size";
            this.Stream2Size.Size = new System.Drawing.Size(338, 17);
            this.Stream2Size.TabIndex = 12;
            this.Stream2Size.Text = "0 size(h) - Compressed: 99a9. Uncompressed: 99a9";
            // 
            // Stream2Offset
            // 
            this.Stream2Offset.AutoSize = true;
            this.Stream2Offset.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Stream2Offset.Location = new System.Drawing.Point(6, 104);
            this.Stream2Offset.Name = "Stream2Offset";
            this.Stream2Offset.Size = new System.Drawing.Size(118, 17);
            this.Stream2Offset.TabIndex = 11;
            this.Stream2Offset.Text = "0 offset(h) - 99a9";
            // 
            // Stream1Size
            // 
            this.Stream1Size.AutoSize = true;
            this.Stream1Size.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Stream1Size.Location = new System.Drawing.Point(6, 78);
            this.Stream1Size.Name = "Stream1Size";
            this.Stream1Size.Size = new System.Drawing.Size(338, 17);
            this.Stream1Size.TabIndex = 10;
            this.Stream1Size.Text = "0 size(h) - Compressed: 99a9. Uncompressed: 99a9";
            // 
            // Stream1Offset
            // 
            this.Stream1Offset.AutoSize = true;
            this.Stream1Offset.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Stream1Offset.Location = new System.Drawing.Point(6, 61);
            this.Stream1Offset.Name = "Stream1Offset";
            this.Stream1Offset.Size = new System.Drawing.Size(118, 17);
            this.Stream1Offset.TabIndex = 9;
            this.Stream1Offset.Text = "1 offset(h) - 99a9";
            // 
            // Stream0Size
            // 
            this.Stream0Size.AutoSize = true;
            this.Stream0Size.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Stream0Size.Location = new System.Drawing.Point(6, 35);
            this.Stream0Size.Name = "Stream0Size";
            this.Stream0Size.Size = new System.Drawing.Size(338, 17);
            this.Stream0Size.TabIndex = 8;
            this.Stream0Size.Text = "0 size(h) - Compressed: 99a9. Uncompressed: 99a9";
            // 
            // CaffOffset
            // 
            this.CaffOffset.AutoSize = true;
            this.CaffOffset.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CaffOffset.Location = new System.Drawing.Point(6, 52);
            this.CaffOffset.Name = "CaffOffset";
            this.CaffOffset.Size = new System.Drawing.Size(104, 17);
            this.CaffOffset.TabIndex = 9;
            this.CaffOffset.Text = "Offset(h): 9a99";
            // 
            // CaffInfoGroupBox
            // 
            this.CaffInfoGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CaffInfoGroupBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CaffInfoGroupBox.Controls.Add(this.CaffOffset);
            this.CaffInfoGroupBox.Controls.Add(this.DataChunkCount);
            this.CaffInfoGroupBox.Controls.Add(this.GpuChunkCount);
            this.CaffInfoGroupBox.Controls.Add(this.CaffSize);
            this.CaffInfoGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CaffInfoGroupBox.Location = new System.Drawing.Point(0, 29);
            this.CaffInfoGroupBox.Name = "CaffInfoGroupBox";
            this.CaffInfoGroupBox.Size = new System.Drawing.Size(791, 130);
            this.CaffInfoGroupBox.TabIndex = 10;
            this.CaffInfoGroupBox.TabStop = false;
            this.CaffInfoGroupBox.Text = "Info";
            // 
            // CaffHeaderControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CaffInfoGroupBox);
            this.Controls.Add(this.StreamGroupBox);
            this.Controls.Add(this.CaffName);
            this.Name = "CaffHeaderControl";
            this.Size = new System.Drawing.Size(791, 352);
            this.StreamGroupBox.ResumeLayout(false);
            this.StreamGroupBox.PerformLayout();
            this.CaffInfoGroupBox.ResumeLayout(false);
            this.CaffInfoGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label CaffName;
        public System.Windows.Forms.Label CaffSize;
        public System.Windows.Forms.Label DataChunkCount;
        public System.Windows.Forms.Label GpuChunkCount;
        public System.Windows.Forms.Label Stream0Offset;
        private System.Windows.Forms.GroupBox StreamGroupBox;
        public System.Windows.Forms.Label Stream3Size;
        public System.Windows.Forms.Label Stream3Offset;
        public System.Windows.Forms.Label Stream2Size;
        public System.Windows.Forms.Label Stream2Offset;
        public System.Windows.Forms.Label Stream1Size;
        public System.Windows.Forms.Label Stream1Offset;
        public System.Windows.Forms.Label Stream0Size;
        public System.Windows.Forms.Label CaffOffset;
        private System.Windows.Forms.GroupBox CaffInfoGroupBox;
    }
}

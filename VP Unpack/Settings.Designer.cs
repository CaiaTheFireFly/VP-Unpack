namespace VP_Unpack
{
    partial class Settings
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.vpXBDirO = new System.Windows.Forms.TextBox();
            this.vpPCDirO = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button_VPPCO = new System.Windows.Forms.Button();
            this.button_VPXBO = new System.Windows.Forms.Button();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.button_Apply = new System.Windows.Forms.Button();
            this.vpTIPDirO = new System.Windows.Forms.TextBox();
            this.bkNBDirO = new System.Windows.Forms.TextBox();
            this.button_BKNBO = new System.Windows.Forms.Button();
            this.button_VPTIPO = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Games";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Viva Pinata (PC)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Viva Pinata (Xbox)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Viva Pinata: TiP";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 241);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(211, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Banjo Kazooie : Nuts & Bolts";
            this.label5.UseMnemonic = false;
            // 
            // vpXBDirO
            // 
            this.vpXBDirO.Enabled = false;
            this.vpXBDirO.Location = new System.Drawing.Point(234, 135);
            this.vpXBDirO.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.vpXBDirO.Name = "vpXBDirO";
            this.vpXBDirO.Size = new System.Drawing.Size(490, 26);
            this.vpXBDirO.TabIndex = 6;
            // 
            // vpPCDirO
            // 
            this.vpPCDirO.Location = new System.Drawing.Point(234, 68);
            this.vpPCDirO.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.vpPCDirO.Name = "vpPCDirO";
            this.vpPCDirO.Size = new System.Drawing.Size(490, 26);
            this.vpPCDirO.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(231, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Paths";
            // 
            // button_VPPCO
            // 
            this.button_VPPCO.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button_VPPCO.Location = new System.Drawing.Point(727, 68);
            this.button_VPPCO.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_VPPCO.Name = "button_VPPCO";
            this.button_VPPCO.Size = new System.Drawing.Size(36, 30);
            this.button_VPPCO.TabIndex = 12;
            this.button_VPPCO.Text = "...";
            this.button_VPPCO.UseVisualStyleBackColor = true;
            this.button_VPPCO.Click += new System.EventHandler(this.BrowseFolderDialog);
            // 
            // button_VPXBO
            // 
            this.button_VPXBO.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button_VPXBO.Enabled = false;
            this.button_VPXBO.Location = new System.Drawing.Point(727, 135);
            this.button_VPXBO.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_VPXBO.Name = "button_VPXBO";
            this.button_VPXBO.Size = new System.Drawing.Size(36, 30);
            this.button_VPXBO.TabIndex = 14;
            this.button_VPXBO.Text = "...";
            this.button_VPXBO.UseVisualStyleBackColor = true;
            this.button_VPXBO.Click += new System.EventHandler(this.BrowseFolderDialog);
            // 
            // button_Cancel
            // 
            this.button_Cancel.Location = new System.Drawing.Point(755, 310);
            this.button_Cancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(84, 36);
            this.button_Cancel.TabIndex = 19;
            this.button_Cancel.Text = "Cancel";
            this.button_Cancel.UseVisualStyleBackColor = true;
            this.button_Cancel.Click += new System.EventHandler(this.CloseSettings);
            // 
            // button_Apply
            // 
            this.button_Apply.Location = new System.Drawing.Point(664, 310);
            this.button_Apply.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_Apply.Name = "button_Apply";
            this.button_Apply.Size = new System.Drawing.Size(84, 36);
            this.button_Apply.TabIndex = 20;
            this.button_Apply.Text = "Apply";
            this.button_Apply.UseVisualStyleBackColor = true;
            this.button_Apply.Click += new System.EventHandler(this.ApplySettings);
            // 
            // vpTIPDirO
            // 
            this.vpTIPDirO.Enabled = false;
            this.vpTIPDirO.Location = new System.Drawing.Point(234, 204);
            this.vpTIPDirO.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.vpTIPDirO.Name = "vpTIPDirO";
            this.vpTIPDirO.Size = new System.Drawing.Size(490, 26);
            this.vpTIPDirO.TabIndex = 23;
            // 
            // bkNBDirO
            // 
            this.bkNBDirO.Enabled = false;
            this.bkNBDirO.Location = new System.Drawing.Point(234, 271);
            this.bkNBDirO.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bkNBDirO.Name = "bkNBDirO";
            this.bkNBDirO.Size = new System.Drawing.Size(490, 26);
            this.bkNBDirO.TabIndex = 21;
            // 
            // button_BKNBO
            // 
            this.button_BKNBO.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button_BKNBO.Enabled = false;
            this.button_BKNBO.Location = new System.Drawing.Point(727, 271);
            this.button_BKNBO.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_BKNBO.Name = "button_BKNBO";
            this.button_BKNBO.Size = new System.Drawing.Size(36, 30);
            this.button_BKNBO.TabIndex = 28;
            this.button_BKNBO.Text = "...";
            this.button_BKNBO.UseVisualStyleBackColor = true;
            this.button_BKNBO.Click += new System.EventHandler(this.BrowseFolderDialog);
            // 
            // button_VPTIPO
            // 
            this.button_VPTIPO.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button_VPTIPO.Enabled = false;
            this.button_VPTIPO.Location = new System.Drawing.Point(727, 204);
            this.button_VPTIPO.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_VPTIPO.Name = "button_VPTIPO";
            this.button_VPTIPO.Size = new System.Drawing.Size(36, 30);
            this.button_VPTIPO.TabIndex = 26;
            this.button_VPTIPO.Text = "...";
            this.button_VPTIPO.UseVisualStyleBackColor = true;
            this.button_VPTIPO.Click += new System.EventHandler(this.BrowseFolderDialog);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 70);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 20);
            this.label8.TabIndex = 29;
            this.label8.Text = "Output";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(26, 139);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 20);
            this.label9.TabIndex = 30;
            this.label9.Text = "Output";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(26, 276);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 20);
            this.label10.TabIndex = 32;
            this.label10.Text = "Output";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(26, 208);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 20);
            this.label11.TabIndex = 31;
            this.label11.Text = "Output";
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 354);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button_BKNBO);
            this.Controls.Add(this.button_VPTIPO);
            this.Controls.Add(this.vpTIPDirO);
            this.Controls.Add(this.bkNBDirO);
            this.Controls.Add(this.button_Apply);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.button_VPXBO);
            this.Controls.Add(this.button_VPPCO);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.vpPCDirO);
            this.Controls.Add(this.vpXBDirO);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Settings";
            this.Text = "Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;

        private System.Windows.Forms.TextBox vpPCDirO;
        private System.Windows.Forms.TextBox vpXBDirO;
        private System.Windows.Forms.TextBox vpTIPDirO;
        private System.Windows.Forms.TextBox bkNBDirO;
        private System.Windows.Forms.Button button_VPPCO;
        private System.Windows.Forms.Button button_VPXBO;
        private System.Windows.Forms.Button button_VPTIPO;
        private System.Windows.Forms.Button button_BKNBO;

        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.Button button_Apply;
    }
}
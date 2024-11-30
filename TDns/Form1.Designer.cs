namespace TDns
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Pic_Dns = new PictureBox();
            Lbl_Dnsname = new Label();
            btnSet = new Button();
            btnUnset = new Button();
            Cmx_Dns = new ComboBox();
            pds1 = new TextBox();
            pds2 = new TextBox();
            pds3 = new TextBox();
            pds4 = new TextBox();
            ads1 = new TextBox();
            ads2 = new TextBox();
            ads3 = new TextBox();
            ads4 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)Pic_Dns).BeginInit();
            SuspendLayout();
            // 
            // Pic_Dns
            // 
            Pic_Dns.Location = new Point(12, 12);
            Pic_Dns.Margin = new Padding(3, 4, 3, 4);
            Pic_Dns.Name = "Pic_Dns";
            Pic_Dns.Size = new Size(48, 48);
            Pic_Dns.SizeMode = PictureBoxSizeMode.StretchImage;
            Pic_Dns.TabIndex = 2;
            Pic_Dns.TabStop = false;
            // 
            // Lbl_Dnsname
            // 
            Lbl_Dnsname.Font = new Font("Proxima Soft", 16.1999989F, FontStyle.Bold, GraphicsUnit.Point);
            Lbl_Dnsname.Location = new Point(66, 12);
            Lbl_Dnsname.Margin = new Padding(0);
            Lbl_Dnsname.Name = "Lbl_Dnsname";
            Lbl_Dnsname.Size = new Size(162, 48);
            Lbl_Dnsname.TabIndex = 3;
            Lbl_Dnsname.Text = "403";
            Lbl_Dnsname.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnSet
            // 
            btnSet.Font = new Font("Proxima Soft", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnSet.Location = new Point(12, 188);
            btnSet.Margin = new Padding(3, 4, 3, 4);
            btnSet.Name = "btnSet";
            btnSet.Size = new Size(102, 36);
            btnSet.TabIndex = 4;
            btnSet.Text = "Set";
            btnSet.UseVisualStyleBackColor = true;
            btnSet.Click += BtnSet_Click;
            // 
            // btnUnset
            // 
            btnUnset.Font = new Font("Proxima Soft", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnUnset.Location = new Point(120, 188);
            btnUnset.Margin = new Padding(3, 4, 3, 4);
            btnUnset.Name = "btnUnset";
            btnUnset.Size = new Size(108, 36);
            btnUnset.TabIndex = 4;
            btnUnset.Text = "Reset";
            btnUnset.UseVisualStyleBackColor = true;
            btnUnset.Click += BtnUnset_Click;
            // 
            // Cmx_Dns
            // 
            Cmx_Dns.DropDownStyle = ComboBoxStyle.DropDownList;
            Cmx_Dns.Font = new Font("Proxima Soft SemiBold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            Cmx_Dns.FormattingEnabled = true;
            Cmx_Dns.Location = new Point(12, 149);
            Cmx_Dns.Name = "Cmx_Dns";
            Cmx_Dns.Size = new Size(216, 34);
            Cmx_Dns.TabIndex = 5;
            Cmx_Dns.SelectedIndexChanged += CmxDnses_SelectedIndexChanged;
            // 
            // pds1
            // 
            pds1.Font = new Font("Microsoft JhengHei", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            pds1.Location = new Point(12, 67);
            pds1.MaxLength = 3;
            pds1.Name = "pds1";
            pds1.ReadOnly = true;
            pds1.Size = new Size(48, 38);
            pds1.TabIndex = 6;
            pds1.TextAlign = HorizontalAlignment.Center;
            // 
            // pds2
            // 
            pds2.Font = new Font("Microsoft JhengHei", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            pds2.Location = new Point(67, 67);
            pds2.MaxLength = 3;
            pds2.Name = "pds2";
            pds2.ReadOnly = true;
            pds2.Size = new Size(48, 38);
            pds2.TabIndex = 6;
            pds2.TextAlign = HorizontalAlignment.Center;
            // 
            // pds3
            // 
            pds3.Font = new Font("Microsoft JhengHei", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            pds3.Location = new Point(124, 67);
            pds3.MaxLength = 3;
            pds3.Name = "pds3";
            pds3.ReadOnly = true;
            pds3.Size = new Size(48, 38);
            pds3.TabIndex = 6;
            pds3.TextAlign = HorizontalAlignment.Center;
            // 
            // pds4
            // 
            pds4.Font = new Font("Microsoft JhengHei", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            pds4.Location = new Point(180, 67);
            pds4.MaxLength = 3;
            pds4.Name = "pds4";
            pds4.ReadOnly = true;
            pds4.Size = new Size(48, 38);
            pds4.TabIndex = 6;
            pds4.TextAlign = HorizontalAlignment.Center;
            // 
            // ads1
            // 
            ads1.Font = new Font("Microsoft JhengHei", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            ads1.Location = new Point(12, 106);
            ads1.MaxLength = 3;
            ads1.Name = "ads1";
            ads1.ReadOnly = true;
            ads1.Size = new Size(48, 38);
            ads1.TabIndex = 6;
            ads1.TextAlign = HorizontalAlignment.Center;
            // 
            // ads2
            // 
            ads2.Font = new Font("Microsoft JhengHei", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            ads2.Location = new Point(67, 106);
            ads2.MaxLength = 3;
            ads2.Name = "ads2";
            ads2.ReadOnly = true;
            ads2.Size = new Size(48, 38);
            ads2.TabIndex = 6;
            ads2.TextAlign = HorizontalAlignment.Center;
            // 
            // ads3
            // 
            ads3.Font = new Font("Microsoft JhengHei", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            ads3.Location = new Point(124, 106);
            ads3.MaxLength = 3;
            ads3.Name = "ads3";
            ads3.ReadOnly = true;
            ads3.Size = new Size(48, 38);
            ads3.TabIndex = 6;
            ads3.TextAlign = HorizontalAlignment.Center;
            // 
            // ads4
            // 
            ads4.Font = new Font("Microsoft JhengHei", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            ads4.Location = new Point(180, 106);
            ads4.MaxLength = 3;
            ads4.Name = "ads4";
            ads4.ReadOnly = true;
            ads4.Size = new Size(48, 38);
            ads4.TabIndex = 6;
            ads4.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(54, 64);
            label1.Name = "label1";
            label1.Size = new Size(21, 31);
            label1.TabIndex = 7;
            label1.Text = ".";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(110, 64);
            label2.Name = "label2";
            label2.Size = new Size(21, 31);
            label2.TabIndex = 8;
            label2.Text = ".";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(166, 64);
            label3.Name = "label3";
            label3.Size = new Size(21, 31);
            label3.TabIndex = 8;
            label3.Text = ".";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(110, 99);
            label4.Name = "label4";
            label4.Size = new Size(21, 31);
            label4.TabIndex = 8;
            label4.Text = ".";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(167, 99);
            label5.Name = "label5";
            label5.Size = new Size(21, 31);
            label5.TabIndex = 8;
            label5.Text = ".";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(54, 99);
            label6.Name = "label6";
            label6.Size = new Size(21, 31);
            label6.TabIndex = 7;
            label6.Text = ".";
            // 
            // Form1
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = SystemColors.Window;
            ClientSize = new Size(240, 237);
            Controls.Add(ads4);
            Controls.Add(pds4);
            Controls.Add(ads3);
            Controls.Add(ads2);
            Controls.Add(pds3);
            Controls.Add(ads1);
            Controls.Add(pds2);
            Controls.Add(pds1);
            Controls.Add(Cmx_Dns);
            Controls.Add(btnUnset);
            Controls.Add(btnSet);
            Controls.Add(Lbl_Dnsname);
            Controls.Add(Pic_Dns);
            Controls.Add(label6);
            Controls.Add(label1);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label2);
            Font = new Font("Proxima Soft ExtraBold", 16.1999989F, FontStyle.Bold, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(6, 5, 6, 5);
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "Form1";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TDns";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)Pic_Dns).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox Pic_Dns;
        private Label Lbl_Dnsname;
        private Button btnSet;
        private Button btnUnset;
        private ComboBox Cmx_Dns;
        private TextBox pds1;
        private TextBox pds2;
        private TextBox pds3;
        private TextBox pds4;
        private TextBox ads1;
        private TextBox ads2;
        private TextBox ads3;
        private TextBox ads4;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}
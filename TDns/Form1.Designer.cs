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
            Lbl_Dnsname.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
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
            btnSet.Font = new Font("Tahoma", 8F);
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
            btnUnset.Font = new Font("Tahoma", 8F);
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
            Cmx_Dns.Font = new Font("Tahoma", 8F);
            Cmx_Dns.FormattingEnabled = true;
            Cmx_Dns.Location = new Point(12, 149);
            Cmx_Dns.Name = "Cmx_Dns";
            Cmx_Dns.Size = new Size(216, 24);
            Cmx_Dns.TabIndex = 5;
            Cmx_Dns.SelectedIndexChanged += CmxDnses_SelectedIndexChanged;
            // 
            // pds1
            // 
            pds1.Font = new Font("Tahoma", 7.8F);
            pds1.Location = new Point(12, 67);
            pds1.MaxLength = 3;
            pds1.Name = "pds1";
            pds1.ReadOnly = true;
            pds1.Size = new Size(48, 23);
            pds1.TabIndex = 6;
            pds1.TextAlign = HorizontalAlignment.Center;
            // 
            // pds2
            // 
            pds2.Font = new Font("Tahoma", 7.8F);
            pds2.Location = new Point(67, 67);
            pds2.MaxLength = 3;
            pds2.Name = "pds2";
            pds2.ReadOnly = true;
            pds2.Size = new Size(48, 23);
            pds2.TabIndex = 6;
            pds2.TextAlign = HorizontalAlignment.Center;
            // 
            // pds3
            // 
            pds3.Font = new Font("Tahoma", 7.8F);
            pds3.Location = new Point(124, 67);
            pds3.MaxLength = 3;
            pds3.Name = "pds3";
            pds3.ReadOnly = true;
            pds3.Size = new Size(48, 23);
            pds3.TabIndex = 6;
            pds3.TextAlign = HorizontalAlignment.Center;
            // 
            // pds4
            // 
            pds4.Font = new Font("Tahoma", 7.8F);
            pds4.Location = new Point(180, 67);
            pds4.MaxLength = 3;
            pds4.Name = "pds4";
            pds4.ReadOnly = true;
            pds4.Size = new Size(48, 23);
            pds4.TabIndex = 6;
            pds4.TextAlign = HorizontalAlignment.Center;
            // 
            // ads1
            // 
            ads1.Font = new Font("Tahoma", 7.8F);
            ads1.Location = new Point(12, 106);
            ads1.MaxLength = 3;
            ads1.Name = "ads1";
            ads1.ReadOnly = true;
            ads1.Size = new Size(48, 23);
            ads1.TabIndex = 6;
            ads1.TextAlign = HorizontalAlignment.Center;
            // 
            // ads2
            // 
            ads2.Font = new Font("Tahoma", 7.8F);
            ads2.Location = new Point(67, 106);
            ads2.MaxLength = 3;
            ads2.Name = "ads2";
            ads2.ReadOnly = true;
            ads2.Size = new Size(48, 23);
            ads2.TabIndex = 6;
            ads2.TextAlign = HorizontalAlignment.Center;
            // 
            // ads3
            // 
            ads3.Font = new Font("Tahoma", 7.8F);
            ads3.Location = new Point(124, 106);
            ads3.MaxLength = 3;
            ads3.Name = "ads3";
            ads3.ReadOnly = true;
            ads3.Size = new Size(48, 23);
            ads3.TabIndex = 6;
            ads3.TextAlign = HorizontalAlignment.Center;
            // 
            // ads4
            // 
            ads4.Font = new Font("Tahoma", 7.8F);
            ads4.Location = new Point(180, 106);
            ads4.MaxLength = 3;
            ads4.Name = "ads4";
            ads4.ReadOnly = true;
            ads4.Size = new Size(48, 23);
            ads4.TabIndex = 6;
            ads4.TextAlign = HorizontalAlignment.Center;
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
            Font = new Font("Tahoma", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
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
    }
}
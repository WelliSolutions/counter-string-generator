
namespace CounterStringGenerator
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.txtLength = new System.Windows.Forms.TextBox();
            this.lblLength = new System.Windows.Forms.Label();
            this.lblSpecialChar = new System.Windows.Forms.Label();
            this.txtSpecialChar = new System.Windows.Forms.TextBox();
            this.btnCopy = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.linkLabel5 = new System.Windows.Forms.LinkLabel();
            this.linkLabel4 = new System.Windows.Forms.LinkLabel();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.lbl80 = new System.Windows.Forms.LinkLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.linkLabel22 = new System.Windows.Forms.LinkLabel();
            this.linkLabel21 = new System.Windows.Forms.LinkLabel();
            this.linkLabel20 = new System.Windows.Forms.LinkLabel();
            this.linkLabel19 = new System.Windows.Forms.LinkLabel();
            this.linkLabel18 = new System.Windows.Forms.LinkLabel();
            this.linkLabel17 = new System.Windows.Forms.LinkLabel();
            this.linkLabel16 = new System.Windows.Forms.LinkLabel();
            this.linkLabel15 = new System.Windows.Forms.LinkLabel();
            this.linkLabel14 = new System.Windows.Forms.LinkLabel();
            this.linkLabel13 = new System.Windows.Forms.LinkLabel();
            this.linkLabel12 = new System.Windows.Forms.LinkLabel();
            this.linkLabel11 = new System.Windows.Forms.LinkLabel();
            this.linkLabel10 = new System.Windows.Forms.LinkLabel();
            this.linkLabel9 = new System.Windows.Forms.LinkLabel();
            this.linkLabel8 = new System.Windows.Forms.LinkLabel();
            this.linkLabel7 = new System.Windows.Forms.LinkLabel();
            this.linkLabel6 = new System.Windows.Forms.LinkLabel();
            this.lblExpand = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtLength
            // 
            this.txtLength.Location = new System.Drawing.Point(12, 27);
            this.txtLength.MaxLength = 9;
            this.txtLength.Name = "txtLength";
            this.txtLength.Size = new System.Drawing.Size(120, 23);
            this.txtLength.TabIndex = 0;
            this.txtLength.Text = "1024";
            this.txtLength.TextChanged += new System.EventHandler(this.OnLengthChanged);
            // 
            // lblLength
            // 
            this.lblLength.AutoSize = true;
            this.lblLength.Location = new System.Drawing.Point(12, 9);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(120, 15);
            this.lblLength.TabIndex = 2;
            this.lblLength.Text = "Zu erzeugende &Länge";
            // 
            // lblSpecialChar
            // 
            this.lblSpecialChar.AutoSize = true;
            this.lblSpecialChar.Location = new System.Drawing.Point(152, 9);
            this.lblSpecialChar.Name = "lblSpecialChar";
            this.lblSpecialChar.Size = new System.Drawing.Size(84, 15);
            this.lblSpecialChar.TabIndex = 4;
            this.lblSpecialChar.Text = "Sonder&zeichen";
            // 
            // txtSpecialChar
            // 
            this.txtSpecialChar.Location = new System.Drawing.Point(152, 27);
            this.txtSpecialChar.MaxLength = 1;
            this.txtSpecialChar.Name = "txtSpecialChar";
            this.txtSpecialChar.Size = new System.Drawing.Size(84, 23);
            this.txtSpecialChar.TabIndex = 3;
            this.txtSpecialChar.Text = "_";
            this.txtSpecialChar.TextChanged += new System.EventHandler(this.SpecialCharChanged);
            // 
            // btnCopy
            // 
            this.btnCopy.Location = new System.Drawing.Point(242, 9);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(124, 41);
            this.btnCopy.TabIndex = 5;
            this.btnCopy.Text = "📋 In die Zwischenablage";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.linkLabel5);
            this.groupBox1.Controls.Add(this.linkLabel4);
            this.groupBox1.Controls.Add(this.linkLabel3);
            this.groupBox1.Controls.Add(this.linkLabel2);
            this.groupBox1.Controls.Add(this.linkLabel1);
            this.groupBox1.Controls.Add(this.lbl80);
            this.groupBox1.Location = new System.Drawing.Point(12, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(409, 160);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sonderwerte";
            // 
            // linkLabel5
            // 
            this.linkLabel5.AutoSize = true;
            this.linkLabel5.LinkArea = new System.Windows.Forms.LinkArea(0, 5);
            this.linkLabel5.Location = new System.Drawing.Point(6, 124);
            this.linkLabel5.Name = "linkLabel5";
            this.linkLabel5.Size = new System.Drawing.Size(322, 21);
            this.linkLabel5.TabIndex = 5;
            this.linkLabel5.TabStop = true;
            this.linkLabel5.Text = "64000 Maximale Länge von Richtext-Boxen (Standardwert)";
            this.linkLabel5.UseCompatibleTextRendering = true;
            this.linkLabel5.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.OnLink);
            // 
            // linkLabel4
            // 
            this.linkLabel4.AutoSize = true;
            this.linkLabel4.LinkArea = new System.Windows.Forms.LinkArea(0, 5);
            this.linkLabel4.Location = new System.Drawing.Point(6, 103);
            this.linkLabel4.Name = "linkLabel4";
            this.linkLabel4.Size = new System.Drawing.Size(216, 21);
            this.linkLabel4.TabIndex = 4;
            this.linkLabel4.TabStop = true;
            this.linkLabel4.Text = "43680 Edit-Control Bug in Windows 10";
            this.linkLabel4.UseCompatibleTextRendering = true;
            this.linkLabel4.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.OnLink);
            // 
            // linkLabel3
            // 
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.LinkArea = new System.Windows.Forms.LinkArea(0, 5);
            this.linkLabel3.Location = new System.Drawing.Point(6, 82);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(296, 21);
            this.linkLabel3.TabIndex = 3;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "32767 Maximale Länge von Textboxen (Standardwert)";
            this.linkLabel3.UseCompatibleTextRendering = true;
            this.linkLabel3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.OnLink);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.LinkArea = new System.Windows.Forms.LinkArea(0, 4);
            this.linkLabel2.Location = new System.Drawing.Point(6, 61);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(311, 21);
            this.linkLabel2.TabIndex = 2;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "5461 Edit-Control Bug in Windows Vista und Windows 7";
            this.linkLabel2.UseCompatibleTextRendering = true;
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.OnLink);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkArea = new System.Windows.Forms.LinkArea(0, 3);
            this.linkLabel1.Location = new System.Drawing.Point(6, 40);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(224, 21);
            this.linkLabel1.TabIndex = 1;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "260 Maximale Pfadlänge unter Windows";
            this.linkLabel1.UseCompatibleTextRendering = true;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.OnLink);
            // 
            // lbl80
            // 
            this.lbl80.AutoSize = true;
            this.lbl80.LinkArea = new System.Windows.Forms.LinkArea(0, 2);
            this.lbl80.Location = new System.Drawing.Point(6, 19);
            this.lbl80.Name = "lbl80";
            this.lbl80.Size = new System.Drawing.Size(172, 21);
            this.lbl80.TabIndex = 0;
            this.lbl80.TabStop = true;
            this.lbl80.Text = "80 Spaltenbreite von Terminals";
            this.lbl80.UseCompatibleTextRendering = true;
            this.lbl80.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.OnLink);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.linkLabel22);
            this.groupBox2.Controls.Add(this.linkLabel21);
            this.groupBox2.Controls.Add(this.linkLabel20);
            this.groupBox2.Controls.Add(this.linkLabel19);
            this.groupBox2.Controls.Add(this.linkLabel18);
            this.groupBox2.Controls.Add(this.linkLabel17);
            this.groupBox2.Controls.Add(this.linkLabel16);
            this.groupBox2.Controls.Add(this.linkLabel15);
            this.groupBox2.Controls.Add(this.linkLabel14);
            this.groupBox2.Controls.Add(this.linkLabel13);
            this.groupBox2.Controls.Add(this.linkLabel12);
            this.groupBox2.Controls.Add(this.linkLabel11);
            this.groupBox2.Controls.Add(this.linkLabel10);
            this.groupBox2.Controls.Add(this.linkLabel9);
            this.groupBox2.Controls.Add(this.linkLabel8);
            this.groupBox2.Controls.Add(this.linkLabel7);
            this.groupBox2.Controls.Add(this.linkLabel6);
            this.groupBox2.Location = new System.Drawing.Point(12, 222);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(409, 189);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Zweierpotenzen";
            // 
            // linkLabel22
            // 
            this.linkLabel22.AutoSize = true;
            this.linkLabel22.LinkArea = new System.Windows.Forms.LinkArea(0, 9);
            this.linkLabel22.Location = new System.Drawing.Point(261, 166);
            this.linkLabel22.Name = "linkLabel22";
            this.linkLabel22.Size = new System.Drawing.Size(112, 21);
            this.linkLabel22.TabIndex = 17;
            this.linkLabel22.TabStop = true;
            this.linkLabel22.Text = "134217728 128 MiB";
            this.linkLabel22.UseCompatibleTextRendering = true;
            this.linkLabel22.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.OnLink);
            // 
            // linkLabel21
            // 
            this.linkLabel21.AutoSize = true;
            this.linkLabel21.LinkArea = new System.Windows.Forms.LinkArea(0, 8);
            this.linkLabel21.Location = new System.Drawing.Point(261, 145);
            this.linkLabel21.Name = "linkLabel21";
            this.linkLabel21.Size = new System.Drawing.Size(99, 21);
            this.linkLabel21.TabIndex = 16;
            this.linkLabel21.TabStop = true;
            this.linkLabel21.Text = "67108864 64 MiB";
            this.linkLabel21.UseCompatibleTextRendering = true;
            this.linkLabel21.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.OnLink);
            // 
            // linkLabel20
            // 
            this.linkLabel20.AutoSize = true;
            this.linkLabel20.LinkArea = new System.Windows.Forms.LinkArea(0, 8);
            this.linkLabel20.Location = new System.Drawing.Point(261, 124);
            this.linkLabel20.Name = "linkLabel20";
            this.linkLabel20.Size = new System.Drawing.Size(99, 21);
            this.linkLabel20.TabIndex = 15;
            this.linkLabel20.TabStop = true;
            this.linkLabel20.Text = "33554432 32 MiB";
            this.linkLabel20.UseCompatibleTextRendering = true;
            this.linkLabel20.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.OnLink);
            // 
            // linkLabel19
            // 
            this.linkLabel19.AutoSize = true;
            this.linkLabel19.LinkArea = new System.Windows.Forms.LinkArea(0, 7);
            this.linkLabel19.Location = new System.Drawing.Point(261, 82);
            this.linkLabel19.Name = "linkLabel19";
            this.linkLabel19.Size = new System.Drawing.Size(86, 21);
            this.linkLabel19.TabIndex = 14;
            this.linkLabel19.TabStop = true;
            this.linkLabel19.Text = "8388608 8 MiB";
            this.linkLabel19.UseCompatibleTextRendering = true;
            this.linkLabel19.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.OnLink);
            // 
            // linkLabel18
            // 
            this.linkLabel18.AutoSize = true;
            this.linkLabel18.LinkArea = new System.Windows.Forms.LinkArea(0, 7);
            this.linkLabel18.Location = new System.Drawing.Point(261, 61);
            this.linkLabel18.Name = "linkLabel18";
            this.linkLabel18.Size = new System.Drawing.Size(86, 21);
            this.linkLabel18.TabIndex = 13;
            this.linkLabel18.TabStop = true;
            this.linkLabel18.Text = "4194304 4 MiB";
            this.linkLabel18.UseCompatibleTextRendering = true;
            this.linkLabel18.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.OnLink);
            // 
            // linkLabel17
            // 
            this.linkLabel17.AutoSize = true;
            this.linkLabel17.LinkArea = new System.Windows.Forms.LinkArea(0, 7);
            this.linkLabel17.Location = new System.Drawing.Point(261, 40);
            this.linkLabel17.Name = "linkLabel17";
            this.linkLabel17.Size = new System.Drawing.Size(86, 21);
            this.linkLabel17.TabIndex = 12;
            this.linkLabel17.TabStop = true;
            this.linkLabel17.Text = "2097152 2 MiB";
            this.linkLabel17.UseCompatibleTextRendering = true;
            this.linkLabel17.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.OnLink);
            // 
            // linkLabel16
            // 
            this.linkLabel16.AutoSize = true;
            this.linkLabel16.LinkArea = new System.Windows.Forms.LinkArea(0, 8);
            this.linkLabel16.Location = new System.Drawing.Point(261, 103);
            this.linkLabel16.Name = "linkLabel16";
            this.linkLabel16.Size = new System.Drawing.Size(125, 21);
            this.linkLabel16.TabIndex = 11;
            this.linkLabel16.TabStop = true;
            this.linkLabel16.Text = "16777216 16 MiB (2²⁴)";
            this.linkLabel16.UseCompatibleTextRendering = true;
            this.linkLabel16.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.OnLink);
            // 
            // linkLabel15
            // 
            this.linkLabel15.AutoSize = true;
            this.linkLabel15.LinkArea = new System.Windows.Forms.LinkArea(0, 7);
            this.linkLabel15.Location = new System.Drawing.Point(261, 19);
            this.linkLabel15.Name = "linkLabel15";
            this.linkLabel15.Size = new System.Drawing.Size(112, 21);
            this.linkLabel15.TabIndex = 10;
            this.linkLabel15.TabStop = true;
            this.linkLabel15.Text = "1048576 1 MiB (2²⁰)";
            this.linkLabel15.UseCompatibleTextRendering = true;
            this.linkLabel15.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.OnLink);
            // 
            // linkLabel14
            // 
            this.linkLabel14.AutoSize = true;
            this.linkLabel14.LinkArea = new System.Windows.Forms.LinkArea(0, 5);
            this.linkLabel14.Location = new System.Drawing.Point(6, 187);
            this.linkLabel14.Name = "linkLabel14";
            this.linkLabel14.Size = new System.Drawing.Size(0, 18);
            this.linkLabel14.TabIndex = 9;
            this.linkLabel14.UseCompatibleTextRendering = true;
            // 
            // linkLabel13
            // 
            this.linkLabel13.AutoSize = true;
            this.linkLabel13.LinkArea = new System.Windows.Forms.LinkArea(0, 5);
            this.linkLabel13.Location = new System.Drawing.Point(6, 166);
            this.linkLabel13.Name = "linkLabel13";
            this.linkLabel13.Size = new System.Drawing.Size(219, 21);
            this.linkLabel13.TabIndex = 8;
            this.linkLabel13.TabStop = true;
            this.linkLabel13.Text = "65536 64 kiB, Maximalwert eines uint16";
            this.linkLabel13.UseCompatibleTextRendering = true;
            this.linkLabel13.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.OnLink);
            // 
            // linkLabel12
            // 
            this.linkLabel12.AutoSize = true;
            this.linkLabel12.LinkArea = new System.Windows.Forms.LinkArea(0, 5);
            this.linkLabel12.Location = new System.Drawing.Point(6, 145);
            this.linkLabel12.Name = "linkLabel12";
            this.linkLabel12.Size = new System.Drawing.Size(74, 21);
            this.linkLabel12.TabIndex = 7;
            this.linkLabel12.TabStop = true;
            this.linkLabel12.Text = "32768 32 kiB";
            this.linkLabel12.UseCompatibleTextRendering = true;
            this.linkLabel12.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.OnLink);
            // 
            // linkLabel11
            // 
            this.linkLabel11.AutoSize = true;
            this.linkLabel11.LinkArea = new System.Windows.Forms.LinkArea(0, 5);
            this.linkLabel11.Location = new System.Drawing.Point(6, 124);
            this.linkLabel11.Name = "linkLabel11";
            this.linkLabel11.Size = new System.Drawing.Size(74, 21);
            this.linkLabel11.TabIndex = 6;
            this.linkLabel11.TabStop = true;
            this.linkLabel11.Text = "16384 16 kiB";
            this.linkLabel11.UseCompatibleTextRendering = true;
            this.linkLabel11.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.OnLink);
            // 
            // linkLabel10
            // 
            this.linkLabel10.AutoSize = true;
            this.linkLabel10.LinkArea = new System.Windows.Forms.LinkArea(0, 4);
            this.linkLabel10.Location = new System.Drawing.Point(6, 103);
            this.linkLabel10.Name = "linkLabel10";
            this.linkLabel10.Size = new System.Drawing.Size(61, 21);
            this.linkLabel10.TabIndex = 5;
            this.linkLabel10.TabStop = true;
            this.linkLabel10.Text = "8192 8 kiB";
            this.linkLabel10.UseCompatibleTextRendering = true;
            this.linkLabel10.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.OnLink);
            // 
            // linkLabel9
            // 
            this.linkLabel9.AutoSize = true;
            this.linkLabel9.LinkArea = new System.Windows.Forms.LinkArea(0, 4);
            this.linkLabel9.Location = new System.Drawing.Point(6, 82);
            this.linkLabel9.Name = "linkLabel9";
            this.linkLabel9.Size = new System.Drawing.Size(61, 21);
            this.linkLabel9.TabIndex = 4;
            this.linkLabel9.TabStop = true;
            this.linkLabel9.Text = "4096 4 kiB";
            this.linkLabel9.UseCompatibleTextRendering = true;
            this.linkLabel9.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.OnLink);
            // 
            // linkLabel8
            // 
            this.linkLabel8.AutoSize = true;
            this.linkLabel8.LinkArea = new System.Windows.Forms.LinkArea(0, 4);
            this.linkLabel8.Location = new System.Drawing.Point(6, 61);
            this.linkLabel8.Name = "linkLabel8";
            this.linkLabel8.Size = new System.Drawing.Size(61, 21);
            this.linkLabel8.TabIndex = 3;
            this.linkLabel8.TabStop = true;
            this.linkLabel8.Text = "2048 2 kiB";
            this.linkLabel8.UseCompatibleTextRendering = true;
            this.linkLabel8.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.OnLink);
            // 
            // linkLabel7
            // 
            this.linkLabel7.AutoSize = true;
            this.linkLabel7.LinkArea = new System.Windows.Forms.LinkArea(0, 4);
            this.linkLabel7.Location = new System.Drawing.Point(6, 40);
            this.linkLabel7.Name = "linkLabel7";
            this.linkLabel7.Size = new System.Drawing.Size(61, 21);
            this.linkLabel7.TabIndex = 2;
            this.linkLabel7.TabStop = true;
            this.linkLabel7.Text = "1024 1 kiB";
            this.linkLabel7.UseCompatibleTextRendering = true;
            this.linkLabel7.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.OnLink);
            // 
            // linkLabel6
            // 
            this.linkLabel6.AutoSize = true;
            this.linkLabel6.LinkArea = new System.Windows.Forms.LinkArea(0, 3);
            this.linkLabel6.Location = new System.Drawing.Point(6, 19);
            this.linkLabel6.Name = "linkLabel6";
            this.linkLabel6.Size = new System.Drawing.Size(156, 21);
            this.linkLabel6.TabIndex = 1;
            this.linkLabel6.TabStop = true;
            this.linkLabel6.Text = "256 Maximalwert eines Byte";
            this.linkLabel6.UseCompatibleTextRendering = true;
            this.linkLabel6.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.OnLink);
            // 
            // lblExpand
            // 
            this.lblExpand.AutoSize = true;
            this.lblExpand.Location = new System.Drawing.Point(404, 35);
            this.lblExpand.Name = "lblExpand";
            this.lblExpand.Size = new System.Drawing.Size(17, 15);
            this.lblExpand.TabIndex = 8;
            this.lblExpand.Text = "▼";
            this.lblExpand.Click += new System.EventHandler(this.OnExpand);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 421);
            this.Controls.Add(this.lblExpand);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.lblSpecialChar);
            this.Controls.Add(this.txtSpecialChar);
            this.Controls.Add(this.lblLength);
            this.Controls.Add(this.txtLength);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(449, 460);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(449, 97);
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Counter String Generator";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLength;
        private System.Windows.Forms.Label lblLength;
        private System.Windows.Forms.Label lblSpecialChar;
        private System.Windows.Forms.TextBox txtSpecialChar;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.LinkLabel linkLabel5;
        private System.Windows.Forms.LinkLabel linkLabel4;
        private System.Windows.Forms.LinkLabel linkLabel3;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel lbl80;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.LinkLabel linkLabel22;
        private System.Windows.Forms.LinkLabel linkLabel21;
        private System.Windows.Forms.LinkLabel linkLabel20;
        private System.Windows.Forms.LinkLabel linkLabel19;
        private System.Windows.Forms.LinkLabel linkLabel18;
        private System.Windows.Forms.LinkLabel linkLabel17;
        private System.Windows.Forms.LinkLabel linkLabel16;
        private System.Windows.Forms.LinkLabel linkLabel15;
        private System.Windows.Forms.LinkLabel linkLabel14;
        private System.Windows.Forms.LinkLabel linkLabel13;
        private System.Windows.Forms.LinkLabel linkLabel12;
        private System.Windows.Forms.LinkLabel linkLabel11;
        private System.Windows.Forms.LinkLabel linkLabel10;
        private System.Windows.Forms.LinkLabel linkLabel9;
        private System.Windows.Forms.LinkLabel linkLabel8;
        private System.Windows.Forms.LinkLabel linkLabel7;
        private System.Windows.Forms.LinkLabel linkLabel6;
        private System.Windows.Forms.Label lblExpand;
    }
}


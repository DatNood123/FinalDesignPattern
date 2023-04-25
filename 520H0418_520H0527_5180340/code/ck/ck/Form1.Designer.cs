namespace ck
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
            this.raddanhsach = new System.Windows.Forms.Button();
            this.btndathang = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbElectric = new System.Windows.Forms.ComboBox();
            this.cbDiesel = new System.Windows.Forms.ComboBox();
            this.cbGasoline = new System.Windows.Forms.ComboBox();
            this.radElectric = new System.Windows.Forms.RadioButton();
            this.radDiesel = new System.Windows.Forms.RadioButton();
            this.radGasoline = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radBlue = new System.Windows.Forms.RadioButton();
            this.radGreen = new System.Windows.Forms.RadioButton();
            this.radRed = new System.Windows.Forms.RadioButton();
            this.radWhite = new System.Windows.Forms.RadioButton();
            this.radBlack = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radAutomatic = new System.Windows.Forms.RadioButton();
            this.radManual = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.radHatchback = new System.Windows.Forms.RadioButton();
            this.radSport = new System.Windows.Forms.RadioButton();
            this.radSUV = new System.Windows.Forms.RadioButton();
            this.radSedan = new System.Windows.Forms.RadioButton();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.radDTDModel03 = new System.Windows.Forms.RadioButton();
            this.radDTDModel02 = new System.Windows.Forms.RadioButton();
            this.radDTDModel01 = new System.Windows.Forms.RadioButton();
            this.btnthoat = new System.Windows.Forms.Button();
            this.btnthongbao = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // raddanhsach
            // 
            this.raddanhsach.BackColor = System.Drawing.SystemColors.Desktop;
            this.raddanhsach.Location = new System.Drawing.Point(151, 446);
            this.raddanhsach.Margin = new System.Windows.Forms.Padding(4);
            this.raddanhsach.Name = "raddanhsach";
            this.raddanhsach.Size = new System.Drawing.Size(183, 59);
            this.raddanhsach.TabIndex = 0;
            this.raddanhsach.Text = "Danh sách sản phẩm";
            this.raddanhsach.UseVisualStyleBackColor = false;
            // 
            // btndathang
            // 
            this.btndathang.Location = new System.Drawing.Point(14, 445);
            this.btndathang.Margin = new System.Windows.Forms.Padding(4);
            this.btndathang.Name = "btndathang";
            this.btndathang.Size = new System.Drawing.Size(117, 60);
            this.btndathang.TabIndex = 1;
            this.btndathang.Text = "Đặt hàng";
            this.btndathang.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Highlight;
            this.groupBox1.Controls.Add(this.cbElectric);
            this.groupBox1.Controls.Add(this.cbDiesel);
            this.groupBox1.Controls.Add(this.cbGasoline);
            this.groupBox1.Controls.Add(this.radElectric);
            this.groupBox1.Controls.Add(this.radDiesel);
            this.groupBox1.Controls.Add(this.radGasoline);
            this.groupBox1.Location = new System.Drawing.Point(14, 51);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(313, 181);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "TypeCar";
            // 
            // cbElectric
            // 
            this.cbElectric.FormattingEnabled = true;
            this.cbElectric.Items.AddRange(new object[] {
            "EEngine01",
            "EEngine02"});
            this.cbElectric.Location = new System.Drawing.Point(151, 139);
            this.cbElectric.Margin = new System.Windows.Forms.Padding(4);
            this.cbElectric.Name = "cbElectric";
            this.cbElectric.Size = new System.Drawing.Size(153, 31);
            this.cbElectric.TabIndex = 5;
            this.cbElectric.Text = "Electric";
            // 
            // cbDiesel
            // 
            this.cbDiesel.FormattingEnabled = true;
            this.cbDiesel.Items.AddRange(new object[] {
            "DEngine01",
            "DEngine02"});
            this.cbDiesel.Location = new System.Drawing.Point(151, 90);
            this.cbDiesel.Margin = new System.Windows.Forms.Padding(4);
            this.cbDiesel.Name = "cbDiesel";
            this.cbDiesel.Size = new System.Drawing.Size(153, 31);
            this.cbDiesel.TabIndex = 4;
            this.cbDiesel.Text = "Diesel";
            // 
            // cbGasoline
            // 
            this.cbGasoline.FormattingEnabled = true;
            this.cbGasoline.Items.AddRange(new object[] {
            "GEngine01",
            "GEngine02"});
            this.cbGasoline.Location = new System.Drawing.Point(151, 38);
            this.cbGasoline.Margin = new System.Windows.Forms.Padding(4);
            this.cbGasoline.Name = "cbGasoline";
            this.cbGasoline.Size = new System.Drawing.Size(153, 31);
            this.cbGasoline.TabIndex = 3;
            this.cbGasoline.Text = "Gasoline";
            // 
            // radElectric
            // 
            this.radElectric.AutoSize = true;
            this.radElectric.Location = new System.Drawing.Point(23, 138);
            this.radElectric.Margin = new System.Windows.Forms.Padding(4);
            this.radElectric.Name = "radElectric";
            this.radElectric.Size = new System.Drawing.Size(89, 27);
            this.radElectric.TabIndex = 2;
            this.radElectric.TabStop = true;
            this.radElectric.Text = "Electric";
            this.radElectric.UseVisualStyleBackColor = true;
            // 
            // radDiesel
            // 
            this.radDiesel.AutoSize = true;
            this.radDiesel.Location = new System.Drawing.Point(23, 88);
            this.radDiesel.Margin = new System.Windows.Forms.Padding(4);
            this.radDiesel.Name = "radDiesel";
            this.radDiesel.Size = new System.Drawing.Size(79, 27);
            this.radDiesel.TabIndex = 1;
            this.radDiesel.TabStop = true;
            this.radDiesel.Text = "Diesel";
            this.radDiesel.UseVisualStyleBackColor = true;
            // 
            // radGasoline
            // 
            this.radGasoline.AutoSize = true;
            this.radGasoline.Location = new System.Drawing.Point(23, 39);
            this.radGasoline.Margin = new System.Windows.Forms.Padding(4);
            this.radGasoline.Name = "radGasoline";
            this.radGasoline.Size = new System.Drawing.Size(98, 27);
            this.radGasoline.TabIndex = 0;
            this.radGasoline.TabStop = true;
            this.radGasoline.Text = "Gasoline";
            this.radGasoline.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(195, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(729, 38);
            this.label1.TabIndex = 3;
            this.label1.Text = "Chào mừng quý khách đã đến với cửa hàng chúng tôi";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Highlight;
            this.groupBox2.Controls.Add(this.radBlue);
            this.groupBox2.Controls.Add(this.radGreen);
            this.groupBox2.Controls.Add(this.radRed);
            this.groupBox2.Controls.Add(this.radWhite);
            this.groupBox2.Controls.Add(this.radBlack);
            this.groupBox2.Location = new System.Drawing.Point(355, 51);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(216, 181);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Color";
            // 
            // radBlue
            // 
            this.radBlue.AutoSize = true;
            this.radBlue.Location = new System.Drawing.Point(118, 85);
            this.radBlue.Name = "radBlue";
            this.radBlue.Size = new System.Drawing.Size(66, 27);
            this.radBlue.TabIndex = 4;
            this.radBlue.TabStop = true;
            this.radBlue.Text = "Blue";
            this.radBlue.UseVisualStyleBackColor = true;
            // 
            // radGreen
            // 
            this.radGreen.AutoSize = true;
            this.radGreen.Location = new System.Drawing.Point(118, 37);
            this.radGreen.Name = "radGreen";
            this.radGreen.Size = new System.Drawing.Size(78, 27);
            this.radGreen.TabIndex = 3;
            this.radGreen.TabStop = true;
            this.radGreen.Text = "Green";
            this.radGreen.UseVisualStyleBackColor = true;
            // 
            // radRed
            // 
            this.radRed.AutoSize = true;
            this.radRed.Location = new System.Drawing.Point(14, 134);
            this.radRed.Name = "radRed";
            this.radRed.Size = new System.Drawing.Size(62, 27);
            this.radRed.TabIndex = 2;
            this.radRed.TabStop = true;
            this.radRed.Text = "Red";
            this.radRed.UseVisualStyleBackColor = true;
            // 
            // radWhite
            // 
            this.radWhite.AutoSize = true;
            this.radWhite.Location = new System.Drawing.Point(14, 82);
            this.radWhite.Name = "radWhite";
            this.radWhite.Size = new System.Drawing.Size(79, 27);
            this.radWhite.TabIndex = 1;
            this.radWhite.TabStop = true;
            this.radWhite.Text = "White";
            this.radWhite.UseVisualStyleBackColor = true;
            // 
            // radBlack
            // 
            this.radBlack.AutoSize = true;
            this.radBlack.Location = new System.Drawing.Point(14, 37);
            this.radBlack.Name = "radBlack";
            this.radBlack.Size = new System.Drawing.Size(74, 27);
            this.radBlack.TabIndex = 0;
            this.radBlack.TabStop = true;
            this.radBlack.Text = "Black";
            this.radBlack.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.Highlight;
            this.groupBox3.Controls.Add(this.radAutomatic);
            this.groupBox3.Controls.Add(this.radManual);
            this.groupBox3.Location = new System.Drawing.Point(609, 51);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(179, 181);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "GearBox";
            // 
            // radAutomatic
            // 
            this.radAutomatic.AutoSize = true;
            this.radAutomatic.Location = new System.Drawing.Point(16, 79);
            this.radAutomatic.Name = "radAutomatic";
            this.radAutomatic.Size = new System.Drawing.Size(115, 27);
            this.radAutomatic.TabIndex = 1;
            this.radAutomatic.TabStop = true;
            this.radAutomatic.Text = "Automatic";
            this.radAutomatic.UseVisualStyleBackColor = true;
            // 
            // radManual
            // 
            this.radManual.AutoSize = true;
            this.radManual.Location = new System.Drawing.Point(16, 29);
            this.radManual.Name = "radManual";
            this.radManual.Size = new System.Drawing.Size(90, 27);
            this.radManual.TabIndex = 0;
            this.radManual.TabStop = true;
            this.radManual.Text = "Manual";
            this.radManual.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.SystemColors.Highlight;
            this.groupBox4.Controls.Add(this.radHatchback);
            this.groupBox4.Controls.Add(this.radSport);
            this.groupBox4.Controls.Add(this.radSUV);
            this.groupBox4.Controls.Add(this.radSedan);
            this.groupBox4.Location = new System.Drawing.Point(834, 51);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(250, 181);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Model Car";
            // 
            // radHatchback
            // 
            this.radHatchback.AutoSize = true;
            this.radHatchback.Location = new System.Drawing.Point(113, 37);
            this.radHatchback.Name = "radHatchback";
            this.radHatchback.Size = new System.Drawing.Size(116, 27);
            this.radHatchback.TabIndex = 3;
            this.radHatchback.TabStop = true;
            this.radHatchback.Text = "Hatchback";
            this.radHatchback.UseVisualStyleBackColor = true;
            // 
            // radSport
            // 
            this.radSport.AutoSize = true;
            this.radSport.Location = new System.Drawing.Point(10, 132);
            this.radSport.Name = "radSport";
            this.radSport.Size = new System.Drawing.Size(76, 27);
            this.radSport.TabIndex = 2;
            this.radSport.TabStop = true;
            this.radSport.Text = "Sport";
            this.radSport.UseVisualStyleBackColor = true;
            // 
            // radSUV
            // 
            this.radSUV.AutoSize = true;
            this.radSUV.Location = new System.Drawing.Point(10, 84);
            this.radSUV.Name = "radSUV";
            this.radSUV.Size = new System.Drawing.Size(64, 27);
            this.radSUV.TabIndex = 1;
            this.radSUV.TabStop = true;
            this.radSUV.Text = "SUV";
            this.radSUV.UseVisualStyleBackColor = true;
            // 
            // radSedan
            // 
            this.radSedan.AutoSize = true;
            this.radSedan.Location = new System.Drawing.Point(10, 37);
            this.radSedan.Name = "radSedan";
            this.radSedan.Size = new System.Drawing.Size(80, 27);
            this.radSedan.TabIndex = 0;
            this.radSedan.TabStop = true;
            this.radSedan.Text = "Sedan";
            this.radSedan.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.SystemColors.Highlight;
            this.groupBox5.Controls.Add(this.radDTDModel03);
            this.groupBox5.Controls.Add(this.radDTDModel02);
            this.groupBox5.Controls.Add(this.radDTDModel01);
            this.groupBox5.Location = new System.Drawing.Point(12, 258);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(315, 160);
            this.groupBox5.TabIndex = 7;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Wheel Type";
            // 
            // radDTDModel03
            // 
            this.radDTDModel03.AutoSize = true;
            this.radDTDModel03.Location = new System.Drawing.Point(18, 127);
            this.radDTDModel03.Name = "radDTDModel03";
            this.radDTDModel03.Size = new System.Drawing.Size(164, 27);
            this.radDTDModel03.TabIndex = 2;
            this.radDTDModel03.TabStop = true;
            this.radDTDModel03.Text = "DTDModel03_29";
            this.radDTDModel03.UseVisualStyleBackColor = true;
            // 
            // radDTDModel02
            // 
            this.radDTDModel02.AutoSize = true;
            this.radDTDModel02.Location = new System.Drawing.Point(18, 78);
            this.radDTDModel02.Name = "radDTDModel02";
            this.radDTDModel02.Size = new System.Drawing.Size(164, 27);
            this.radDTDModel02.TabIndex = 1;
            this.radDTDModel02.TabStop = true;
            this.radDTDModel02.Text = "DTDModel02_27";
            this.radDTDModel02.UseVisualStyleBackColor = true;
            // 
            // radDTDModel01
            // 
            this.radDTDModel01.AutoSize = true;
            this.radDTDModel01.Location = new System.Drawing.Point(18, 29);
            this.radDTDModel01.Name = "radDTDModel01";
            this.radDTDModel01.Size = new System.Drawing.Size(164, 27);
            this.radDTDModel01.TabIndex = 0;
            this.radDTDModel01.TabStop = true;
            this.radDTDModel01.Text = "DTDModel01_26";
            this.radDTDModel01.UseVisualStyleBackColor = true;
            // 
            // btnthoat
            // 
            this.btnthoat.Location = new System.Drawing.Point(993, 446);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(91, 60);
            this.btnthoat.TabIndex = 8;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            // 
            // btnthongbao
            // 
            this.btnthongbao.Location = new System.Drawing.Point(874, 446);
            this.btnthongbao.Name = "btnthongbao";
            this.btnthongbao.Size = new System.Drawing.Size(94, 59);
            this.btnthongbao.TabIndex = 9;
            this.btnthongbao.Text = "Thông báo";
            this.btnthongbao.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1115, 518);
            this.Controls.Add(this.btnthongbao);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btndathang);
            this.Controls.Add(this.raddanhsach);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Phần mềm bán xe";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button raddanhsach;
        private Button btndathang;
        private GroupBox groupBox1;
        private ComboBox cbElectric;
        private ComboBox cbDiesel;
        private ComboBox cbGasoline;
        private RadioButton radElectric;
        private RadioButton radDiesel;
        private RadioButton radGasoline;
        private Label label1;
        private GroupBox groupBox2;
        private RadioButton radBlue;
        private RadioButton radGreen;
        private RadioButton radRed;
        private RadioButton radWhite;
        private RadioButton radBlack;
        private GroupBox groupBox3;
        private RadioButton radAutomatic;
        private RadioButton radManual;
        private GroupBox groupBox4;
        private RadioButton radHatchback;
        private RadioButton radSport;
        private RadioButton radSUV;
        private RadioButton radSedan;
        private GroupBox groupBox5;
        private RadioButton radDTDModel03;
        private RadioButton radDTDModel02;
        private RadioButton radDTDModel01;
        private Button btnthoat;
        private Button btnthongbao;
    }
}
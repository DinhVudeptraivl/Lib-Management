﻿using System.Windows.Forms;

namespace GUI
{
    partial class fPhieuMuonSach
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
            this.components = new System.ComponentModel.Container();
            this.siticonePanel1 = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.label10 = new System.Windows.Forms.Label();
            this.labelTheLoai = new System.Windows.Forms.Label();
            this.siticoneVSeparator1 = new Siticone.Desktop.UI.WinForms.SiticoneVSeparator();
            this.comboDocGia = new System.Windows.Forms.ComboBox();
            this.dOCGIABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboCuonSach = new System.Windows.Forms.ComboBox();
            this.cUONSACHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.siticoneSeparator2 = new Siticone.Desktop.UI.WinForms.SiticoneSeparator();
            this.butSave = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.label13 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dateNgayMuon = new Siticone.Desktop.UI.WinForms.SiticoneDateTimePicker();
            this.labelHanTra = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelTienPhat = new System.Windows.Forms.Label();
            this.labelTongNoHienTai = new System.Windows.Forms.Label();
            this.labelDonGiaPhat = new System.Windows.Forms.Label();
            this.labelTongNoMoi = new System.Windows.Forms.Label();
            this.labelSoNgayTre = new System.Windows.Forms.Label();
            this.labelHoTen = new System.Windows.Forms.Label();
            this.labelTenCS = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.siticoneSeparator1 = new Siticone.Desktop.UI.WinForms.SiticoneSeparator();
            this.siticoneSeparator4 = new Siticone.Desktop.UI.WinForms.SiticoneSeparator();
            this.siticoneSeparator5 = new Siticone.Desktop.UI.WinForms.SiticoneSeparator();
            this.siticoneSeparator3 = new Siticone.Desktop.UI.WinForms.SiticoneSeparator();
            this.siticoneControlBox2 = new Siticone.Desktop.UI.WinForms.SiticoneControlBox();
            this.siticoneControlBox1 = new Siticone.Desktop.UI.WinForms.SiticoneControlBox();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.siticoneDragControl1 = new Siticone.Desktop.UI.WinForms.SiticoneDragControl(this.components);
            this.ErrorDia = new Siticone.Desktop.UI.WinForms.SiticoneMessageDialog();
            this.SuccDia = new Siticone.Desktop.UI.WinForms.SiticoneMessageDialog();
            this.siticonePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dOCGIABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cUONSACHBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // siticonePanel1
            // 
            this.siticonePanel1.BackColor = System.Drawing.Color.AliceBlue;
            this.siticonePanel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.siticonePanel1.BorderRadius = 6;
            this.siticonePanel1.BorderThickness = 2;
            this.siticonePanel1.Controls.Add(this.label10);
            this.siticonePanel1.Controls.Add(this.labelTheLoai);
            this.siticonePanel1.Controls.Add(this.siticoneVSeparator1);
            this.siticonePanel1.Controls.Add(this.comboDocGia);
            this.siticonePanel1.Controls.Add(this.comboCuonSach);
            this.siticonePanel1.Controls.Add(this.siticoneSeparator2);
            this.siticonePanel1.Controls.Add(this.butSave);
            this.siticonePanel1.Controls.Add(this.label13);
            this.siticonePanel1.Controls.Add(this.label8);
            this.siticonePanel1.Controls.Add(this.dateNgayMuon);
            this.siticonePanel1.Controls.Add(this.labelHanTra);
            this.siticonePanel1.Controls.Add(this.label11);
            this.siticonePanel1.Controls.Add(this.label3);
            this.siticonePanel1.Controls.Add(this.labelTienPhat);
            this.siticonePanel1.Controls.Add(this.labelTongNoHienTai);
            this.siticonePanel1.Controls.Add(this.labelDonGiaPhat);
            this.siticonePanel1.Controls.Add(this.labelTongNoMoi);
            this.siticonePanel1.Controls.Add(this.labelSoNgayTre);
            this.siticonePanel1.Controls.Add(this.labelHoTen);
            this.siticonePanel1.Controls.Add(this.labelTenCS);
            this.siticonePanel1.Controls.Add(this.label2);
            this.siticonePanel1.Controls.Add(this.label12);
            this.siticonePanel1.Controls.Add(this.label1);
            this.siticonePanel1.Controls.Add(this.siticoneSeparator1);
            this.siticonePanel1.Controls.Add(this.siticoneSeparator4);
            this.siticonePanel1.Controls.Add(this.siticoneSeparator5);
            this.siticonePanel1.Controls.Add(this.siticoneSeparator3);
            this.siticonePanel1.Location = new System.Drawing.Point(50, 64);
            this.siticonePanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.siticonePanel1.Name = "siticonePanel1";
            this.siticonePanel1.Size = new System.Drawing.Size(754, 613);
            this.siticonePanel1.TabIndex = 1;
            this.siticonePanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.siticonePanel1_Paint);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(13, 77);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(275, 37);
            this.label10.TabIndex = 146;
            this.label10.Text = "Thông tin cuốn sách";
            // 
            // labelTheLoai
            // 
            this.labelTheLoai.AutoSize = true;
            this.labelTheLoai.Font = new System.Drawing.Font("Segoe UI Variable Display", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTheLoai.ForeColor = System.Drawing.Color.Black;
            this.labelTheLoai.Location = new System.Drawing.Point(14, 256);
            this.labelTheLoai.Name = "labelTheLoai";
            this.labelTheLoai.Size = new System.Drawing.Size(107, 31);
            this.labelTheLoai.TabIndex = 128;
            this.labelTheLoai.Text = "Thể loại: ";
            // 
            // siticoneVSeparator1
            // 
            this.siticoneVSeparator1.FillColor = System.Drawing.Color.Black;
            this.siticoneVSeparator1.FillThickness = 2;
            this.siticoneVSeparator1.Location = new System.Drawing.Point(345, 77);
            this.siticoneVSeparator1.Name = "siticoneVSeparator1";
            this.siticoneVSeparator1.Size = new System.Drawing.Size(10, 476);
            this.siticoneVSeparator1.TabIndex = 151;
            // 
            // comboDocGia
            // 
            this.comboDocGia.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboDocGia.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboDocGia.DataSource = this.dOCGIABindingSource;
            this.comboDocGia.DisplayMember = "MaDocGia";
            this.comboDocGia.Font = new System.Drawing.Font("Segoe UI Variable Display", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboDocGia.FormattingEnabled = true;
            this.comboDocGia.Location = new System.Drawing.Point(20, 402);
            this.comboDocGia.Name = "comboDocGia";
            this.comboDocGia.Size = new System.Drawing.Size(236, 32);
            this.comboDocGia.TabIndex = 155;
            this.comboDocGia.ValueMember = "ID";
            this.comboDocGia.SelectedIndexChanged += new System.EventHandler(this.comboDocGia_SelectedIndexChanged);
            // 
            // dOCGIABindingSource
            // 
            this.dOCGIABindingSource.DataSource = typeof(DTO.DOCGIA);
            // 
            // comboCuonSach
            // 
            this.comboCuonSach.AllowDrop = true;
            this.comboCuonSach.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboCuonSach.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboCuonSach.DataSource = this.cUONSACHBindingSource;
            this.comboCuonSach.DisplayMember = "MaCuonSach";
            this.comboCuonSach.Font = new System.Drawing.Font("Segoe UI Variable Display", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboCuonSach.FormattingEnabled = true;
            this.comboCuonSach.Location = new System.Drawing.Point(20, 176);
            this.comboCuonSach.Name = "comboCuonSach";
            this.comboCuonSach.Size = new System.Drawing.Size(231, 32);
            this.comboCuonSach.TabIndex = 154;
            this.comboCuonSach.ValueMember = "id";
            this.comboCuonSach.SelectedIndexChanged += new System.EventHandler(this.comboCuonSach_SelectedIndexChanged);
            // 
            // cUONSACHBindingSource
            // 
            this.cUONSACHBindingSource.DataSource = typeof(DTO.CUONSACH);
            // 
            // siticoneSeparator2
            // 
            this.siticoneSeparator2.FillColor = System.Drawing.Color.Black;
            this.siticoneSeparator2.Location = new System.Drawing.Point(3, 283);
            this.siticoneSeparator2.Name = "siticoneSeparator2";
            this.siticoneSeparator2.Size = new System.Drawing.Size(352, 28);
            this.siticoneSeparator2.TabIndex = 150;
            // 
            // butSave
            // 
            this.butSave.BorderRadius = 6;
            this.butSave.BorderThickness = 2;
            this.butSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.butSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.butSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.butSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.butSave.FillColor = System.Drawing.Color.DodgerBlue;
            this.butSave.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butSave.ForeColor = System.Drawing.Color.White;
            this.butSave.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.butSave.Location = new System.Drawing.Point(252, 559);
            this.butSave.Name = "butSave";
            this.butSave.Size = new System.Drawing.Size(246, 43);
            this.butSave.TabIndex = 65;
            this.butSave.Text = "Lưu";
            this.butSave.Click += new System.EventHandler(this.butSave_Click_1);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(13, 303);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(240, 37);
            this.label13.TabIndex = 147;
            this.label13.Text = "Thông tin độc giả";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(358, 77);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(236, 37);
            this.label8.TabIndex = 146;
            this.label8.Text = "Chi tiết mượn trả";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // dateNgayMuon
            // 
            this.dateNgayMuon.Checked = true;
            this.dateNgayMuon.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dateNgayMuon.Font = new System.Drawing.Font("Segoe UI Variable Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateNgayMuon.ForeColor = System.Drawing.Color.Black;
            this.dateNgayMuon.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateNgayMuon.Location = new System.Drawing.Point(365, 174);
            this.dateNgayMuon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateNgayMuon.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dateNgayMuon.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dateNgayMuon.Name = "dateNgayMuon";
            this.dateNgayMuon.Size = new System.Drawing.Size(177, 38);
            this.dateNgayMuon.TabIndex = 131;
            this.dateNgayMuon.Value = new System.DateTime(2022, 12, 2, 22, 44, 12, 275);
            this.dateNgayMuon.ValueChanged += new System.EventHandler(this.dateNgayMuon_ValueChanged_1);
            // 
            // labelHanTra
            // 
            this.labelHanTra.AutoSize = true;
            this.labelHanTra.Font = new System.Drawing.Font("Segoe UI Variable Display", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHanTra.ForeColor = System.Drawing.Color.Black;
            this.labelHanTra.Location = new System.Drawing.Point(577, 181);
            this.labelHanTra.Name = "labelHanTra";
            this.labelHanTra.Size = new System.Drawing.Size(148, 31);
            this.labelHanTra.TabIndex = 129;
            this.labelHanTra.Text = "dd/mm/yyyy";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Variable Display", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(579, 148);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 24);
            this.label11.TabIndex = 129;
            this.label11.Text = "Hạn trả";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Variable Display", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(16, 374);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 24);
            this.label3.TabIndex = 128;
            this.label3.Text = "Độc giả";
            // 
            // labelTienPhat
            // 
            this.labelTienPhat.AutoSize = true;
            this.labelTienPhat.Font = new System.Drawing.Font("Segoe UI Variable Display", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTienPhat.ForeColor = System.Drawing.Color.Black;
            this.labelTienPhat.Location = new System.Drawing.Point(359, 335);
            this.labelTienPhat.Name = "labelTienPhat";
            this.labelTienPhat.Size = new System.Drawing.Size(153, 31);
            this.labelTienPhat.TabIndex = 128;
            this.labelTienPhat.Text = "Số tiền phạt: ";
            // 
            // labelTongNoHienTai
            // 
            this.labelTongNoHienTai.AutoSize = true;
            this.labelTongNoHienTai.Font = new System.Drawing.Font("Segoe UI Variable Display", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTongNoHienTai.ForeColor = System.Drawing.Color.Black;
            this.labelTongNoHienTai.Location = new System.Drawing.Point(14, 482);
            this.labelTongNoHienTai.Name = "labelTongNoHienTai";
            this.labelTongNoHienTai.Size = new System.Drawing.Size(196, 31);
            this.labelTongNoHienTai.TabIndex = 128;
            this.labelTongNoHienTai.Text = "Tổng nợ hiện tại: ";
            // 
            // labelDonGiaPhat
            // 
            this.labelDonGiaPhat.AutoSize = true;
            this.labelDonGiaPhat.Font = new System.Drawing.Font("Segoe UI Variable Display", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDonGiaPhat.ForeColor = System.Drawing.Color.Black;
            this.labelDonGiaPhat.Location = new System.Drawing.Point(359, 280);
            this.labelDonGiaPhat.Name = "labelDonGiaPhat";
            this.labelDonGiaPhat.Size = new System.Drawing.Size(161, 31);
            this.labelDonGiaPhat.TabIndex = 128;
            this.labelDonGiaPhat.Text = "Đơn giá phạt: ";
            // 
            // labelTongNoMoi
            // 
            this.labelTongNoMoi.AutoSize = true;
            this.labelTongNoMoi.Font = new System.Drawing.Font("Segoe UI Variable Display", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTongNoMoi.ForeColor = System.Drawing.Color.Black;
            this.labelTongNoMoi.Location = new System.Drawing.Point(359, 390);
            this.labelTongNoMoi.Name = "labelTongNoMoi";
            this.labelTongNoMoi.Size = new System.Drawing.Size(159, 31);
            this.labelTongNoMoi.TabIndex = 128;
            this.labelTongNoMoi.Text = "Tổng nợ mới: ";
            // 
            // labelSoNgayTre
            // 
            this.labelSoNgayTre.AutoSize = true;
            this.labelSoNgayTre.Font = new System.Drawing.Font("Segoe UI Variable Display", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSoNgayTre.ForeColor = System.Drawing.Color.Black;
            this.labelSoNgayTre.Location = new System.Drawing.Point(359, 225);
            this.labelSoNgayTre.Name = "labelSoNgayTre";
            this.labelSoNgayTre.Size = new System.Drawing.Size(183, 31);
            this.labelSoNgayTre.TabIndex = 128;
            this.labelSoNgayTre.Text = "Số ngày trả trễ: ";
            // 
            // labelHoTen
            // 
            this.labelHoTen.AutoSize = true;
            this.labelHoTen.Font = new System.Drawing.Font("Segoe UI Variable Display", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHoTen.ForeColor = System.Drawing.Color.Black;
            this.labelHoTen.Location = new System.Drawing.Point(14, 437);
            this.labelHoTen.Name = "labelHoTen";
            this.labelHoTen.Size = new System.Drawing.Size(96, 31);
            this.labelHoTen.TabIndex = 128;
            this.labelHoTen.Text = "Họ tên: ";
            // 
            // labelTenCS
            // 
            this.labelTenCS.AutoSize = true;
            this.labelTenCS.Font = new System.Drawing.Font("Segoe UI Variable Display", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTenCS.ForeColor = System.Drawing.Color.Black;
            this.labelTenCS.Location = new System.Drawing.Point(14, 211);
            this.labelTenCS.Name = "labelTenCS";
            this.labelTenCS.Size = new System.Drawing.Size(62, 31);
            this.labelTenCS.TabIndex = 128;
            this.labelTenCS.Text = "Tên: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Variable Display", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(16, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 24);
            this.label2.TabIndex = 128;
            this.label2.Text = "Mã cuốn sách";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI Variable Display", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(361, 148);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(109, 24);
            this.label12.TabIndex = 128;
            this.label12.Text = "Ngày mượn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Variable Display", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(192, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(338, 49);
            this.label1.TabIndex = 5;
            this.label1.Text = "PHIẾU MƯỢN TRẢ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // siticoneSeparator1
            // 
            this.siticoneSeparator1.FillColor = System.Drawing.Color.Black;
            this.siticoneSeparator1.Location = new System.Drawing.Point(3, 61);
            this.siticoneSeparator1.Name = "siticoneSeparator1";
            this.siticoneSeparator1.Size = new System.Drawing.Size(748, 28);
            this.siticoneSeparator1.TabIndex = 156;
            // 
            // siticoneSeparator4
            // 
            this.siticoneSeparator4.FillColor = System.Drawing.Color.Black;
            this.siticoneSeparator4.Location = new System.Drawing.Point(3, 117);
            this.siticoneSeparator4.Name = "siticoneSeparator4";
            this.siticoneSeparator4.Size = new System.Drawing.Size(748, 28);
            this.siticoneSeparator4.TabIndex = 159;
            // 
            // siticoneSeparator5
            // 
            this.siticoneSeparator5.FillColor = System.Drawing.Color.Black;
            this.siticoneSeparator5.Location = new System.Drawing.Point(3, 343);
            this.siticoneSeparator5.Name = "siticoneSeparator5";
            this.siticoneSeparator5.Size = new System.Drawing.Size(352, 28);
            this.siticoneSeparator5.TabIndex = 160;
            // 
            // siticoneSeparator3
            // 
            this.siticoneSeparator3.FillColor = System.Drawing.Color.Black;
            this.siticoneSeparator3.Location = new System.Drawing.Point(3, 540);
            this.siticoneSeparator3.Name = "siticoneSeparator3";
            this.siticoneSeparator3.Size = new System.Drawing.Size(748, 28);
            this.siticoneSeparator3.TabIndex = 157;
            // 
            // siticoneControlBox2
            // 
            this.siticoneControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.siticoneControlBox2.BackColor = System.Drawing.Color.Transparent;
            this.siticoneControlBox2.ControlBoxType = Siticone.Desktop.UI.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.siticoneControlBox2.FillColor = System.Drawing.Color.Transparent;
            this.siticoneControlBox2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.siticoneControlBox2.IconColor = System.Drawing.SystemColors.ControlDarkDark;
            this.siticoneControlBox2.Location = new System.Drawing.Point(761, -1);
            this.siticoneControlBox2.Name = "siticoneControlBox2";
            this.siticoneControlBox2.Size = new System.Drawing.Size(60, 48);
            this.siticoneControlBox2.TabIndex = 66;
            // 
            // siticoneControlBox1
            // 
            this.siticoneControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.siticoneControlBox1.BackColor = System.Drawing.Color.Transparent;
            this.siticoneControlBox1.FillColor = System.Drawing.Color.Transparent;
            this.siticoneControlBox1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.siticoneControlBox1.IconColor = System.Drawing.SystemColors.ControlDarkDark;
            this.siticoneControlBox1.Location = new System.Drawing.Point(818, -1);
            this.siticoneControlBox1.Name = "siticoneControlBox1";
            this.siticoneControlBox1.Size = new System.Drawing.Size(60, 48);
            this.siticoneControlBox1.TabIndex = 67;
            // 
            // siticoneDragControl1
            // 
            this.siticoneDragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.siticoneDragControl1.TargetControl = this;
            this.siticoneDragControl1.UseTransparentDrag = true;
            // 
            // ErrorDia
            // 
            this.ErrorDia.Buttons = Siticone.Desktop.UI.WinForms.MessageDialogButtons.OK;
            this.ErrorDia.Caption = null;
            this.ErrorDia.Icon = Siticone.Desktop.UI.WinForms.MessageDialogIcon.Error;
            this.ErrorDia.Parent = null;
            this.ErrorDia.Style = Siticone.Desktop.UI.WinForms.MessageDialogStyle.Default;
            this.ErrorDia.Text = null;
            // 
            // SuccDia
            // 
            this.SuccDia.Buttons = Siticone.Desktop.UI.WinForms.MessageDialogButtons.OK;
            this.SuccDia.Caption = null;
            this.SuccDia.Icon = Siticone.Desktop.UI.WinForms.MessageDialogIcon.None;
            this.SuccDia.Parent = null;
            this.SuccDia.Style = Siticone.Desktop.UI.WinForms.MessageDialogStyle.Default;
            this.SuccDia.Text = null;
            // 
            // fPhieuMuonSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BackgroundImage = global::GUI.Properties.Resources.loginimg;
            this.ClientSize = new System.Drawing.Size(875, 766);
            this.Controls.Add(this.siticoneControlBox2);
            this.Controls.Add(this.siticoneControlBox1);
            this.Controls.Add(this.siticonePanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "fPhieuMuonSach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BMChoMuonSach";
            this.siticonePanel1.ResumeLayout(false);
            this.siticonePanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dOCGIABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cUONSACHBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticonePanel siticonePanel1;
        private Label label1;
        private Siticone.Desktop.UI.WinForms.SiticoneButton butSave;
        private Siticone.Desktop.UI.WinForms.SiticoneControlBox siticoneControlBox2;
        private Siticone.Desktop.UI.WinForms.SiticoneControlBox siticoneControlBox1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private Label label13;
        private Label label10;
        private Siticone.Desktop.UI.WinForms.SiticoneDateTimePicker dateNgayMuon;
        private Label label11;
        private Label label12;
        private Label labelHanTra;
        private Siticone.Desktop.UI.WinForms.SiticoneVSeparator siticoneVSeparator1;
        private Siticone.Desktop.UI.WinForms.SiticoneSeparator siticoneSeparator2;
        private Label label8;
        private Label label3;
        private Label labelTheLoai;
        private Label labelTienPhat;
        private Label labelTongNoHienTai;
        private Label labelDonGiaPhat;
        private Label labelTongNoMoi;
        private Label labelSoNgayTre;
        private Label labelHoTen;
        private Label labelTenCS;
        private Label label2;
        private Siticone.Desktop.UI.WinForms.SiticoneDragControl siticoneDragControl1;
        private Siticone.Desktop.UI.WinForms.SiticoneMessageDialog ErrorDia;
        private ComboBox comboDocGia;
        private ComboBox comboCuonSach;
        private Siticone.Desktop.UI.WinForms.SiticoneMessageDialog SuccDia;
        private BindingSource dOCGIABindingSource;
        private BindingSource cUONSACHBindingSource;
        private Siticone.Desktop.UI.WinForms.SiticoneSeparator siticoneSeparator1;
        private Siticone.Desktop.UI.WinForms.SiticoneSeparator siticoneSeparator3;
        private Siticone.Desktop.UI.WinForms.SiticoneSeparator siticoneSeparator5;
        private Siticone.Desktop.UI.WinForms.SiticoneSeparator siticoneSeparator4;
    }
}
using Siticone.Desktop.UI.WinForms;

namespace GUI.UserControls
{
    partial class ucQLSach
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
            this.container = new Siticone.Desktop.UI.WinForms.SiticoneContainerControl();
            this.butTuaSach = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.butSach = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.butCuonsach = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.butTacGia = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.butTheLoai = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.butPhieuNhap = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.siticoneGradientPanel1 = new Siticone.Desktop.UI.WinForms.SiticoneGradientPanel();
            this.siticoneGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // container
            // 
            this.container.BackColor = System.Drawing.Color.AliceBlue;
            this.container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.container.FillColor = System.Drawing.Color.Transparent;
            this.container.ForeColor = System.Drawing.Color.White;
            this.container.Location = new System.Drawing.Point(0, 62);
            this.container.Name = "container";
            this.container.Size = new System.Drawing.Size(1187, 631);
            this.container.TabIndex = 1;
            this.container.Text = "siticoneContainerControl2";
            this.container.Click += new System.EventHandler(this.container_Click);
            // 
            // butTuaSach
            // 
            this.butTuaSach.BackColor = System.Drawing.Color.DodgerBlue;
            this.butTuaSach.BorderColor = System.Drawing.Color.Transparent;
            this.butTuaSach.ButtonMode = Siticone.Desktop.UI.WinForms.Enums.ButtonMode.RadioButton;
            this.butTuaSach.CheckedState.BorderColor = System.Drawing.Color.Transparent;
            this.butTuaSach.CheckedState.FillColor = System.Drawing.Color.DodgerBlue;
            this.butTuaSach.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.butTuaSach.CustomBorderColor = System.Drawing.Color.DodgerBlue;
            this.butTuaSach.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.butTuaSach.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.butTuaSach.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.butTuaSach.DisabledState.FillColor = System.Drawing.Color.DarkGray;
            this.butTuaSach.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.butTuaSach.Dock = System.Windows.Forms.DockStyle.Left;
            this.butTuaSach.FillColor = System.Drawing.Color.Transparent;
            this.butTuaSach.Font = new System.Drawing.Font("Segoe UI Variable Display", 13.8F, System.Drawing.FontStyle.Bold);
            this.butTuaSach.ForeColor = System.Drawing.Color.Black;
            this.butTuaSach.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.butTuaSach.Location = new System.Drawing.Point(0, 0);
            this.butTuaSach.Name = "butTuaSach";
            this.butTuaSach.Size = new System.Drawing.Size(189, 62);
            this.butTuaSach.TabIndex = 1;
            this.butTuaSach.Text = "Tựa sách";
            this.butTuaSach.Click += new System.EventHandler(this.butTuaSach_Click);
            // 
            // butSach
            // 
            this.butSach.BackColor = System.Drawing.Color.DodgerBlue;
            this.butSach.BorderColor = System.Drawing.Color.Transparent;
            this.butSach.ButtonMode = Siticone.Desktop.UI.WinForms.Enums.ButtonMode.RadioButton;
            this.butSach.CheckedState.BorderColor = System.Drawing.Color.Transparent;
            this.butSach.CheckedState.FillColor = System.Drawing.Color.DodgerBlue;
            this.butSach.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.butSach.CustomBorderColor = System.Drawing.Color.DodgerBlue;
            this.butSach.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.butSach.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.butSach.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.butSach.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.butSach.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.butSach.Dock = System.Windows.Forms.DockStyle.Left;
            this.butSach.FillColor = System.Drawing.Color.Transparent;
            this.butSach.Font = new System.Drawing.Font("Segoe UI Variable Display", 13.8F, System.Drawing.FontStyle.Bold);
            this.butSach.ForeColor = System.Drawing.Color.Black;
            this.butSach.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.butSach.Location = new System.Drawing.Point(189, 0);
            this.butSach.Name = "butSach";
            this.butSach.Size = new System.Drawing.Size(173, 62);
            this.butSach.TabIndex = 0;
            this.butSach.Text = "Sách";
            this.butSach.Click += new System.EventHandler(this.butSach_Click);
            // 
            // butCuonsach
            // 
            this.butCuonsach.BackColor = System.Drawing.Color.DodgerBlue;
            this.butCuonsach.BorderColor = System.Drawing.Color.Transparent;
            this.butCuonsach.ButtonMode = Siticone.Desktop.UI.WinForms.Enums.ButtonMode.RadioButton;
            this.butCuonsach.CheckedState.BorderColor = System.Drawing.Color.Transparent;
            this.butCuonsach.CheckedState.FillColor = System.Drawing.Color.DodgerBlue;
            this.butCuonsach.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.butCuonsach.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.butCuonsach.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.butCuonsach.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.butCuonsach.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.butCuonsach.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.butCuonsach.Dock = System.Windows.Forms.DockStyle.Left;
            this.butCuonsach.FillColor = System.Drawing.Color.Transparent;
            this.butCuonsach.Font = new System.Drawing.Font("Segoe UI Variable Display", 13.8F, System.Drawing.FontStyle.Bold);
            this.butCuonsach.ForeColor = System.Drawing.Color.Black;
            this.butCuonsach.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.butCuonsach.Location = new System.Drawing.Point(362, 0);
            this.butCuonsach.Name = "butCuonsach";
            this.butCuonsach.Size = new System.Drawing.Size(187, 62);
            this.butCuonsach.TabIndex = 2;
            this.butCuonsach.Text = "Cuốn sách";
            this.butCuonsach.Click += new System.EventHandler(this.butCuonsach_Click_1);
            // 
            // butTacGia
            // 
            this.butTacGia.BackColor = System.Drawing.Color.DodgerBlue;
            this.butTacGia.BorderColor = System.Drawing.Color.Transparent;
            this.butTacGia.ButtonMode = Siticone.Desktop.UI.WinForms.Enums.ButtonMode.RadioButton;
            this.butTacGia.CheckedState.BorderColor = System.Drawing.Color.Transparent;
            this.butTacGia.CheckedState.FillColor = System.Drawing.Color.DodgerBlue;
            this.butTacGia.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.butTacGia.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.butTacGia.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.butTacGia.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.butTacGia.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.butTacGia.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.butTacGia.Dock = System.Windows.Forms.DockStyle.Left;
            this.butTacGia.FillColor = System.Drawing.Color.Transparent;
            this.butTacGia.Font = new System.Drawing.Font("Segoe UI Variable Display", 13.8F, System.Drawing.FontStyle.Bold);
            this.butTacGia.ForeColor = System.Drawing.Color.Black;
            this.butTacGia.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.butTacGia.Location = new System.Drawing.Point(549, 0);
            this.butTacGia.Name = "butTacGia";
            this.butTacGia.Size = new System.Drawing.Size(199, 62);
            this.butTacGia.TabIndex = 3;
            this.butTacGia.Text = "Tác giả";
            this.butTacGia.Click += new System.EventHandler(this.butTacGia_Click);
            // 
            // butTheLoai
            // 
            this.butTheLoai.BackColor = System.Drawing.Color.DodgerBlue;
            this.butTheLoai.BorderColor = System.Drawing.Color.Transparent;
            this.butTheLoai.ButtonMode = Siticone.Desktop.UI.WinForms.Enums.ButtonMode.RadioButton;
            this.butTheLoai.CheckedState.BorderColor = System.Drawing.Color.Transparent;
            this.butTheLoai.CheckedState.FillColor = System.Drawing.Color.DodgerBlue;
            this.butTheLoai.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.butTheLoai.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.butTheLoai.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.butTheLoai.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.butTheLoai.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.butTheLoai.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.butTheLoai.Dock = System.Windows.Forms.DockStyle.Left;
            this.butTheLoai.FillColor = System.Drawing.Color.Transparent;
            this.butTheLoai.Font = new System.Drawing.Font("Segoe UI Variable Display", 13.8F, System.Drawing.FontStyle.Bold);
            this.butTheLoai.ForeColor = System.Drawing.Color.Black;
            this.butTheLoai.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.butTheLoai.Location = new System.Drawing.Point(748, 0);
            this.butTheLoai.Name = "butTheLoai";
            this.butTheLoai.Size = new System.Drawing.Size(188, 62);
            this.butTheLoai.TabIndex = 4;
            this.butTheLoai.Text = "Thể loại";
            this.butTheLoai.Click += new System.EventHandler(this.butTheLoai_Click);
            // 
            // butPhieuNhap
            // 
            this.butPhieuNhap.BackColor = System.Drawing.Color.DodgerBlue;
            this.butPhieuNhap.BorderColor = System.Drawing.Color.Transparent;
            this.butPhieuNhap.ButtonMode = Siticone.Desktop.UI.WinForms.Enums.ButtonMode.RadioButton;
            this.butPhieuNhap.CheckedState.BorderColor = System.Drawing.Color.Transparent;
            this.butPhieuNhap.CheckedState.FillColor = System.Drawing.Color.DodgerBlue;
            this.butPhieuNhap.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.butPhieuNhap.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.butPhieuNhap.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.butPhieuNhap.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.butPhieuNhap.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.butPhieuNhap.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.butPhieuNhap.Dock = System.Windows.Forms.DockStyle.Left;
            this.butPhieuNhap.FillColor = System.Drawing.Color.Transparent;
            this.butPhieuNhap.Font = new System.Drawing.Font("Segoe UI Variable Display", 13.8F, System.Drawing.FontStyle.Bold);
            this.butPhieuNhap.ForeColor = System.Drawing.Color.Black;
            this.butPhieuNhap.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.butPhieuNhap.Location = new System.Drawing.Point(936, 0);
            this.butPhieuNhap.Name = "butPhieuNhap";
            this.butPhieuNhap.Size = new System.Drawing.Size(255, 62);
            this.butPhieuNhap.TabIndex = 5;
            this.butPhieuNhap.Text = "Phiếu nhập sách";
            this.butPhieuNhap.Click += new System.EventHandler(this.butPhieuNhap_Click);
            // 
            // siticoneGradientPanel1
            // 
            this.siticoneGradientPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.siticoneGradientPanel1.Controls.Add(this.butPhieuNhap);
            this.siticoneGradientPanel1.Controls.Add(this.butTheLoai);
            this.siticoneGradientPanel1.Controls.Add(this.butTacGia);
            this.siticoneGradientPanel1.Controls.Add(this.butCuonsach);
            this.siticoneGradientPanel1.Controls.Add(this.butSach);
            this.siticoneGradientPanel1.Controls.Add(this.butTuaSach);
            this.siticoneGradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.siticoneGradientPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.siticoneGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.siticoneGradientPanel1.Name = "siticoneGradientPanel1";
            this.siticoneGradientPanel1.Size = new System.Drawing.Size(1187, 62);
            this.siticoneGradientPanel1.TabIndex = 0;
            // 
            // ucQLSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.container);
            this.Controls.Add(this.siticoneGradientPanel1);
            this.Name = "ucQLSach";
            this.Size = new System.Drawing.Size(1187, 693);
            this.siticoneGradientPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Siticone.Desktop.UI.WinForms.SiticoneContainerControl container;
        private SiticoneButton butTuaSach;
        private SiticoneButton butSach;
        private SiticoneButton butCuonsach;
        private SiticoneButton butTacGia;
        private SiticoneButton butTheLoai;
        private SiticoneButton butPhieuNhap;
        private SiticoneGradientPanel siticoneGradientPanel1;
        //public SiticoneContainerControl Container1 { get => container; set => container = value; }
    }
}

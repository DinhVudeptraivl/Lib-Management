using Siticone.Desktop.UI.WinForms;

namespace GUI.UserControls
{
    partial class ucQLDG
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
            this.siticoneGradientPanel1 = new Siticone.Desktop.UI.WinForms.SiticoneGradientPanel();
            this.butLoaiDG = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.butDocGia = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.container = new Siticone.Desktop.UI.WinForms.SiticoneContainerControl();
            this.siticoneGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // siticoneGradientPanel1
            // 
            this.siticoneGradientPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.siticoneGradientPanel1.Controls.Add(this.butLoaiDG);
            this.siticoneGradientPanel1.Controls.Add(this.butDocGia);
            this.siticoneGradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.siticoneGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.siticoneGradientPanel1.Name = "siticoneGradientPanel1";
            this.siticoneGradientPanel1.Size = new System.Drawing.Size(997, 59);
            this.siticoneGradientPanel1.TabIndex = 0;
            // 
            // butLoaiDG
            // 
            this.butLoaiDG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.butLoaiDG.BorderColor = System.Drawing.Color.Transparent;
            this.butLoaiDG.ButtonMode = Siticone.Desktop.UI.WinForms.Enums.ButtonMode.RadioButton;
            this.butLoaiDG.CheckedState.BorderColor = System.Drawing.Color.Transparent;
            this.butLoaiDG.CheckedState.FillColor = System.Drawing.Color.DodgerBlue;
            this.butLoaiDG.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.butLoaiDG.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.butLoaiDG.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.butLoaiDG.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.butLoaiDG.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.butLoaiDG.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.butLoaiDG.Dock = System.Windows.Forms.DockStyle.Left;
            this.butLoaiDG.FillColor = System.Drawing.Color.DodgerBlue;
            this.butLoaiDG.Font = new System.Drawing.Font("Segoe UI Variable Display", 13.8F, System.Drawing.FontStyle.Bold);
            this.butLoaiDG.ForeColor = System.Drawing.Color.Black;
            this.butLoaiDG.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.butLoaiDG.Location = new System.Drawing.Point(236, 0);
            this.butLoaiDG.Name = "butLoaiDG";
            this.butLoaiDG.Size = new System.Drawing.Size(226, 59);
            this.butLoaiDG.TabIndex = 1;
            this.butLoaiDG.Text = "Loại độc giả";
            this.butLoaiDG.Click += new System.EventHandler(this.butLoaiDG_Click);
            // 
            // butDocGia
            // 
            this.butDocGia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.butDocGia.BorderColor = System.Drawing.Color.Transparent;
            this.butDocGia.ButtonMode = Siticone.Desktop.UI.WinForms.Enums.ButtonMode.RadioButton;
            this.butDocGia.CheckedState.BorderColor = System.Drawing.Color.Transparent;
            this.butDocGia.CheckedState.FillColor = System.Drawing.Color.DodgerBlue;
            this.butDocGia.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.butDocGia.CustomBorderColor = System.Drawing.Color.Transparent;
            this.butDocGia.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.butDocGia.DisabledState.BorderColor = System.Drawing.Color.Transparent;
            this.butDocGia.DisabledState.FillColor = System.Drawing.Color.Transparent;
            this.butDocGia.DisabledState.ForeColor = System.Drawing.Color.Black;
            this.butDocGia.Dock = System.Windows.Forms.DockStyle.Left;
            this.butDocGia.FillColor = System.Drawing.Color.Empty;
            this.butDocGia.Font = new System.Drawing.Font("Segoe UI Variable Display", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butDocGia.ForeColor = System.Drawing.Color.Black;
            this.butDocGia.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.butDocGia.Location = new System.Drawing.Point(0, 0);
            this.butDocGia.Name = "butDocGia";
            this.butDocGia.Size = new System.Drawing.Size(236, 59);
            this.butDocGia.TabIndex = 0;
            this.butDocGia.Text = "Độc giả";
            this.butDocGia.Click += new System.EventHandler(this.butDocGia_Click);
            // 
            // container
            // 
            this.container.BackColor = System.Drawing.Color.AliceBlue;
            this.container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.container.FillColor = System.Drawing.Color.Transparent;
            this.container.Location = new System.Drawing.Point(0, 59);
            this.container.Name = "container";
            this.container.Size = new System.Drawing.Size(997, 593);
            this.container.TabIndex = 1;
            this.container.Text = "siticoneContainerControl2";
            // 
            // ucQLDG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.container);
            this.Controls.Add(this.siticoneGradientPanel1);
            this.Name = "ucQLDG";
            this.Size = new System.Drawing.Size(997, 652);
            this.siticoneGradientPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticoneGradientPanel siticoneGradientPanel1;
        private Siticone.Desktop.UI.WinForms.SiticoneButton butLoaiDG;
        private Siticone.Desktop.UI.WinForms.SiticoneButton butDocGia;
        private Siticone.Desktop.UI.WinForms.SiticoneContainerControl container;
        private static ucDocGia ucdg;
        private static ucLoaiDG ucloaidg;
        //public SiticoneContainerControl Container1 { get => container; set => container = value; }
    }
}

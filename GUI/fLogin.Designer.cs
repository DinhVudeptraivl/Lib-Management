namespace GUI
{
    partial class fLogin
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
            this.siticoneControlBox1 = new Siticone.Desktop.UI.WinForms.SiticoneControlBox();
            this.siticoneControlBox2 = new Siticone.Desktop.UI.WinForms.SiticoneControlBox();
            this.siticonePanel1 = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.butLogin = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.txtUserpwd = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.txtUsername = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.siticoneSeparator1 = new Siticone.Desktop.UI.WinForms.SiticoneSeparator();
            this.siticoneBorderlessForm1 = new Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm(this.components);
            this.siticonePanel2 = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.siticoneDragControl1 = new Siticone.Desktop.UI.WinForms.SiticoneDragControl(this.components);
            this.siticoneDragControl2 = new Siticone.Desktop.UI.WinForms.SiticoneDragControl(this.components);
            this.siticonePanel1.SuspendLayout();
            this.siticonePanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // siticoneControlBox1
            // 
            this.siticoneControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.siticoneControlBox1.FillColor = System.Drawing.Color.Transparent;
            this.siticoneControlBox1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.siticoneControlBox1.IconColor = System.Drawing.SystemColors.ControlDarkDark;
            this.siticoneControlBox1.Location = new System.Drawing.Point(502, 5);
            this.siticoneControlBox1.Name = "siticoneControlBox1";
            this.siticoneControlBox1.Size = new System.Drawing.Size(59, 52);
            this.siticoneControlBox1.TabIndex = 2;
            // 
            // siticoneControlBox2
            // 
            this.siticoneControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.siticoneControlBox2.ControlBoxType = Siticone.Desktop.UI.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.siticoneControlBox2.FillColor = System.Drawing.Color.Transparent;
            this.siticoneControlBox2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.siticoneControlBox2.IconColor = System.Drawing.SystemColors.ControlDarkDark;
            this.siticoneControlBox2.Location = new System.Drawing.Point(440, 3);
            this.siticoneControlBox2.Name = "siticoneControlBox2";
            this.siticoneControlBox2.Size = new System.Drawing.Size(60, 52);
            this.siticoneControlBox2.TabIndex = 1;
            this.siticoneControlBox2.Click += new System.EventHandler(this.siticoneControlBox2_Click);
            // 
            // siticonePanel1
            // 
            this.siticonePanel1.BackColor = System.Drawing.Color.Transparent;
            this.siticonePanel1.BackgroundImage = global::GUI.Properties.Resources.loginimg;
            this.siticonePanel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.siticonePanel1.BorderRadius = 6;
            this.siticonePanel1.BorderThickness = 2;
            this.siticonePanel1.Controls.Add(this.label9);
            this.siticonePanel1.Controls.Add(this.label8);
            this.siticonePanel1.Controls.Add(this.butLogin);
            this.siticonePanel1.Controls.Add(this.txtUserpwd);
            this.siticonePanel1.Controls.Add(this.txtUsername);
            this.siticonePanel1.Controls.Add(this.label1);
            this.siticonePanel1.Controls.Add(this.siticoneSeparator1);
            this.siticonePanel1.Location = new System.Drawing.Point(59, 89);
            this.siticonePanel1.Name = "siticonePanel1";
            this.siticonePanel1.ShadowDecoration.BorderRadius = 8;
            this.siticonePanel1.ShadowDecoration.Color = System.Drawing.Color.White;
            this.siticonePanel1.ShadowDecoration.Enabled = true;
            this.siticonePanel1.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 8, 8);
            this.siticonePanel1.Size = new System.Drawing.Size(439, 351);
            this.siticonePanel1.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Segoe UI Variable Display", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(21, 177);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 22);
            this.label9.TabIndex = 6;
            this.label9.Text = "Mật Khẩu*";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Segoe UI Variable Display", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(21, 99);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(138, 22);
            this.label8.TabIndex = 5;
            this.label8.Text = "Tên Đăng Nhập*";
            // 
            // butLogin
            // 
            this.butLogin.BackColor = System.Drawing.Color.Transparent;
            this.butLogin.BorderColor = System.Drawing.Color.Transparent;
            this.butLogin.BorderRadius = 6;
            this.butLogin.BorderThickness = 2;
            this.butLogin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.butLogin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.butLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.butLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.butLogin.FillColor = System.Drawing.Color.SteelBlue;
            this.butLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(241)))), ((int)(((byte)(255)))));
            this.butLogin.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.butLogin.Location = new System.Drawing.Point(116, 275);
            this.butLogin.Name = "butLogin";
            this.butLogin.Size = new System.Drawing.Size(210, 39);
            this.butLogin.TabIndex = 2;
            this.butLogin.Text = "LOGIN";
            this.butLogin.Click += new System.EventHandler(this.butLogin_Click);
            // 
            // txtUserpwd
            // 
            this.txtUserpwd.BackColor = System.Drawing.Color.AliceBlue;
            this.txtUserpwd.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtUserpwd.BorderRadius = 4;
            this.txtUserpwd.BorderThickness = 2;
            this.txtUserpwd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUserpwd.DefaultText = "";
            this.txtUserpwd.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUserpwd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUserpwd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUserpwd.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUserpwd.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(196)))), ((int)(((byte)(255)))));
            this.txtUserpwd.FocusedState.ForeColor = System.Drawing.Color.SlateBlue;
            this.txtUserpwd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtUserpwd.ForeColor = System.Drawing.Color.SlateGray;
            this.txtUserpwd.HoverState.BorderColor = System.Drawing.Color.Silver;
            this.txtUserpwd.Location = new System.Drawing.Point(23, 202);
            this.txtUserpwd.Name = "txtUserpwd";
            this.txtUserpwd.PasswordChar = '●';
            this.txtUserpwd.PlaceholderForeColor = System.Drawing.Color.LightSteelBlue;
            this.txtUserpwd.PlaceholderText = "Mật khẩu";
            this.txtUserpwd.SelectedText = "";
            this.txtUserpwd.Size = new System.Drawing.Size(390, 50);
            this.txtUserpwd.TabIndex = 1;
            this.txtUserpwd.UseSystemPasswordChar = true;
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.AliceBlue;
            this.txtUsername.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtUsername.BorderRadius = 4;
            this.txtUsername.BorderThickness = 2;
            this.txtUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsername.DefaultText = "";
            this.txtUsername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUsername.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUsername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUsername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUsername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(196)))), ((int)(((byte)(255)))));
            this.txtUsername.FocusedState.ForeColor = System.Drawing.Color.SlateBlue;
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtUsername.ForeColor = System.Drawing.Color.SlateGray;
            this.txtUsername.HoverState.BorderColor = System.Drawing.Color.Silver;
            this.txtUsername.Location = new System.Drawing.Point(23, 124);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.PasswordChar = '\0';
            this.txtUsername.PlaceholderForeColor = System.Drawing.Color.LightSteelBlue;
            this.txtUsername.PlaceholderText = "Tên đăng nhập";
            this.txtUsername.SelectedText = "";
            this.txtUsername.Size = new System.Drawing.Size(390, 50);
            this.txtUsername.TabIndex = 0;
            this.txtUsername.TextChanged += new System.EventHandler(this.txtUsername_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(123, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 69);
            this.label1.TabIndex = 3;
            this.label1.Text = "Login";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // siticoneSeparator1
            // 
            this.siticoneSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.siticoneSeparator1.FillColor = System.Drawing.Color.Black;
            this.siticoneSeparator1.FillThickness = 2;
            this.siticoneSeparator1.Location = new System.Drawing.Point(23, 64);
            this.siticoneSeparator1.Name = "siticoneSeparator1";
            this.siticoneSeparator1.Size = new System.Drawing.Size(390, 32);
            this.siticoneSeparator1.TabIndex = 4;
            this.siticoneSeparator1.Click += new System.EventHandler(this.siticoneSeparator1_Click);
            // 
            // siticoneBorderlessForm1
            // 
            this.siticoneBorderlessForm1.ContainerControl = this;
            this.siticoneBorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.siticoneBorderlessForm1.ResizeForm = false;
            this.siticoneBorderlessForm1.TransparentWhileDrag = true;
            // 
            // siticonePanel2
            // 
            this.siticonePanel2.BackColor = System.Drawing.Color.Transparent;
            this.siticonePanel2.BorderColor = System.Drawing.Color.White;
            this.siticonePanel2.BorderThickness = 2;
            this.siticonePanel2.Controls.Add(this.label2);
            this.siticonePanel2.Controls.Add(this.siticoneControlBox1);
            this.siticonePanel2.Controls.Add(this.siticoneControlBox2);
            this.siticonePanel2.CustomBorderColor = System.Drawing.Color.Black;
            this.siticonePanel2.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.siticonePanel2.ForeColor = System.Drawing.Color.Transparent;
            this.siticonePanel2.Location = new System.Drawing.Point(-2, -5);
            this.siticonePanel2.Name = "siticonePanel2";
            this.siticonePanel2.Size = new System.Drawing.Size(561, 57);
            this.siticonePanel2.TabIndex = 3;
            this.siticonePanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.siticonePanel2_Paint);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Variable Display", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(217, 57);
            this.label2.TabIndex = 0;
            this.label2.Text = "LIBRASOFT";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 0;
            // 
            // siticoneDragControl1
            // 
            this.siticoneDragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.siticoneDragControl1.TargetControl = this;
            this.siticoneDragControl1.UseTransparentDrag = true;
            // 
            // siticoneDragControl2
            // 
            this.siticoneDragControl2.DockIndicatorTransparencyValue = 0.6D;
            this.siticoneDragControl2.TargetControl = this.siticonePanel2;
            this.siticoneDragControl2.UseTransparentDrag = true;
            // 
            // fLogin
            // 
            this.AcceptButton = this.butLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BackgroundImage = global::GUI.Properties.Resources.loginimg;
            this.ClientSize = new System.Drawing.Size(559, 467);
            this.Controls.Add(this.siticonePanel2);
            this.Controls.Add(this.siticonePanel1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fLogin";
            this.Load += new System.EventHandler(this.fLogin_Load);
            this.siticonePanel1.ResumeLayout(false);
            this.siticonePanel1.PerformLayout();
            this.siticonePanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        private Siticone.Desktop.UI.WinForms.SiticoneControlBox siticoneControlBox2;
        private Siticone.Desktop.UI.WinForms.SiticoneControlBox siticoneControlBox1;
        private Siticone.Desktop.UI.WinForms.SiticonePanel siticonePanel1;
        private Siticone.Desktop.UI.WinForms.SiticoneButton butLogin;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtUserpwd;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtUsername;
        #endregion
        private System.Windows.Forms.Label label3;
        private Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm siticoneBorderlessForm1;
        private Siticone.Desktop.UI.WinForms.SiticonePanel siticonePanel2;
        private System.Windows.Forms.Label label1;
        private Siticone.Desktop.UI.WinForms.SiticoneDragControl siticoneDragControl1;
        private System.Windows.Forms.Label label2;
        private Siticone.Desktop.UI.WinForms.SiticoneSeparator siticoneSeparator1;
        private Siticone.Desktop.UI.WinForms.SiticoneDragControl siticoneDragControl2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}
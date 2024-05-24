namespace GUI
{
    partial class fEditNhomND
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.siticoneBorderlessForm1 = new Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm(this.components);
            this.siticoneControlBox2 = new Siticone.Desktop.UI.WinForms.SiticoneControlBox();
            this.siticoneControlBox1 = new Siticone.Desktop.UI.WinForms.SiticoneControlBox();
            this.siticonePanel1 = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.dsChucNang = new Siticone.Desktop.UI.WinForms.SiticoneDataGridView();
            this.isChoosen = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.idCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaChucNang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenChucNang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenManHinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.butSave = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTenNhom = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.labelMaNND = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.siticoneSeparator1 = new Siticone.Desktop.UI.WinForms.SiticoneSeparator();
            this.cHUCNANGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.siticonePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsChucNang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cHUCNANGBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // siticoneBorderlessForm1
            // 
            this.siticoneBorderlessForm1.ContainerControl = this;
            this.siticoneBorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.siticoneBorderlessForm1.TransparentWhileDrag = true;
            // 
            // siticoneControlBox2
            // 
            this.siticoneControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.siticoneControlBox2.BackColor = System.Drawing.Color.Transparent;
            this.siticoneControlBox2.ControlBoxType = Siticone.Desktop.UI.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.siticoneControlBox2.FillColor = System.Drawing.Color.Transparent;
            this.siticoneControlBox2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.siticoneControlBox2.IconColor = System.Drawing.SystemColors.ControlDarkDark;
            this.siticoneControlBox2.Location = new System.Drawing.Point(686, -1);
            this.siticoneControlBox2.Name = "siticoneControlBox2";
            this.siticoneControlBox2.Size = new System.Drawing.Size(55, 45);
            this.siticoneControlBox2.TabIndex = 12;
            // 
            // siticoneControlBox1
            // 
            this.siticoneControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.siticoneControlBox1.BackColor = System.Drawing.Color.Transparent;
            this.siticoneControlBox1.FillColor = System.Drawing.Color.Transparent;
            this.siticoneControlBox1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.siticoneControlBox1.IconColor = System.Drawing.SystemColors.ControlDarkDark;
            this.siticoneControlBox1.Location = new System.Drawing.Point(741, -1);
            this.siticoneControlBox1.Name = "siticoneControlBox1";
            this.siticoneControlBox1.Size = new System.Drawing.Size(57, 45);
            this.siticoneControlBox1.TabIndex = 13;
            // 
            // siticonePanel1
            // 
            this.siticonePanel1.BackColor = System.Drawing.Color.AliceBlue;
            this.siticonePanel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.siticonePanel1.BorderRadius = 6;
            this.siticonePanel1.BorderThickness = 2;
            this.siticonePanel1.Controls.Add(this.dsChucNang);
            this.siticonePanel1.Controls.Add(this.butSave);
            this.siticonePanel1.Controls.Add(this.label1);
            this.siticonePanel1.Controls.Add(this.txtTenNhom);
            this.siticonePanel1.Controls.Add(this.labelMaNND);
            this.siticonePanel1.Controls.Add(this.label2);
            this.siticonePanel1.Controls.Add(this.siticoneSeparator1);
            this.siticonePanel1.Location = new System.Drawing.Point(48, 66);
            this.siticonePanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.siticonePanel1.Name = "siticonePanel1";
            this.siticonePanel1.Size = new System.Drawing.Size(696, 567);
            this.siticonePanel1.TabIndex = 14;
            // 
            // dsChucNang
            // 
            this.dsChucNang.AllowUserToAddRows = false;
            this.dsChucNang.AllowUserToDeleteRows = false;
            this.dsChucNang.AllowUserToResizeColumns = false;
            this.dsChucNang.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Variable Display", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dsChucNang.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dsChucNang.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dsChucNang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Variable Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dsChucNang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dsChucNang.ColumnHeadersHeight = 35;
            this.dsChucNang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dsChucNang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.isChoosen,
            this.idCol,
            this.MaChucNang,
            this.TenChucNang,
            this.TenManHinh});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Variable Display", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dsChucNang.DefaultCellStyle = dataGridViewCellStyle6;
            this.dsChucNang.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dsChucNang.Location = new System.Drawing.Point(23, 199);
            this.dsChucNang.Name = "dsChucNang";
            this.dsChucNang.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dsChucNang.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dsChucNang.RowHeadersVisible = false;
            this.dsChucNang.RowHeadersWidth = 51;
            this.dsChucNang.RowTemplate.Height = 30;
            this.dsChucNang.Size = new System.Drawing.Size(656, 279);
            this.dsChucNang.TabIndex = 40;
            this.dsChucNang.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dsChucNang.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dsChucNang.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dsChucNang.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dsChucNang.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dsChucNang.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dsChucNang.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dsChucNang.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dsChucNang.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dsChucNang.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dsChucNang.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dsChucNang.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dsChucNang.ThemeStyle.HeaderStyle.Height = 35;
            this.dsChucNang.ThemeStyle.ReadOnly = false;
            this.dsChucNang.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dsChucNang.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dsChucNang.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dsChucNang.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dsChucNang.ThemeStyle.RowsStyle.Height = 30;
            this.dsChucNang.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dsChucNang.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // isChoosen
            // 
            this.isChoosen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.isChoosen.FalseValue = "0";
            this.isChoosen.HeaderText = "";
            this.isChoosen.MinimumWidth = 6;
            this.isChoosen.Name = "isChoosen";
            this.isChoosen.TrueValue = "1";
            this.isChoosen.Width = 30;
            // 
            // idCol
            // 
            this.idCol.HeaderText = "id";
            this.idCol.MinimumWidth = 6;
            this.idCol.Name = "idCol";
            this.idCol.Visible = false;
            // 
            // MaChucNang
            // 
            this.MaChucNang.HeaderText = "Mã chức măng";
            this.MaChucNang.MinimumWidth = 6;
            this.MaChucNang.Name = "MaChucNang";
            // 
            // TenChucNang
            // 
            this.TenChucNang.HeaderText = "Tên chức năng";
            this.TenChucNang.MinimumWidth = 6;
            this.TenChucNang.Name = "TenChucNang";
            // 
            // TenManHinh
            // 
            this.TenManHinh.HeaderText = "Tên màn hình";
            this.TenManHinh.MinimumWidth = 6;
            this.TenManHinh.Name = "TenManHinh";
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
            this.butSave.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butSave.ForeColor = System.Drawing.Color.White;
            this.butSave.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.butSave.Location = new System.Drawing.Point(237, 500);
            this.butSave.Name = "butSave";
            this.butSave.Size = new System.Drawing.Size(229, 38);
            this.butSave.TabIndex = 4;
            this.butSave.Text = "Lưu";
            this.butSave.Click += new System.EventHandler(this.butSave_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Variable Display", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(129, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(426, 44);
            this.label1.TabIndex = 5;
            this.label1.Text = "SỬA NHÓM NGƯỜI DÙNG";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtTenNhom
            // 
            this.txtTenNhom.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenNhom.DefaultText = "";
            this.txtTenNhom.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTenNhom.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTenNhom.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenNhom.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenNhom.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.txtTenNhom.Font = new System.Drawing.Font("Segoe UI Variable Display", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenNhom.HoverState.BorderColor = System.Drawing.Color.Silver;
            this.txtTenNhom.Location = new System.Drawing.Point(23, 143);
            this.txtTenNhom.Name = "txtTenNhom";
            this.txtTenNhom.PasswordChar = '\0';
            this.txtTenNhom.PlaceholderText = "Nhập tên nhóm người dùng...";
            this.txtTenNhom.SelectedText = "";
            this.txtTenNhom.Size = new System.Drawing.Size(656, 40);
            this.txtTenNhom.TabIndex = 39;
            // 
            // labelMaNND
            // 
            this.labelMaNND.AutoSize = true;
            this.labelMaNND.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMaNND.ForeColor = System.Drawing.Color.Black;
            this.labelMaNND.Location = new System.Drawing.Point(132, 64);
            this.labelMaNND.Name = "labelMaNND";
            this.labelMaNND.Size = new System.Drawing.Size(215, 27);
            this.labelMaNND.TabIndex = 28;
            this.labelMaNND.Text = "Mã nhóm người dùng: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Variable Display", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(19, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 22);
            this.label2.TabIndex = 28;
            this.label2.Text = "Tên nhóm người dùng: ";
            // 
            // siticoneSeparator1
            // 
            this.siticoneSeparator1.FillColor = System.Drawing.Color.Black;
            this.siticoneSeparator1.Location = new System.Drawing.Point(23, 87);
            this.siticoneSeparator1.Name = "siticoneSeparator1";
            this.siticoneSeparator1.Size = new System.Drawing.Size(656, 28);
            this.siticoneSeparator1.TabIndex = 159;
            // 
            // cHUCNANGBindingSource
            // 
            this.cHUCNANGBindingSource.DataSource = typeof(DTO.CHUCNANG);
            // 
            // fEditNhomND
            // 
            this.AcceptButton = this.butSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BackgroundImage = global::GUI.Properties.Resources.loginimg;
            this.ClientSize = new System.Drawing.Size(797, 669);
            this.Controls.Add(this.siticonePanel1);
            this.Controls.Add(this.siticoneControlBox2);
            this.Controls.Add(this.siticoneControlBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fEditNhomND";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fEditNhomND";
            this.siticonePanel1.ResumeLayout(false);
            this.siticonePanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsChucNang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cHUCNANGBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm siticoneBorderlessForm1;
        private Siticone.Desktop.UI.WinForms.SiticoneControlBox siticoneControlBox2;
        private Siticone.Desktop.UI.WinForms.SiticoneControlBox siticoneControlBox1;
        private Siticone.Desktop.UI.WinForms.SiticonePanel siticonePanel1;
        private Siticone.Desktop.UI.WinForms.SiticoneDataGridView dsChucNang;
        private Siticone.Desktop.UI.WinForms.SiticoneButton butSave;
        private System.Windows.Forms.Label label1;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtTenNhom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource cHUCNANGBindingSource;
        private System.Windows.Forms.Label labelMaNND;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isChoosen;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaChucNang;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenChucNang;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenManHinh;
        private Siticone.Desktop.UI.WinForms.SiticoneSeparator siticoneSeparator1;
    }
}
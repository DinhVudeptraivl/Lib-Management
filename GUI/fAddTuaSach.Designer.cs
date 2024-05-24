namespace GUI
{
    partial class fAddTuaSach
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
            this.controlPanel = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.miniControlBox = new Siticone.Desktop.UI.WinForms.SiticoneControlBox();
            this.closeControlBox = new Siticone.Desktop.UI.WinForms.SiticoneControlBox();
            this.mainPanel = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.label5 = new System.Windows.Forms.Label();
            this.TacGiaGrid = new Siticone.Desktop.UI.WinForms.SiticoneDataGridView();
            this.TenTacGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboTacGia = new System.Windows.Forms.ComboBox();
            this.butOK = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.butAddTacGia = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.comboTheLoai = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTenTuaSach = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.siticoneSeparator1 = new Siticone.Desktop.UI.WinForms.SiticoneSeparator();
            this.siticoneDragControl1 = new Siticone.Desktop.UI.WinForms.SiticoneDragControl(this.components);
            this.controlPanel.SuspendLayout();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TacGiaGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // siticoneBorderlessForm1
            // 
            this.siticoneBorderlessForm1.ContainerControl = this;
            this.siticoneBorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.siticoneBorderlessForm1.TransparentWhileDrag = true;
            // 
            // controlPanel
            // 
            this.controlPanel.BackColor = System.Drawing.Color.Transparent;
            this.controlPanel.Controls.Add(this.miniControlBox);
            this.controlPanel.Controls.Add(this.closeControlBox);
            this.controlPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.controlPanel.Location = new System.Drawing.Point(0, 0);
            this.controlPanel.Name = "controlPanel";
            this.controlPanel.Size = new System.Drawing.Size(827, 54);
            this.controlPanel.TabIndex = 2;
            // 
            // miniControlBox
            // 
            this.miniControlBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.miniControlBox.ControlBoxType = Siticone.Desktop.UI.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.miniControlBox.FillColor = System.Drawing.Color.Transparent;
            this.miniControlBox.IconColor = System.Drawing.Color.Black;
            this.miniControlBox.Location = new System.Drawing.Point(700, 3);
            this.miniControlBox.Name = "miniControlBox";
            this.miniControlBox.Size = new System.Drawing.Size(60, 48);
            this.miniControlBox.TabIndex = 0;
            // 
            // closeControlBox
            // 
            this.closeControlBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeControlBox.FillColor = System.Drawing.Color.Transparent;
            this.closeControlBox.IconColor = System.Drawing.Color.Black;
            this.closeControlBox.Location = new System.Drawing.Point(766, 3);
            this.closeControlBox.Name = "closeControlBox";
            this.closeControlBox.Size = new System.Drawing.Size(61, 48);
            this.closeControlBox.TabIndex = 0;
            // 
            // mainPanel
            // 
            this.mainPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainPanel.BackColor = System.Drawing.Color.AliceBlue;
            this.mainPanel.BorderColor = System.Drawing.Color.Black;
            this.mainPanel.BorderRadius = 6;
            this.mainPanel.BorderThickness = 2;
            this.mainPanel.Controls.Add(this.label5);
            this.mainPanel.Controls.Add(this.TacGiaGrid);
            this.mainPanel.Controls.Add(this.comboTacGia);
            this.mainPanel.Controls.Add(this.butOK);
            this.mainPanel.Controls.Add(this.butAddTacGia);
            this.mainPanel.Controls.Add(this.comboTheLoai);
            this.mainPanel.Controls.Add(this.label3);
            this.mainPanel.Controls.Add(this.label2);
            this.mainPanel.Controls.Add(this.label1);
            this.mainPanel.Controls.Add(this.txtTenTuaSach);
            this.mainPanel.Controls.Add(this.labelTitle);
            this.mainPanel.Controls.Add(this.siticoneSeparator1);
            this.mainPanel.Location = new System.Drawing.Point(159, 87);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(476, 548);
            this.mainPanel.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Variable Display", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(21, 419);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 22);
            this.label5.TabIndex = 14;
            this.label5.Text = "Chọn tác giả*";
            // 
            // TacGiaGrid
            // 
            this.TacGiaGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.TacGiaGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.TacGiaGrid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TacGiaGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.TacGiaGrid.ColumnHeadersHeight = 29;
            this.TacGiaGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.TacGiaGrid.ColumnHeadersVisible = false;
            this.TacGiaGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TenTacGia,
            this.id});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.TacGiaGrid.DefaultCellStyle = dataGridViewCellStyle6;
            this.TacGiaGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.TacGiaGrid.Location = new System.Drawing.Point(25, 262);
            this.TacGiaGrid.Name = "TacGiaGrid";
            this.TacGiaGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.TacGiaGrid.RowHeadersVisible = false;
            this.TacGiaGrid.RowHeadersWidth = 51;
            this.TacGiaGrid.RowTemplate.Height = 24;
            this.TacGiaGrid.Size = new System.Drawing.Size(419, 142);
            this.TacGiaGrid.TabIndex = 13;
            this.TacGiaGrid.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.TacGiaGrid.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TacGiaGrid.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.TacGiaGrid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.TacGiaGrid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.TacGiaGrid.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.TacGiaGrid.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.TacGiaGrid.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.TacGiaGrid.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.TacGiaGrid.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TacGiaGrid.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.TacGiaGrid.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.TacGiaGrid.ThemeStyle.HeaderStyle.Height = 29;
            this.TacGiaGrid.ThemeStyle.ReadOnly = false;
            this.TacGiaGrid.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.TacGiaGrid.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.TacGiaGrid.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TacGiaGrid.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.TacGiaGrid.ThemeStyle.RowsStyle.Height = 24;
            this.TacGiaGrid.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.TacGiaGrid.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.TacGiaGrid.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.TacGiaGrid_RowsRemoved);
            // 
            // TenTacGia
            // 
            this.TenTacGia.HeaderText = "";
            this.TenTacGia.MinimumWidth = 6;
            this.TenTacGia.Name = "TenTacGia";
            // 
            // id
            // 
            this.id.HeaderText = "";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.Visible = false;
            // 
            // comboTacGia
            // 
            this.comboTacGia.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboTacGia.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboTacGia.Font = new System.Drawing.Font("Segoe UI Variable Display", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboTacGia.FormattingEnabled = true;
            this.comboTacGia.Location = new System.Drawing.Point(25, 444);
            this.comboTacGia.Name = "comboTacGia";
            this.comboTacGia.Size = new System.Drawing.Size(224, 32);
            this.comboTacGia.TabIndex = 12;
            this.comboTacGia.TextUpdate += new System.EventHandler(this.comboTacGia_TextUpdate);
            this.comboTacGia.TextChanged += new System.EventHandler(this.comboTacGia_TextChanged);
            // 
            // butOK
            // 
            this.butOK.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.butOK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(218)))), ((int)(((byte)(255)))));
            this.butOK.BorderRadius = 6;
            this.butOK.BorderThickness = 2;
            this.butOK.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.butOK.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.butOK.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.butOK.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.butOK.FillColor = System.Drawing.Color.DodgerBlue;
            this.butOK.Font = new System.Drawing.Font("Segoe UI Variable Display", 9F, System.Drawing.FontStyle.Bold);
            this.butOK.ForeColor = System.Drawing.Color.White;
            this.butOK.Location = new System.Drawing.Point(160, 491);
            this.butOK.Name = "butOK";
            this.butOK.Size = new System.Drawing.Size(138, 42);
            this.butOK.TabIndex = 10;
            this.butOK.Text = "Lưu";
            this.butOK.Click += new System.EventHandler(this.butOK_Click);
            // 
            // butAddTacGia
            // 
            this.butAddTacGia.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.butAddTacGia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(218)))), ((int)(((byte)(255)))));
            this.butAddTacGia.BorderRadius = 6;
            this.butAddTacGia.BorderThickness = 2;
            this.butAddTacGia.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.butAddTacGia.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.butAddTacGia.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.butAddTacGia.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.butAddTacGia.FillColor = System.Drawing.Color.DodgerBlue;
            this.butAddTacGia.Font = new System.Drawing.Font("Segoe UI Variable Display", 9F, System.Drawing.FontStyle.Bold);
            this.butAddTacGia.ForeColor = System.Drawing.Color.White;
            this.butAddTacGia.Location = new System.Drawing.Point(325, 444);
            this.butAddTacGia.Name = "butAddTacGia";
            this.butAddTacGia.Size = new System.Drawing.Size(106, 32);
            this.butAddTacGia.TabIndex = 10;
            this.butAddTacGia.Text = "+  Thêm  ";
            this.butAddTacGia.Click += new System.EventHandler(this.butAddTacGia_Click);
            // 
            // comboTheLoai
            // 
            this.comboTheLoai.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboTheLoai.BackColor = System.Drawing.Color.Transparent;
            this.comboTheLoai.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboTheLoai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboTheLoai.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboTheLoai.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboTheLoai.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboTheLoai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.comboTheLoai.ItemHeight = 30;
            this.comboTheLoai.Location = new System.Drawing.Point(25, 198);
            this.comboTheLoai.Name = "comboTheLoai";
            this.comboTheLoai.Size = new System.Drawing.Size(419, 36);
            this.comboTheLoai.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Variable Display", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(21, 237);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 22);
            this.label3.TabIndex = 6;
            this.label3.Text = "Danh sách tác giả";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Variable Display", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(21, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 22);
            this.label2.TabIndex = 6;
            this.label2.Text = "Thể loại*";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Variable Display", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(21, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 22);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tên tựa sách*";
            // 
            // txtTenTuaSach
            // 
            this.txtTenTuaSach.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenTuaSach.DefaultText = "";
            this.txtTenTuaSach.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTenTuaSach.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTenTuaSach.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenTuaSach.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenTuaSach.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenTuaSach.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTenTuaSach.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenTuaSach.Location = new System.Drawing.Point(25, 134);
            this.txtTenTuaSach.Name = "txtTenTuaSach";
            this.txtTenTuaSach.PasswordChar = '\0';
            this.txtTenTuaSach.PlaceholderText = "";
            this.txtTenTuaSach.SelectedText = "";
            this.txtTenTuaSach.Size = new System.Drawing.Size(419, 36);
            this.txtTenTuaSach.TabIndex = 5;
            // 
            // labelTitle
            // 
            this.labelTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI Variable Display", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.Black;
            this.labelTitle.Location = new System.Drawing.Point(33, 26);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(404, 49);
            this.labelTitle.TabIndex = 4;
            this.labelTitle.Text = "THÊM TỰA SÁCH MỚI";
            // 
            // siticoneSeparator1
            // 
            this.siticoneSeparator1.FillColor = System.Drawing.Color.Black;
            this.siticoneSeparator1.Location = new System.Drawing.Point(25, 63);
            this.siticoneSeparator1.Name = "siticoneSeparator1";
            this.siticoneSeparator1.Size = new System.Drawing.Size(429, 28);
            this.siticoneSeparator1.TabIndex = 159;
            // 
            // siticoneDragControl1
            // 
            this.siticoneDragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.siticoneDragControl1.TargetControl = this.controlPanel;
            this.siticoneDragControl1.UseTransparentDrag = true;
            // 
            // fAddTuaSach
            // 
            this.AcceptButton = this.butOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BackgroundImage = global::GUI.Properties.Resources.loginimg;
            this.ClientSize = new System.Drawing.Size(827, 668);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.controlPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fAddTuaSach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fAddTuaSach";
            this.Load += new System.EventHandler(this.fAddTuaSach_Load);
            this.controlPanel.ResumeLayout(false);
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TacGiaGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm siticoneBorderlessForm1;
        private Siticone.Desktop.UI.WinForms.SiticonePanel mainPanel;
        private Siticone.Desktop.UI.WinForms.SiticonePanel controlPanel;
        private Siticone.Desktop.UI.WinForms.SiticoneControlBox miniControlBox;
        private Siticone.Desktop.UI.WinForms.SiticoneControlBox closeControlBox;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtTenTuaSach;
        private System.Windows.Forms.Label labelTitle;
        private Siticone.Desktop.UI.WinForms.SiticoneComboBox comboTheLoai;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private Siticone.Desktop.UI.WinForms.SiticoneButton butAddTacGia;
        private Siticone.Desktop.UI.WinForms.SiticoneButton butOK;
        private Siticone.Desktop.UI.WinForms.SiticoneDragControl siticoneDragControl1;
        private System.Windows.Forms.ComboBox comboTacGia;
        private Siticone.Desktop.UI.WinForms.SiticoneDataGridView TacGiaGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenTacGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.Label label5;
        private Siticone.Desktop.UI.WinForms.SiticoneSeparator siticoneSeparator1;
    }
}
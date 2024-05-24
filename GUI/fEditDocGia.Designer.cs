namespace GUI
{
    partial class fEditDocGia
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
            this.siticoneBorderlessForm1 = new Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm(this.components);
            this.controlPanel = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.miniControlBox = new Siticone.Desktop.UI.WinForms.SiticoneControlBox();
            this.closeControlBox = new Siticone.Desktop.UI.WinForms.SiticoneControlBox();
            this.siticoneDragControl1 = new Siticone.Desktop.UI.WinForms.SiticoneDragControl(this.components);
            this.mainPanel = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.labelNgayHetHan = new System.Windows.Forms.Label();
            this.labelNgayLapThe = new System.Windows.Forms.Label();
            this.labelEmailError = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.butOK = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.comboLoaiDG = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
            this.dateNgaySinh = new Siticone.Desktop.UI.WinForms.SiticoneDateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelMaDG = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEmail = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.txtDiaChi = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.txtHoTen = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.siticoneSeparator1 = new Siticone.Desktop.UI.WinForms.SiticoneSeparator();
            this.siticoneEmailValidatingTool1 = new Siticone.Desktop.UI.Winforms.SiticoneEmailValidatingTool();
            this.errDia = new Siticone.Desktop.UI.WinForms.SiticoneMessageDialog();
            this.messDia = new Siticone.Desktop.UI.WinForms.SiticoneMessageDialog();
            this.controlPanel.SuspendLayout();
            this.mainPanel.SuspendLayout();
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
            this.controlPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.controlPanel.Name = "controlPanel";
            this.controlPanel.Size = new System.Drawing.Size(794, 54);
            this.controlPanel.TabIndex = 0;
            // 
            // miniControlBox
            // 
            this.miniControlBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.miniControlBox.ControlBoxType = Siticone.Desktop.UI.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.miniControlBox.FillColor = System.Drawing.Color.Transparent;
            this.miniControlBox.IconColor = System.Drawing.Color.Black;
            this.miniControlBox.Location = new System.Drawing.Point(670, 2);
            this.miniControlBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.miniControlBox.Name = "miniControlBox";
            this.miniControlBox.Size = new System.Drawing.Size(60, 50);
            this.miniControlBox.TabIndex = 0;
            // 
            // closeControlBox
            // 
            this.closeControlBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeControlBox.FillColor = System.Drawing.Color.Transparent;
            this.closeControlBox.IconColor = System.Drawing.Color.Black;
            this.closeControlBox.Location = new System.Drawing.Point(732, 2);
            this.closeControlBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.closeControlBox.Name = "closeControlBox";
            this.closeControlBox.Size = new System.Drawing.Size(61, 50);
            this.closeControlBox.TabIndex = 0;
            // 
            // siticoneDragControl1
            // 
            this.siticoneDragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.siticoneDragControl1.TargetControl = this.controlPanel;
            this.siticoneDragControl1.UseTransparentDrag = true;
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.AliceBlue;
            this.mainPanel.BorderColor = System.Drawing.Color.Black;
            this.mainPanel.BorderRadius = 6;
            this.mainPanel.BorderThickness = 2;
            this.mainPanel.Controls.Add(this.labelNgayHetHan);
            this.mainPanel.Controls.Add(this.labelNgayLapThe);
            this.mainPanel.Controls.Add(this.labelEmailError);
            this.mainPanel.Controls.Add(this.label7);
            this.mainPanel.Controls.Add(this.butOK);
            this.mainPanel.Controls.Add(this.comboLoaiDG);
            this.mainPanel.Controls.Add(this.dateNgaySinh);
            this.mainPanel.Controls.Add(this.label6);
            this.mainPanel.Controls.Add(this.label3);
            this.mainPanel.Controls.Add(this.label2);
            this.mainPanel.Controls.Add(this.label5);
            this.mainPanel.Controls.Add(this.label4);
            this.mainPanel.Controls.Add(this.labelMaDG);
            this.mainPanel.Controls.Add(this.label1);
            this.mainPanel.Controls.Add(this.txtEmail);
            this.mainPanel.Controls.Add(this.txtDiaChi);
            this.mainPanel.Controls.Add(this.txtHoTen);
            this.mainPanel.Controls.Add(this.labelTitle);
            this.mainPanel.Controls.Add(this.siticoneSeparator1);
            this.mainPanel.Location = new System.Drawing.Point(84, 91);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.ShadowDecoration.Color = System.Drawing.Color.MediumSlateBlue;
            this.mainPanel.ShadowDecoration.CustomizableEdges.BottomLeft = false;
            this.mainPanel.ShadowDecoration.CustomizableEdges.TopLeft = false;
            this.mainPanel.ShadowDecoration.CustomizableEdges.TopRight = false;
            this.mainPanel.Size = new System.Drawing.Size(613, 569);
            this.mainPanel.TabIndex = 1;
            this.mainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.mainPanel_Paint);
            // 
            // labelNgayHetHan
            // 
            this.labelNgayHetHan.AutoSize = true;
            this.labelNgayHetHan.Font = new System.Drawing.Font("Segoe UI Variable Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNgayHetHan.ForeColor = System.Drawing.Color.Black;
            this.labelNgayHetHan.Location = new System.Drawing.Point(320, 454);
            this.labelNgayHetHan.Name = "labelNgayHetHan";
            this.labelNgayHetHan.Size = new System.Drawing.Size(126, 27);
            this.labelNgayHetHan.TabIndex = 174;
            this.labelNgayHetHan.Text = "dd/mm/yyyy";
            // 
            // labelNgayLapThe
            // 
            this.labelNgayLapThe.AutoSize = true;
            this.labelNgayLapThe.Font = new System.Drawing.Font("Segoe UI Variable Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNgayLapThe.ForeColor = System.Drawing.Color.Black;
            this.labelNgayLapThe.Location = new System.Drawing.Point(20, 454);
            this.labelNgayLapThe.Name = "labelNgayLapThe";
            this.labelNgayLapThe.Size = new System.Drawing.Size(126, 27);
            this.labelNgayLapThe.TabIndex = 173;
            this.labelNgayLapThe.Text = "dd/mm/yyyy";
            // 
            // labelEmailError
            // 
            this.labelEmailError.AutoSize = true;
            this.labelEmailError.Location = new System.Drawing.Point(133, 437);
            this.labelEmailError.Name = "labelEmailError";
            this.labelEmailError.Size = new System.Drawing.Size(0, 16);
            this.labelEmailError.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Variable Display", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(321, 431);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 22);
            this.label7.TabIndex = 6;
            this.label7.Text = "Ngày hết hạn:";
            // 
            // butOK
            // 
            this.butOK.BorderRadius = 6;
            this.butOK.BorderThickness = 2;
            this.butOK.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.butOK.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.butOK.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.butOK.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.butOK.FillColor = System.Drawing.Color.DodgerBlue;
            this.butOK.Font = new System.Drawing.Font("Segoe UI Variable Display", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butOK.ForeColor = System.Drawing.Color.White;
            this.butOK.Location = new System.Drawing.Point(186, 508);
            this.butOK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.butOK.Name = "butOK";
            this.butOK.Size = new System.Drawing.Size(213, 40);
            this.butOK.TabIndex = 5;
            this.butOK.Text = "Lưu";
            this.butOK.Click += new System.EventHandler(this.butOK_Click);
            // 
            // comboLoaiDG
            // 
            this.comboLoaiDG.BackColor = System.Drawing.Color.Transparent;
            this.comboLoaiDG.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboLoaiDG.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboLoaiDG.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboLoaiDG.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboLoaiDG.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboLoaiDG.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.comboLoaiDG.ItemHeight = 30;
            this.comboLoaiDG.Location = new System.Drawing.Point(325, 227);
            this.comboLoaiDG.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboLoaiDG.Name = "comboLoaiDG";
            this.comboLoaiDG.Size = new System.Drawing.Size(264, 36);
            this.comboLoaiDG.TabIndex = 4;
            // 
            // dateNgaySinh
            // 
            this.dateNgaySinh.Checked = true;
            this.dateNgaySinh.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dateNgaySinh.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dateNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateNgaySinh.Location = new System.Drawing.Point(25, 227);
            this.dateNgaySinh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateNgaySinh.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dateNgaySinh.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dateNgaySinh.Name = "dateNgaySinh";
            this.dateNgaySinh.Size = new System.Drawing.Size(245, 36);
            this.dateNgaySinh.TabIndex = 3;
            this.dateNgaySinh.Value = new System.DateTime(2022, 12, 16, 12, 3, 14, 424);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Variable Display", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(21, 432);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 22);
            this.label6.TabIndex = 2;
            this.label6.Text = "Ngày lập thẻ:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Variable Display", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(321, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Loại độc giả";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Variable Display", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(21, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ngày sinh";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Variable Display", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(21, 359);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 22);
            this.label5.TabIndex = 2;
            this.label5.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Variable Display", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(21, 280);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 22);
            this.label4.TabIndex = 2;
            this.label4.Text = "Địa chỉ";
            // 
            // labelMaDG
            // 
            this.labelMaDG.AutoSize = true;
            this.labelMaDG.Font = new System.Drawing.Font("Segoe UI Variable Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMaDG.ForeColor = System.Drawing.Color.Black;
            this.labelMaDG.Location = new System.Drawing.Point(120, 73);
            this.labelMaDG.Name = "labelMaDG";
            this.labelMaDG.Size = new System.Drawing.Size(121, 27);
            this.labelMaDG.TabIndex = 2;
            this.labelMaDG.Text = "Mã độc giả:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Variable Display", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(21, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Họ tên";
            // 
            // txtEmail
            // 
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.DefaultText = "";
            this.txtEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmail.Location = new System.Drawing.Point(25, 383);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.PlaceholderText = "";
            this.txtEmail.SelectedText = "";
            this.txtEmail.Size = new System.Drawing.Size(564, 36);
            this.txtEmail.TabIndex = 1;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDiaChi.DefaultText = "";
            this.txtDiaChi.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDiaChi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDiaChi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDiaChi.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDiaChi.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDiaChi.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDiaChi.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDiaChi.Location = new System.Drawing.Point(25, 304);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.PasswordChar = '\0';
            this.txtDiaChi.PlaceholderText = "";
            this.txtDiaChi.SelectedText = "";
            this.txtDiaChi.Size = new System.Drawing.Size(564, 36);
            this.txtDiaChi.TabIndex = 1;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtHoTen.DefaultText = "";
            this.txtHoTen.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtHoTen.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtHoTen.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtHoTen.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtHoTen.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtHoTen.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtHoTen.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtHoTen.Location = new System.Drawing.Point(25, 151);
            this.txtHoTen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.PasswordChar = '\0';
            this.txtHoTen.PlaceholderText = "";
            this.txtHoTen.SelectedText = "";
            this.txtHoTen.Size = new System.Drawing.Size(564, 36);
            this.txtHoTen.TabIndex = 1;
            // 
            // labelTitle
            // 
            this.labelTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI Variable Display", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.Black;
            this.labelTitle.Location = new System.Drawing.Point(116, 20);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(364, 53);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "SỬA THẺ ĐỘC GIẢ";
            // 
            // siticoneSeparator1
            // 
            this.siticoneSeparator1.FillColor = System.Drawing.Color.Black;
            this.siticoneSeparator1.Location = new System.Drawing.Point(50, 96);
            this.siticoneSeparator1.Name = "siticoneSeparator1";
            this.siticoneSeparator1.Size = new System.Drawing.Size(525, 28);
            this.siticoneSeparator1.TabIndex = 159;
            // 
            // siticoneEmailValidatingTool1
            // 
            this.siticoneEmailValidatingTool1.EmailTextbox = this.txtEmail;
            this.siticoneEmailValidatingTool1.MessageDescription = this.labelEmailError;
            // 
            // errDia
            // 
            this.errDia.Buttons = Siticone.Desktop.UI.WinForms.MessageDialogButtons.OK;
            this.errDia.Caption = null;
            this.errDia.Icon = Siticone.Desktop.UI.WinForms.MessageDialogIcon.Error;
            this.errDia.Parent = null;
            this.errDia.Style = Siticone.Desktop.UI.WinForms.MessageDialogStyle.Light;
            this.errDia.Text = null;
            // 
            // messDia
            // 
            this.messDia.Buttons = Siticone.Desktop.UI.WinForms.MessageDialogButtons.OK;
            this.messDia.Caption = null;
            this.messDia.Icon = Siticone.Desktop.UI.WinForms.MessageDialogIcon.Information;
            this.messDia.Parent = null;
            this.messDia.Style = Siticone.Desktop.UI.WinForms.MessageDialogStyle.Light;
            this.messDia.Text = null;
            // 
            // fEditDocGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BackgroundImage = global::GUI.Properties.Resources.loginimg;
            this.ClientSize = new System.Drawing.Size(794, 701);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.controlPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "fEditDocGia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fEditDocGia";
            this.Load += new System.EventHandler(this.fEditDocGia_Load);
            this.controlPanel.ResumeLayout(false);
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm siticoneBorderlessForm1;
        private Siticone.Desktop.UI.WinForms.SiticonePanel controlPanel;
        private Siticone.Desktop.UI.WinForms.SiticoneControlBox miniControlBox;
        private Siticone.Desktop.UI.WinForms.SiticoneControlBox closeControlBox;
        private Siticone.Desktop.UI.WinForms.SiticoneDragControl siticoneDragControl1;
        private Siticone.Desktop.UI.WinForms.SiticonePanel mainPanel;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label label1;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtHoTen;
        private Siticone.Desktop.UI.WinForms.SiticoneComboBox comboLoaiDG;
        private Siticone.Desktop.UI.WinForms.SiticoneDateTimePicker dateNgaySinh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtEmail;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtDiaChi;
        private System.Windows.Forms.Label label6;
        private Siticone.Desktop.UI.Winforms.SiticoneEmailValidatingTool siticoneEmailValidatingTool1;
        private Siticone.Desktop.UI.WinForms.SiticoneButton butOK;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelEmailError;
        private System.Windows.Forms.Label labelMaDG;
        private Siticone.Desktop.UI.WinForms.SiticoneMessageDialog errDia;
        private Siticone.Desktop.UI.WinForms.SiticoneMessageDialog messDia;
        private Siticone.Desktop.UI.WinForms.SiticoneSeparator siticoneSeparator1;
        private System.Windows.Forms.Label labelNgayHetHan;
        private System.Windows.Forms.Label labelNgayLapThe;
    }
}
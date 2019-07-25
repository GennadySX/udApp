namespace WindowsFormsApp2
{
    partial class Students
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Students));
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.udDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.udDataSet = new WindowsFormsApp2.udDataSet();
            this.usersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.userGrid = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loginDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.secretcodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usersBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.nameUT = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.surnameUT = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.emailUT = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.birthUT = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.loginUT = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.passUT = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.pinUT = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.roleUT = new Bunifu.Framework.UI.BunifuDropdown();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton2 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton3 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton4 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton5 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton6 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton7 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton8 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.imageUT = new Bunifu.Framework.UI.BunifuImageButton();
            this.create_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.update_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.deleteB = new Bunifu.Framework.UI.BunifuFlatButton();
            this.repassUT = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.idUT = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.usersAdapter = new WindowsFormsApp2.udDataSetTableAdapters.usersTableAdapter();
            this.dialogFile = new System.Windows.Forms.OpenFileDialog();
            this.clear_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageUT)).BeginInit();
            this.SuspendLayout();
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "users";
            this.usersBindingSource.DataSource = this.udDataSetBindingSource;
            // 
            // udDataSetBindingSource
            // 
            this.udDataSetBindingSource.DataSource = this.udDataSet;
            this.udDataSetBindingSource.Position = 0;
            // 
            // udDataSet
            // 
            this.udDataSet.DataSetName = "udDataSet";
            this.udDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usersBindingSource1
            // 
            this.usersBindingSource1.DataMember = "users";
            this.usersBindingSource1.DataSource = this.udDataSetBindingSource;
            // 
            // userGrid
            // 
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.userGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.userGrid.AutoGenerateColumns = false;
            this.userGrid.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.userGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.userGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.userGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.userGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.surnameDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.birthdateDataGridViewTextBoxColumn,
            this.loginDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.secretcodeDataGridViewTextBoxColumn,
            this.roleDataGridViewTextBoxColumn});
            this.userGrid.DataSource = this.usersBindingSource2;
            this.userGrid.DoubleBuffered = true;
            this.userGrid.EnableHeadersVisualStyles = false;
            this.userGrid.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.userGrid.HeaderForeColor = System.Drawing.Color.SeaGreen;
            this.userGrid.Location = new System.Drawing.Point(-90, 3);
            this.userGrid.Name = "userGrid";
            this.userGrid.ReadOnly = true;
            this.userGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.userGrid.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.userGrid.Size = new System.Drawing.Size(1117, 395);
            this.userGrid.TabIndex = 0;
            this.userGrid.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.userGrid_CellMouseClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 50;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 150;
            // 
            // surnameDataGridViewTextBoxColumn
            // 
            this.surnameDataGridViewTextBoxColumn.DataPropertyName = "surname";
            this.surnameDataGridViewTextBoxColumn.HeaderText = "surname";
            this.surnameDataGridViewTextBoxColumn.Name = "surnameDataGridViewTextBoxColumn";
            this.surnameDataGridViewTextBoxColumn.ReadOnly = true;
            this.surnameDataGridViewTextBoxColumn.Width = 150;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            this.emailDataGridViewTextBoxColumn.Width = 150;
            // 
            // birthdateDataGridViewTextBoxColumn
            // 
            this.birthdateDataGridViewTextBoxColumn.DataPropertyName = "birth_date";
            this.birthdateDataGridViewTextBoxColumn.HeaderText = "birth_date";
            this.birthdateDataGridViewTextBoxColumn.Name = "birthdateDataGridViewTextBoxColumn";
            this.birthdateDataGridViewTextBoxColumn.ReadOnly = true;
            this.birthdateDataGridViewTextBoxColumn.Width = 120;
            // 
            // loginDataGridViewTextBoxColumn
            // 
            this.loginDataGridViewTextBoxColumn.DataPropertyName = "login";
            this.loginDataGridViewTextBoxColumn.HeaderText = "login";
            this.loginDataGridViewTextBoxColumn.Name = "loginDataGridViewTextBoxColumn";
            this.loginDataGridViewTextBoxColumn.ReadOnly = true;
            this.loginDataGridViewTextBoxColumn.Width = 150;
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "password";
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            this.passwordDataGridViewTextBoxColumn.ReadOnly = true;
            this.passwordDataGridViewTextBoxColumn.Width = 150;
            // 
            // secretcodeDataGridViewTextBoxColumn
            // 
            this.secretcodeDataGridViewTextBoxColumn.DataPropertyName = "secret_code";
            this.secretcodeDataGridViewTextBoxColumn.HeaderText = "secret_code";
            this.secretcodeDataGridViewTextBoxColumn.Name = "secretcodeDataGridViewTextBoxColumn";
            this.secretcodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // roleDataGridViewTextBoxColumn
            // 
            this.roleDataGridViewTextBoxColumn.DataPropertyName = "role";
            this.roleDataGridViewTextBoxColumn.HeaderText = "role";
            this.roleDataGridViewTextBoxColumn.Name = "roleDataGridViewTextBoxColumn";
            this.roleDataGridViewTextBoxColumn.ReadOnly = true;
            this.roleDataGridViewTextBoxColumn.Width = 50;
            // 
            // usersBindingSource2
            // 
            this.usersBindingSource2.DataMember = "users";
            this.usersBindingSource2.DataSource = this.udDataSetBindingSource;
            // 
            // nameUT
            // 
            this.nameUT.BorderColorFocused = System.Drawing.Color.Blue;
            this.nameUT.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.nameUT.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.nameUT.BorderThickness = 3;
            this.nameUT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nameUT.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.nameUT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.nameUT.isPassword = false;
            this.nameUT.Location = new System.Drawing.Point(19, 413);
            this.nameUT.Margin = new System.Windows.Forms.Padding(4);
            this.nameUT.Name = "nameUT";
            this.nameUT.Size = new System.Drawing.Size(210, 31);
            this.nameUT.TabIndex = 1;
            this.nameUT.Text = "Имя";
            this.nameUT.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // surnameUT
            // 
            this.surnameUT.BorderColorFocused = System.Drawing.Color.Blue;
            this.surnameUT.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.surnameUT.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.surnameUT.BorderThickness = 3;
            this.surnameUT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.surnameUT.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.surnameUT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.surnameUT.isPassword = false;
            this.surnameUT.Location = new System.Drawing.Point(257, 413);
            this.surnameUT.Margin = new System.Windows.Forms.Padding(4);
            this.surnameUT.Name = "surnameUT";
            this.surnameUT.Size = new System.Drawing.Size(210, 31);
            this.surnameUT.TabIndex = 2;
            this.surnameUT.Text = "Фамилия";
            this.surnameUT.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // emailUT
            // 
            this.emailUT.BorderColorFocused = System.Drawing.Color.Blue;
            this.emailUT.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.emailUT.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.emailUT.BorderThickness = 3;
            this.emailUT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.emailUT.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.emailUT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.emailUT.isPassword = false;
            this.emailUT.Location = new System.Drawing.Point(19, 452);
            this.emailUT.Margin = new System.Windows.Forms.Padding(4);
            this.emailUT.Name = "emailUT";
            this.emailUT.Size = new System.Drawing.Size(210, 31);
            this.emailUT.TabIndex = 3;
            this.emailUT.Text = "Email адрес";
            this.emailUT.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // birthUT
            // 
            this.birthUT.BorderColorFocused = System.Drawing.Color.Blue;
            this.birthUT.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.birthUT.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.birthUT.BorderThickness = 3;
            this.birthUT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.birthUT.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.birthUT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.birthUT.isPassword = false;
            this.birthUT.Location = new System.Drawing.Point(257, 452);
            this.birthUT.Margin = new System.Windows.Forms.Padding(4);
            this.birthUT.Name = "birthUT";
            this.birthUT.Size = new System.Drawing.Size(210, 31);
            this.birthUT.TabIndex = 4;
            this.birthUT.Text = "День рождения";
            this.birthUT.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // loginUT
            // 
            this.loginUT.BorderColorFocused = System.Drawing.Color.Blue;
            this.loginUT.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.loginUT.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.loginUT.BorderThickness = 3;
            this.loginUT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.loginUT.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.loginUT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.loginUT.isPassword = false;
            this.loginUT.Location = new System.Drawing.Point(19, 491);
            this.loginUT.Margin = new System.Windows.Forms.Padding(4);
            this.loginUT.Name = "loginUT";
            this.loginUT.Size = new System.Drawing.Size(210, 31);
            this.loginUT.TabIndex = 5;
            this.loginUT.Text = "Логин";
            this.loginUT.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // passUT
            // 
            this.passUT.BorderColorFocused = System.Drawing.Color.Blue;
            this.passUT.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.passUT.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.passUT.BorderThickness = 3;
            this.passUT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passUT.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.passUT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.passUT.isPassword = false;
            this.passUT.Location = new System.Drawing.Point(257, 491);
            this.passUT.Margin = new System.Windows.Forms.Padding(4);
            this.passUT.Name = "passUT";
            this.passUT.Size = new System.Drawing.Size(210, 31);
            this.passUT.TabIndex = 6;
            this.passUT.Text = "Пароль";
            this.passUT.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // pinUT
            // 
            this.pinUT.BorderColorFocused = System.Drawing.Color.Blue;
            this.pinUT.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pinUT.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.pinUT.BorderThickness = 3;
            this.pinUT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.pinUT.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.pinUT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pinUT.isPassword = false;
            this.pinUT.Location = new System.Drawing.Point(500, 452);
            this.pinUT.Margin = new System.Windows.Forms.Padding(4);
            this.pinUT.Name = "pinUT";
            this.pinUT.Size = new System.Drawing.Size(210, 31);
            this.pinUT.TabIndex = 7;
            this.pinUT.Text = "Пин-кодь";
            this.pinUT.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // roleUT
            // 
            this.roleUT.BackColor = System.Drawing.Color.Transparent;
            this.roleUT.BorderRadius = 3;
            this.roleUT.DisabledColor = System.Drawing.Color.Gray;
            this.roleUT.ForeColor = System.Drawing.Color.White;
            this.roleUT.Items = new string[] {
        "Админ",
        "Мастер",
        "Студент ",
        "Организатор"};
            this.roleUT.Location = new System.Drawing.Point(500, 413);
            this.roleUT.Name = "roleUT";
            this.roleUT.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.roleUT.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.roleUT.selectedIndex = 0;
            this.roleUT.Size = new System.Drawing.Size(210, 31);
            this.roleUT.TabIndex = 8;
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "Имя";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = null;
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 90D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(0, 3);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(130, 19);
            this.bunifuFlatButton1.TabIndex = 9;
            this.bunifuFlatButton1.Text = "Имя";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // bunifuFlatButton2
            // 
            this.bunifuFlatButton2.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton2.BorderRadius = 0;
            this.bunifuFlatButton2.ButtonText = "Фамилия";
            this.bunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton2.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton2.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.Iconimage = null;
            this.bunifuFlatButton2.Iconimage_right = null;
            this.bunifuFlatButton2.Iconimage_right_Selected = null;
            this.bunifuFlatButton2.Iconimage_Selected = null;
            this.bunifuFlatButton2.IconMarginLeft = 0;
            this.bunifuFlatButton2.IconMarginRight = 0;
            this.bunifuFlatButton2.IconRightVisible = true;
            this.bunifuFlatButton2.IconRightZoom = 0D;
            this.bunifuFlatButton2.IconVisible = true;
            this.bunifuFlatButton2.IconZoom = 90D;
            this.bunifuFlatButton2.IsTab = false;
            this.bunifuFlatButton2.Location = new System.Drawing.Point(176, 3);
            this.bunifuFlatButton2.Name = "bunifuFlatButton2";
            this.bunifuFlatButton2.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton2.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton2.selected = false;
            this.bunifuFlatButton2.Size = new System.Drawing.Size(98, 19);
            this.bunifuFlatButton2.TabIndex = 10;
            this.bunifuFlatButton2.Text = "Фамилия";
            this.bunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton2.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton2.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // bunifuFlatButton3
            // 
            this.bunifuFlatButton3.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton3.BorderRadius = 0;
            this.bunifuFlatButton3.ButtonText = "Почта";
            this.bunifuFlatButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton3.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton3.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton3.Iconimage = null;
            this.bunifuFlatButton3.Iconimage_right = null;
            this.bunifuFlatButton3.Iconimage_right_Selected = null;
            this.bunifuFlatButton3.Iconimage_Selected = null;
            this.bunifuFlatButton3.IconMarginLeft = 0;
            this.bunifuFlatButton3.IconMarginRight = 0;
            this.bunifuFlatButton3.IconRightVisible = true;
            this.bunifuFlatButton3.IconRightZoom = 0D;
            this.bunifuFlatButton3.IconVisible = true;
            this.bunifuFlatButton3.IconZoom = 90D;
            this.bunifuFlatButton3.IsTab = false;
            this.bunifuFlatButton3.Location = new System.Drawing.Point(321, 3);
            this.bunifuFlatButton3.Name = "bunifuFlatButton3";
            this.bunifuFlatButton3.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton3.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton3.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton3.selected = false;
            this.bunifuFlatButton3.Size = new System.Drawing.Size(98, 19);
            this.bunifuFlatButton3.TabIndex = 11;
            this.bunifuFlatButton3.Text = "Почта";
            this.bunifuFlatButton3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton3.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton3.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // bunifuFlatButton4
            // 
            this.bunifuFlatButton4.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton4.BorderRadius = 0;
            this.bunifuFlatButton4.ButtonText = "День рождения";
            this.bunifuFlatButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton4.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton4.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton4.Iconimage = null;
            this.bunifuFlatButton4.Iconimage_right = null;
            this.bunifuFlatButton4.Iconimage_right_Selected = null;
            this.bunifuFlatButton4.Iconimage_Selected = null;
            this.bunifuFlatButton4.IconMarginLeft = 0;
            this.bunifuFlatButton4.IconMarginRight = 0;
            this.bunifuFlatButton4.IconRightVisible = true;
            this.bunifuFlatButton4.IconRightZoom = 0D;
            this.bunifuFlatButton4.IconVisible = true;
            this.bunifuFlatButton4.IconZoom = 90D;
            this.bunifuFlatButton4.IsTab = false;
            this.bunifuFlatButton4.Location = new System.Drawing.Point(454, 3);
            this.bunifuFlatButton4.Name = "bunifuFlatButton4";
            this.bunifuFlatButton4.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton4.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton4.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton4.selected = false;
            this.bunifuFlatButton4.Size = new System.Drawing.Size(110, 19);
            this.bunifuFlatButton4.TabIndex = 12;
            this.bunifuFlatButton4.Text = "День рождения";
            this.bunifuFlatButton4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton4.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton4.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // bunifuFlatButton5
            // 
            this.bunifuFlatButton5.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton5.BorderRadius = 0;
            this.bunifuFlatButton5.ButtonText = "Логин";
            this.bunifuFlatButton5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton5.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton5.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton5.Iconimage = null;
            this.bunifuFlatButton5.Iconimage_right = null;
            this.bunifuFlatButton5.Iconimage_right_Selected = null;
            this.bunifuFlatButton5.Iconimage_Selected = null;
            this.bunifuFlatButton5.IconMarginLeft = 0;
            this.bunifuFlatButton5.IconMarginRight = 0;
            this.bunifuFlatButton5.IconRightVisible = true;
            this.bunifuFlatButton5.IconRightZoom = 0D;
            this.bunifuFlatButton5.IconVisible = true;
            this.bunifuFlatButton5.IconZoom = 90D;
            this.bunifuFlatButton5.IsTab = false;
            this.bunifuFlatButton5.Location = new System.Drawing.Point(589, 3);
            this.bunifuFlatButton5.Name = "bunifuFlatButton5";
            this.bunifuFlatButton5.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton5.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton5.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton5.selected = false;
            this.bunifuFlatButton5.Size = new System.Drawing.Size(100, 19);
            this.bunifuFlatButton5.TabIndex = 13;
            this.bunifuFlatButton5.Text = "Логин";
            this.bunifuFlatButton5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton5.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton5.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // bunifuFlatButton6
            // 
            this.bunifuFlatButton6.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton6.BorderRadius = 0;
            this.bunifuFlatButton6.ButtonText = "Пароль";
            this.bunifuFlatButton6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton6.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton6.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton6.Iconimage = null;
            this.bunifuFlatButton6.Iconimage_right = null;
            this.bunifuFlatButton6.Iconimage_right_Selected = null;
            this.bunifuFlatButton6.Iconimage_Selected = null;
            this.bunifuFlatButton6.IconMarginLeft = 0;
            this.bunifuFlatButton6.IconMarginRight = 0;
            this.bunifuFlatButton6.IconRightVisible = true;
            this.bunifuFlatButton6.IconRightZoom = 0D;
            this.bunifuFlatButton6.IconVisible = true;
            this.bunifuFlatButton6.IconZoom = 90D;
            this.bunifuFlatButton6.IsTab = false;
            this.bunifuFlatButton6.Location = new System.Drawing.Point(739, 3);
            this.bunifuFlatButton6.Name = "bunifuFlatButton6";
            this.bunifuFlatButton6.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton6.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton6.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton6.selected = false;
            this.bunifuFlatButton6.Size = new System.Drawing.Size(100, 19);
            this.bunifuFlatButton6.TabIndex = 14;
            this.bunifuFlatButton6.Text = "Пароль";
            this.bunifuFlatButton6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton6.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton6.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // bunifuFlatButton7
            // 
            this.bunifuFlatButton7.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton7.BorderRadius = 0;
            this.bunifuFlatButton7.ButtonText = "Пин-код";
            this.bunifuFlatButton7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton7.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton7.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton7.Iconimage = null;
            this.bunifuFlatButton7.Iconimage_right = null;
            this.bunifuFlatButton7.Iconimage_right_Selected = null;
            this.bunifuFlatButton7.Iconimage_Selected = null;
            this.bunifuFlatButton7.IconMarginLeft = 0;
            this.bunifuFlatButton7.IconMarginRight = 0;
            this.bunifuFlatButton7.IconRightVisible = true;
            this.bunifuFlatButton7.IconRightZoom = 0D;
            this.bunifuFlatButton7.IconVisible = true;
            this.bunifuFlatButton7.IconZoom = 90D;
            this.bunifuFlatButton7.IsTab = false;
            this.bunifuFlatButton7.Location = new System.Drawing.Point(873, 3);
            this.bunifuFlatButton7.Name = "bunifuFlatButton7";
            this.bunifuFlatButton7.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton7.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton7.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton7.selected = false;
            this.bunifuFlatButton7.Size = new System.Drawing.Size(100, 19);
            this.bunifuFlatButton7.TabIndex = 15;
            this.bunifuFlatButton7.Text = "Пин-код";
            this.bunifuFlatButton7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton7.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton7.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // bunifuFlatButton8
            // 
            this.bunifuFlatButton8.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton8.BorderRadius = 0;
            this.bunifuFlatButton8.ButtonText = "Роли";
            this.bunifuFlatButton8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton8.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton8.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton8.Iconimage = null;
            this.bunifuFlatButton8.Iconimage_right = null;
            this.bunifuFlatButton8.Iconimage_right_Selected = null;
            this.bunifuFlatButton8.Iconimage_Selected = null;
            this.bunifuFlatButton8.IconMarginLeft = 0;
            this.bunifuFlatButton8.IconMarginRight = 0;
            this.bunifuFlatButton8.IconRightVisible = true;
            this.bunifuFlatButton8.IconRightZoom = 0D;
            this.bunifuFlatButton8.IconVisible = true;
            this.bunifuFlatButton8.IconZoom = 90D;
            this.bunifuFlatButton8.IsTab = false;
            this.bunifuFlatButton8.Location = new System.Drawing.Point(968, 3);
            this.bunifuFlatButton8.Name = "bunifuFlatButton8";
            this.bunifuFlatButton8.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton8.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton8.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton8.selected = false;
            this.bunifuFlatButton8.Size = new System.Drawing.Size(46, 19);
            this.bunifuFlatButton8.TabIndex = 16;
            this.bunifuFlatButton8.Text = "Роли";
            this.bunifuFlatButton8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton8.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton8.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // imageUT
            // 
            this.imageUT.BackColor = System.Drawing.Color.Transparent;
            this.imageUT.Image = ((System.Drawing.Image)(resources.GetObject("imageUT.Image")));
            this.imageUT.ImageActive = null;
            this.imageUT.Location = new System.Drawing.Point(782, 413);
            this.imageUT.Name = "imageUT";
            this.imageUT.Size = new System.Drawing.Size(203, 150);
            this.imageUT.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imageUT.TabIndex = 17;
            this.imageUT.TabStop = false;
            this.imageUT.Zoom = 10;
            this.imageUT.Click += new System.EventHandler(this.imageUT_Click);
            // 
            // create_btn
            // 
            this.create_btn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.create_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.create_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.create_btn.BorderRadius = 0;
            this.create_btn.ButtonText = "Создавать";
            this.create_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.create_btn.DisabledColor = System.Drawing.Color.Gray;
            this.create_btn.Iconcolor = System.Drawing.Color.Transparent;
            this.create_btn.Iconimage = null;
            this.create_btn.Iconimage_right = null;
            this.create_btn.Iconimage_right_Selected = null;
            this.create_btn.Iconimage_Selected = null;
            this.create_btn.IconMarginLeft = 0;
            this.create_btn.IconMarginRight = 0;
            this.create_btn.IconRightVisible = true;
            this.create_btn.IconRightZoom = 0D;
            this.create_btn.IconVisible = true;
            this.create_btn.IconZoom = 90D;
            this.create_btn.IsTab = false;
            this.create_btn.Location = new System.Drawing.Point(172, 536);
            this.create_btn.Name = "create_btn";
            this.create_btn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.create_btn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.create_btn.OnHoverTextColor = System.Drawing.Color.White;
            this.create_btn.selected = false;
            this.create_btn.Size = new System.Drawing.Size(170, 27);
            this.create_btn.TabIndex = 18;
            this.create_btn.Text = "Создавать";
            this.create_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.create_btn.Textcolor = System.Drawing.Color.White;
            this.create_btn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.create_btn.Click += new System.EventHandler(this.create_btn_Click);
            // 
            // update_btn
            // 
            this.update_btn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(170)))), ((int)(((byte)(18)))));
            this.update_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(175)))), ((int)(((byte)(8)))));
            this.update_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.update_btn.BorderRadius = 0;
            this.update_btn.ButtonText = "Обновить";
            this.update_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.update_btn.DisabledColor = System.Drawing.Color.Gray;
            this.update_btn.Iconcolor = System.Drawing.Color.Transparent;
            this.update_btn.Iconimage = null;
            this.update_btn.Iconimage_right = null;
            this.update_btn.Iconimage_right_Selected = null;
            this.update_btn.Iconimage_Selected = null;
            this.update_btn.IconMarginLeft = 0;
            this.update_btn.IconMarginRight = 0;
            this.update_btn.IconRightVisible = true;
            this.update_btn.IconRightZoom = 0D;
            this.update_btn.IconVisible = true;
            this.update_btn.IconZoom = 90D;
            this.update_btn.IsTab = false;
            this.update_btn.Location = new System.Drawing.Point(364, 536);
            this.update_btn.Name = "update_btn";
            this.update_btn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(175)))), ((int)(((byte)(8)))));
            this.update_btn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(165)))), ((int)(((byte)(80)))));
            this.update_btn.OnHoverTextColor = System.Drawing.Color.White;
            this.update_btn.selected = false;
            this.update_btn.Size = new System.Drawing.Size(170, 27);
            this.update_btn.TabIndex = 21;
            this.update_btn.Text = "Обновить";
            this.update_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.update_btn.Textcolor = System.Drawing.Color.White;
            this.update_btn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update_btn.Click += new System.EventHandler(this.update_btn_Click);
            // 
            // deleteB
            // 
            this.deleteB.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(34)))), ((int)(((byte)(71)))));
            this.deleteB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(34)))), ((int)(((byte)(71)))));
            this.deleteB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.deleteB.BorderRadius = 0;
            this.deleteB.ButtonText = "Удалить";
            this.deleteB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteB.DisabledColor = System.Drawing.Color.Gray;
            this.deleteB.Iconcolor = System.Drawing.Color.Transparent;
            this.deleteB.Iconimage = null;
            this.deleteB.Iconimage_right = null;
            this.deleteB.Iconimage_right_Selected = null;
            this.deleteB.Iconimage_Selected = null;
            this.deleteB.IconMarginLeft = 0;
            this.deleteB.IconMarginRight = 0;
            this.deleteB.IconRightVisible = true;
            this.deleteB.IconRightZoom = 0D;
            this.deleteB.IconVisible = true;
            this.deleteB.IconZoom = 90D;
            this.deleteB.IsTab = false;
            this.deleteB.Location = new System.Drawing.Point(557, 536);
            this.deleteB.Name = "deleteB";
            this.deleteB.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(34)))), ((int)(((byte)(71)))));
            this.deleteB.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(127)))), ((int)(((byte)(90)))));
            this.deleteB.OnHoverTextColor = System.Drawing.Color.White;
            this.deleteB.selected = false;
            this.deleteB.Size = new System.Drawing.Size(170, 27);
            this.deleteB.TabIndex = 22;
            this.deleteB.Text = "Удалить";
            this.deleteB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.deleteB.Textcolor = System.Drawing.Color.White;
            this.deleteB.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteB.Click += new System.EventHandler(this.deleteB_Click);
            // 
            // repassUT
            // 
            this.repassUT.BorderColorFocused = System.Drawing.Color.Blue;
            this.repassUT.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.repassUT.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.repassUT.BorderThickness = 3;
            this.repassUT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.repassUT.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.repassUT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.repassUT.isPassword = false;
            this.repassUT.Location = new System.Drawing.Point(500, 491);
            this.repassUT.Margin = new System.Windows.Forms.Padding(4);
            this.repassUT.Name = "repassUT";
            this.repassUT.Size = new System.Drawing.Size(210, 31);
            this.repassUT.TabIndex = 23;
            this.repassUT.Text = "Повторите пароль";
            this.repassUT.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // idUT
            // 
            this.idUT.BorderColorFocused = System.Drawing.Color.Blue;
            this.idUT.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.idUT.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.idUT.BorderThickness = 3;
            this.idUT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.idUT.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.idUT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.idUT.isPassword = false;
            this.idUT.Location = new System.Drawing.Point(732, 413);
            this.idUT.Margin = new System.Windows.Forms.Padding(4);
            this.idUT.Name = "idUT";
            this.idUT.Size = new System.Drawing.Size(43, 31);
            this.idUT.TabIndex = 24;
            this.idUT.Text = "id";
            this.idUT.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // usersAdapter
            // 
            this.usersAdapter.ClearBeforeFill = true;
            // 
            // dialogFile
            // 
            this.dialogFile.FileName = "openFileDialog1";
            // 
            // clear_btn
            // 
            this.clear_btn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(132)))), ((int)(((byte)(36)))));
            this.clear_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(132)))), ((int)(((byte)(36)))));
            this.clear_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.clear_btn.BorderRadius = 0;
            this.clear_btn.ButtonText = "Очистить";
            this.clear_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clear_btn.DisabledColor = System.Drawing.Color.Gray;
            this.clear_btn.Iconcolor = System.Drawing.Color.Transparent;
            this.clear_btn.Iconimage = null;
            this.clear_btn.Iconimage_right = null;
            this.clear_btn.Iconimage_right_Selected = null;
            this.clear_btn.Iconimage_Selected = null;
            this.clear_btn.IconMarginLeft = 0;
            this.clear_btn.IconMarginRight = 0;
            this.clear_btn.IconRightVisible = true;
            this.clear_btn.IconRightZoom = 0D;
            this.clear_btn.IconVisible = true;
            this.clear_btn.IconZoom = 90D;
            this.clear_btn.IsTab = true;
            this.clear_btn.Location = new System.Drawing.Point(19, 536);
            this.clear_btn.Name = "clear_btn";
            this.clear_btn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(132)))), ((int)(((byte)(36)))));
            this.clear_btn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(132)))), ((int)(((byte)(36)))));
            this.clear_btn.OnHoverTextColor = System.Drawing.Color.White;
            this.clear_btn.selected = false;
            this.clear_btn.Size = new System.Drawing.Size(93, 27);
            this.clear_btn.TabIndex = 25;
            this.clear_btn.Text = "Очистить";
            this.clear_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.clear_btn.Textcolor = System.Drawing.Color.White;
            this.clear_btn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear_btn.Click += new System.EventHandler(this.clear_btn_Click);
            // 
            // Students
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(35)))));
            this.Controls.Add(this.clear_btn);
            this.Controls.Add(this.idUT);
            this.Controls.Add(this.repassUT);
            this.Controls.Add(this.deleteB);
            this.Controls.Add(this.update_btn);
            this.Controls.Add(this.create_btn);
            this.Controls.Add(this.imageUT);
            this.Controls.Add(this.bunifuFlatButton8);
            this.Controls.Add(this.bunifuFlatButton7);
            this.Controls.Add(this.bunifuFlatButton6);
            this.Controls.Add(this.bunifuFlatButton5);
            this.Controls.Add(this.bunifuFlatButton4);
            this.Controls.Add(this.bunifuFlatButton3);
            this.Controls.Add(this.bunifuFlatButton2);
            this.Controls.Add(this.bunifuFlatButton1);
            this.Controls.Add(this.roleUT);
            this.Controls.Add(this.pinUT);
            this.Controls.Add(this.passUT);
            this.Controls.Add(this.loginUT);
            this.Controls.Add(this.birthUT);
            this.Controls.Add(this.emailUT);
            this.Controls.Add(this.surnameUT);
            this.Controls.Add(this.nameUT);
            this.Controls.Add(this.userGrid);
            this.Name = "Students";
            this.Size = new System.Drawing.Size(1010, 566);
            this.Load += new System.EventHandler(this.Students_Load);
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageUT)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource usersBindingSource;
        private System.Windows.Forms.BindingSource udDataSetBindingSource;
        private udDataSet udDataSet;
        private udDataSetTableAdapters.usersTableAdapter usersAdapter;
        private System.Windows.Forms.BindingSource usersBindingSource1;
        private Bunifu.Framework.UI.BunifuCustomDataGrid userGrid;
        private Bunifu.Framework.UI.BunifuMetroTextbox nameUT;
        private Bunifu.Framework.UI.BunifuMetroTextbox surnameUT;
        private Bunifu.Framework.UI.BunifuMetroTextbox emailUT;
        private Bunifu.Framework.UI.BunifuMetroTextbox birthUT;
        private Bunifu.Framework.UI.BunifuMetroTextbox loginUT;
        private Bunifu.Framework.UI.BunifuMetroTextbox passUT;
        private Bunifu.Framework.UI.BunifuMetroTextbox pinUT;
        private Bunifu.Framework.UI.BunifuDropdown roleUT;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn loginDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn secretcodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roleDataGridViewTextBoxColumn;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton2;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton3;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton4;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton5;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton6;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton7;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton8;
        private Bunifu.Framework.UI.BunifuImageButton imageUT;
        private Bunifu.Framework.UI.BunifuFlatButton create_btn;
        private Bunifu.Framework.UI.BunifuFlatButton update_btn;
        private Bunifu.Framework.UI.BunifuFlatButton deleteB;
        private Bunifu.Framework.UI.BunifuMetroTextbox repassUT;
        private Bunifu.Framework.UI.BunifuMetroTextbox idUT;
        private System.Windows.Forms.BindingSource usersBindingSource2;
        private System.Windows.Forms.OpenFileDialog dialogFile;
        private Bunifu.Framework.UI.BunifuFlatButton clear_btn;
    }
}

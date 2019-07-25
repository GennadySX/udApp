namespace WindowsFormsApp2.Dashboard
{
    partial class Profile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Profile));
            this.roleUT = new Bunifu.Framework.UI.BunifuDropdown();
            this.pinUT = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.passUT = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.loginUT = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.birthUT = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.emailUT = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.surnameUT = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.nameUT = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.date_btn = new Bunifu.Framework.UI.BunifuDatepicker();
            this.imageUT = new Bunifu.Framework.UI.BunifuImageButton();
            this.deleteB = new Bunifu.Framework.UI.BunifuFlatButton();
            this.update_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.call_regPanel = new Bunifu.Framework.UI.BunifuFlatButton();
            this.dialogFile = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.imageUT)).BeginInit();
            this.SuspendLayout();
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
            this.roleUT.Location = new System.Drawing.Point(381, 233);
            this.roleUT.Name = "roleUT";
            this.roleUT.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.roleUT.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.roleUT.selectedIndex = 0;
            this.roleUT.Size = new System.Drawing.Size(236, 37);
            this.roleUT.TabIndex = 31;
            // 
            // pinUT
            // 
            this.pinUT.BorderColorFocused = System.Drawing.Color.MediumSlateBlue;
            this.pinUT.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pinUT.BorderColorMouseHover = System.Drawing.Color.DarkMagenta;
            this.pinUT.BorderThickness = 3;
            this.pinUT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.pinUT.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.pinUT.ForeColor = System.Drawing.Color.Silver;
            this.pinUT.isPassword = false;
            this.pinUT.Location = new System.Drawing.Point(53, 233);
            this.pinUT.Margin = new System.Windows.Forms.Padding(4);
            this.pinUT.Name = "pinUT";
            this.pinUT.Size = new System.Drawing.Size(281, 37);
            this.pinUT.TabIndex = 30;
            this.pinUT.Text = "Пин-кодь";
            this.pinUT.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // passUT
            // 
            this.passUT.BorderColorFocused = System.Drawing.Color.Brown;
            this.passUT.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.passUT.BorderColorMouseHover = System.Drawing.Color.OrangeRed;
            this.passUT.BorderThickness = 3;
            this.passUT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passUT.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.passUT.ForeColor = System.Drawing.Color.Silver;
            this.passUT.isPassword = false;
            this.passUT.Location = new System.Drawing.Point(381, 177);
            this.passUT.Margin = new System.Windows.Forms.Padding(4);
            this.passUT.Name = "passUT";
            this.passUT.Size = new System.Drawing.Size(236, 38);
            this.passUT.TabIndex = 29;
            this.passUT.Text = "Пароль";
            this.passUT.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // loginUT
            // 
            this.loginUT.BorderColorFocused = System.Drawing.Color.Blue;
            this.loginUT.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.loginUT.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.loginUT.BorderThickness = 3;
            this.loginUT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.loginUT.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.loginUT.ForeColor = System.Drawing.Color.Silver;
            this.loginUT.isPassword = false;
            this.loginUT.Location = new System.Drawing.Point(53, 177);
            this.loginUT.Margin = new System.Windows.Forms.Padding(4);
            this.loginUT.Name = "loginUT";
            this.loginUT.Size = new System.Drawing.Size(281, 38);
            this.loginUT.TabIndex = 28;
            this.loginUT.Text = "Логин";
            this.loginUT.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // birthUT
            // 
            this.birthUT.BorderColorFocused = System.Drawing.Color.Chartreuse;
            this.birthUT.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.birthUT.BorderColorMouseHover = System.Drawing.Color.LawnGreen;
            this.birthUT.BorderThickness = 3;
            this.birthUT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.birthUT.Enabled = false;
            this.birthUT.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.birthUT.ForeColor = System.Drawing.Color.Silver;
            this.birthUT.isPassword = false;
            this.birthUT.Location = new System.Drawing.Point(381, 114);
            this.birthUT.Margin = new System.Windows.Forms.Padding(4);
            this.birthUT.Name = "birthUT";
            this.birthUT.Size = new System.Drawing.Size(236, 41);
            this.birthUT.TabIndex = 27;
            this.birthUT.Text = "День рождения";
            this.birthUT.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.birthUT.OnValueChanged += new System.EventHandler(this.birthUT_OnValueChanged);
            this.birthUT.Enter += new System.EventHandler(this.birthUT_Enter);
            // 
            // emailUT
            // 
            this.emailUT.BorderColorFocused = System.Drawing.Color.DodgerBlue;
            this.emailUT.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.emailUT.BorderColorMouseHover = System.Drawing.Color.SteelBlue;
            this.emailUT.BorderThickness = 3;
            this.emailUT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.emailUT.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.emailUT.ForeColor = System.Drawing.Color.Silver;
            this.emailUT.isPassword = false;
            this.emailUT.Location = new System.Drawing.Point(53, 114);
            this.emailUT.Margin = new System.Windows.Forms.Padding(4);
            this.emailUT.Name = "emailUT";
            this.emailUT.Size = new System.Drawing.Size(281, 41);
            this.emailUT.TabIndex = 26;
            this.emailUT.Text = "Email адрес";
            this.emailUT.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // surnameUT
            // 
            this.surnameUT.BorderColorFocused = System.Drawing.Color.SpringGreen;
            this.surnameUT.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.surnameUT.BorderColorMouseHover = System.Drawing.Color.MediumAquamarine;
            this.surnameUT.BorderThickness = 3;
            this.surnameUT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.surnameUT.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.surnameUT.ForeColor = System.Drawing.Color.Silver;
            this.surnameUT.isPassword = false;
            this.surnameUT.Location = new System.Drawing.Point(381, 49);
            this.surnameUT.Margin = new System.Windows.Forms.Padding(4);
            this.surnameUT.Name = "surnameUT";
            this.surnameUT.Size = new System.Drawing.Size(236, 46);
            this.surnameUT.TabIndex = 25;
            this.surnameUT.Text = "Фамилия";
            this.surnameUT.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // nameUT
            // 
            this.nameUT.BorderColorFocused = System.Drawing.Color.SpringGreen;
            this.nameUT.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.nameUT.BorderColorMouseHover = System.Drawing.Color.MediumAquamarine;
            this.nameUT.BorderThickness = 3;
            this.nameUT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nameUT.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.nameUT.ForeColor = System.Drawing.Color.Silver;
            this.nameUT.isPassword = false;
            this.nameUT.Location = new System.Drawing.Point(53, 49);
            this.nameUT.Margin = new System.Windows.Forms.Padding(4);
            this.nameUT.Name = "nameUT";
            this.nameUT.Size = new System.Drawing.Size(281, 46);
            this.nameUT.TabIndex = 24;
            this.nameUT.Text = "Имя";
            this.nameUT.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // date_btn
            // 
            this.date_btn.BackColor = System.Drawing.Color.Transparent;
            this.date_btn.BorderRadius = 0;
            this.date_btn.ForeColor = System.Drawing.Color.White;
            this.date_btn.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.date_btn.FormatCustom = null;
            this.date_btn.Location = new System.Drawing.Point(579, 124);
            this.date_btn.Name = "date_btn";
            this.date_btn.Size = new System.Drawing.Size(27, 24);
            this.date_btn.TabIndex = 33;
            this.date_btn.Value = new System.DateTime(2019, 1, 19, 16, 5, 45, 698);
            this.date_btn.onValueChanged += new System.EventHandler(this.date_btn_onValueChanged);
            // 
            // imageUT
            // 
            this.imageUT.BackColor = System.Drawing.Color.Transparent;
            this.imageUT.Image = ((System.Drawing.Image)(resources.GetObject("imageUT.Image")));
            this.imageUT.ImageActive = null;
            this.imageUT.Location = new System.Drawing.Point(674, 49);
            this.imageUT.Name = "imageUT";
            this.imageUT.Size = new System.Drawing.Size(252, 166);
            this.imageUT.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imageUT.TabIndex = 34;
            this.imageUT.TabStop = false;
            this.imageUT.Zoom = 10;
            this.imageUT.Click += new System.EventHandler(this.imageUT_Click);
            // 
            // deleteB
            // 
            this.deleteB.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(34)))), ((int)(((byte)(71)))));
            this.deleteB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(34)))), ((int)(((byte)(71)))));
            this.deleteB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.deleteB.BorderRadius = 0;
            this.deleteB.ButtonText = "Убить себя";
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
            this.deleteB.Location = new System.Drawing.Point(339, 421);
            this.deleteB.Name = "deleteB";
            this.deleteB.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(34)))), ((int)(((byte)(71)))));
            this.deleteB.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(127)))), ((int)(((byte)(90)))));
            this.deleteB.OnHoverTextColor = System.Drawing.Color.White;
            this.deleteB.selected = false;
            this.deleteB.Size = new System.Drawing.Size(206, 62);
            this.deleteB.TabIndex = 36;
            this.deleteB.Text = "Убить себя";
            this.deleteB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.deleteB.Textcolor = System.Drawing.Color.White;
            this.deleteB.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteB.Click += new System.EventHandler(this.deleteB_Click);
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
            this.update_btn.Location = new System.Drawing.Point(63, 421);
            this.update_btn.Name = "update_btn";
            this.update_btn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(175)))), ((int)(((byte)(8)))));
            this.update_btn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(165)))), ((int)(((byte)(80)))));
            this.update_btn.OnHoverTextColor = System.Drawing.Color.White;
            this.update_btn.selected = false;
            this.update_btn.Size = new System.Drawing.Size(206, 62);
            this.update_btn.TabIndex = 35;
            this.update_btn.Text = "Обновить";
            this.update_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.update_btn.Textcolor = System.Drawing.Color.White;
            this.update_btn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update_btn.Click += new System.EventHandler(this.update_btn_Click);
            // 
            // call_regPanel
            // 
            this.call_regPanel.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(47)))), ((int)(((byte)(70)))));
            this.call_regPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(45)))), ((int)(((byte)(65)))));
            this.call_regPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.call_regPanel.BorderRadius = 0;
            this.call_regPanel.ButtonText = "Загрузить фото";
            this.call_regPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.call_regPanel.DisabledColor = System.Drawing.Color.Gray;
            this.call_regPanel.Iconcolor = System.Drawing.Color.Transparent;
            this.call_regPanel.Iconimage = ((System.Drawing.Image)(resources.GetObject("call_regPanel.Iconimage")));
            this.call_regPanel.Iconimage_right = null;
            this.call_regPanel.Iconimage_right_Selected = null;
            this.call_regPanel.Iconimage_Selected = null;
            this.call_regPanel.IconMarginLeft = 0;
            this.call_regPanel.IconMarginRight = 0;
            this.call_regPanel.IconRightVisible = true;
            this.call_regPanel.IconRightZoom = 0D;
            this.call_regPanel.IconVisible = true;
            this.call_regPanel.IconZoom = 90D;
            this.call_regPanel.IsTab = false;
            this.call_regPanel.Location = new System.Drawing.Point(710, 232);
            this.call_regPanel.Name = "call_regPanel";
            this.call_regPanel.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(45)))), ((int)(((byte)(65)))));
            this.call_regPanel.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(45)))), ((int)(((byte)(70)))));
            this.call_regPanel.OnHoverTextColor = System.Drawing.Color.White;
            this.call_regPanel.selected = false;
            this.call_regPanel.Size = new System.Drawing.Size(199, 38);
            this.call_regPanel.TabIndex = 37;
            this.call_regPanel.Text = "Загрузить фото";
            this.call_regPanel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.call_regPanel.Textcolor = System.Drawing.Color.White;
            this.call_regPanel.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.call_regPanel.Click += new System.EventHandler(this.call_regPanel_Click);
            // 
            // dialogFile
            // 
            this.dialogFile.FileName = "openFileDialog1";
            // 
            // Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(35)))));
            this.Controls.Add(this.call_regPanel);
            this.Controls.Add(this.deleteB);
            this.Controls.Add(this.update_btn);
            this.Controls.Add(this.imageUT);
            this.Controls.Add(this.date_btn);
            this.Controls.Add(this.roleUT);
            this.Controls.Add(this.pinUT);
            this.Controls.Add(this.passUT);
            this.Controls.Add(this.loginUT);
            this.Controls.Add(this.birthUT);
            this.Controls.Add(this.emailUT);
            this.Controls.Add(this.surnameUT);
            this.Controls.Add(this.nameUT);
            this.Name = "Profile";
            this.Size = new System.Drawing.Size(1010, 566);
            this.Load += new System.EventHandler(this.Profile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imageUT)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuDropdown roleUT;
        private Bunifu.Framework.UI.BunifuMetroTextbox pinUT;
        private Bunifu.Framework.UI.BunifuMetroTextbox passUT;
        private Bunifu.Framework.UI.BunifuMetroTextbox loginUT;
        private Bunifu.Framework.UI.BunifuMetroTextbox birthUT;
        private Bunifu.Framework.UI.BunifuMetroTextbox emailUT;
        private Bunifu.Framework.UI.BunifuMetroTextbox surnameUT;
        private Bunifu.Framework.UI.BunifuMetroTextbox nameUT;
        private Bunifu.Framework.UI.BunifuDatepicker date_btn;
        private Bunifu.Framework.UI.BunifuImageButton imageUT;
        private Bunifu.Framework.UI.BunifuFlatButton deleteB;
        private Bunifu.Framework.UI.BunifuFlatButton update_btn;
        public Bunifu.Framework.UI.BunifuFlatButton call_regPanel;
        private System.Windows.Forms.OpenFileDialog dialogFile;
    }
}

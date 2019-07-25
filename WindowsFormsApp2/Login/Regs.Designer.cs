namespace WindowsFormsApp2
{
    partial class reg_panel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(reg_panel));
            this.reg_fname = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.reg_sname = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.reg_email = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.reg_age = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.reg_secretPin = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.reg_repass = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.reg_pass = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.reg_login = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.reg_reg_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.reg_checkbox = new Bunifu.Framework.UI.BunifuCheckbox();
            this.reg_rule = new System.Windows.Forms.LinkLabel();
            this.reg_label = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.reb_backToLogin = new Bunifu.Framework.UI.BunifuFlatButton();
            this.date_btn = new Bunifu.Framework.UI.BunifuDatepicker();
            this.SuspendLayout();
            // 
            // reg_fname
            // 
            this.reg_fname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.reg_fname.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.reg_fname.ForeColor = System.Drawing.Color.White;
            this.reg_fname.HintForeColor = System.Drawing.Color.Empty;
            this.reg_fname.HintText = "";
            this.reg_fname.isPassword = false;
            this.reg_fname.LineFocusedColor = System.Drawing.Color.DarkCyan;
            this.reg_fname.LineIdleColor = System.Drawing.Color.Gray;
            this.reg_fname.LineMouseHoverColor = System.Drawing.Color.Turquoise;
            this.reg_fname.LineThickness = 3;
            this.reg_fname.Location = new System.Drawing.Point(56, 105);
            this.reg_fname.Margin = new System.Windows.Forms.Padding(4);
            this.reg_fname.Name = "reg_fname";
            this.reg_fname.Size = new System.Drawing.Size(253, 32);
            this.reg_fname.TabIndex = 1;
            this.reg_fname.Text = "Ваше имя";
            this.reg_fname.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.reg_fname.KeyDown += new System.Windows.Forms.KeyEventHandler(this.reg_fname_KeyDown);
            this.reg_fname.Leave += new System.EventHandler(this.reg_fname_Leave);
            this.reg_fname.MouseLeave += new System.EventHandler(this.reg_fname_MouseLeave);
            // 
            // reg_sname
            // 
            this.reg_sname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.reg_sname.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.reg_sname.ForeColor = System.Drawing.Color.White;
            this.reg_sname.HintForeColor = System.Drawing.Color.Empty;
            this.reg_sname.HintText = "";
            this.reg_sname.isPassword = false;
            this.reg_sname.LineFocusedColor = System.Drawing.Color.DeepPink;
            this.reg_sname.LineIdleColor = System.Drawing.Color.Gray;
            this.reg_sname.LineMouseHoverColor = System.Drawing.Color.Violet;
            this.reg_sname.LineThickness = 3;
            this.reg_sname.Location = new System.Drawing.Point(56, 158);
            this.reg_sname.Margin = new System.Windows.Forms.Padding(4);
            this.reg_sname.Name = "reg_sname";
            this.reg_sname.Size = new System.Drawing.Size(253, 32);
            this.reg_sname.TabIndex = 2;
            this.reg_sname.Text = "Ваша фамилия ";
            this.reg_sname.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.reg_sname.KeyDown += new System.Windows.Forms.KeyEventHandler(this.reg_sname_KeyDown);
            this.reg_sname.Leave += new System.EventHandler(this.reg_sname_Leave);
            this.reg_sname.MouseLeave += new System.EventHandler(this.reg_sname_MouseLeave);
            // 
            // reg_email
            // 
            this.reg_email.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.reg_email.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.reg_email.ForeColor = System.Drawing.Color.White;
            this.reg_email.HintForeColor = System.Drawing.Color.Empty;
            this.reg_email.HintText = "";
            this.reg_email.isPassword = false;
            this.reg_email.LineFocusedColor = System.Drawing.Color.DeepPink;
            this.reg_email.LineIdleColor = System.Drawing.Color.Gray;
            this.reg_email.LineMouseHoverColor = System.Drawing.Color.Violet;
            this.reg_email.LineThickness = 3;
            this.reg_email.Location = new System.Drawing.Point(56, 210);
            this.reg_email.Margin = new System.Windows.Forms.Padding(4);
            this.reg_email.Name = "reg_email";
            this.reg_email.Size = new System.Drawing.Size(253, 32);
            this.reg_email.TabIndex = 3;
            this.reg_email.Text = "Ваш email ";
            this.reg_email.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.reg_email.OnValueChanged += new System.EventHandler(this.reg_email_OnValueChanged);
            this.reg_email.Enter += new System.EventHandler(this.reg_email_Enter);
            this.reg_email.KeyDown += new System.Windows.Forms.KeyEventHandler(this.reg_email_KeyDown);
            this.reg_email.Leave += new System.EventHandler(this.reg_email_Leave);
            // 
            // reg_age
            // 
            this.reg_age.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.reg_age.Enabled = false;
            this.reg_age.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.reg_age.ForeColor = System.Drawing.Color.White;
            this.reg_age.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.reg_age.HintText = "Введите только цифры";
            this.reg_age.isPassword = false;
            this.reg_age.LineFocusedColor = System.Drawing.Color.DeepPink;
            this.reg_age.LineIdleColor = System.Drawing.Color.Gray;
            this.reg_age.LineMouseHoverColor = System.Drawing.Color.Violet;
            this.reg_age.LineThickness = 3;
            this.reg_age.Location = new System.Drawing.Point(56, 270);
            this.reg_age.Margin = new System.Windows.Forms.Padding(4);
            this.reg_age.Name = "reg_age";
            this.reg_age.Size = new System.Drawing.Size(253, 32);
            this.reg_age.TabIndex = 4;
            this.reg_age.Text = "Ваш день рождения";
            this.reg_age.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.reg_age.Enter += new System.EventHandler(this.reg_age_Enter);
            this.reg_age.Leave += new System.EventHandler(this.reg_age_Leave);
            // 
            // reg_secretPin
            // 
            this.reg_secretPin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.reg_secretPin.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.reg_secretPin.ForeColor = System.Drawing.Color.White;
            this.reg_secretPin.HintForeColor = System.Drawing.Color.Empty;
            this.reg_secretPin.HintText = "";
            this.reg_secretPin.isPassword = false;
            this.reg_secretPin.LineFocusedColor = System.Drawing.Color.DeepPink;
            this.reg_secretPin.LineIdleColor = System.Drawing.Color.Gray;
            this.reg_secretPin.LineMouseHoverColor = System.Drawing.Color.Violet;
            this.reg_secretPin.LineThickness = 3;
            this.reg_secretPin.Location = new System.Drawing.Point(337, 270);
            this.reg_secretPin.Margin = new System.Windows.Forms.Padding(4);
            this.reg_secretPin.Name = "reg_secretPin";
            this.reg_secretPin.Size = new System.Drawing.Size(253, 32);
            this.reg_secretPin.TabIndex = 8;
            this.reg_secretPin.Text = "Секретный пин-код";
            this.reg_secretPin.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.reg_secretPin.KeyDown += new System.Windows.Forms.KeyEventHandler(this.reg_secretPin_KeyDown);
            this.reg_secretPin.Leave += new System.EventHandler(this.reg_secretPin_Leave);
            this.reg_secretPin.MouseLeave += new System.EventHandler(this.reg_secretPin_MouseLeave);
            // 
            // reg_repass
            // 
            this.reg_repass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.reg_repass.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.reg_repass.ForeColor = System.Drawing.Color.White;
            this.reg_repass.HintForeColor = System.Drawing.Color.Empty;
            this.reg_repass.HintText = "";
            this.reg_repass.isPassword = false;
            this.reg_repass.LineFocusedColor = System.Drawing.Color.DeepPink;
            this.reg_repass.LineIdleColor = System.Drawing.Color.Gray;
            this.reg_repass.LineMouseHoverColor = System.Drawing.Color.Violet;
            this.reg_repass.LineThickness = 3;
            this.reg_repass.Location = new System.Drawing.Point(337, 210);
            this.reg_repass.Margin = new System.Windows.Forms.Padding(4);
            this.reg_repass.Name = "reg_repass";
            this.reg_repass.Size = new System.Drawing.Size(253, 32);
            this.reg_repass.TabIndex = 7;
            this.reg_repass.Text = "Повторите пароль";
            this.reg_repass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.reg_repass.Enter += new System.EventHandler(this.reg_repass_Enter);
            this.reg_repass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.reg_repass_KeyDown);
            this.reg_repass.Leave += new System.EventHandler(this.reg_repass_Leave);
            this.reg_repass.MouseLeave += new System.EventHandler(this.reg_repass_MouseLeave);
            // 
            // reg_pass
            // 
            this.reg_pass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.reg_pass.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.reg_pass.ForeColor = System.Drawing.Color.White;
            this.reg_pass.HintForeColor = System.Drawing.Color.Empty;
            this.reg_pass.HintText = "";
            this.reg_pass.isPassword = false;
            this.reg_pass.LineFocusedColor = System.Drawing.Color.DeepPink;
            this.reg_pass.LineIdleColor = System.Drawing.Color.Gray;
            this.reg_pass.LineMouseHoverColor = System.Drawing.Color.Violet;
            this.reg_pass.LineThickness = 3;
            this.reg_pass.Location = new System.Drawing.Point(337, 158);
            this.reg_pass.Margin = new System.Windows.Forms.Padding(4);
            this.reg_pass.Name = "reg_pass";
            this.reg_pass.Size = new System.Drawing.Size(253, 32);
            this.reg_pass.TabIndex = 6;
            this.reg_pass.Text = "Ваш пароль";
            this.reg_pass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.reg_pass.Enter += new System.EventHandler(this.reg_pass_Enter);
            this.reg_pass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.reg_pass_KeyDown);
            this.reg_pass.Leave += new System.EventHandler(this.reg_pass_Leave);
            this.reg_pass.MouseLeave += new System.EventHandler(this.reg_pass_MouseLeave);
            // 
            // reg_login
            // 
            this.reg_login.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.reg_login.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.reg_login.ForeColor = System.Drawing.Color.White;
            this.reg_login.HintForeColor = System.Drawing.Color.Empty;
            this.reg_login.HintText = "";
            this.reg_login.isPassword = false;
            this.reg_login.LineFocusedColor = System.Drawing.Color.DarkCyan;
            this.reg_login.LineIdleColor = System.Drawing.Color.Gray;
            this.reg_login.LineMouseHoverColor = System.Drawing.Color.Turquoise;
            this.reg_login.LineThickness = 3;
            this.reg_login.Location = new System.Drawing.Point(337, 105);
            this.reg_login.Margin = new System.Windows.Forms.Padding(4);
            this.reg_login.Name = "reg_login";
            this.reg_login.Size = new System.Drawing.Size(253, 32);
            this.reg_login.TabIndex = 5;
            this.reg_login.Text = "Ваш логин";
            this.reg_login.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.reg_login.KeyDown += new System.Windows.Forms.KeyEventHandler(this.reg_login_KeyDown);
            this.reg_login.Leave += new System.EventHandler(this.reg_login_Leave);
            this.reg_login.MouseLeave += new System.EventHandler(this.reg_login_MouseLeave);
            // 
            // reg_reg_btn
            // 
            this.reg_reg_btn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(47)))), ((int)(((byte)(70)))));
            this.reg_reg_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(45)))), ((int)(((byte)(65)))));
            this.reg_reg_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.reg_reg_btn.BorderRadius = 0;
            this.reg_reg_btn.ButtonText = "Я теперь  с Вами";
            this.reg_reg_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.reg_reg_btn.DisabledColor = System.Drawing.Color.Gray;
            this.reg_reg_btn.Iconcolor = System.Drawing.Color.Transparent;
            this.reg_reg_btn.Iconimage = ((System.Drawing.Image)(resources.GetObject("reg_reg_btn.Iconimage")));
            this.reg_reg_btn.Iconimage_right = null;
            this.reg_reg_btn.Iconimage_right_Selected = null;
            this.reg_reg_btn.Iconimage_Selected = null;
            this.reg_reg_btn.IconMarginLeft = 0;
            this.reg_reg_btn.IconMarginRight = 0;
            this.reg_reg_btn.IconRightVisible = true;
            this.reg_reg_btn.IconRightZoom = 0D;
            this.reg_reg_btn.IconVisible = true;
            this.reg_reg_btn.IconZoom = 90D;
            this.reg_reg_btn.IsTab = false;
            this.reg_reg_btn.Location = new System.Drawing.Point(421, 329);
            this.reg_reg_btn.Name = "reg_reg_btn";
            this.reg_reg_btn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(45)))), ((int)(((byte)(65)))));
            this.reg_reg_btn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(45)))), ((int)(((byte)(70)))));
            this.reg_reg_btn.OnHoverTextColor = System.Drawing.Color.White;
            this.reg_reg_btn.selected = false;
            this.reg_reg_btn.Size = new System.Drawing.Size(169, 38);
            this.reg_reg_btn.TabIndex = 9;
            this.reg_reg_btn.Text = "Я теперь  с Вами";
            this.reg_reg_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.reg_reg_btn.Textcolor = System.Drawing.Color.White;
            this.reg_reg_btn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reg_reg_btn.Click += new System.EventHandler(this.reg_reg_btn_Click);
            // 
            // reg_checkbox
            // 
            this.reg_checkbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.reg_checkbox.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.reg_checkbox.Checked = false;
            this.reg_checkbox.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.reg_checkbox.ForeColor = System.Drawing.Color.White;
            this.reg_checkbox.Location = new System.Drawing.Point(134, 340);
            this.reg_checkbox.Name = "reg_checkbox";
            this.reg_checkbox.Size = new System.Drawing.Size(20, 20);
            this.reg_checkbox.TabIndex = 10;
            this.reg_checkbox.OnChange += new System.EventHandler(this.reg_checkbox_OnChange);
            // 
            // reg_rule
            // 
            this.reg_rule.AutoSize = true;
            this.reg_rule.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reg_rule.LinkColor = System.Drawing.Color.SeaGreen;
            this.reg_rule.Location = new System.Drawing.Point(160, 340);
            this.reg_rule.Name = "reg_rule";
            this.reg_rule.Size = new System.Drawing.Size(114, 17);
            this.reg_rule.TabIndex = 11;
            this.reg_rule.TabStop = true;
            this.reg_rule.Text = "Я на все согласен...";
            this.reg_rule.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.reg_rule_LinkClicked);
            // 
            // reg_label
            // 
            this.reg_label.AutoSize = true;
            this.reg_label.Font = new System.Drawing.Font("Sitka Small", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reg_label.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.reg_label.Location = new System.Drawing.Point(127, 42);
            this.reg_label.Name = "reg_label";
            this.reg_label.Size = new System.Drawing.Size(382, 40);
            this.reg_label.TabIndex = 12;
            this.reg_label.Text = "Шаги за большем путем";
            // 
            // reb_backToLogin
            // 
            this.reb_backToLogin.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(47)))), ((int)(((byte)(70)))));
            this.reb_backToLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(45)))), ((int)(((byte)(65)))));
            this.reb_backToLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.reb_backToLogin.BorderRadius = 0;
            this.reb_backToLogin.ButtonText = "Я уже с Вами";
            this.reb_backToLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.reb_backToLogin.DisabledColor = System.Drawing.Color.Gray;
            this.reb_backToLogin.Iconcolor = System.Drawing.Color.Transparent;
            this.reb_backToLogin.Iconimage = ((System.Drawing.Image)(resources.GetObject("reb_backToLogin.Iconimage")));
            this.reb_backToLogin.Iconimage_right = null;
            this.reb_backToLogin.Iconimage_right_Selected = null;
            this.reb_backToLogin.Iconimage_Selected = null;
            this.reb_backToLogin.IconMarginLeft = 0;
            this.reb_backToLogin.IconMarginRight = 0;
            this.reb_backToLogin.IconRightVisible = true;
            this.reb_backToLogin.IconRightZoom = 0D;
            this.reb_backToLogin.IconVisible = true;
            this.reb_backToLogin.IconZoom = 90D;
            this.reb_backToLogin.IsTab = false;
            this.reb_backToLogin.Location = new System.Drawing.Point(14, -1);
            this.reb_backToLogin.Name = "reb_backToLogin";
            this.reb_backToLogin.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(45)))), ((int)(((byte)(65)))));
            this.reb_backToLogin.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(45)))), ((int)(((byte)(70)))));
            this.reb_backToLogin.OnHoverTextColor = System.Drawing.Color.White;
            this.reb_backToLogin.selected = false;
            this.reb_backToLogin.Size = new System.Drawing.Size(140, 39);
            this.reb_backToLogin.TabIndex = 13;
            this.reb_backToLogin.Text = "Я уже с Вами";
            this.reb_backToLogin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.reb_backToLogin.Textcolor = System.Drawing.Color.White;
            this.reb_backToLogin.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reb_backToLogin.Click += new System.EventHandler(this.reb_backToLogin_Click);
            // 
            // date_btn
            // 
            this.date_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(34)))), ((int)(((byte)(41)))));
            this.date_btn.BorderRadius = 0;
            this.date_btn.ForeColor = System.Drawing.Color.White;
            this.date_btn.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.date_btn.FormatCustom = null;
            this.date_btn.Location = new System.Drawing.Point(272, 262);
            this.date_btn.Name = "date_btn";
            this.date_btn.Size = new System.Drawing.Size(36, 38);
            this.date_btn.TabIndex = 15;
            this.date_btn.Value = new System.DateTime(2019, 1, 19, 16, 5, 45, 698);
            this.date_btn.onValueChanged += new System.EventHandler(this.date_btn_onValueChanged);
            this.date_btn.Click += new System.EventHandler(this.date_btn_Click);
            // 
            // reg_panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(34)))), ((int)(((byte)(41)))));
            this.Controls.Add(this.date_btn);
            this.Controls.Add(this.reb_backToLogin);
            this.Controls.Add(this.reg_label);
            this.Controls.Add(this.reg_rule);
            this.Controls.Add(this.reg_checkbox);
            this.Controls.Add(this.reg_reg_btn);
            this.Controls.Add(this.reg_secretPin);
            this.Controls.Add(this.reg_repass);
            this.Controls.Add(this.reg_pass);
            this.Controls.Add(this.reg_login);
            this.Controls.Add(this.reg_age);
            this.Controls.Add(this.reg_email);
            this.Controls.Add(this.reg_sname);
            this.Controls.Add(this.reg_fname);
            this.Name = "reg_panel";
            this.Size = new System.Drawing.Size(616, 395);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.reg_panel_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.reg_panel_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.reg_panel_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuMaterialTextbox reg_fname;
        private Bunifu.Framework.UI.BunifuMaterialTextbox reg_sname;
        private Bunifu.Framework.UI.BunifuMaterialTextbox reg_email;
        private Bunifu.Framework.UI.BunifuMaterialTextbox reg_age;
        private Bunifu.Framework.UI.BunifuMaterialTextbox reg_secretPin;
        private Bunifu.Framework.UI.BunifuMaterialTextbox reg_repass;
        private Bunifu.Framework.UI.BunifuMaterialTextbox reg_pass;
        private Bunifu.Framework.UI.BunifuMaterialTextbox reg_login;
        private Bunifu.Framework.UI.BunifuFlatButton reg_reg_btn;
        private Bunifu.Framework.UI.BunifuCheckbox reg_checkbox;
        private System.Windows.Forms.LinkLabel reg_rule;
        private Bunifu.Framework.UI.BunifuCustomLabel reg_label;
        private Bunifu.Framework.UI.BunifuFlatButton reb_backToLogin;
        private Bunifu.Framework.UI.BunifuDatepicker date_btn;
    }
}

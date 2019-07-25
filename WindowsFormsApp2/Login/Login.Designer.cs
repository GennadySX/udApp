namespace WindowsFormsApp2
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.forget_pass = new System.Windows.Forms.LinkLabel();
            this.login_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.password_input = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.login_input = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.call_regPanel = new Bunifu.Framework.UI.BunifuFlatButton();
            this.reg_label = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, -29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(339, 421);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // forget_pass
            // 
            this.forget_pass.AutoSize = true;
            this.forget_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.forget_pass.LinkColor = System.Drawing.Color.SeaGreen;
            this.forget_pass.Location = new System.Drawing.Point(533, 264);
            this.forget_pass.Name = "forget_pass";
            this.forget_pass.Size = new System.Drawing.Size(78, 13);
            this.forget_pass.TabIndex = 10;
            this.forget_pass.TabStop = true;
            this.forget_pass.Text = "забыл пароль";
            this.forget_pass.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.forget_pass_LinkClicked);
            // 
            // login_btn
            // 
            this.login_btn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.login_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.login_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.login_btn.BorderRadius = 0;
            this.login_btn.ButtonText = "Вход";
            this.login_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.login_btn.DisabledColor = System.Drawing.Color.Gray;
            this.login_btn.Iconcolor = System.Drawing.Color.Transparent;
            this.login_btn.Iconimage = ((System.Drawing.Image)(resources.GetObject("login_btn.Iconimage")));
            this.login_btn.Iconimage_right = null;
            this.login_btn.Iconimage_right_Selected = null;
            this.login_btn.Iconimage_Selected = null;
            this.login_btn.IconMarginLeft = 0;
            this.login_btn.IconMarginRight = 0;
            this.login_btn.IconRightVisible = true;
            this.login_btn.IconRightZoom = 0D;
            this.login_btn.IconVisible = true;
            this.login_btn.IconZoom = 90D;
            this.login_btn.IsTab = false;
            this.login_btn.Location = new System.Drawing.Point(429, 317);
            this.login_btn.Name = "login_btn";
            this.login_btn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.login_btn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.login_btn.OnHoverTextColor = System.Drawing.Color.White;
            this.login_btn.selected = false;
            this.login_btn.Size = new System.Drawing.Size(133, 38);
            this.login_btn.TabIndex = 9;
            this.login_btn.Text = "Вход";
            this.login_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.login_btn.Textcolor = System.Drawing.Color.White;
            this.login_btn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_btn.Click += new System.EventHandler(this.login_btn_Click);
            // 
            // password_input
            // 
            this.password_input.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.password_input.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.password_input.ForeColor = System.Drawing.Color.White;
            this.password_input.HintForeColor = System.Drawing.Color.White;
            this.password_input.HintText = "";
            this.password_input.isPassword = false;
            this.password_input.LineFocusedColor = System.Drawing.Color.DeepPink;
            this.password_input.LineIdleColor = System.Drawing.Color.Gray;
            this.password_input.LineMouseHoverColor = System.Drawing.Color.Violet;
            this.password_input.LineThickness = 3;
            this.password_input.Location = new System.Drawing.Point(360, 225);
            this.password_input.Margin = new System.Windows.Forms.Padding(4);
            this.password_input.Name = "password_input";
            this.password_input.Size = new System.Drawing.Size(253, 32);
            this.password_input.TabIndex = 8;
            this.password_input.Text = "Ваш пароль";
            this.password_input.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.password_input.OnValueChanged += new System.EventHandler(this.password_input_OnValueChanged);
            this.password_input.Click += new System.EventHandler(this.password_input_Click);
            this.password_input.Enter += new System.EventHandler(this.password_input_Enter);
            this.password_input.KeyDown += new System.Windows.Forms.KeyEventHandler(this.password_input_KeyDown);
            this.password_input.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.password_input_KeyPress);
            this.password_input.Leave += new System.EventHandler(this.password_input_Leave);
            this.password_input.MouseClick += new System.Windows.Forms.MouseEventHandler(this.password_input_MouseClick);
            // 
            // login_input
            // 
            this.login_input.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.login_input.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.login_input.ForeColor = System.Drawing.Color.White;
            this.login_input.HintForeColor = System.Drawing.Color.White;
            this.login_input.HintText = "";
            this.login_input.isPassword = false;
            this.login_input.LineFocusedColor = System.Drawing.Color.DarkCyan;
            this.login_input.LineIdleColor = System.Drawing.Color.Gray;
            this.login_input.LineMouseHoverColor = System.Drawing.Color.Turquoise;
            this.login_input.LineThickness = 3;
            this.login_input.Location = new System.Drawing.Point(360, 148);
            this.login_input.Margin = new System.Windows.Forms.Padding(4);
            this.login_input.Name = "login_input";
            this.login_input.Size = new System.Drawing.Size(253, 32);
            this.login_input.TabIndex = 7;
            this.login_input.Text = "Ваш логин";
            this.login_input.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.login_input.OnValueChanged += new System.EventHandler(this.login_input_OnValueChanged);
            this.login_input.Click += new System.EventHandler(this.login_input_Click);
            this.login_input.KeyDown += new System.Windows.Forms.KeyEventHandler(this.login_input_KeyDown);
            this.login_input.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.login_input_KeyPress);
            this.login_input.Leave += new System.EventHandler(this.login_input_Leave);
            this.login_input.MouseEnter += new System.EventHandler(this.login_input_MouseEnter);
            // 
            // call_regPanel
            // 
            this.call_regPanel.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(47)))), ((int)(((byte)(70)))));
            this.call_regPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(45)))), ((int)(((byte)(65)))));
            this.call_regPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.call_regPanel.BorderRadius = 0;
            this.call_regPanel.ButtonText = "Стань нашем членом";
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
            this.call_regPanel.Location = new System.Drawing.Point(80, 288);
            this.call_regPanel.Name = "call_regPanel";
            this.call_regPanel.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(45)))), ((int)(((byte)(65)))));
            this.call_regPanel.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(45)))), ((int)(((byte)(70)))));
            this.call_regPanel.OnHoverTextColor = System.Drawing.Color.White;
            this.call_regPanel.selected = false;
            this.call_regPanel.Size = new System.Drawing.Size(199, 38);
            this.call_regPanel.TabIndex = 12;
            this.call_regPanel.Text = "Стань нашем членом";
            this.call_regPanel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.call_regPanel.Textcolor = System.Drawing.Color.White;
            this.call_regPanel.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.call_regPanel.Click += new System.EventHandler(this.call_regPanel_Click);
            // 
            // reg_label
            // 
            this.reg_label.AutoSize = true;
            this.reg_label.Font = new System.Drawing.Font("Sitka Small", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.reg_label.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.reg_label.Location = new System.Drawing.Point(61, 12);
            this.reg_label.Name = "reg_label";
            this.reg_label.Size = new System.Drawing.Size(564, 28);
            this.reg_label.TabIndex = 13;
            this.reg_label.Text = "Внимaние! мы не берем себе отвественности ваши!";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Sitka Small", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(163, 40);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(349, 28);
            this.bunifuCustomLabel1.TabIndex = 14;
            this.bunifuCustomLabel1.Text = "Будьте готовы на всех случаях!";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(34)))), ((int)(((byte)(41)))));
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.reg_label);
            this.Controls.Add(this.call_regPanel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.forget_pass);
            this.Controls.Add(this.login_btn);
            this.Controls.Add(this.password_input);
            this.Controls.Add(this.login_input);
            this.Name = "Login";
            this.Size = new System.Drawing.Size(669, 395);
            this.Load += new System.EventHandler(this.Login_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Login_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Login_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Login_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel forget_pass;
        private Bunifu.Framework.UI.BunifuFlatButton login_btn;
        private Bunifu.Framework.UI.BunifuMaterialTextbox password_input;
        private Bunifu.Framework.UI.BunifuMaterialTextbox login_input;
        public Bunifu.Framework.UI.BunifuFlatButton call_regPanel;
        private Bunifu.Framework.UI.BunifuCustomLabel reg_label;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
    }
}

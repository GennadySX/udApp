namespace WindowsFormsApp2
{
    partial class Dashboardxs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboardxs));
            this.fullScreen_btn = new System.Windows.Forms.Button();
            this.minimze_btn = new System.Windows.Forms.Button();
            this.close_btn = new System.Windows.Forms.Button();
            this.topPanel = new System.Windows.Forms.Panel();
            this.profile_btn = new Bunifu.Framework.UI.BunifuImageButton();
            this.about_btn = new Bunifu.Framework.UI.BunifuImageButton();
            this.masters_btn = new Bunifu.Framework.UI.BunifuImageButton();
            this.materials_btn = new Bunifu.Framework.UI.BunifuImageButton();
            this.new_student_btn = new Bunifu.Framework.UI.BunifuImageButton();
            this.leftPanel = new System.Windows.Forms.Panel();
            this.bunifuFlatButton2 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.user_img = new System.Windows.Forms.PictureBox();
            this.support_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.room_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pupil_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.group_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.theme_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.master_class_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.home_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.contentPanel = new System.Windows.Forms.Panel();
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profile_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.about_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.masters_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materials_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.new_student_btn)).BeginInit();
            this.leftPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.user_img)).BeginInit();
            this.SuspendLayout();
            // 
            // fullScreen_btn
            // 
            this.fullScreen_btn.BackColor = System.Drawing.Color.SeaGreen;
            this.fullScreen_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fullScreen_btn.ForeColor = System.Drawing.Color.SeaGreen;
            this.fullScreen_btn.Location = new System.Drawing.Point(807, 4);
            this.fullScreen_btn.Name = "fullScreen_btn";
            this.fullScreen_btn.Size = new System.Drawing.Size(73, 17);
            this.fullScreen_btn.TabIndex = 11;
            this.fullScreen_btn.UseVisualStyleBackColor = false;
            this.fullScreen_btn.Click += new System.EventHandler(this.fullScreen_btn_Click);
            // 
            // minimze_btn
            // 
            this.minimze_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(223)))), ((int)(((byte)(102)))));
            this.minimze_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimze_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(223)))), ((int)(((byte)(102)))));
            this.minimze_btn.Location = new System.Drawing.Point(876, 4);
            this.minimze_btn.Name = "minimze_btn";
            this.minimze_btn.Size = new System.Drawing.Size(73, 17);
            this.minimze_btn.TabIndex = 10;
            this.minimze_btn.UseVisualStyleBackColor = false;
            // 
            // close_btn
            // 
            this.close_btn.BackColor = System.Drawing.Color.Red;
            this.close_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close_btn.ForeColor = System.Drawing.Color.Red;
            this.close_btn.Location = new System.Drawing.Point(949, 4);
            this.close_btn.Name = "close_btn";
            this.close_btn.Size = new System.Drawing.Size(73, 17);
            this.close_btn.TabIndex = 9;
            this.close_btn.UseVisualStyleBackColor = false;
            this.close_btn.Click += new System.EventHandler(this.close_btn_Click);
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(18)))), ((int)(((byte)(19)))));
            this.topPanel.Controls.Add(this.profile_btn);
            this.topPanel.Controls.Add(this.about_btn);
            this.topPanel.Controls.Add(this.masters_btn);
            this.topPanel.Controls.Add(this.materials_btn);
            this.topPanel.Controls.Add(this.new_student_btn);
            this.topPanel.Controls.Add(this.fullScreen_btn);
            this.topPanel.Controls.Add(this.minimze_btn);
            this.topPanel.Controls.Add(this.close_btn);
            this.topPanel.Location = new System.Drawing.Point(222, 4);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(1013, 64);
            this.topPanel.TabIndex = 12;
            this.topPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.topPanel_MouseDown);
            this.topPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.topPanel_MouseMove);
            this.topPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.topPanel_MouseUp);
            // 
            // profile_btn
            // 
            this.profile_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(239)))), ((int)(((byte)(234)))));
            this.profile_btn.Image = ((System.Drawing.Image)(resources.GetObject("profile_btn.Image")));
            this.profile_btn.ImageActive = null;
            this.profile_btn.Location = new System.Drawing.Point(625, 12);
            this.profile_btn.Name = "profile_btn";
            this.profile_btn.Size = new System.Drawing.Size(63, 43);
            this.profile_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.profile_btn.TabIndex = 15;
            this.profile_btn.TabStop = false;
            this.profile_btn.Zoom = 10;
            this.profile_btn.Click += new System.EventHandler(this.profile_btn_Click);
            // 
            // about_btn
            // 
            this.about_btn.Image = ((System.Drawing.Image)(resources.GetObject("about_btn.Image")));
            this.about_btn.ImageActive = null;
            this.about_btn.Location = new System.Drawing.Point(694, 12);
            this.about_btn.Name = "about_btn";
            this.about_btn.Size = new System.Drawing.Size(66, 43);
            this.about_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.about_btn.TabIndex = 14;
            this.about_btn.TabStop = false;
            this.about_btn.Zoom = 10;
            this.about_btn.Click += new System.EventHandler(this.about_btn_Click);
            // 
            // masters_btn
            // 
            this.masters_btn.BackColor = System.Drawing.Color.Transparent;
            this.masters_btn.Image = ((System.Drawing.Image)(resources.GetObject("masters_btn.Image")));
            this.masters_btn.ImageActive = null;
            this.masters_btn.Location = new System.Drawing.Point(40, 12);
            this.masters_btn.Name = "masters_btn";
            this.masters_btn.Size = new System.Drawing.Size(52, 43);
            this.masters_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.masters_btn.TabIndex = 13;
            this.masters_btn.TabStop = false;
            this.masters_btn.Zoom = 10;
            this.masters_btn.Click += new System.EventHandler(this.masters_btn_Click);
            // 
            // materials_btn
            // 
            this.materials_btn.BackColor = System.Drawing.Color.Transparent;
            this.materials_btn.Image = ((System.Drawing.Image)(resources.GetObject("materials_btn.Image")));
            this.materials_btn.ImageActive = null;
            this.materials_btn.Location = new System.Drawing.Point(108, 12);
            this.materials_btn.Name = "materials_btn";
            this.materials_btn.Size = new System.Drawing.Size(52, 43);
            this.materials_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.materials_btn.TabIndex = 12;
            this.materials_btn.TabStop = false;
            this.materials_btn.Zoom = 10;
            this.materials_btn.Click += new System.EventHandler(this.bunifuImageButton2_Click);
            // 
            // new_student_btn
            // 
            this.new_student_btn.BackColor = System.Drawing.Color.Transparent;
            this.new_student_btn.Image = ((System.Drawing.Image)(resources.GetObject("new_student_btn.Image")));
            this.new_student_btn.ImageActive = null;
            this.new_student_btn.Location = new System.Drawing.Point(175, 12);
            this.new_student_btn.Name = "new_student_btn";
            this.new_student_btn.Size = new System.Drawing.Size(52, 43);
            this.new_student_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.new_student_btn.TabIndex = 0;
            this.new_student_btn.TabStop = false;
            this.new_student_btn.Zoom = 10;
            this.new_student_btn.Click += new System.EventHandler(this.new_student_btn_Click);
            // 
            // leftPanel
            // 
            this.leftPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.leftPanel.Controls.Add(this.bunifuFlatButton2);
            this.leftPanel.Controls.Add(this.bunifuFlatButton1);
            this.leftPanel.Controls.Add(this.user_img);
            this.leftPanel.Controls.Add(this.support_btn);
            this.leftPanel.Controls.Add(this.room_btn);
            this.leftPanel.Controls.Add(this.pupil_btn);
            this.leftPanel.Controls.Add(this.group_btn);
            this.leftPanel.Controls.Add(this.theme_btn);
            this.leftPanel.Controls.Add(this.master_class_btn);
            this.leftPanel.Controls.Add(this.home_btn);
            this.leftPanel.Location = new System.Drawing.Point(5, 4);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(219, 630);
            this.leftPanel.TabIndex = 13;
            this.leftPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // bunifuFlatButton2
            // 
            this.bunifuFlatButton2.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.bunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton2.BorderRadius = 0;
            this.bunifuFlatButton2.ButtonText = "Оценки";
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
            this.bunifuFlatButton2.Location = new System.Drawing.Point(1, 478);
            this.bunifuFlatButton2.Name = "bunifuFlatButton2";
            this.bunifuFlatButton2.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.bunifuFlatButton2.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton2.selected = false;
            this.bunifuFlatButton2.Size = new System.Drawing.Size(219, 48);
            this.bunifuFlatButton2.TabIndex = 25;
            this.bunifuFlatButton2.Text = "Оценки";
            this.bunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton2.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton2.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton2.Click += new System.EventHandler(this.bunifuFlatButton2_Click);
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "Группы Препода";
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
            this.bunifuFlatButton1.Location = new System.Drawing.Point(0, 429);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(219, 48);
            this.bunifuFlatButton1.TabIndex = 24;
            this.bunifuFlatButton1.Text = "Группы Препода";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // user_img
            // 
            this.user_img.Image = ((System.Drawing.Image)(resources.GetObject("user_img.Image")));
            this.user_img.Location = new System.Drawing.Point(3, 1);
            this.user_img.Name = "user_img";
            this.user_img.Size = new System.Drawing.Size(216, 129);
            this.user_img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.user_img.TabIndex = 23;
            this.user_img.TabStop = false;
            // 
            // support_btn
            // 
            this.support_btn.Activecolor = System.Drawing.Color.Maroon;
            this.support_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.support_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.support_btn.BorderRadius = 0;
            this.support_btn.ButtonText = "Обращение к помочь";
            this.support_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.support_btn.DisabledColor = System.Drawing.Color.Gray;
            this.support_btn.Iconcolor = System.Drawing.Color.Transparent;
            this.support_btn.Iconimage = ((System.Drawing.Image)(resources.GetObject("support_btn.Iconimage")));
            this.support_btn.Iconimage_right = null;
            this.support_btn.Iconimage_right_Selected = null;
            this.support_btn.Iconimage_Selected = null;
            this.support_btn.IconMarginLeft = 0;
            this.support_btn.IconMarginRight = 0;
            this.support_btn.IconRightVisible = true;
            this.support_btn.IconRightZoom = 0D;
            this.support_btn.IconVisible = true;
            this.support_btn.IconZoom = 90D;
            this.support_btn.IsTab = false;
            this.support_btn.Location = new System.Drawing.Point(-4, 582);
            this.support_btn.Name = "support_btn";
            this.support_btn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.support_btn.OnHovercolor = System.Drawing.Color.Red;
            this.support_btn.OnHoverTextColor = System.Drawing.Color.White;
            this.support_btn.selected = false;
            this.support_btn.Size = new System.Drawing.Size(223, 48);
            this.support_btn.TabIndex = 22;
            this.support_btn.Text = "Обращение к помочь";
            this.support_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.support_btn.Textcolor = System.Drawing.Color.White;
            this.support_btn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.support_btn.Click += new System.EventHandler(this.support_btn_Click);
            // 
            // room_btn
            // 
            this.room_btn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.room_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.room_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.room_btn.BorderRadius = 0;
            this.room_btn.ButtonText = "Помещение";
            this.room_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.room_btn.DisabledColor = System.Drawing.Color.Gray;
            this.room_btn.Iconcolor = System.Drawing.Color.Transparent;
            this.room_btn.Iconimage = null;
            this.room_btn.Iconimage_right = null;
            this.room_btn.Iconimage_right_Selected = null;
            this.room_btn.Iconimage_Selected = null;
            this.room_btn.IconMarginLeft = 0;
            this.room_btn.IconMarginRight = 0;
            this.room_btn.IconRightVisible = true;
            this.room_btn.IconRightZoom = 0D;
            this.room_btn.IconVisible = true;
            this.room_btn.IconZoom = 90D;
            this.room_btn.IsTab = false;
            this.room_btn.Location = new System.Drawing.Point(0, 380);
            this.room_btn.Name = "room_btn";
            this.room_btn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.room_btn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.room_btn.OnHoverTextColor = System.Drawing.Color.White;
            this.room_btn.selected = false;
            this.room_btn.Size = new System.Drawing.Size(216, 48);
            this.room_btn.TabIndex = 21;
            this.room_btn.Text = "Помещение";
            this.room_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.room_btn.Textcolor = System.Drawing.Color.White;
            this.room_btn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.room_btn.Click += new System.EventHandler(this.room_btn_Click);
            // 
            // pupil_btn
            // 
            this.pupil_btn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.pupil_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.pupil_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pupil_btn.BorderRadius = 0;
            this.pupil_btn.ButtonText = "Ученики";
            this.pupil_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pupil_btn.DisabledColor = System.Drawing.Color.Gray;
            this.pupil_btn.Iconcolor = System.Drawing.Color.Transparent;
            this.pupil_btn.Iconimage = null;
            this.pupil_btn.Iconimage_right = null;
            this.pupil_btn.Iconimage_right_Selected = null;
            this.pupil_btn.Iconimage_Selected = null;
            this.pupil_btn.IconMarginLeft = 0;
            this.pupil_btn.IconMarginRight = 0;
            this.pupil_btn.IconRightVisible = true;
            this.pupil_btn.IconRightZoom = 0D;
            this.pupil_btn.IconVisible = true;
            this.pupil_btn.IconZoom = 90D;
            this.pupil_btn.IsTab = false;
            this.pupil_btn.Location = new System.Drawing.Point(0, 330);
            this.pupil_btn.Name = "pupil_btn";
            this.pupil_btn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.pupil_btn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.pupil_btn.OnHoverTextColor = System.Drawing.Color.White;
            this.pupil_btn.selected = false;
            this.pupil_btn.Size = new System.Drawing.Size(219, 48);
            this.pupil_btn.TabIndex = 19;
            this.pupil_btn.Text = "Ученики";
            this.pupil_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.pupil_btn.Textcolor = System.Drawing.Color.White;
            this.pupil_btn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pupil_btn.Click += new System.EventHandler(this.pupil_btn_Click);
            // 
            // group_btn
            // 
            this.group_btn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.group_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.group_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.group_btn.BorderRadius = 0;
            this.group_btn.ButtonText = "Группы";
            this.group_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.group_btn.DisabledColor = System.Drawing.Color.Gray;
            this.group_btn.Iconcolor = System.Drawing.Color.Transparent;
            this.group_btn.Iconimage = null;
            this.group_btn.Iconimage_right = null;
            this.group_btn.Iconimage_right_Selected = null;
            this.group_btn.Iconimage_Selected = null;
            this.group_btn.IconMarginLeft = 0;
            this.group_btn.IconMarginRight = 0;
            this.group_btn.IconRightVisible = true;
            this.group_btn.IconRightZoom = 0D;
            this.group_btn.IconVisible = true;
            this.group_btn.IconZoom = 90D;
            this.group_btn.IsTab = false;
            this.group_btn.Location = new System.Drawing.Point(0, 281);
            this.group_btn.Name = "group_btn";
            this.group_btn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.group_btn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.group_btn.OnHoverTextColor = System.Drawing.Color.White;
            this.group_btn.selected = false;
            this.group_btn.Size = new System.Drawing.Size(219, 48);
            this.group_btn.TabIndex = 18;
            this.group_btn.Text = "Группы";
            this.group_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.group_btn.Textcolor = System.Drawing.Color.White;
            this.group_btn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.group_btn.Click += new System.EventHandler(this.group_btn_Click);
            // 
            // theme_btn
            // 
            this.theme_btn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.theme_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.theme_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.theme_btn.BorderRadius = 0;
            this.theme_btn.ButtonText = "Тематика";
            this.theme_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.theme_btn.DisabledColor = System.Drawing.Color.Gray;
            this.theme_btn.Iconcolor = System.Drawing.Color.Transparent;
            this.theme_btn.Iconimage = null;
            this.theme_btn.Iconimage_right = null;
            this.theme_btn.Iconimage_right_Selected = null;
            this.theme_btn.Iconimage_Selected = null;
            this.theme_btn.IconMarginLeft = 0;
            this.theme_btn.IconMarginRight = 0;
            this.theme_btn.IconRightVisible = true;
            this.theme_btn.IconRightZoom = 0D;
            this.theme_btn.IconVisible = true;
            this.theme_btn.IconZoom = 90D;
            this.theme_btn.IsTab = false;
            this.theme_btn.Location = new System.Drawing.Point(0, 232);
            this.theme_btn.Name = "theme_btn";
            this.theme_btn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.theme_btn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.theme_btn.OnHoverTextColor = System.Drawing.Color.White;
            this.theme_btn.selected = false;
            this.theme_btn.Size = new System.Drawing.Size(219, 48);
            this.theme_btn.TabIndex = 17;
            this.theme_btn.Text = "Тематика";
            this.theme_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.theme_btn.Textcolor = System.Drawing.Color.White;
            this.theme_btn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.theme_btn.Click += new System.EventHandler(this.theme_btn_Click);
            // 
            // master_class_btn
            // 
            this.master_class_btn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.master_class_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.master_class_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.master_class_btn.BorderRadius = 0;
            this.master_class_btn.ButtonText = "Мастер классы";
            this.master_class_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.master_class_btn.DisabledColor = System.Drawing.Color.Gray;
            this.master_class_btn.Iconcolor = System.Drawing.Color.Transparent;
            this.master_class_btn.Iconimage = null;
            this.master_class_btn.Iconimage_right = null;
            this.master_class_btn.Iconimage_right_Selected = null;
            this.master_class_btn.Iconimage_Selected = null;
            this.master_class_btn.IconMarginLeft = 0;
            this.master_class_btn.IconMarginRight = 0;
            this.master_class_btn.IconRightVisible = true;
            this.master_class_btn.IconRightZoom = 0D;
            this.master_class_btn.IconVisible = true;
            this.master_class_btn.IconZoom = 90D;
            this.master_class_btn.IsTab = false;
            this.master_class_btn.Location = new System.Drawing.Point(0, 183);
            this.master_class_btn.Name = "master_class_btn";
            this.master_class_btn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.master_class_btn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.master_class_btn.OnHoverTextColor = System.Drawing.Color.White;
            this.master_class_btn.selected = false;
            this.master_class_btn.Size = new System.Drawing.Size(219, 48);
            this.master_class_btn.TabIndex = 16;
            this.master_class_btn.Text = "Мастер классы";
            this.master_class_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.master_class_btn.Textcolor = System.Drawing.Color.White;
            this.master_class_btn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.master_class_btn.Click += new System.EventHandler(this.master_class_btn_Click);
            // 
            // home_btn
            // 
            this.home_btn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.home_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.home_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.home_btn.BorderRadius = 0;
            this.home_btn.ButtonText = "Главный";
            this.home_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.home_btn.DisabledColor = System.Drawing.Color.Gray;
            this.home_btn.Iconcolor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(86)))), ((int)(((byte)(85)))));
            this.home_btn.Iconimage = null;
            this.home_btn.Iconimage_right = null;
            this.home_btn.Iconimage_right_Selected = null;
            this.home_btn.Iconimage_Selected = null;
            this.home_btn.IconMarginLeft = 0;
            this.home_btn.IconMarginRight = 0;
            this.home_btn.IconRightVisible = true;
            this.home_btn.IconRightZoom = 0D;
            this.home_btn.IconVisible = true;
            this.home_btn.IconZoom = 90D;
            this.home_btn.IsTab = false;
            this.home_btn.Location = new System.Drawing.Point(0, 135);
            this.home_btn.Name = "home_btn";
            this.home_btn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.home_btn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.home_btn.OnHoverTextColor = System.Drawing.Color.White;
            this.home_btn.selected = false;
            this.home_btn.Size = new System.Drawing.Size(219, 48);
            this.home_btn.TabIndex = 14;
            this.home_btn.Text = "Главный";
            this.home_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.home_btn.Textcolor = System.Drawing.Color.White;
            this.home_btn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.home_btn.Click += new System.EventHandler(this.home_btn_Click);
            // 
            // contentPanel
            // 
            this.contentPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(35)))));
            this.contentPanel.Location = new System.Drawing.Point(225, 65);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(1010, 566);
            this.contentPanel.TabIndex = 14;
            this.contentPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.contentPanel_Paint);
            // 
            // Dashboardxs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(1238, 633);
            this.Controls.Add(this.contentPanel);
            this.Controls.Add(this.leftPanel);
            this.Controls.Add(this.topPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboardxs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.topPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.profile_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.about_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.masters_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materials_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.new_student_btn)).EndInit();
            this.leftPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.user_img)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button fullScreen_btn;
        private System.Windows.Forms.Button minimze_btn;
        private System.Windows.Forms.Button close_btn;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Panel leftPanel;
        private Bunifu.Framework.UI.BunifuFlatButton room_btn;
        private Bunifu.Framework.UI.BunifuFlatButton pupil_btn;
        private Bunifu.Framework.UI.BunifuFlatButton group_btn;
        private Bunifu.Framework.UI.BunifuFlatButton theme_btn;
        private Bunifu.Framework.UI.BunifuFlatButton master_class_btn;
        private Bunifu.Framework.UI.BunifuFlatButton home_btn;
        private Bunifu.Framework.UI.BunifuFlatButton support_btn;
        private System.Windows.Forms.Panel contentPanel;
        private Bunifu.Framework.UI.BunifuImageButton masters_btn;
        private Bunifu.Framework.UI.BunifuImageButton materials_btn;
        private Bunifu.Framework.UI.BunifuImageButton new_student_btn;
        private Bunifu.Framework.UI.BunifuImageButton profile_btn;
        private Bunifu.Framework.UI.BunifuImageButton about_btn;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton2;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        public System.Windows.Forms.PictureBox user_img;
    }
}
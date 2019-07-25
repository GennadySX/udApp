namespace WindowsFormsApp2
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.close_btn = new System.Windows.Forms.Button();
            this.minimze_btn = new System.Windows.Forms.Button();
            this.fullScreen_btn = new System.Windows.Forms.Button();
            this.logMain_panel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // close_btn
            // 
            this.close_btn.BackColor = System.Drawing.Color.Red;
            this.close_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close_btn.ForeColor = System.Drawing.Color.Red;
            this.close_btn.Location = new System.Drawing.Point(594, 0);
            this.close_btn.Name = "close_btn";
            this.close_btn.Size = new System.Drawing.Size(73, 17);
            this.close_btn.TabIndex = 2;
            this.close_btn.UseVisualStyleBackColor = false;
            this.close_btn.Click += new System.EventHandler(this.close_btn_Click);
            // 
            // minimze_btn
            // 
            this.minimze_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(223)))), ((int)(((byte)(102)))));
            this.minimze_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimze_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(223)))), ((int)(((byte)(102)))));
            this.minimze_btn.Location = new System.Drawing.Point(521, 0);
            this.minimze_btn.Name = "minimze_btn";
            this.minimze_btn.Size = new System.Drawing.Size(73, 17);
            this.minimze_btn.TabIndex = 7;
            this.minimze_btn.UseVisualStyleBackColor = false;
            this.minimze_btn.Click += new System.EventHandler(this.minimze_btn_Click);
            // 
            // fullScreen_btn
            // 
            this.fullScreen_btn.BackColor = System.Drawing.Color.SeaGreen;
            this.fullScreen_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fullScreen_btn.ForeColor = System.Drawing.Color.SeaGreen;
            this.fullScreen_btn.Location = new System.Drawing.Point(452, 0);
            this.fullScreen_btn.Name = "fullScreen_btn";
            this.fullScreen_btn.Size = new System.Drawing.Size(73, 17);
            this.fullScreen_btn.TabIndex = 8;
            this.fullScreen_btn.UseVisualStyleBackColor = false;
            this.fullScreen_btn.Click += new System.EventHandler(this.fullScreen_btn_Click);
            // 
            // logMain_panel
            // 
            this.logMain_panel.AllowDrop = true;
            this.logMain_panel.Location = new System.Drawing.Point(-2, 20);
            this.logMain_panel.Name = "logMain_panel";
            this.logMain_panel.Size = new System.Drawing.Size(669, 395);
            this.logMain_panel.TabIndex = 9;
            this.logMain_panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.logMain_panel_MouseDown);
            this.logMain_panel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.logMain_panel_MouseMove);
            this.logMain_panel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.logMain_panel_MouseUp);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(34)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(668, 418);
            this.Controls.Add(this.logMain_panel);
            this.Controls.Add(this.fullScreen_btn);
            this.Controls.Add(this.minimze_btn);
            this.Controls.Add(this.close_btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UD";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseUp);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button close_btn;
        private System.Windows.Forms.Button minimze_btn;
        private System.Windows.Forms.Button fullScreen_btn;
        public System.Windows.Forms.Panel logMain_panel;
    }
}


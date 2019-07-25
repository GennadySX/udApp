namespace WindowsFormsApp2.Dashboard
{
    partial class warningForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.no_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.yes_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.topPanel = new System.Windows.Forms.Panel();
            this.fullScreen_btn = new System.Windows.Forms.Button();
            this.minimze_btn = new System.Windows.Forms.Button();
            this.close_btn = new System.Windows.Forms.Button();
            this.topPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label2.Location = new System.Drawing.Point(53, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(382, 37);
            this.label2.TabIndex = 22;
            this.label2.Text = "Вы уверены что делаете?";
            // 
            // no_btn
            // 
            this.no_btn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.no_btn.BackColor = System.Drawing.Color.Red;
            this.no_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.no_btn.BorderRadius = 0;
            this.no_btn.ButtonText = "Нет";
            this.no_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.no_btn.DisabledColor = System.Drawing.Color.Gray;
            this.no_btn.Iconcolor = System.Drawing.Color.Transparent;
            this.no_btn.Iconimage = null;
            this.no_btn.Iconimage_right = null;
            this.no_btn.Iconimage_right_Selected = null;
            this.no_btn.Iconimage_Selected = null;
            this.no_btn.IconMarginLeft = 0;
            this.no_btn.IconMarginRight = 0;
            this.no_btn.IconRightVisible = true;
            this.no_btn.IconRightZoom = 0D;
            this.no_btn.IconVisible = true;
            this.no_btn.IconZoom = 90D;
            this.no_btn.IsTab = false;
            this.no_btn.Location = new System.Drawing.Point(304, 235);
            this.no_btn.Name = "no_btn";
            this.no_btn.Normalcolor = System.Drawing.Color.Red;
            this.no_btn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.no_btn.OnHoverTextColor = System.Drawing.Color.White;
            this.no_btn.selected = false;
            this.no_btn.Size = new System.Drawing.Size(97, 48);
            this.no_btn.TabIndex = 21;
            this.no_btn.Text = "Нет";
            this.no_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.no_btn.Textcolor = System.Drawing.Color.White;
            this.no_btn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.no_btn.Click += new System.EventHandler(this.no_btn_Click);
            // 
            // yes_btn
            // 
            this.yes_btn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.yes_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.yes_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.yes_btn.BorderRadius = 0;
            this.yes_btn.ButtonText = "Да";
            this.yes_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.yes_btn.DisabledColor = System.Drawing.Color.Gray;
            this.yes_btn.Iconcolor = System.Drawing.Color.Transparent;
            this.yes_btn.Iconimage = null;
            this.yes_btn.Iconimage_right = null;
            this.yes_btn.Iconimage_right_Selected = null;
            this.yes_btn.Iconimage_Selected = null;
            this.yes_btn.IconMarginLeft = 0;
            this.yes_btn.IconMarginRight = 0;
            this.yes_btn.IconRightVisible = true;
            this.yes_btn.IconRightZoom = 0D;
            this.yes_btn.IconVisible = true;
            this.yes_btn.IconZoom = 90D;
            this.yes_btn.IsTab = false;
            this.yes_btn.Location = new System.Drawing.Point(88, 235);
            this.yes_btn.Name = "yes_btn";
            this.yes_btn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.yes_btn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.yes_btn.OnHoverTextColor = System.Drawing.Color.White;
            this.yes_btn.selected = false;
            this.yes_btn.Size = new System.Drawing.Size(97, 48);
            this.yes_btn.TabIndex = 20;
            this.yes_btn.Text = "Да";
            this.yes_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.yes_btn.Textcolor = System.Drawing.Color.White;
            this.yes_btn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yes_btn.Click += new System.EventHandler(this.yes_btn_Click);
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(18)))), ((int)(((byte)(19)))));
            this.topPanel.Controls.Add(this.fullScreen_btn);
            this.topPanel.Controls.Add(this.minimze_btn);
            this.topPanel.Controls.Add(this.close_btn);
            this.topPanel.Location = new System.Drawing.Point(-1, -1);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(497, 34);
            this.topPanel.TabIndex = 23;
            // 
            // fullScreen_btn
            // 
            this.fullScreen_btn.BackColor = System.Drawing.Color.SeaGreen;
            this.fullScreen_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fullScreen_btn.ForeColor = System.Drawing.Color.SeaGreen;
            this.fullScreen_btn.Location = new System.Drawing.Point(280, 2);
            this.fullScreen_btn.Name = "fullScreen_btn";
            this.fullScreen_btn.Size = new System.Drawing.Size(73, 17);
            this.fullScreen_btn.TabIndex = 11;
            this.fullScreen_btn.UseVisualStyleBackColor = false;
            // 
            // minimze_btn
            // 
            this.minimze_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(223)))), ((int)(((byte)(102)))));
            this.minimze_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimze_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(223)))), ((int)(((byte)(102)))));
            this.minimze_btn.Location = new System.Drawing.Point(349, 2);
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
            this.close_btn.Location = new System.Drawing.Point(422, 2);
            this.close_btn.Name = "close_btn";
            this.close_btn.Size = new System.Drawing.Size(73, 17);
            this.close_btn.TabIndex = 9;
            this.close_btn.UseVisualStyleBackColor = false;
            // 
            // warningForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(495, 311);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.no_btn);
            this.Controls.Add(this.yes_btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "warningForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "warningForm";
            this.Load += new System.EventHandler(this.warningForm_Load);
            this.topPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuFlatButton no_btn;
        private Bunifu.Framework.UI.BunifuFlatButton yes_btn;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Button fullScreen_btn;
        private System.Windows.Forms.Button minimze_btn;
        private System.Windows.Forms.Button close_btn;
    }
}
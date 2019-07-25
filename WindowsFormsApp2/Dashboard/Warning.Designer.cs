namespace WindowsFormsApp2.Dashboard
{
    partial class Warning
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
            this.topPanel = new System.Windows.Forms.Panel();
            this.yes_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.no_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(18)))), ((int)(((byte)(19)))));
            this.topPanel.Location = new System.Drawing.Point(0, -1);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(454, 30);
            this.topPanel.TabIndex = 14;
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
            this.yes_btn.Location = new System.Drawing.Point(68, 206);
            this.yes_btn.Name = "yes_btn";
            this.yes_btn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.yes_btn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.yes_btn.OnHoverTextColor = System.Drawing.Color.White;
            this.yes_btn.selected = false;
            this.yes_btn.Size = new System.Drawing.Size(97, 48);
            this.yes_btn.TabIndex = 16;
            this.yes_btn.Text = "Да";
            this.yes_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.yes_btn.Textcolor = System.Drawing.Color.White;
            this.yes_btn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yes_btn.Click += new System.EventHandler(this.yes_btn_Click);
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
            this.no_btn.Location = new System.Drawing.Point(284, 206);
            this.no_btn.Name = "no_btn";
            this.no_btn.Normalcolor = System.Drawing.Color.Red;
            this.no_btn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.no_btn.OnHoverTextColor = System.Drawing.Color.White;
            this.no_btn.selected = false;
            this.no_btn.Size = new System.Drawing.Size(97, 48);
            this.no_btn.TabIndex = 17;
            this.no_btn.Text = "Нет";
            this.no_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.no_btn.Textcolor = System.Drawing.Color.White;
            this.no_btn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.no_btn.Click += new System.EventHandler(this.no_btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label2.Location = new System.Drawing.Point(33, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(382, 37);
            this.label2.TabIndex = 18;
            this.label2.Text = "Вы уверены что делаете?";
            // 
            // Warning
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(35)))));
            this.Controls.Add(this.label2);
            this.Controls.Add(this.no_btn);
            this.Controls.Add(this.yes_btn);
            this.Controls.Add(this.topPanel);
            this.Name = "Warning";
            this.Size = new System.Drawing.Size(452, 276);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel topPanel;
        private Bunifu.Framework.UI.BunifuFlatButton yes_btn;
        private Bunifu.Framework.UI.BunifuFlatButton no_btn;
        private System.Windows.Forms.Label label2;
    }
}

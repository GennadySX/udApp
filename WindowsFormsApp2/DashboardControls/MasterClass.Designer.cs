namespace WindowsFormsApp2
{
    partial class MasterClass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MasterClass));
            this.masterClassBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.udData = new WindowsFormsApp2.udData();
            this.masterClassTableAdapter = new WindowsFormsApp2.udDataTableAdapters.masterClassTableAdapter();
            this.masterClass_grid = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idmasterDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idtematicDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datepassageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idpremisesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.masterClassBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterClass_grid)).BeginInit();
            this.SuspendLayout();
            // 
            // masterClassBindingSource
            // 
            this.masterClassBindingSource.DataMember = "masterClass";
            this.masterClassBindingSource.DataSource = this.udData;
            // 
            // udData
            // 
            this.udData.DataSetName = "udData";
            this.udData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // masterClassTableAdapter
            // 
            this.masterClassTableAdapter.ClearBeforeFill = true;
            // 
            // masterClass_grid
            // 
            this.masterClass_grid.AutoGenerateColumns = false;
            this.masterClass_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.masterClass_grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.idmasterDataGridViewTextBoxColumn,
            this.idtematicDataGridViewTextBoxColumn,
            this.groupsDataGridViewTextBoxColumn,
            this.datepassageDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.idpremisesDataGridViewTextBoxColumn});
            this.masterClass_grid.DataSource = this.masterClassBindingSource;
            this.masterClass_grid.Location = new System.Drawing.Point(0, 3);
            this.masterClass_grid.Name = "masterClass_grid";
            this.masterClass_grid.Size = new System.Drawing.Size(1010, 490);
            this.masterClass_grid.TabIndex = 0;
            this.masterClass_grid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.masterClass_grid_CellContentClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idmasterDataGridViewTextBoxColumn
            // 
            this.idmasterDataGridViewTextBoxColumn.DataPropertyName = "id_master";
            this.idmasterDataGridViewTextBoxColumn.HeaderText = "id_master";
            this.idmasterDataGridViewTextBoxColumn.Name = "idmasterDataGridViewTextBoxColumn";
            // 
            // idtematicDataGridViewTextBoxColumn
            // 
            this.idtematicDataGridViewTextBoxColumn.DataPropertyName = "id_tematic";
            this.idtematicDataGridViewTextBoxColumn.HeaderText = "id_tematic";
            this.idtematicDataGridViewTextBoxColumn.Name = "idtematicDataGridViewTextBoxColumn";
            // 
            // groupsDataGridViewTextBoxColumn
            // 
            this.groupsDataGridViewTextBoxColumn.DataPropertyName = "groups";
            this.groupsDataGridViewTextBoxColumn.HeaderText = "groups";
            this.groupsDataGridViewTextBoxColumn.Name = "groupsDataGridViewTextBoxColumn";
            // 
            // datepassageDataGridViewTextBoxColumn
            // 
            this.datepassageDataGridViewTextBoxColumn.DataPropertyName = "date_passage";
            this.datepassageDataGridViewTextBoxColumn.HeaderText = "date_passage";
            this.datepassageDataGridViewTextBoxColumn.Name = "datepassageDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // idpremisesDataGridViewTextBoxColumn
            // 
            this.idpremisesDataGridViewTextBoxColumn.DataPropertyName = "id_premises";
            this.idpremisesDataGridViewTextBoxColumn.HeaderText = "id_premises";
            this.idpremisesDataGridViewTextBoxColumn.Name = "idpremisesDataGridViewTextBoxColumn";
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "Записаться";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton1.Iconimage")));
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
            this.bunifuFlatButton1.Location = new System.Drawing.Point(45, 512);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(241, 48);
            this.bunifuFlatButton1.TabIndex = 1;
            this.bunifuFlatButton1.Text = "Записаться";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // MasterClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(35)))));
            this.Controls.Add(this.bunifuFlatButton1);
            this.Controls.Add(this.masterClass_grid);
            this.Name = "MasterClass";
            this.Size = new System.Drawing.Size(1010, 566);
            this.Load += new System.EventHandler(this.MasterClass_Load);
            ((System.ComponentModel.ISupportInitialize)(this.masterClassBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterClass_grid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource masterClassBindingSource;
        private udData udData;
        private udDataTableAdapters.masterClassTableAdapter masterClassTableAdapter;
        private System.Windows.Forms.DataGridView masterClass_grid;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idmasterDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idtematicDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn groupsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datepassageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idpremisesDataGridViewTextBoxColumn;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
    }
}

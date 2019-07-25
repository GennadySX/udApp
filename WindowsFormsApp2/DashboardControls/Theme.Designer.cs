namespace WindowsFormsApp2
{
    partial class Theme
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
            this.thematic_grid = new System.Windows.Forms.DataGridView();
            this.baseX = new WindowsFormsApp2.BaseX();
            this.tematicBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tematicTableAdapter = new WindowsFormsApp2.BaseXTableAdapters.tematicTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qualitiesTematicDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.premisesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idmasterDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.thematic_grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.baseX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tematicBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // thematic_grid
            // 
            this.thematic_grid.AutoGenerateColumns = false;
            this.thematic_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.thematic_grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.qualitiesTematicDataGridViewTextBoxColumn,
            this.materialDataGridViewTextBoxColumn,
            this.premisesDataGridViewTextBoxColumn,
            this.idmasterDataGridViewTextBoxColumn});
            this.thematic_grid.DataSource = this.tematicBindingSource;
            this.thematic_grid.Location = new System.Drawing.Point(6, 0);
            this.thematic_grid.Name = "thematic_grid";
            this.thematic_grid.Size = new System.Drawing.Size(1004, 540);
            this.thematic_grid.TabIndex = 1;
            this.thematic_grid.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.thematic_grid_CellEnter);
            this.thematic_grid.CellValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.thematic_grid_CellValidated);
            this.thematic_grid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.thematic_grid_KeyDown);
            // 
            // baseX
            // 
            this.baseX.DataSetName = "BaseX";
            this.baseX.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tematicBindingSource
            // 
            this.tematicBindingSource.DataMember = "tematic";
            this.tematicBindingSource.DataSource = this.baseX;
            // 
            // tematicTableAdapter
            // 
            this.tematicTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "ид";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 50;
            // 
            // qualitiesTematicDataGridViewTextBoxColumn
            // 
            this.qualitiesTematicDataGridViewTextBoxColumn.DataPropertyName = "qualitiesTematic";
            this.qualitiesTematicDataGridViewTextBoxColumn.HeaderText = "О тематике";
            this.qualitiesTematicDataGridViewTextBoxColumn.Name = "qualitiesTematicDataGridViewTextBoxColumn";
            this.qualitiesTematicDataGridViewTextBoxColumn.Width = 350;
            // 
            // materialDataGridViewTextBoxColumn
            // 
            this.materialDataGridViewTextBoxColumn.DataPropertyName = "material";
            this.materialDataGridViewTextBoxColumn.HeaderText = "Материалы";
            this.materialDataGridViewTextBoxColumn.Name = "materialDataGridViewTextBoxColumn";
            this.materialDataGridViewTextBoxColumn.Width = 250;
            // 
            // premisesDataGridViewTextBoxColumn
            // 
            this.premisesDataGridViewTextBoxColumn.DataPropertyName = "premises";
            this.premisesDataGridViewTextBoxColumn.HeaderText = "Помещение";
            this.premisesDataGridViewTextBoxColumn.Name = "premisesDataGridViewTextBoxColumn";
            this.premisesDataGridViewTextBoxColumn.Width = 200;
            // 
            // idmasterDataGridViewTextBoxColumn
            // 
            this.idmasterDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idmasterDataGridViewTextBoxColumn.DataPropertyName = "id_master";
            this.idmasterDataGridViewTextBoxColumn.HeaderText = "ид Мастера";
            this.idmasterDataGridViewTextBoxColumn.Name = "idmasterDataGridViewTextBoxColumn";
            // 
            // Theme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(35)))));
            this.Controls.Add(this.thematic_grid);
            this.Name = "Theme";
            this.Size = new System.Drawing.Size(1010, 566);
            this.Load += new System.EventHandler(this.Theme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.thematic_grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.baseX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tematicBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView thematic_grid;
        private System.Windows.Forms.BindingSource tematicBindingSource;
        private BaseX baseX;
        private BaseXTableAdapters.tematicTableAdapter tematicTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qualitiesTematicDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn materialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn premisesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idmasterDataGridViewTextBoxColumn;
    }
}

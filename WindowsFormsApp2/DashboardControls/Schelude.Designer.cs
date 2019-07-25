namespace WindowsFormsApp2
{
    partial class Schelude
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
            this.schelude_grid = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.placeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contractPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.capacityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.specialityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.premisesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.baseX = new WindowsFormsApp2.BaseX();
            this.premisesTableAdapter = new WindowsFormsApp2.BaseXTableAdapters.premisesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.schelude_grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.premisesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.baseX)).BeginInit();
            this.SuspendLayout();
            // 
            // schelude_grid
            // 
            this.schelude_grid.AutoGenerateColumns = false;
            this.schelude_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.schelude_grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.placeDataGridViewTextBoxColumn,
            this.contractPriceDataGridViewTextBoxColumn,
            this.capacityDataGridViewTextBoxColumn,
            this.specialityDataGridViewTextBoxColumn});
            this.schelude_grid.DataSource = this.premisesBindingSource;
            this.schelude_grid.Location = new System.Drawing.Point(3, 3);
            this.schelude_grid.Name = "schelude_grid";
            this.schelude_grid.Size = new System.Drawing.Size(995, 495);
            this.schelude_grid.TabIndex = 0;
            this.schelude_grid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.schelude_grid_CellContentClick);
            this.schelude_grid.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.schelude_grid_CellEnter);
            this.schelude_grid.CellValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.schelude_grid_CellValidated);
            this.schelude_grid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.schelude_grid_KeyDown);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "ид";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 50;
            // 
            // placeDataGridViewTextBoxColumn
            // 
            this.placeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.placeDataGridViewTextBoxColumn.DataPropertyName = "place";
            this.placeDataGridViewTextBoxColumn.HeaderText = "Место прохождения";
            this.placeDataGridViewTextBoxColumn.Name = "placeDataGridViewTextBoxColumn";
            // 
            // contractPriceDataGridViewTextBoxColumn
            // 
            this.contractPriceDataGridViewTextBoxColumn.DataPropertyName = "contractPrice";
            this.contractPriceDataGridViewTextBoxColumn.HeaderText = "Учебная плата";
            this.contractPriceDataGridViewTextBoxColumn.Name = "contractPriceDataGridViewTextBoxColumn";
            this.contractPriceDataGridViewTextBoxColumn.Width = 150;
            // 
            // capacityDataGridViewTextBoxColumn
            // 
            this.capacityDataGridViewTextBoxColumn.DataPropertyName = "capacity";
            this.capacityDataGridViewTextBoxColumn.HeaderText = "Вместимость";
            this.capacityDataGridViewTextBoxColumn.Name = "capacityDataGridViewTextBoxColumn";
            // 
            // specialityDataGridViewTextBoxColumn
            // 
            this.specialityDataGridViewTextBoxColumn.DataPropertyName = "speciality";
            this.specialityDataGridViewTextBoxColumn.HeaderText = "Специальзация";
            this.specialityDataGridViewTextBoxColumn.Name = "specialityDataGridViewTextBoxColumn";
            this.specialityDataGridViewTextBoxColumn.Width = 250;
            // 
            // premisesBindingSource
            // 
            this.premisesBindingSource.DataMember = "premises";
            this.premisesBindingSource.DataSource = this.baseX;
            // 
            // baseX
            // 
            this.baseX.DataSetName = "BaseX";
            this.baseX.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // premisesTableAdapter
            // 
            this.premisesTableAdapter.ClearBeforeFill = true;
            // 
            // Schelude
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(35)))));
            this.Controls.Add(this.schelude_grid);
            this.Name = "Schelude";
            this.Size = new System.Drawing.Size(998, 557);
            this.Load += new System.EventHandler(this.Schelude_Load);
            ((System.ComponentModel.ISupportInitialize)(this.schelude_grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.premisesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.baseX)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView schelude_grid;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn placeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contractPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn capacityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn specialityDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource premisesBindingSource;
        private BaseX baseX;
        private BaseXTableAdapters.premisesTableAdapter premisesTableAdapter;
    }
}

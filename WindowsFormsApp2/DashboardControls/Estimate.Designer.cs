
namespace WindowsFormsApp2
{
    partial class Estimate
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
            this.estimate_grid = new System.Windows.Forms.DataGridView();
            this.baseX = new WindowsFormsApp2.BaseX();
            this.estimateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.estimateTableAdapter = new WindowsFormsApp2.BaseXTableAdapters.estimateTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idmasterClassDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idstudentsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estimateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.estimate_grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.baseX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estimateBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // estimate_grid
            // 
            this.estimate_grid.AutoGenerateColumns = false;
            this.estimate_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.estimate_grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.idmasterClassDataGridViewTextBoxColumn,
            this.idstudentsDataGridViewTextBoxColumn,
            this.estimateDataGridViewTextBoxColumn});
            this.estimate_grid.DataSource = this.estimateBindingSource;
            this.estimate_grid.Location = new System.Drawing.Point(0, 3);
            this.estimate_grid.Name = "estimate_grid";
            this.estimate_grid.Size = new System.Drawing.Size(1010, 523);
            this.estimate_grid.TabIndex = 0;
            this.estimate_grid.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.estimate_grid_CellEnter);
            this.estimate_grid.CellValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.estimate_grid_CellValidated);
            this.estimate_grid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.estimate_grid_KeyDown);
            // 
            // baseX
            // 
            this.baseX.DataSetName = "BaseX";
            this.baseX.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // estimateBindingSource
            // 
            this.estimateBindingSource.DataMember = "estimate";
            this.estimateBindingSource.DataSource = this.baseX;
            // 
            // estimateTableAdapter
            // 
            this.estimateTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "ид";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idmasterClassDataGridViewTextBoxColumn
            // 
            this.idmasterClassDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idmasterClassDataGridViewTextBoxColumn.DataPropertyName = "id_masterClass";
            this.idmasterClassDataGridViewTextBoxColumn.HeaderText = "ид Мастер Класса";
            this.idmasterClassDataGridViewTextBoxColumn.Name = "idmasterClassDataGridViewTextBoxColumn";
            // 
            // idstudentsDataGridViewTextBoxColumn
            // 
            this.idstudentsDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idstudentsDataGridViewTextBoxColumn.DataPropertyName = "id_students";
            this.idstudentsDataGridViewTextBoxColumn.HeaderText = "ид Студента";
            this.idstudentsDataGridViewTextBoxColumn.Name = "idstudentsDataGridViewTextBoxColumn";
            // 
            // estimateDataGridViewTextBoxColumn
            // 
            this.estimateDataGridViewTextBoxColumn.DataPropertyName = "estimate";
            this.estimateDataGridViewTextBoxColumn.HeaderText = "Оценка";
            this.estimateDataGridViewTextBoxColumn.Name = "estimateDataGridViewTextBoxColumn";
            // 
            // Estimate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(35)))));
            this.Controls.Add(this.estimate_grid);
            this.Name = "Estimate";
            this.Size = new System.Drawing.Size(1010, 566);
            ((System.ComponentModel.ISupportInitialize)(this.estimate_grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.baseX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estimateBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView estimate_grid;
        private System.Windows.Forms.BindingSource estimateBindingSource;
        private BaseX baseX;
        private BaseXTableAdapters.estimateTableAdapter estimateTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idmasterClassDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idstudentsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estimateDataGridViewTextBoxColumn;
    }
}

namespace WindowsFormsApp2
{
    partial class StudentsX
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
            this.studentx_grid = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.middlenameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.masterDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupsidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.role = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.baseX = new WindowsFormsApp2.BaseX();
            this.studentsTableAdapter = new WindowsFormsApp2.BaseXTableAdapters.studentsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.studentx_grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.baseX)).BeginInit();
            this.SuspendLayout();
            // 
            // studentx_grid
            // 
            this.studentx_grid.AutoGenerateColumns = false;
            this.studentx_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentx_grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.surnameDataGridViewTextBoxColumn,
            this.middlenameDataGridViewTextBoxColumn,
            this.masterDataGridViewTextBoxColumn,
            this.groupsidDataGridViewTextBoxColumn,
            this.role});
            this.studentx_grid.DataSource = this.studentsBindingSource;
            this.studentx_grid.Location = new System.Drawing.Point(0, 13);
            this.studentx_grid.Name = "studentx_grid";
            this.studentx_grid.Size = new System.Drawing.Size(1007, 523);
            this.studentx_grid.TabIndex = 1;
            this.studentx_grid.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.studentx_grid_CellEnter);
            this.studentx_grid.CellValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.studentx_grid_CellValidated);
            this.studentx_grid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.studentx_grid_KeyDown);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 50;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // surnameDataGridViewTextBoxColumn
            // 
            this.surnameDataGridViewTextBoxColumn.DataPropertyName = "surname";
            this.surnameDataGridViewTextBoxColumn.HeaderText = "surname";
            this.surnameDataGridViewTextBoxColumn.Name = "surnameDataGridViewTextBoxColumn";
            this.surnameDataGridViewTextBoxColumn.Width = 250;
            // 
            // middlenameDataGridViewTextBoxColumn
            // 
            this.middlenameDataGridViewTextBoxColumn.DataPropertyName = "middle_name";
            this.middlenameDataGridViewTextBoxColumn.HeaderText = "middle_name";
            this.middlenameDataGridViewTextBoxColumn.Name = "middlenameDataGridViewTextBoxColumn";
            this.middlenameDataGridViewTextBoxColumn.Width = 200;
            // 
            // masterDataGridViewTextBoxColumn
            // 
            this.masterDataGridViewTextBoxColumn.DataPropertyName = "master";
            this.masterDataGridViewTextBoxColumn.HeaderText = "master";
            this.masterDataGridViewTextBoxColumn.Name = "masterDataGridViewTextBoxColumn";
            this.masterDataGridViewTextBoxColumn.Width = 150;
            // 
            // groupsidDataGridViewTextBoxColumn
            // 
            this.groupsidDataGridViewTextBoxColumn.DataPropertyName = "groups_id";
            this.groupsidDataGridViewTextBoxColumn.HeaderText = "groups_id";
            this.groupsidDataGridViewTextBoxColumn.Name = "groupsidDataGridViewTextBoxColumn";
            // 
            // role
            // 
            this.role.DataPropertyName = "role";
            this.role.HeaderText = "role";
            this.role.Name = "role";
            // 
            // studentsBindingSource
            // 
            this.studentsBindingSource.DataMember = "students";
            this.studentsBindingSource.DataSource = this.baseX;
            // 
            // baseX
            // 
            this.baseX.DataSetName = "BaseX";
            this.baseX.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentsTableAdapter
            // 
            this.studentsTableAdapter.ClearBeforeFill = true;
            // 
            // StudentsX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(35)))));
            this.Controls.Add(this.studentx_grid);
            this.Name = "StudentsX";
            this.Size = new System.Drawing.Size(1010, 566);
            this.Load += new System.EventHandler(this.StudentsX_Load);
            ((System.ComponentModel.ISupportInitialize)(this.studentx_grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.baseX)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView studentx_grid;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn middlenameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn masterDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn groupsidDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource studentsBindingSource;
        private BaseX baseX;
        private BaseXTableAdapters.studentsTableAdapter studentsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn role;
    }
}

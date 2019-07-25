namespace WindowsFormsApp2
{
    partial class ToRoom
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.userGrid = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.placeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contractPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.capacityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.specialityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.premisesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.udData = new WindowsFormsApp2.udData();
            this.premisesTableAdapter = new WindowsFormsApp2.udDataTableAdapters.premisesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.userGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.premisesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udData)).BeginInit();
            this.SuspendLayout();
            // 
            // userGrid
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.userGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.userGrid.AutoGenerateColumns = false;
            this.userGrid.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.userGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.userGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.userGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.userGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.placeDataGridViewTextBoxColumn,
            this.contractPriceDataGridViewTextBoxColumn,
            this.capacityDataGridViewTextBoxColumn,
            this.specialityDataGridViewTextBoxColumn});
            this.userGrid.DataSource = this.premisesBindingSource;
            this.userGrid.DoubleBuffered = true;
            this.userGrid.EnableHeadersVisualStyles = false;
            this.userGrid.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.userGrid.HeaderForeColor = System.Drawing.Color.SeaGreen;
            this.userGrid.Location = new System.Drawing.Point(-3, 3);
            this.userGrid.Name = "userGrid";
            this.userGrid.ReadOnly = true;
            this.userGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.userGrid.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.userGrid.Size = new System.Drawing.Size(1010, 378);
            this.userGrid.TabIndex = 3;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // placeDataGridViewTextBoxColumn
            // 
            this.placeDataGridViewTextBoxColumn.DataPropertyName = "place";
            this.placeDataGridViewTextBoxColumn.HeaderText = "place";
            this.placeDataGridViewTextBoxColumn.Name = "placeDataGridViewTextBoxColumn";
            this.placeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // contractPriceDataGridViewTextBoxColumn
            // 
            this.contractPriceDataGridViewTextBoxColumn.DataPropertyName = "contractPrice";
            this.contractPriceDataGridViewTextBoxColumn.HeaderText = "contractPrice";
            this.contractPriceDataGridViewTextBoxColumn.Name = "contractPriceDataGridViewTextBoxColumn";
            this.contractPriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // capacityDataGridViewTextBoxColumn
            // 
            this.capacityDataGridViewTextBoxColumn.DataPropertyName = "capacity";
            this.capacityDataGridViewTextBoxColumn.HeaderText = "capacity";
            this.capacityDataGridViewTextBoxColumn.Name = "capacityDataGridViewTextBoxColumn";
            this.capacityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // specialityDataGridViewTextBoxColumn
            // 
            this.specialityDataGridViewTextBoxColumn.DataPropertyName = "speciality";
            this.specialityDataGridViewTextBoxColumn.HeaderText = "speciality";
            this.specialityDataGridViewTextBoxColumn.Name = "specialityDataGridViewTextBoxColumn";
            this.specialityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // premisesBindingSource
            // 
            this.premisesBindingSource.DataMember = "premises";
            this.premisesBindingSource.DataSource = this.udData;
            // 
            // udData
            // 
            this.udData.DataSetName = "udData";
            this.udData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // premisesTableAdapter
            // 
            this.premisesTableAdapter.ClearBeforeFill = true;
            // 
            // ToRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(35)))));
            this.Controls.Add(this.userGrid);
            this.Name = "ToRoom";
            this.Size = new System.Drawing.Size(1010, 566);
            this.Load += new System.EventHandler(this.ToRoom_Load);
            ((System.ComponentModel.ISupportInitialize)(this.userGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.premisesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomDataGrid userGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn placeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contractPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn capacityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn specialityDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource premisesBindingSource;
        private udData udData;
        private udDataTableAdapters.premisesTableAdapter premisesTableAdapter;
    }
}

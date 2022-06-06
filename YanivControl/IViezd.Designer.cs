
namespace CarInterface
{
    partial class IViezd
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.viezdBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dateViezdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.driverIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.carNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.kmDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viezdBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dateViezdDataGridViewTextBoxColumn,
            this.driverIdDataGridViewTextBoxColumn,
            this.carNumDataGridViewTextBoxColumn,
            this.kmDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.viezdBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(2, 2);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(700, 401);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridView1_DataError);
            // 
            // viezdBindingSource
            // 
            this.viezdBindingSource.DataSource = typeof(CarClassDB.Viezd);
            // 
            // dateViezdDataGridViewTextBoxColumn
            // 
            this.dateViezdDataGridViewTextBoxColumn.DataPropertyName = "dateViezd";
            this.dateViezdDataGridViewTextBoxColumn.HeaderText = "Date of start travel";
            this.dateViezdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateViezdDataGridViewTextBoxColumn.Name = "dateViezdDataGridViewTextBoxColumn";
            // 
            // driverIdDataGridViewTextBoxColumn
            // 
            this.driverIdDataGridViewTextBoxColumn.DataPropertyName = "driverId";
            this.driverIdDataGridViewTextBoxColumn.HeaderText = "Driver Id";
            this.driverIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.driverIdDataGridViewTextBoxColumn.Name = "driverIdDataGridViewTextBoxColumn";
            this.driverIdDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.driverIdDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // carNumDataGridViewTextBoxColumn
            // 
            this.carNumDataGridViewTextBoxColumn.DataPropertyName = "carNum";
            this.carNumDataGridViewTextBoxColumn.HeaderText = "Car number";
            this.carNumDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.carNumDataGridViewTextBoxColumn.Name = "carNumDataGridViewTextBoxColumn";
            this.carNumDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.carNumDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // kmDataGridViewTextBoxColumn
            // 
            this.kmDataGridViewTextBoxColumn.DataPropertyName = "km";
            this.kmDataGridViewTextBoxColumn.HeaderText = "Distance";
            this.kmDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kmDataGridViewTextBoxColumn.Name = "kmDataGridViewTextBoxColumn";
            // 
            // IViezd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "IViezd";
            this.Size = new System.Drawing.Size(704, 406);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viezdBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource viezdBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateViezdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn driverIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn carNumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kmDataGridViewTextBoxColumn;
    }
}

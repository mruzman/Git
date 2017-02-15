namespace RentACarApp
{
    partial class OdaberiStavke
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.rezerviranoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._16023_DBDataSet = new RentACarApp._16023_DBDataSet();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.automobilDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iznajmljenodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iznajmljendoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.klijent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rezerviranoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._16023_DBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.automobilDataGridViewTextBoxColumn,
            this.iznajmljenodDataGridViewTextBoxColumn,
            this.iznajmljendoDataGridViewTextBoxColumn,
            this.klijent});
            this.dataGridView1.DataSource = this.rezerviranoBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(625, 428);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // rezerviranoBindingSource
            // 
            this.rezerviranoBindingSource.DataMember = "rezervirano";
            this.rezerviranoBindingSource.DataSource = this._16023_DBDataSet;
            // 
            // _16023_DBDataSet
            // 
            this._16023_DBDataSet.DataSetName = "_16023_DBDataSet";
            this._16023_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // automobilDataGridViewTextBoxColumn
            // 
            this.automobilDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.automobilDataGridViewTextBoxColumn.DataPropertyName = "automobil";
            this.automobilDataGridViewTextBoxColumn.HeaderText = "automobil";
            this.automobilDataGridViewTextBoxColumn.Name = "automobilDataGridViewTextBoxColumn";
            // 
            // iznajmljenodDataGridViewTextBoxColumn
            // 
            this.iznajmljenodDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.iznajmljenodDataGridViewTextBoxColumn.DataPropertyName = "iznajmljen_od";
            this.iznajmljenodDataGridViewTextBoxColumn.HeaderText = "iznajmljen_od";
            this.iznajmljenodDataGridViewTextBoxColumn.Name = "iznajmljenodDataGridViewTextBoxColumn";
            // 
            // iznajmljendoDataGridViewTextBoxColumn
            // 
            this.iznajmljendoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.iznajmljendoDataGridViewTextBoxColumn.DataPropertyName = "iznajmljen_do";
            this.iznajmljendoDataGridViewTextBoxColumn.HeaderText = "iznajmljen_do";
            this.iznajmljendoDataGridViewTextBoxColumn.Name = "iznajmljendoDataGridViewTextBoxColumn";
            // 
            // klijent
            // 
            this.klijent.DataPropertyName = "klijent";
            this.klijent.HeaderText = "klijent";
            this.klijent.Name = "klijent";
            this.klijent.Visible = false;
            // 
            // OdaberiStavke
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 428);
            this.Controls.Add(this.dataGridView1);
            this.Name = "OdaberiStavke";
            this.Text = "OdaberiStavke";
            this.Load += new System.EventHandler(this.OdaberiStavke_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rezerviranoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._16023_DBDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private _16023_DBDataSet _16023_DBDataSet;
        private System.Windows.Forms.BindingSource rezerviranoBindingSource;
  
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn automobilDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iznajmljenodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iznajmljendoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn klijent;
    }
}
namespace RentACarApp
{
    partial class Slobodni_automobili
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
            this.proczapretragu2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._16023_DBDataSet = new RentACarApp._16023_DBDataSet();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpOd = new System.Windows.Forms.DateTimePicker();
            this.dtDo = new System.Windows.Forms.DateTimePicker();
            this.cmbMarka = new System.Windows.Forms.ComboBox();
            this.cmbKlasa = new System.Windows.Forms.ComboBox();
            this.txtPretraga = new System.Windows.Forms.TextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbVrijemeDo = new System.Windows.Forms.ComboBox();
            this.cmbVrijemeOd = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSnagaDo = new System.Windows.Forms.TextBox();
            this.txtSnagaOd = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBrojPutnika = new System.Windows.Forms.TextBox();
            this.cmbIzvedba = new System.Windows.Forms.ComboBox();
            this.cmbTipVozila = new System.Windows.Forms.ComboBox();
            this.proc_za_pretragu2TableAdapter = new RentACarApp._16023_DBDataSetTableAdapters.Proc_za_pretragu2TableAdapter();
            this.sifraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.markaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.izvedbaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.klasaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipvozilaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.motorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.snagamotoraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.radniobujamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registracijaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.godinaproizvodnjeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proczapretragu2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._16023_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sifraDataGridViewTextBoxColumn,
            this.markaDataGridViewTextBoxColumn,
            this.nazivDataGridViewTextBoxColumn,
            this.izvedbaDataGridViewTextBoxColumn,
            this.klasaDataGridViewTextBoxColumn,
            this.tipvozilaDataGridViewTextBoxColumn,
            this.motorDataGridViewTextBoxColumn,
            this.snagamotoraDataGridViewTextBoxColumn,
            this.radniobujamDataGridViewTextBoxColumn,
            this.registracijaDataGridViewTextBoxColumn,
            this.godinaproizvodnjeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.proczapretragu2BindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1194, 689);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseDoubleClick);
            // 
            // proczapretragu2BindingSource
            // 
            this.proczapretragu2BindingSource.DataMember = "Proc_za_pretragu2";
            this.proczapretragu2BindingSource.DataSource = this._16023_DBDataSet;
            // 
            // _16023_DBDataSet
            // 
            this._16023_DBDataSet.DataSetName = "_16023_DBDataSet";
            this._16023_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(411, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Klasa:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(411, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Marka:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Slobodno od:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Slobodno do:";
            // 
            // dtpOd
            // 
            this.dtpOd.Location = new System.Drawing.Point(116, 33);
            this.dtpOd.Name = "dtpOd";
            this.dtpOd.Size = new System.Drawing.Size(206, 20);
            this.dtpOd.TabIndex = 9;
            this.dtpOd.CloseUp += new System.EventHandler(this.dtpOd_CloseUp);
            // 
            // dtDo
            // 
            this.dtDo.Location = new System.Drawing.Point(116, 58);
            this.dtDo.Name = "dtDo";
            this.dtDo.Size = new System.Drawing.Size(206, 20);
            this.dtDo.TabIndex = 10;
            this.dtDo.CloseUp += new System.EventHandler(this.dtDo_CloseUp);
            // 
            // cmbMarka
            // 
            this.cmbMarka.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMarka.FormattingEnabled = true;
            this.cmbMarka.Location = new System.Drawing.Point(466, 9);
            this.cmbMarka.Name = "cmbMarka";
            this.cmbMarka.Size = new System.Drawing.Size(192, 21);
            this.cmbMarka.TabIndex = 16;
            this.cmbMarka.SelectionChangeCommitted += new System.EventHandler(this.cmbMarka_SelectionChangeCommitted);
            // 
            // cmbKlasa
            // 
            this.cmbKlasa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKlasa.FormattingEnabled = true;
            this.cmbKlasa.Location = new System.Drawing.Point(466, 33);
            this.cmbKlasa.Name = "cmbKlasa";
            this.cmbKlasa.Size = new System.Drawing.Size(192, 21);
            this.cmbKlasa.TabIndex = 15;
            this.cmbKlasa.SelectionChangeCommitted += new System.EventHandler(this.cmbKlasa_SelectionChangeCommitted);
            // 
            // txtPretraga
            // 
            this.txtPretraga.Location = new System.Drawing.Point(6, 54);
            this.txtPretraga.Name = "txtPretraga";
            this.txtPretraga.Size = new System.Drawing.Size(143, 20);
            this.txtPretraga.TabIndex = 1;
            this.txtPretraga.TextChanged += new System.EventHandler(this.txtPretraga_TextChanged);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer1.Size = new System.Drawing.Size(1194, 96);
            this.splitContainer1.SplitterDistance = 162;
            this.splitContainer1.TabIndex = 16;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtPretraga);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(162, 90);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Brza pretraga:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbVrijemeDo);
            this.groupBox2.Controls.Add(this.cmbVrijemeOd);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtSnagaDo);
            this.groupBox2.Controls.Add(this.txtSnagaOd);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.cmbKlasa);
            this.groupBox2.Controls.Add(this.txtBrojPutnika);
            this.groupBox2.Controls.Add(this.cmbMarka);
            this.groupBox2.Controls.Add(this.cmbIzvedba);
            this.groupBox2.Controls.Add(this.dtDo);
            this.groupBox2.Controls.Add(this.cmbTipVozila);
            this.groupBox2.Controls.Add(this.dtpOd);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1028, 90);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pretraži po filterima:";
            // 
            // cmbVrijemeDo
            // 
            this.cmbVrijemeDo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVrijemeDo.FormattingEnabled = true;
            this.cmbVrijemeDo.Items.AddRange(new object[] {
            "07:00",
            "07:30",
            "08:00",
            "08:30",
            "09:00",
            "09:30",
            "10:00",
            "10:30",
            "11:00",
            "11:30",
            "12:00",
            "12:30",
            "13:00",
            "13:30",
            "14:00",
            "14:30",
            "15:00",
            "15:30",
            "16:00",
            "16:30",
            "17:00",
            "17:30",
            "18:00",
            "18:30",
            "19:00",
            "19:30",
            "20:00",
            "20:30",
            "21:00",
            "21:30",
            "22:00"});
            this.cmbVrijemeDo.Location = new System.Drawing.Point(328, 58);
            this.cmbVrijemeDo.Name = "cmbVrijemeDo";
            this.cmbVrijemeDo.Size = new System.Drawing.Size(77, 21);
            this.cmbVrijemeDo.TabIndex = 38;
            this.cmbVrijemeDo.SelectionChangeCommitted += new System.EventHandler(this.cmbVrijemeDo_SelectionChangeCommitted);
            // 
            // cmbVrijemeOd
            // 
            this.cmbVrijemeOd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVrijemeOd.FormattingEnabled = true;
            this.cmbVrijemeOd.Items.AddRange(new object[] {
            "07:00",
            "07:30",
            "08:00",
            "08:30",
            "09:00",
            "09:30",
            "10:00",
            "10:30",
            "11:00",
            "11:30",
            "12:00",
            "12:30",
            "13:00",
            "13:30",
            "14:00",
            "14:30",
            "15:00",
            "15:30",
            "16:00",
            "16:30",
            "17:00",
            "17:30",
            "18:00",
            "18:30",
            "19:00",
            "19:30",
            "20:00",
            "20:30",
            "21:00",
            "21:30",
            "22:00"});
            this.cmbVrijemeOd.Location = new System.Drawing.Point(328, 33);
            this.cmbVrijemeOd.Name = "cmbVrijemeOd";
            this.cmbVrijemeOd.Size = new System.Drawing.Size(77, 21);
            this.cmbVrijemeOd.TabIndex = 37;
            this.cmbVrijemeOd.SelectionChangeCommitted += new System.EventHandler(this.cmbVrijemeOd_SelectionChangeCommitted);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(664, 62);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 13);
            this.label11.TabIndex = 36;
            this.label11.Text = "Konjske snage:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(667, 37);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 13);
            this.label10.TabIndex = 35;
            this.label10.Text = "Izvedba:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(667, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 34;
            this.label6.Text = "Tip vozila:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(416, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = "Broj putnika:";
            // 
            // txtSnagaDo
            // 
            this.txtSnagaDo.Location = new System.Drawing.Point(872, 59);
            this.txtSnagaDo.Name = "txtSnagaDo";
            this.txtSnagaDo.Size = new System.Drawing.Size(40, 20);
            this.txtSnagaDo.TabIndex = 32;
            this.txtSnagaDo.TextChanged += new System.EventHandler(this.txtSnagaDo_TextChanged);
            // 
            // txtSnagaOd
            // 
            this.txtSnagaOd.Location = new System.Drawing.Point(814, 59);
            this.txtSnagaOd.Name = "txtSnagaOd";
            this.txtSnagaOd.Size = new System.Drawing.Size(40, 20);
            this.txtSnagaOd.TabIndex = 31;
            this.txtSnagaOd.TextChanged += new System.EventHandler(this.txtSnagaOd_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(918, 64);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(21, 13);
            this.label9.TabIndex = 30;
            this.label9.Text = "KS";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(860, 63);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(9, 13);
            this.label8.TabIndex = 29;
            this.label8.Text = "i";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(766, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "Između";
            // 
            // txtBrojPutnika
            // 
            this.txtBrojPutnika.Location = new System.Drawing.Point(490, 57);
            this.txtBrojPutnika.Name = "txtBrojPutnika";
            this.txtBrojPutnika.Size = new System.Drawing.Size(168, 20);
            this.txtBrojPutnika.TabIndex = 26;
            this.txtBrojPutnika.TextChanged += new System.EventHandler(this.txtBrojPutnika_TextChanged);
            // 
            // cmbIzvedba
            // 
            this.cmbIzvedba.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIzvedba.FormattingEnabled = true;
            this.cmbIzvedba.Location = new System.Drawing.Point(744, 32);
            this.cmbIzvedba.Name = "cmbIzvedba";
            this.cmbIzvedba.Size = new System.Drawing.Size(262, 21);
            this.cmbIzvedba.TabIndex = 24;
            this.cmbIzvedba.SelectionChangeCommitted += new System.EventHandler(this.cmbIzvedba_SelectionChangeCommitted);
            // 
            // cmbTipVozila
            // 
            this.cmbTipVozila.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipVozila.FormattingEnabled = true;
            this.cmbTipVozila.Location = new System.Drawing.Point(744, 9);
            this.cmbTipVozila.Name = "cmbTipVozila";
            this.cmbTipVozila.Size = new System.Drawing.Size(262, 21);
            this.cmbTipVozila.TabIndex = 23;
            this.cmbTipVozila.SelectionChangeCommitted += new System.EventHandler(this.cmbTipVozila_SelectionChangeCommitted);
            // 
            // proc_za_pretragu2TableAdapter
            // 
            this.proc_za_pretragu2TableAdapter.ClearBeforeFill = true;
            // 
            // sifraDataGridViewTextBoxColumn
            // 
            this.sifraDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.sifraDataGridViewTextBoxColumn.DataPropertyName = "sifra";
            this.sifraDataGridViewTextBoxColumn.HeaderText = "sifra";
            this.sifraDataGridViewTextBoxColumn.Name = "sifraDataGridViewTextBoxColumn";
            this.sifraDataGridViewTextBoxColumn.ReadOnly = true;
            this.sifraDataGridViewTextBoxColumn.Visible = false;
            // 
            // markaDataGridViewTextBoxColumn
            // 
            this.markaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.markaDataGridViewTextBoxColumn.DataPropertyName = "marka";
            this.markaDataGridViewTextBoxColumn.HeaderText = "Marka automobila";
            this.markaDataGridViewTextBoxColumn.Name = "markaDataGridViewTextBoxColumn";
            this.markaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nazivDataGridViewTextBoxColumn
            // 
            this.nazivDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nazivDataGridViewTextBoxColumn.DataPropertyName = "naziv";
            this.nazivDataGridViewTextBoxColumn.HeaderText = "Model automobila";
            this.nazivDataGridViewTextBoxColumn.Name = "nazivDataGridViewTextBoxColumn";
            this.nazivDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // izvedbaDataGridViewTextBoxColumn
            // 
            this.izvedbaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.izvedbaDataGridViewTextBoxColumn.DataPropertyName = "izvedba";
            this.izvedbaDataGridViewTextBoxColumn.HeaderText = "Izvedba";
            this.izvedbaDataGridViewTextBoxColumn.Name = "izvedbaDataGridViewTextBoxColumn";
            this.izvedbaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // klasaDataGridViewTextBoxColumn
            // 
            this.klasaDataGridViewTextBoxColumn.DataPropertyName = "klasa";
            this.klasaDataGridViewTextBoxColumn.HeaderText = "Klasa";
            this.klasaDataGridViewTextBoxColumn.Name = "klasaDataGridViewTextBoxColumn";
            this.klasaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tipvozilaDataGridViewTextBoxColumn
            // 
            this.tipvozilaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tipvozilaDataGridViewTextBoxColumn.DataPropertyName = "tip_vozila";
            this.tipvozilaDataGridViewTextBoxColumn.HeaderText = "Tip vozila";
            this.tipvozilaDataGridViewTextBoxColumn.Name = "tipvozilaDataGridViewTextBoxColumn";
            this.tipvozilaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // motorDataGridViewTextBoxColumn
            // 
            this.motorDataGridViewTextBoxColumn.DataPropertyName = "motor";
            this.motorDataGridViewTextBoxColumn.HeaderText = "Motor";
            this.motorDataGridViewTextBoxColumn.Name = "motorDataGridViewTextBoxColumn";
            this.motorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // snagamotoraDataGridViewTextBoxColumn
            // 
            this.snagamotoraDataGridViewTextBoxColumn.DataPropertyName = "snaga_motora";
            this.snagamotoraDataGridViewTextBoxColumn.HeaderText = "Snaga motora(u KS)";
            this.snagamotoraDataGridViewTextBoxColumn.Name = "snagamotoraDataGridViewTextBoxColumn";
            this.snagamotoraDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // radniobujamDataGridViewTextBoxColumn
            // 
            this.radniobujamDataGridViewTextBoxColumn.DataPropertyName = "radni_obujam";
            this.radniobujamDataGridViewTextBoxColumn.HeaderText = "Radni obujam motora";
            this.radniobujamDataGridViewTextBoxColumn.Name = "radniobujamDataGridViewTextBoxColumn";
            this.radniobujamDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // registracijaDataGridViewTextBoxColumn
            // 
            this.registracijaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.registracijaDataGridViewTextBoxColumn.DataPropertyName = "registracija";
            this.registracijaDataGridViewTextBoxColumn.HeaderText = "Registarske tablice";
            this.registracijaDataGridViewTextBoxColumn.Name = "registracijaDataGridViewTextBoxColumn";
            this.registracijaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // godinaproizvodnjeDataGridViewTextBoxColumn
            // 
            this.godinaproizvodnjeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.godinaproizvodnjeDataGridViewTextBoxColumn.DataPropertyName = "godina_proizvodnje";
            this.godinaproizvodnjeDataGridViewTextBoxColumn.HeaderText = "Godina proizvodnje automobila";
            this.godinaproizvodnjeDataGridViewTextBoxColumn.Name = "godinaproizvodnjeDataGridViewTextBoxColumn";
            this.godinaproizvodnjeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 96);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1194, 689);
            this.panel1.TabIndex = 17;
            // 
            // Slobodni_automobili
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1194, 785);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Slobodni_automobili";
            this.Text = "Slobodni automobili";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proczapretragu2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._16023_DBDataSet)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private _16023_DBDataSet _16023_DBDataSet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpOd;
        private System.Windows.Forms.DateTimePicker dtDo;
        private System.Windows.Forms.ComboBox cmbMarka;
        private System.Windows.Forms.ComboBox cmbKlasa;
        private System.Windows.Forms.TextBox txtPretraga;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ComboBox cmbIzvedba;
        private System.Windows.Forms.ComboBox cmbTipVozila;
        private System.Windows.Forms.TextBox txtSnagaDo;
        private System.Windows.Forms.TextBox txtSnagaOd;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBrojPutnika;
        private System.Windows.Forms.BindingSource proczapretragu2BindingSource;
        private _16023_DBDataSetTableAdapters.Proc_za_pretragu2TableAdapter proc_za_pretragu2TableAdapter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbVrijemeDo;
        private System.Windows.Forms.ComboBox cmbVrijemeOd;
        private System.Windows.Forms.DataGridViewTextBoxColumn sifraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn markaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn izvedbaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn klasaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipvozilaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn motorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn snagamotoraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn radniobujamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn registracijaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn godinaproizvodnjeDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel1;
    }
}
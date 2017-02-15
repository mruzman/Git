namespace RentACarApp
{
    partial class rezervirajForma
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnZavrsi = new System.Windows.Forms.Button();
            this.lblGreska = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.klijentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._16023_DBDataSet = new RentACarApp._16023_DBDataSet();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dtOd = new System.Windows.Forms.DateTimePicker();
            this.dtDo = new System.Windows.Forms.DateTimePicker();
            this.btnSviKlijenti = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtMarka = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.txtTablice = new System.Windows.Forms.TextBox();
            this.txtIzvedba = new System.Windows.Forms.TextBox();
            this.txtKlasa = new System.Windows.Forms.TextBox();
            this.txtBoja = new System.Windows.Forms.TextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.cmbKlijent = new System.Windows.Forms.ComboBox();
            this.cmbVureDo = new System.Windows.Forms.ComboBox();
            this.cmbVureOd = new System.Windows.Forms.ComboBox();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.markaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.izvedbaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.klasaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registracijaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.godinaproizvodnjeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumpreuzimanjaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumpovrataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sifraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rezervacija2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtRezervacijuZapisao = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.klijentTableAdapter = new RentACarApp._16023_DBDataSetTableAdapters.klijentTableAdapter();
            this.klijentBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.rezervacija2TableAdapter = new RentACarApp._16023_DBDataSetTableAdapters.rezervacija2TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.klijentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._16023_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rezervacija2BindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.klijentBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(26, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Rezervacija auta:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(26, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Razdoblje";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(436, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "POVRAT:";
            // 
            // btnZavrsi
            // 
            this.btnZavrsi.Enabled = false;
            this.btnZavrsi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnZavrsi.Location = new System.Drawing.Point(605, 3);
            this.btnZavrsi.Name = "btnZavrsi";
            this.btnZavrsi.Size = new System.Drawing.Size(178, 41);
            this.btnZavrsi.TabIndex = 7;
            this.btnZavrsi.Text = "Zaključi rezervaciju";
            this.btnZavrsi.UseVisualStyleBackColor = true;
            this.btnZavrsi.Click += new System.EventHandler(this.btnZavrsi_Click);
            // 
            // lblGreska
            // 
            this.lblGreska.AutoSize = true;
            this.lblGreska.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblGreska.Location = new System.Drawing.Point(10, 43);
            this.lblGreska.Name = "lblGreska";
            this.lblGreska.Size = new System.Drawing.Size(141, 20);
            this.lblGreska.TabIndex = 10;
            this.lblGreska.Text = "Stavke rezervacije:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "PREUZIMANJE:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(34, 274);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "KLIJENT:";
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(139, 133);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(255, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "ODABIR AUTOMOBILA";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // klijentBindingSource
            // 
            this.klijentBindingSource.DataMember = "klijent";
            this.klijentBindingSource.DataSource = this.dBDataSetBindingSource;
            // 
            // dBDataSetBindingSource
            // 
            this.dBDataSetBindingSource.DataSource = this._16023_DBDataSet;
            this.dBDataSetBindingSource.Position = 0;
            // 
            // _16023_DBDataSet
            // 
            this._16023_DBDataSet.DataSetName = "_16023_DBDataSet";
            this._16023_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "MARKA VOZILA:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 205);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "MODEL:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(33, 233);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "TABLICE:";
            // 
            // dtOd
            // 
            this.dtOd.Location = new System.Drawing.Point(139, 54);
            this.dtOd.Name = "dtOd";
            this.dtOd.Size = new System.Drawing.Size(176, 20);
            this.dtOd.TabIndex = 26;
            this.dtOd.CloseUp += new System.EventHandler(this.dtOd_CloseUp);
            // 
            // dtDo
            // 
            this.dtDo.Enabled = false;
            this.dtDo.Location = new System.Drawing.Point(519, 51);
            this.dtDo.Name = "dtDo";
            this.dtDo.Size = new System.Drawing.Size(182, 20);
            this.dtDo.TabIndex = 27;
            this.dtDo.CloseUp += new System.EventHandler(this.dtDo_CloseUp);
            // 
            // btnSviKlijenti
            // 
            this.btnSviKlijenti.Location = new System.Drawing.Point(343, 269);
            this.btnSviKlijenti.Name = "btnSviKlijenti";
            this.btnSviKlijenti.Size = new System.Drawing.Size(51, 22);
            this.btnSviKlijenti.TabIndex = 28;
            this.btnSviKlijenti.Text = "...";
            this.btnSviKlijenti.UseVisualStyleBackColor = true;
            this.btnSviKlijenti.Click += new System.EventHandler(this.btnSviKlijenti_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(10, 318);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 20);
            this.label9.TabIndex = 29;
            this.label9.Text = "Iznajmljuje";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(436, 233);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 13);
            this.label10.TabIndex = 32;
            this.label10.Text = "BOJA:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(436, 205);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 13);
            this.label11.TabIndex = 31;
            this.label11.Text = "KLASA:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(436, 176);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 13);
            this.label12.TabIndex = 30;
            this.label12.Text = "IZVEDBA:";
            // 
            // txtMarka
            // 
            this.txtMarka.Enabled = false;
            this.txtMarka.Location = new System.Drawing.Point(140, 173);
            this.txtMarka.Name = "txtMarka";
            this.txtMarka.Size = new System.Drawing.Size(254, 20);
            this.txtMarka.TabIndex = 23;
            // 
            // txtModel
            // 
            this.txtModel.Enabled = false;
            this.txtModel.Location = new System.Drawing.Point(140, 202);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(254, 20);
            this.txtModel.TabIndex = 24;
            // 
            // txtTablice
            // 
            this.txtTablice.Enabled = false;
            this.txtTablice.Location = new System.Drawing.Point(140, 230);
            this.txtTablice.Name = "txtTablice";
            this.txtTablice.Size = new System.Drawing.Size(254, 20);
            this.txtTablice.TabIndex = 25;
            // 
            // txtIzvedba
            // 
            this.txtIzvedba.Enabled = false;
            this.txtIzvedba.Location = new System.Drawing.Point(519, 173);
            this.txtIzvedba.Name = "txtIzvedba";
            this.txtIzvedba.Size = new System.Drawing.Size(264, 20);
            this.txtIzvedba.TabIndex = 33;
            // 
            // txtKlasa
            // 
            this.txtKlasa.Enabled = false;
            this.txtKlasa.Location = new System.Drawing.Point(519, 202);
            this.txtKlasa.Name = "txtKlasa";
            this.txtKlasa.Size = new System.Drawing.Size(264, 20);
            this.txtKlasa.TabIndex = 34;
            // 
            // txtBoja
            // 
            this.txtBoja.Enabled = false;
            this.txtBoja.Location = new System.Drawing.Point(519, 230);
            this.txtBoja.Name = "txtBoja";
            this.txtBoja.Size = new System.Drawing.Size(264, 20);
            this.txtBoja.TabIndex = 35;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.cmbKlijent);
            this.splitContainer1.Panel1.Controls.Add(this.cmbVureDo);
            this.splitContainer1.Panel1.Controls.Add(this.cmbVureOd);
            this.splitContainer1.Panel1.Controls.Add(this.btnSviKlijenti);
            this.splitContainer1.Panel1.Controls.Add(this.btnSpremi);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.label7);
            this.splitContainer1.Panel1.Controls.Add(this.txtBoja);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.txtKlasa);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.txtIzvedba);
            this.splitContainer1.Panel1.Controls.Add(this.label10);
            this.splitContainer1.Panel1.Controls.Add(this.label11);
            this.splitContainer1.Panel1.Controls.Add(this.label12);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.button1);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.dtDo);
            this.splitContainer1.Panel1.Controls.Add(this.label6);
            this.splitContainer1.Panel1.Controls.Add(this.dtOd);
            this.splitContainer1.Panel1.Controls.Add(this.label8);
            this.splitContainer1.Panel1.Controls.Add(this.txtTablice);
            this.splitContainer1.Panel1.Controls.Add(this.txtMarka);
            this.splitContainer1.Panel1.Controls.Add(this.txtModel);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer1.Panel2.Controls.Add(this.panel2);
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Size = new System.Drawing.Size(975, 748);
            this.splitContainer1.SplitterDistance = 295;
            this.splitContainer1.TabIndex = 36;
            // 
            // cmbKlijent
            // 
            this.cmbKlijent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cmbKlijent.Enabled = false;
            this.cmbKlijent.FormattingEnabled = true;
            this.cmbKlijent.Location = new System.Drawing.Point(139, 269);
            this.cmbKlijent.Name = "cmbKlijent";
            this.cmbKlijent.Size = new System.Drawing.Size(196, 21);
            this.cmbKlijent.TabIndex = 31;
            // 
            // cmbVureDo
            // 
            this.cmbVureDo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVureDo.Enabled = false;
            this.cmbVureDo.FormattingEnabled = true;
            this.cmbVureDo.Items.AddRange(new object[] {
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
            this.cmbVureDo.Location = new System.Drawing.Point(707, 51);
            this.cmbVureDo.Name = "cmbVureDo";
            this.cmbVureDo.Size = new System.Drawing.Size(76, 21);
            this.cmbVureDo.TabIndex = 38;
            this.cmbVureDo.SelectionChangeCommitted += new System.EventHandler(this.cmbVureDo_SelectionChangeCommitted);
            // 
            // cmbVureOd
            // 
            this.cmbVureOd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVureOd.FormattingEnabled = true;
            this.cmbVureOd.Items.AddRange(new object[] {
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
            this.cmbVureOd.Location = new System.Drawing.Point(321, 53);
            this.cmbVureOd.Name = "cmbVureOd";
            this.cmbVureOd.Size = new System.Drawing.Size(73, 21);
            this.cmbVureOd.TabIndex = 37;
            this.cmbVureOd.SelectionChangeCommitted += new System.EventHandler(this.cmbVureOd_SelectionChangeCommitted);
            // 
            // btnSpremi
            // 
            this.btnSpremi.Location = new System.Drawing.Point(674, 265);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(109, 25);
            this.btnSpremi.TabIndex = 36;
            this.btnSpremi.Text = "Dodaj stavku";
            this.btnSpremi.UseVisualStyleBackColor = true;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.markaDataGridViewTextBoxColumn,
            this.nazivDataGridViewTextBoxColumn,
            this.izvedbaDataGridViewTextBoxColumn,
            this.klasaDataGridViewTextBoxColumn,
            this.registracijaDataGridViewTextBoxColumn,
            this.godinaproizvodnjeDataGridViewTextBoxColumn,
            this.datumpreuzimanjaDataGridViewTextBoxColumn,
            this.datumpovrataDataGridViewTextBoxColumn,
            this.sifraDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.rezervacija2BindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 63);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(975, 386);
            this.dataGridView1.TabIndex = 29;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // markaDataGridViewTextBoxColumn
            // 
            this.markaDataGridViewTextBoxColumn.DataPropertyName = "marka";
            this.markaDataGridViewTextBoxColumn.HeaderText = "Marka vozila";
            this.markaDataGridViewTextBoxColumn.Name = "markaDataGridViewTextBoxColumn";
            this.markaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nazivDataGridViewTextBoxColumn
            // 
            this.nazivDataGridViewTextBoxColumn.DataPropertyName = "naziv";
            this.nazivDataGridViewTextBoxColumn.HeaderText = "Model vozila";
            this.nazivDataGridViewTextBoxColumn.Name = "nazivDataGridViewTextBoxColumn";
            this.nazivDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // izvedbaDataGridViewTextBoxColumn
            // 
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
            // registracijaDataGridViewTextBoxColumn
            // 
            this.registracijaDataGridViewTextBoxColumn.DataPropertyName = "registracija";
            this.registracijaDataGridViewTextBoxColumn.HeaderText = "Registracijske tablice";
            this.registracijaDataGridViewTextBoxColumn.Name = "registracijaDataGridViewTextBoxColumn";
            this.registracijaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // godinaproizvodnjeDataGridViewTextBoxColumn
            // 
            this.godinaproizvodnjeDataGridViewTextBoxColumn.DataPropertyName = "godina_proizvodnje";
            this.godinaproizvodnjeDataGridViewTextBoxColumn.HeaderText = "Godina proizvodnje";
            this.godinaproizvodnjeDataGridViewTextBoxColumn.Name = "godinaproizvodnjeDataGridViewTextBoxColumn";
            this.godinaproizvodnjeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // datumpreuzimanjaDataGridViewTextBoxColumn
            // 
            this.datumpreuzimanjaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.datumpreuzimanjaDataGridViewTextBoxColumn.DataPropertyName = "datum_preuzimanja";
            this.datumpreuzimanjaDataGridViewTextBoxColumn.HeaderText = "Datum preuzimanja";
            this.datumpreuzimanjaDataGridViewTextBoxColumn.Name = "datumpreuzimanjaDataGridViewTextBoxColumn";
            this.datumpreuzimanjaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // datumpovrataDataGridViewTextBoxColumn
            // 
            this.datumpovrataDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.datumpovrataDataGridViewTextBoxColumn.DataPropertyName = "datum_povrata";
            this.datumpovrataDataGridViewTextBoxColumn.HeaderText = "Datum povrata";
            this.datumpovrataDataGridViewTextBoxColumn.Name = "datumpovrataDataGridViewTextBoxColumn";
            this.datumpovrataDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sifraDataGridViewTextBoxColumn
            // 
            this.sifraDataGridViewTextBoxColumn.DataPropertyName = "sifra";
            this.sifraDataGridViewTextBoxColumn.HeaderText = "sifra";
            this.sifraDataGridViewTextBoxColumn.Name = "sifraDataGridViewTextBoxColumn";
            this.sifraDataGridViewTextBoxColumn.ReadOnly = true;
            this.sifraDataGridViewTextBoxColumn.Visible = false;
            // 
            // rezervacija2BindingSource
            // 
            this.rezervacija2BindingSource.DataMember = "rezervacija2";
            this.rezervacija2BindingSource.DataSource = this._16023_DBDataSet;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 63);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(975, 386);
            this.panel2.TabIndex = 31;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtRezervacijuZapisao);
            this.panel1.Controls.Add(this.lblGreska);
            this.panel1.Controls.Add(this.btnZavrsi);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(975, 63);
            this.panel1.TabIndex = 30;
            // 
            // txtRezervacijuZapisao
            // 
            this.txtRezervacijuZapisao.Enabled = false;
            this.txtRezervacijuZapisao.Location = new System.Drawing.Point(140, 14);
            this.txtRezervacijuZapisao.Name = "txtRezervacijuZapisao";
            this.txtRezervacijuZapisao.Size = new System.Drawing.Size(224, 20);
            this.txtRezervacijuZapisao.TabIndex = 30;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(27, 17);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(105, 13);
            this.label13.TabIndex = 29;
            this.label13.Text = "Rezervaciju zapisao:";
            // 
            // klijentTableAdapter
            // 
            this.klijentTableAdapter.ClearBeforeFill = true;
            // 
            // klijentBindingSource1
            // 
            this.klijentBindingSource1.DataMember = "klijent";
            this.klijentBindingSource1.DataSource = this._16023_DBDataSet;
            // 
            // rezervacija2TableAdapter
            // 
            this.rezervacija2TableAdapter.ClearBeforeFill = true;
            // 
            // rezervirajForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 748);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.label9);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "rezervirajForma";
            this.Text = "Rezervacija";
            this.Load += new System.EventHandler(this.rezervirajForma_Load);
            ((System.ComponentModel.ISupportInitialize)(this.klijentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._16023_DBDataSet)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rezervacija2BindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.klijentBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnZavrsi;
        private System.Windows.Forms.Label lblGreska;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtOd;
        private System.Windows.Forms.DateTimePicker dtDo;
        private System.Windows.Forms.BindingSource dBDataSetBindingSource;
        private _16023_DBDataSet _16023_DBDataSet;
        private System.Windows.Forms.BindingSource klijentBindingSource;
        private _16023_DBDataSetTableAdapters.klijentTableAdapter klijentTableAdapter;
        private System.Windows.Forms.Button btnSviKlijenti;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.BindingSource klijentBindingSource1;
        private System.Windows.Forms.TextBox txtMarka;
        private System.Windows.Forms.TextBox txtTablice;
        private System.Windows.Forms.TextBox txtIzvedba;
        private System.Windows.Forms.TextBox txtKlasa;
        private System.Windows.Forms.TextBox txtBoja;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtRezervacijuZapisao;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnSpremi;
        private System.Windows.Forms.ComboBox cmbVureDo;
        private System.Windows.Forms.ComboBox cmbVureOd;
        private System.Windows.Forms.BindingSource rezervacija2BindingSource;
        private _16023_DBDataSetTableAdapters.rezervacija2TableAdapter rezervacija2TableAdapter;
        private System.Windows.Forms.ComboBox cmbKlijent;
        private System.Windows.Forms.DataGridViewTextBoxColumn markaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn izvedbaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn klasaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn registracijaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn godinaproizvodnjeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumpreuzimanjaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumpovrataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sifraDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel2;
    }
}
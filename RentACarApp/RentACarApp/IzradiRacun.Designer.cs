namespace RentACarApp
{
    partial class IzradiRacun
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtOIB = new System.Windows.Forms.TextBox();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sifraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.markaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.izvedbaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.klasaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registracijaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.godinaproizvodnjeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumpreuzimanjaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumpovrataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusrezDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pocetnakilometrazaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zavrsnakilometrazaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iznosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zaRacunBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._16023_DBDataSet = new RentACarApp._16023_DBDataSet();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtRacunIzdao = new System.Windows.Forms.TextBox();
            this.txtDatumIzdavanja = new System.Windows.Forms.TextBox();
            this.txtDatumRezervacije = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblIznos = new System.Windows.Forms.Label();
            this.lblKilometraza = new System.Windows.Forms.Label();
            this.lblTrajanje = new System.Windows.Forms.Label();
            this.lblKlasa = new System.Windows.Forms.Label();
            this.txtIznos = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtKilometri = new System.Windows.Forms.TextBox();
            this.txtKlasa = new System.Windows.Forms.TextBox();
            this.txtTrajanje = new System.Windows.Forms.TextBox();
            this.txtPregledZaAuto = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUkupnaCijena = new System.Windows.Forms.TextBox();
            this.btnIZDAJ = new System.Windows.Forms.Button();
            this.zaRacunTableAdapter = new RentACarApp._16023_DBDataSetTableAdapters.zaRacunTableAdapter();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zaRacunBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._16023_DBDataSet)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtOIB);
            this.groupBox1.Controls.Add(this.txtPrezime);
            this.groupBox1.Controls.Add(this.txtIme);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(266, 88);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Podaci o klijentu";
            // 
            // txtOIB
            // 
            this.txtOIB.Enabled = false;
            this.txtOIB.Location = new System.Drawing.Point(62, 65);
            this.txtOIB.Name = "txtOIB";
            this.txtOIB.Size = new System.Drawing.Size(180, 20);
            this.txtOIB.TabIndex = 5;
            // 
            // txtPrezime
            // 
            this.txtPrezime.Enabled = false;
            this.txtPrezime.Location = new System.Drawing.Point(62, 40);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(180, 20);
            this.txtPrezime.TabIndex = 4;
            // 
            // txtIme
            // 
            this.txtIme.Enabled = false;
            this.txtIme.Location = new System.Drawing.Point(62, 17);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(180, 20);
            this.txtIme.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "OIB:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Prezime:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ime:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(12, 231);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(813, 185);
            this.panel1.TabIndex = 1;
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
            this.registracijaDataGridViewTextBoxColumn,
            this.godinaproizvodnjeDataGridViewTextBoxColumn,
            this.datumpreuzimanjaDataGridViewTextBoxColumn,
            this.datumpovrataDataGridViewTextBoxColumn,
            this.statusrezDataGridViewTextBoxColumn,
            this.pocetnakilometrazaDataGridViewTextBoxColumn,
            this.zavrsnakilometrazaDataGridViewTextBoxColumn,
            this.iznosDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.zaRacunBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(813, 185);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // sifraDataGridViewTextBoxColumn
            // 
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
            this.izvedbaDataGridViewTextBoxColumn.DataPropertyName = "izvedba";
            this.izvedbaDataGridViewTextBoxColumn.HeaderText = "izvedba";
            this.izvedbaDataGridViewTextBoxColumn.Name = "izvedbaDataGridViewTextBoxColumn";
            this.izvedbaDataGridViewTextBoxColumn.ReadOnly = true;
            this.izvedbaDataGridViewTextBoxColumn.Visible = false;
            // 
            // klasaDataGridViewTextBoxColumn
            // 
            this.klasaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.klasaDataGridViewTextBoxColumn.DataPropertyName = "klasa";
            this.klasaDataGridViewTextBoxColumn.HeaderText = "Klasa";
            this.klasaDataGridViewTextBoxColumn.Name = "klasaDataGridViewTextBoxColumn";
            this.klasaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // registracijaDataGridViewTextBoxColumn
            // 
            this.registracijaDataGridViewTextBoxColumn.DataPropertyName = "registracija";
            this.registracijaDataGridViewTextBoxColumn.HeaderText = "registracija";
            this.registracijaDataGridViewTextBoxColumn.Name = "registracijaDataGridViewTextBoxColumn";
            this.registracijaDataGridViewTextBoxColumn.ReadOnly = true;
            this.registracijaDataGridViewTextBoxColumn.Visible = false;
            // 
            // godinaproizvodnjeDataGridViewTextBoxColumn
            // 
            this.godinaproizvodnjeDataGridViewTextBoxColumn.DataPropertyName = "godina_proizvodnje";
            this.godinaproizvodnjeDataGridViewTextBoxColumn.HeaderText = "Godina_proizvodnje";
            this.godinaproizvodnjeDataGridViewTextBoxColumn.Name = "godinaproizvodnjeDataGridViewTextBoxColumn";
            this.godinaproizvodnjeDataGridViewTextBoxColumn.ReadOnly = true;
            this.godinaproizvodnjeDataGridViewTextBoxColumn.Visible = false;
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
            // statusrezDataGridViewTextBoxColumn
            // 
            this.statusrezDataGridViewTextBoxColumn.DataPropertyName = "status_rez";
            this.statusrezDataGridViewTextBoxColumn.HeaderText = "status_rez";
            this.statusrezDataGridViewTextBoxColumn.Name = "statusrezDataGridViewTextBoxColumn";
            this.statusrezDataGridViewTextBoxColumn.ReadOnly = true;
            this.statusrezDataGridViewTextBoxColumn.Visible = false;
            // 
            // pocetnakilometrazaDataGridViewTextBoxColumn
            // 
            this.pocetnakilometrazaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.pocetnakilometrazaDataGridViewTextBoxColumn.DataPropertyName = "pocetna_kilometraza";
            this.pocetnakilometrazaDataGridViewTextBoxColumn.HeaderText = "Početna kilometraža";
            this.pocetnakilometrazaDataGridViewTextBoxColumn.Name = "pocetnakilometrazaDataGridViewTextBoxColumn";
            this.pocetnakilometrazaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // zavrsnakilometrazaDataGridViewTextBoxColumn
            // 
            this.zavrsnakilometrazaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.zavrsnakilometrazaDataGridViewTextBoxColumn.DataPropertyName = "zavrsna_kilometraza";
            this.zavrsnakilometrazaDataGridViewTextBoxColumn.HeaderText = "Završna kilometraža";
            this.zavrsnakilometrazaDataGridViewTextBoxColumn.Name = "zavrsnakilometrazaDataGridViewTextBoxColumn";
            this.zavrsnakilometrazaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iznosDataGridViewTextBoxColumn
            // 
            this.iznosDataGridViewTextBoxColumn.DataPropertyName = "iznos";
            this.iznosDataGridViewTextBoxColumn.HeaderText = "Iznos";
            this.iznosDataGridViewTextBoxColumn.Name = "iznosDataGridViewTextBoxColumn";
            this.iznosDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // zaRacunBindingSource
            // 
            this.zaRacunBindingSource.DataMember = "zaRacun";
            this.zaRacunBindingSource.DataSource = this._16023_DBDataSet;
            // 
            // _16023_DBDataSet
            // 
            this._16023_DBDataSet.DataSetName = "_16023_DBDataSet";
            this._16023_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtRacunIzdao);
            this.groupBox2.Controls.Add(this.txtDatumIzdavanja);
            this.groupBox2.Controls.Add(this.txtDatumRezervacije);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(12, 106);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(266, 119);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Podaci o računu";
            // 
            // txtRacunIzdao
            // 
            this.txtRacunIzdao.Enabled = false;
            this.txtRacunIzdao.Location = new System.Drawing.Point(86, 75);
            this.txtRacunIzdao.Name = "txtRacunIzdao";
            this.txtRacunIzdao.Size = new System.Drawing.Size(174, 20);
            this.txtRacunIzdao.TabIndex = 5;
            // 
            // txtDatumIzdavanja
            // 
            this.txtDatumIzdavanja.Enabled = false;
            this.txtDatumIzdavanja.Location = new System.Drawing.Point(132, 48);
            this.txtDatumIzdavanja.Name = "txtDatumIzdavanja";
            this.txtDatumIzdavanja.Size = new System.Drawing.Size(128, 20);
            this.txtDatumIzdavanja.TabIndex = 4;
            // 
            // txtDatumRezervacije
            // 
            this.txtDatumRezervacije.Enabled = false;
            this.txtDatumRezervacije.Location = new System.Drawing.Point(132, 22);
            this.txtDatumRezervacije.Name = "txtDatumRezervacije";
            this.txtDatumRezervacije.Size = new System.Drawing.Size(128, 20);
            this.txtDatumRezervacije.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Račun izdao:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Datum izdavanja računa:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Datum rezervacije:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblIznos);
            this.groupBox3.Controls.Add(this.lblKilometraza);
            this.groupBox3.Controls.Add(this.lblTrajanje);
            this.groupBox3.Controls.Add(this.lblKlasa);
            this.groupBox3.Controls.Add(this.txtIznos);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.txtKilometri);
            this.groupBox3.Controls.Add(this.txtKlasa);
            this.groupBox3.Controls.Add(this.txtTrajanje);
            this.groupBox3.Controls.Add(this.txtPregledZaAuto);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Location = new System.Drawing.Point(284, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(541, 213);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Podaci o najmu";
            // 
            // lblIznos
            // 
            this.lblIznos.AutoSize = true;
            this.lblIznos.Location = new System.Drawing.Point(403, 182);
            this.lblIznos.Name = "lblIznos";
            this.lblIznos.Size = new System.Drawing.Size(41, 13);
            this.lblIznos.TabIndex = 15;
            this.lblIznos.Text = "label18";
            this.lblIznos.Visible = false;
            // 
            // lblKilometraza
            // 
            this.lblKilometraza.AutoSize = true;
            this.lblKilometraza.Location = new System.Drawing.Point(400, 145);
            this.lblKilometraza.Name = "lblKilometraza";
            this.lblKilometraza.Size = new System.Drawing.Size(41, 13);
            this.lblKilometraza.TabIndex = 14;
            this.lblKilometraza.Text = "label17";
            this.lblKilometraza.Visible = false;
            // 
            // lblTrajanje
            // 
            this.lblTrajanje.AutoSize = true;
            this.lblTrajanje.Location = new System.Drawing.Point(400, 104);
            this.lblTrajanje.Name = "lblTrajanje";
            this.lblTrajanje.Size = new System.Drawing.Size(41, 13);
            this.lblTrajanje.TabIndex = 13;
            this.lblTrajanje.Text = "label16";
            this.lblTrajanje.Visible = false;
            // 
            // lblKlasa
            // 
            this.lblKlasa.AutoSize = true;
            this.lblKlasa.Location = new System.Drawing.Point(403, 65);
            this.lblKlasa.Name = "lblKlasa";
            this.lblKlasa.Size = new System.Drawing.Size(41, 13);
            this.lblKlasa.TabIndex = 12;
            this.lblKlasa.Text = "label15";
            this.lblKlasa.Visible = false;
            // 
            // txtIznos
            // 
            this.txtIznos.Enabled = false;
            this.txtIznos.Location = new System.Drawing.Point(181, 176);
            this.txtIznos.Name = "txtIznos";
            this.txtIznos.Size = new System.Drawing.Size(204, 20);
            this.txtIznos.TabIndex = 11;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(400, 43);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(139, 13);
            this.label14.TabIndex = 10;
            this.label14.Text = "--------------------------------------------";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(444, 24);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(42, 13);
            this.label13.TabIndex = 9;
            this.label13.Text = "Izračun";
            // 
            // txtKilometri
            // 
            this.txtKilometri.Enabled = false;
            this.txtKilometri.Location = new System.Drawing.Point(181, 139);
            this.txtKilometri.Name = "txtKilometri";
            this.txtKilometri.Size = new System.Drawing.Size(204, 20);
            this.txtKilometri.TabIndex = 8;
            // 
            // txtKlasa
            // 
            this.txtKlasa.Enabled = false;
            this.txtKlasa.Location = new System.Drawing.Point(181, 62);
            this.txtKlasa.Name = "txtKlasa";
            this.txtKlasa.Size = new System.Drawing.Size(204, 20);
            this.txtKlasa.TabIndex = 7;
            // 
            // txtTrajanje
            // 
            this.txtTrajanje.Enabled = false;
            this.txtTrajanje.Location = new System.Drawing.Point(181, 101);
            this.txtTrajanje.Name = "txtTrajanje";
            this.txtTrajanje.Size = new System.Drawing.Size(204, 20);
            this.txtTrajanje.TabIndex = 6;
            // 
            // txtPregledZaAuto
            // 
            this.txtPregledZaAuto.Enabled = false;
            this.txtPregledZaAuto.Location = new System.Drawing.Point(181, 21);
            this.txtPregledZaAuto.Name = "txtPregledZaAuto";
            this.txtPregledZaAuto.Size = new System.Drawing.Size(204, 20);
            this.txtPregledZaAuto.TabIndex = 5;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(24, 24);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(108, 13);
            this.label12.TabIndex = 4;
            this.label12.Text = "Pregled za automobil:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(24, 179);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(97, 13);
            this.label11.TabIndex = 3;
            this.label11.Text = "Iznos za automobil:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(24, 142);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(151, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Ukupna prijeđena kilometraža:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(24, 104);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(112, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Trajanje iznajmljivanja:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 65);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Klasa automobila:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(368, 426);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "UKUPNO:";
            // 
            // txtUkupnaCijena
            // 
            this.txtUkupnaCijena.Enabled = false;
            this.txtUkupnaCijena.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.txtUkupnaCijena.Location = new System.Drawing.Point(488, 423);
            this.txtUkupnaCijena.Name = "txtUkupnaCijena";
            this.txtUkupnaCijena.Size = new System.Drawing.Size(170, 31);
            this.txtUkupnaCijena.TabIndex = 5;
            // 
            // btnIZDAJ
            // 
            this.btnIZDAJ.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnIZDAJ.Location = new System.Drawing.Point(665, 422);
            this.btnIZDAJ.Name = "btnIZDAJ";
            this.btnIZDAJ.Size = new System.Drawing.Size(160, 31);
            this.btnIZDAJ.TabIndex = 6;
            this.btnIZDAJ.Text = "IZDAJ RAČUN";
            this.btnIZDAJ.UseVisualStyleBackColor = true;
            this.btnIZDAJ.Click += new System.EventHandler(this.btnIZDAJ_Click);
            // 
            // zaRacunTableAdapter
            // 
            this.zaRacunTableAdapter.ClearBeforeFill = true;
            // 
            // IzradiRacun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 457);
            this.Controls.Add(this.btnIZDAJ);
            this.Controls.Add(this.txtUkupnaCijena);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "IzradiRacun";
            this.Text = "Izradi račun";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zaRacunBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._16023_DBDataSet)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.TextBox txtOIB;
        private System.Windows.Forms.TextBox txtUkupnaCijena;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDatumRezervacije;
        private System.Windows.Forms.TextBox txtDatumIzdavanja;
        private System.Windows.Forms.TextBox txtRacunIzdao;
        private System.Windows.Forms.Button btnIZDAJ;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtPregledZaAuto;
        private System.Windows.Forms.TextBox txtTrajanje;
        private System.Windows.Forms.TextBox txtKlasa;
        private System.Windows.Forms.TextBox txtKilometri;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtIznos;
        private System.Windows.Forms.Label lblIznos;
        private System.Windows.Forms.Label lblKilometraza;
        private System.Windows.Forms.Label lblTrajanje;
        private System.Windows.Forms.Label lblKlasa;
        private System.Windows.Forms.BindingSource zaRacunBindingSource;
        private _16023_DBDataSet _16023_DBDataSet;
        private _16023_DBDataSetTableAdapters.zaRacunTableAdapter zaRacunTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn sifraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn markaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn izvedbaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn klasaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn registracijaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn godinaproizvodnjeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumpreuzimanjaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumpovrataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusrezDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pocetnakilometrazaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zavrsnakilometrazaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iznosDataGridViewTextBoxColumn;
    }
}
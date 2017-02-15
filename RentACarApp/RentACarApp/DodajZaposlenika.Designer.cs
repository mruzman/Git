namespace RentACarApp
{
    partial class DodajZaposlenika
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
            this.cmbRola = new System.Windows.Forms.ComboBox();
            this.rolaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._16023_DBDataSet = new RentACarApp._16023_DBDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.txtAdresa = new System.Windows.Forms.TextBox();
            this.txtOIB = new System.Windows.Forms.TextBox();
            this.txtBrMob = new System.Windows.Forms.TextBox();
            this.txtKorime = new System.Windows.Forms.TextBox();
            this.txtLozinka = new System.Windows.Forms.TextBox();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.rolaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._16023_DBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbRola
            // 
            this.cmbRola.DataSource = this.rolaBindingSource;
            this.cmbRola.DisplayMember = "naziv";
            this.cmbRola.FormattingEnabled = true;
            this.cmbRola.Location = new System.Drawing.Point(94, 168);
            this.cmbRola.Name = "cmbRola";
            this.cmbRola.Size = new System.Drawing.Size(178, 21);
            this.cmbRola.TabIndex = 12;
            this.cmbRola.ValueMember = "Id";
            // 
            // rolaBindingSource
            // 
            this.rolaBindingSource.DataMember = "rola";
            this.rolaBindingSource.DataSource = this._16023_DBDataSet;
            // 
            // _16023_DBDataSet
            // 
            this._16023_DBDataSet.DataSetName = "_16023_DBDataSet";
            this._16023_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ime:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Prezime:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Adresa:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "OIB:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Rola:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Broj mobitela:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 198);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Korisničko ime:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 224);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Lozinka:";
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(94, 10);
            this.txtIme.MaxLength = 15;
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(178, 20);
            this.txtIme.TabIndex = 7;
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(94, 36);
            this.txtPrezime.MaxLength = 15;
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(178, 20);
            this.txtPrezime.TabIndex = 8;
            // 
            // txtAdresa
            // 
            this.txtAdresa.Location = new System.Drawing.Point(94, 62);
            this.txtAdresa.MaxLength = 40;
            this.txtAdresa.Name = "txtAdresa";
            this.txtAdresa.Size = new System.Drawing.Size(178, 20);
            this.txtAdresa.TabIndex = 9;
            // 
            // txtOIB
            // 
            this.txtOIB.Location = new System.Drawing.Point(94, 88);
            this.txtOIB.MaxLength = 11;
            this.txtOIB.Name = "txtOIB";
            this.txtOIB.Size = new System.Drawing.Size(178, 20);
            this.txtOIB.TabIndex = 10;
            // 
            // txtBrMob
            // 
            this.txtBrMob.Location = new System.Drawing.Point(94, 140);
            this.txtBrMob.MaxLength = 12;
            this.txtBrMob.Name = "txtBrMob";
            this.txtBrMob.Size = new System.Drawing.Size(178, 20);
            this.txtBrMob.TabIndex = 11;
            // 
            // txtKorime
            // 
            this.txtKorime.Location = new System.Drawing.Point(94, 195);
            this.txtKorime.MaxLength = 8;
            this.txtKorime.Name = "txtKorime";
            this.txtKorime.Size = new System.Drawing.Size(125, 20);
            this.txtKorime.TabIndex = 13;
            // 
            // txtLozinka
            // 
            this.txtLozinka.Location = new System.Drawing.Point(94, 221);
            this.txtLozinka.MaxLength = 8;
            this.txtLozinka.Name = "txtLozinka";
            this.txtLozinka.Size = new System.Drawing.Size(125, 20);
            this.txtLozinka.TabIndex = 14;
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(278, 88);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(113, 46);
            this.btnOdustani.TabIndex = 15;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // btnSpremi
            // 
            this.btnSpremi.Location = new System.Drawing.Point(278, 10);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(213, 72);
            this.btnSpremi.TabIndex = 16;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.UseVisualStyleBackColor = true;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(94, 114);
            this.txtEmail.MaxLength = 11;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(178, 20);
            this.txtEmail.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 117);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Email:";
            // 
            // DodajZaposlenika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 251);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.btnSpremi);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.txtLozinka);
            this.Controls.Add(this.txtKorime);
            this.Controls.Add(this.txtBrMob);
            this.Controls.Add(this.txtOIB);
            this.Controls.Add(this.txtAdresa);
            this.Controls.Add(this.txtPrezime);
            this.Controls.Add(this.txtIme);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbRola);
            this.Name = "DodajZaposlenika";
            this.Text = "DodajZaposlenika";
            this.Load += new System.EventHandler(this.DodajZaposlenika_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rolaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._16023_DBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbRola;
        private _16023_DBDataSet _16023_DBDataSet;
        private System.Windows.Forms.BindingSource rolaBindingSource;
    
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtOIB;
        private System.Windows.Forms.TextBox txtLozinka;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Button btnSpremi;
        private System.Windows.Forms.TextBox txtKorime;
        private System.Windows.Forms.TextBox txtBrMob;
        private System.Windows.Forms.TextBox txtAdresa;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label9;
    }
}
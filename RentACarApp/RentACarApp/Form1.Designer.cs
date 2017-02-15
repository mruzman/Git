namespace RentACarApp
{
    partial class Form1
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
            this.txtLozinka = new System.Windows.Forms.TextBox();
            this.txtKorIme = new System.Windows.Forms.TextBox();
            this.stsStrip1 = new System.Windows.Forms.StatusStrip();
            this.tssStrip1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.prijaviSeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izlazakToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.prijaviSeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.izlazakToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.oAplikacijiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.stsStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtLozinka
            // 
            this.txtLozinka.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtLozinka.Location = new System.Drawing.Point(55, 189);
            this.txtLozinka.MaxLength = 8;
            this.txtLozinka.Name = "txtLozinka";
            this.txtLozinka.PasswordChar = '*';
            this.txtLozinka.Size = new System.Drawing.Size(157, 30);
            this.txtLozinka.TabIndex = 1;
            this.txtLozinka.Click += new System.EventHandler(this.txtLozinka_Click);
            this.txtLozinka.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtLozinka_KeyDown);
            // 
            // txtKorIme
            // 
            this.txtKorIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtKorIme.Location = new System.Drawing.Point(55, 131);
            this.txtKorIme.MaxLength = 8;
            this.txtKorIme.Name = "txtKorIme";
            this.txtKorIme.Size = new System.Drawing.Size(157, 30);
            this.txtKorIme.TabIndex = 0;
            this.txtKorIme.Click += new System.EventHandler(this.txtKorIme_Click);
            // 
            // stsStrip1
            // 
            this.stsStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssStrip1});
            this.stsStrip1.Location = new System.Drawing.Point(0, 257);
            this.stsStrip1.Name = "stsStrip1";
            this.stsStrip1.Size = new System.Drawing.Size(281, 22);
            this.stsStrip1.TabIndex = 3;
            this.stsStrip1.Text = "statusStrip1";
            // 
            // tssStrip1
            // 
            this.tssStrip1.Name = "tssStrip1";
            this.tssStrip1.Size = new System.Drawing.Size(231, 17);
            this.tssStrip1.Text = "Dobro došli u prijavu, kliknite F1 za pomoć";
            // 
            // prijaviSeToolStripMenuItem
            // 
            this.prijaviSeToolStripMenuItem.Name = "prijaviSeToolStripMenuItem";
            this.prijaviSeToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.prijaviSeToolStripMenuItem.Text = "Prijavi se";
            // 
            // izlazakToolStripMenuItem
            // 
            this.izlazakToolStripMenuItem.Name = "izlazakToolStripMenuItem";
            this.izlazakToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.izlazakToolStripMenuItem.Text = "Izlazak";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.prijaviSeToolStripMenuItem1,
            this.oAplikacijiToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(281, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // prijaviSeToolStripMenuItem1
            // 
            this.prijaviSeToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.izlazakToolStripMenuItem1});
            this.prijaviSeToolStripMenuItem1.Name = "prijaviSeToolStripMenuItem1";
            this.prijaviSeToolStripMenuItem1.Size = new System.Drawing.Size(61, 20);
            this.prijaviSeToolStripMenuItem1.Text = "Izbornik";
            // 
            // izlazakToolStripMenuItem1
            // 
            this.izlazakToolStripMenuItem1.Name = "izlazakToolStripMenuItem1";
            this.izlazakToolStripMenuItem1.Size = new System.Drawing.Size(108, 22);
            this.izlazakToolStripMenuItem1.Text = "Izlazak";
            this.izlazakToolStripMenuItem1.Click += new System.EventHandler(this.izlazakToolStripMenuItem1_Click_1);
            // 
            // oAplikacijiToolStripMenuItem
            // 
            this.oAplikacijiToolStripMenuItem.Name = "oAplikacijiToolStripMenuItem";
            this.oAplikacijiToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.oAplikacijiToolStripMenuItem.Text = "O aplikaciji";
            this.oAplikacijiToolStripMenuItem.Click += new System.EventHandler(this.oAplikacijiToolStripMenuItem_Click);
            this.oAplikacijiToolStripMenuItem.MouseHover += new System.EventHandler(this.oAplikacijiToolStripMenuItem_MouseHover);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(12, 20);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(52, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "KORISNIČKO IME:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(52, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "LOZINKA:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::RentACarApp.Properties.Resources.rentAIntro;
            this.pictureBox1.Location = new System.Drawing.Point(55, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(157, 85);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 279);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.stsStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.txtKorIme);
            this.Controls.Add(this.txtLozinka);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Prijavi se";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.MouseHover += new System.EventHandler(this.Form1_MouseHover);
            this.stsStrip1.ResumeLayout(false);
            this.stsStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtLozinka;
        private System.Windows.Forms.TextBox txtKorIme;
        private System.Windows.Forms.ToolStripMenuItem izlazakToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prijaviSeToolStripMenuItem;
        private System.Windows.Forms.StatusStrip stsStrip1;
        private System.Windows.Forms.ToolStripMenuItem prijaviSeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem izlazakToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem oAplikacijiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripStatusLabel tssStrip1;
    }
}


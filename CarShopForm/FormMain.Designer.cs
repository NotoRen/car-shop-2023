﻿namespace CarShopForm
{
    partial class FormMain
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.toolStripMain = new System.Windows.Forms.ToolStrip();
            this.tsdShowSelected = new System.Windows.Forms.ToolStripDropDownButton();
            this.aUTOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mOTOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fURGONEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tslMarca = new System.Windows.Forms.ToolStripLabel();
            this.tstMarca = new System.Windows.Forms.ToolStripTextBox();
            this.dgvVeicoli = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtDescrizione = new System.Windows.Forms.TextBox();
            this.txtTarga = new System.Windows.Forms.TextBox();
            this.txtModello = new System.Windows.Forms.TextBox();
            this.txtColore = new System.Windows.Forms.TextBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.lblDescrizione = new System.Windows.Forms.Label();
            this.lblTarga = new System.Windows.Forms.Label();
            this.lblColore = new System.Windows.Forms.Label();
            this.lblModello = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblPrezzo = new System.Windows.Forms.Label();
            this.lblDataImmatricolazione = new System.Windows.Forms.Label();
            this.lblAlimentazione = new System.Windows.Forms.Label();
            this.numPrezzo = new System.Windows.Forms.NumericUpDown();
            this.dateImmatricolazione = new System.Windows.Forms.DateTimePicker();
            this.cmbAlimentazione = new System.Windows.Forms.ComboBox();
            this.chkAutomatica = new System.Windows.Forms.CheckBox();
            this.toolStripMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVeicoli)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPrezzo)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStripMain
            // 
            this.toolStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsdShowSelected,
            this.toolStripSeparator1,
            this.tslMarca,
            this.tstMarca});
            this.toolStripMain.Location = new System.Drawing.Point(0, 0);
            this.toolStripMain.Name = "toolStripMain";
            this.toolStripMain.Size = new System.Drawing.Size(784, 25);
            this.toolStripMain.TabIndex = 0;
            this.toolStripMain.Text = "toolStrip1";
            // 
            // tsdShowSelected
            // 
            this.tsdShowSelected.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aUTOToolStripMenuItem,
            this.mOTOToolStripMenuItem,
            this.fURGONEToolStripMenuItem});
            this.tsdShowSelected.Image = ((System.Drawing.Image)(resources.GetObject("tsdShowSelected.Image")));
            this.tsdShowSelected.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsdShowSelected.Name = "tsdShowSelected";
            this.tsdShowSelected.Size = new System.Drawing.Size(66, 22);
            this.tsdShowSelected.Text = "AUTO";
            // 
            // aUTOToolStripMenuItem
            // 
            this.aUTOToolStripMenuItem.Name = "aUTOToolStripMenuItem";
            this.aUTOToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.aUTOToolStripMenuItem.Text = "AUTO";
            this.aUTOToolStripMenuItem.Click += new System.EventHandler(this.aUTOToolStripMenuItem_Click);
            // 
            // mOTOToolStripMenuItem
            // 
            this.mOTOToolStripMenuItem.Name = "mOTOToolStripMenuItem";
            this.mOTOToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.mOTOToolStripMenuItem.Text = "MOTO";
            this.mOTOToolStripMenuItem.Click += new System.EventHandler(this.mOTOToolStripMenuItem_Click);
            // 
            // fURGONEToolStripMenuItem
            // 
            this.fURGONEToolStripMenuItem.Name = "fURGONEToolStripMenuItem";
            this.fURGONEToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.fURGONEToolStripMenuItem.Text = "FURGONE";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tslMarca
            // 
            this.tslMarca.Name = "tslMarca";
            this.tslMarca.Size = new System.Drawing.Size(43, 22);
            this.tslMarca.Text = "Marca:";
            // 
            // tstMarca
            // 
            this.tstMarca.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tstMarca.Name = "tstMarca";
            this.tstMarca.Size = new System.Drawing.Size(100, 25);
            this.tstMarca.TextChanged += new System.EventHandler(this.tstMarca_TextChanged);
            // 
            // dgvVeicoli
            // 
            this.dgvVeicoli.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVeicoli.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvVeicoli.Location = new System.Drawing.Point(0, 25);
            this.dgvVeicoli.MultiSelect = false;
            this.dgvVeicoli.Name = "dgvVeicoli";
            this.dgvVeicoli.ReadOnly = true;
            this.dgvVeicoli.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVeicoli.Size = new System.Drawing.Size(784, 228);
            this.dgvVeicoli.TabIndex = 1;
            this.dgvVeicoli.SelectionChanged += new System.EventHandler(this.dgvVeicoli_SelectionChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkAutomatica);
            this.groupBox1.Controls.Add(this.cmbAlimentazione);
            this.groupBox1.Controls.Add(this.dateImmatricolazione);
            this.groupBox1.Controls.Add(this.numPrezzo);
            this.groupBox1.Controls.Add(this.lblPrezzo);
            this.groupBox1.Controls.Add(this.lblDataImmatricolazione);
            this.groupBox1.Controls.Add(this.lblAlimentazione);
            this.groupBox1.Controls.Add(this.txtDescrizione);
            this.groupBox1.Controls.Add(this.txtTarga);
            this.groupBox1.Controls.Add(this.txtModello);
            this.groupBox1.Controls.Add(this.txtColore);
            this.groupBox1.Controls.Add(this.txtMarca);
            this.groupBox1.Controls.Add(this.lblDescrizione);
            this.groupBox1.Controls.Add(this.lblTarga);
            this.groupBox1.Controls.Add(this.lblColore);
            this.groupBox1.Controls.Add(this.lblModello);
            this.groupBox1.Controls.Add(this.lblMarca);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 253);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(784, 281);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Veicolo";
            // 
            // txtDescrizione
            // 
            this.txtDescrizione.Location = new System.Drawing.Point(74, 108);
            this.txtDescrizione.Multiline = true;
            this.txtDescrizione.Name = "txtDescrizione";
            this.txtDescrizione.Size = new System.Drawing.Size(245, 82);
            this.txtDescrizione.TabIndex = 9;
            // 
            // txtTarga
            // 
            this.txtTarga.Location = new System.Drawing.Point(219, 61);
            this.txtTarga.Name = "txtTarga";
            this.txtTarga.Size = new System.Drawing.Size(100, 20);
            this.txtTarga.TabIndex = 8;
            // 
            // txtModello
            // 
            this.txtModello.Location = new System.Drawing.Point(56, 61);
            this.txtModello.Name = "txtModello";
            this.txtModello.Size = new System.Drawing.Size(100, 20);
            this.txtModello.TabIndex = 7;
            // 
            // txtColore
            // 
            this.txtColore.Location = new System.Drawing.Point(219, 23);
            this.txtColore.Name = "txtColore";
            this.txtColore.Size = new System.Drawing.Size(100, 20);
            this.txtColore.TabIndex = 6;
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(56, 23);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(100, 20);
            this.txtMarca.TabIndex = 5;
            // 
            // lblDescrizione
            // 
            this.lblDescrizione.AutoSize = true;
            this.lblDescrizione.Location = new System.Drawing.Point(6, 108);
            this.lblDescrizione.Name = "lblDescrizione";
            this.lblDescrizione.Size = new System.Drawing.Size(62, 13);
            this.lblDescrizione.TabIndex = 4;
            this.lblDescrizione.Text = "Descrizione";
            // 
            // lblTarga
            // 
            this.lblTarga.AutoSize = true;
            this.lblTarga.Location = new System.Drawing.Point(176, 64);
            this.lblTarga.Name = "lblTarga";
            this.lblTarga.Size = new System.Drawing.Size(35, 13);
            this.lblTarga.TabIndex = 3;
            this.lblTarga.Text = "Targa";
            // 
            // lblColore
            // 
            this.lblColore.AutoSize = true;
            this.lblColore.Location = new System.Drawing.Point(176, 27);
            this.lblColore.Name = "lblColore";
            this.lblColore.Size = new System.Drawing.Size(37, 13);
            this.lblColore.TabIndex = 2;
            this.lblColore.Text = "Colore";
            // 
            // lblModello
            // 
            this.lblModello.AutoSize = true;
            this.lblModello.Location = new System.Drawing.Point(3, 64);
            this.lblModello.Name = "lblModello";
            this.lblModello.Size = new System.Drawing.Size(44, 13);
            this.lblModello.TabIndex = 1;
            this.lblModello.Text = "Modello";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(3, 27);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(37, 13);
            this.lblMarca.TabIndex = 0;
            this.lblMarca.Text = "Marca";
            // 
            // lblPrezzo
            // 
            this.lblPrezzo.AutoSize = true;
            this.lblPrezzo.Location = new System.Drawing.Point(341, 25);
            this.lblPrezzo.Name = "lblPrezzo";
            this.lblPrezzo.Size = new System.Drawing.Size(39, 13);
            this.lblPrezzo.TabIndex = 3;
            this.lblPrezzo.Text = "Prezzo";
            // 
            // lblDataImmatricolazione
            // 
            this.lblDataImmatricolazione.AutoSize = true;
            this.lblDataImmatricolazione.Location = new System.Drawing.Point(341, 64);
            this.lblDataImmatricolazione.Name = "lblDataImmatricolazione";
            this.lblDataImmatricolazione.Size = new System.Drawing.Size(111, 13);
            this.lblDataImmatricolazione.TabIndex = 4;
            this.lblDataImmatricolazione.Text = "Data Immatricolazione";
            // 
            // lblAlimentazione
            // 
            this.lblAlimentazione.AutoSize = true;
            this.lblAlimentazione.Location = new System.Drawing.Point(341, 128);
            this.lblAlimentazione.Name = "lblAlimentazione";
            this.lblAlimentazione.Size = new System.Drawing.Size(72, 13);
            this.lblAlimentazione.TabIndex = 5;
            this.lblAlimentazione.Text = "Alimentazione";
            // 
            // numPrezzo
            // 
            this.numPrezzo.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numPrezzo.Location = new System.Drawing.Point(386, 23);
            this.numPrezzo.Maximum = new decimal(new int[] {
            200000,
            0,
            0,
            0});
            this.numPrezzo.Name = "numPrezzo";
            this.numPrezzo.Size = new System.Drawing.Size(79, 20);
            this.numPrezzo.TabIndex = 10;
            // 
            // dateImmatricolazione
            // 
            this.dateImmatricolazione.Location = new System.Drawing.Point(342, 80);
            this.dateImmatricolazione.Name = "dateImmatricolazione";
            this.dateImmatricolazione.Size = new System.Drawing.Size(200, 20);
            this.dateImmatricolazione.TabIndex = 11;
            // 
            // cmbAlimentazione
            // 
            this.cmbAlimentazione.FormattingEnabled = true;
            this.cmbAlimentazione.Items.AddRange(new object[] {
            "Benzina",
            "Diesel",
            "Elettrica",
            "Ibrida",
            "GPL",
            "Metano"});
            this.cmbAlimentazione.Location = new System.Drawing.Point(417, 125);
            this.cmbAlimentazione.Name = "cmbAlimentazione";
            this.cmbAlimentazione.Size = new System.Drawing.Size(125, 21);
            this.cmbAlimentazione.TabIndex = 12;
            // 
            // chkAutomatica
            // 
            this.chkAutomatica.AutoSize = true;
            this.chkAutomatica.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkAutomatica.Location = new System.Drawing.Point(446, 173);
            this.chkAutomatica.Name = "chkAutomatica";
            this.chkAutomatica.Size = new System.Drawing.Size(96, 17);
            this.chkAutomatica.TabIndex = 13;
            this.chkAutomatica.Text = "AUTOMATICA";
            this.chkAutomatica.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 534);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvVeicoli);
            this.Controls.Add(this.toolStripMain);
            this.Name = "FormMain";
            this.Text = "RIVENDITA VEICOLI VALLAURI";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.toolStripMain.ResumeLayout(false);
            this.toolStripMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVeicoli)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPrezzo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStripMain;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel tslMarca;
        private System.Windows.Forms.ToolStripTextBox tstMarca;
        private System.Windows.Forms.DataGridView dgvVeicoli;
        private System.Windows.Forms.ToolStripDropDownButton tsdShowSelected;
        private System.Windows.Forms.ToolStripMenuItem aUTOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mOTOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fURGONEToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtDescrizione;
        private System.Windows.Forms.TextBox txtTarga;
        private System.Windows.Forms.TextBox txtModello;
        private System.Windows.Forms.TextBox txtColore;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Label lblDescrizione;
        private System.Windows.Forms.Label lblTarga;
        private System.Windows.Forms.Label lblColore;
        private System.Windows.Forms.Label lblModello;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.CheckBox chkAutomatica;
        private System.Windows.Forms.ComboBox cmbAlimentazione;
        private System.Windows.Forms.DateTimePicker dateImmatricolazione;
        private System.Windows.Forms.NumericUpDown numPrezzo;
        private System.Windows.Forms.Label lblPrezzo;
        private System.Windows.Forms.Label lblDataImmatricolazione;
        private System.Windows.Forms.Label lblAlimentazione;
    }
}


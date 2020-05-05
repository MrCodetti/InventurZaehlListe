namespace InventurZaehlListe
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.lstArtikel = new System.Windows.Forms.ListView();
            this.gbArtikel = new System.Windows.Forms.GroupBox();
            this.gbSortieren = new System.Windows.Forms.GroupBox();
            this.cohArtNr = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cohBezeichnung = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cohLagerort = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cohEinkauf = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cohIstStand = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cohSollStand = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cohInvDiff = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblArtBez = new System.Windows.Forms.Label();
            this.lblLagerort = new System.Windows.Forms.Label();
            this.lblEinPreis = new System.Windows.Forms.Label();
            this.lblIstSt = new System.Windows.Forms.Label();
            this.lblSollSt = new System.Windows.Forms.Label();
            this.txbLagerort = new System.Windows.Forms.TextBox();
            this.txbEinkauf = new System.Windows.Forms.TextBox();
            this.txbIst = new System.Windows.Forms.TextBox();
            this.txbSoll = new System.Windows.Forms.TextBox();
            this.btnHinzufugen = new System.Windows.Forms.Button();
            this.rdbBezeichnung = new System.Windows.Forms.RadioButton();
            this.rdbLagerort = new System.Windows.Forms.RadioButton();
            this.txbArtBez = new System.Windows.Forms.TextBox();
            this.rdbUnsort = new System.Windows.Forms.RadioButton();
            this.gbArtikel.SuspendLayout();
            this.gbSortieren.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstArtikel
            // 
            this.lstArtikel.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cohArtNr,
            this.cohBezeichnung,
            this.cohLagerort,
            this.cohEinkauf,
            this.cohIstStand,
            this.cohSollStand,
            this.cohInvDiff});
            this.lstArtikel.GridLines = true;
            this.lstArtikel.HideSelection = false;
            this.lstArtikel.Location = new System.Drawing.Point(12, 12);
            this.lstArtikel.Name = "lstArtikel";
            this.lstArtikel.Size = new System.Drawing.Size(625, 343);
            this.lstArtikel.TabIndex = 0;
            this.lstArtikel.UseCompatibleStateImageBehavior = false;
            this.lstArtikel.View = System.Windows.Forms.View.Details;
            // 
            // gbArtikel
            // 
            this.gbArtikel.Controls.Add(this.txbArtBez);
            this.gbArtikel.Controls.Add(this.btnHinzufugen);
            this.gbArtikel.Controls.Add(this.txbSoll);
            this.gbArtikel.Controls.Add(this.txbIst);
            this.gbArtikel.Controls.Add(this.txbEinkauf);
            this.gbArtikel.Controls.Add(this.txbLagerort);
            this.gbArtikel.Controls.Add(this.lblSollSt);
            this.gbArtikel.Controls.Add(this.lblIstSt);
            this.gbArtikel.Controls.Add(this.lblEinPreis);
            this.gbArtikel.Controls.Add(this.lblLagerort);
            this.gbArtikel.Controls.Add(this.lblArtBez);
            this.gbArtikel.Location = new System.Drawing.Point(12, 361);
            this.gbArtikel.Name = "gbArtikel";
            this.gbArtikel.Size = new System.Drawing.Size(476, 146);
            this.gbArtikel.TabIndex = 1;
            this.gbArtikel.TabStop = false;
            this.gbArtikel.Text = "Artikel eingabe";
            // 
            // gbSortieren
            // 
            this.gbSortieren.Controls.Add(this.rdbUnsort);
            this.gbSortieren.Controls.Add(this.rdbLagerort);
            this.gbSortieren.Controls.Add(this.rdbBezeichnung);
            this.gbSortieren.Location = new System.Drawing.Point(494, 361);
            this.gbSortieren.Name = "gbSortieren";
            this.gbSortieren.Size = new System.Drawing.Size(143, 146);
            this.gbSortieren.TabIndex = 2;
            this.gbSortieren.TabStop = false;
            this.gbSortieren.Text = "Sortieren";
            // 
            // cohArtNr
            // 
            this.cohArtNr.Text = "Artikel Nr.";
            // 
            // cohBezeichnung
            // 
            this.cohBezeichnung.Text = "Art. Bezeichnung";
            this.cohBezeichnung.Width = 150;
            // 
            // cohLagerort
            // 
            this.cohLagerort.Text = "Lagerort";
            this.cohLagerort.Width = 100;
            // 
            // cohEinkauf
            // 
            this.cohEinkauf.Text = "Einkaufspreis";
            this.cohEinkauf.Width = 90;
            // 
            // cohIstStand
            // 
            this.cohIstStand.Text = "Ist-Stand";
            // 
            // cohSollStand
            // 
            this.cohSollStand.Text = "Soll-Stand";
            // 
            // cohInvDiff
            // 
            this.cohInvDiff.Text = "Inventurdifferenz";
            this.cohInvDiff.Width = 100;
            // 
            // lblArtBez
            // 
            this.lblArtBez.AutoSize = true;
            this.lblArtBez.Location = new System.Drawing.Point(13, 23);
            this.lblArtBez.Name = "lblArtBez";
            this.lblArtBez.Size = new System.Drawing.Size(104, 13);
            this.lblArtBez.TabIndex = 0;
            this.lblArtBez.Text = "Artikel Bezeichnung:";
            // 
            // lblLagerort
            // 
            this.lblLagerort.AutoSize = true;
            this.lblLagerort.Location = new System.Drawing.Point(40, 54);
            this.lblLagerort.Name = "lblLagerort";
            this.lblLagerort.Size = new System.Drawing.Size(49, 13);
            this.lblLagerort.TabIndex = 1;
            this.lblLagerort.Text = "Lagerort:";
            // 
            // lblEinPreis
            // 
            this.lblEinPreis.AutoSize = true;
            this.lblEinPreis.Location = new System.Drawing.Point(16, 87);
            this.lblEinPreis.Name = "lblEinPreis";
            this.lblEinPreis.Size = new System.Drawing.Size(73, 13);
            this.lblEinPreis.TabIndex = 2;
            this.lblEinPreis.Text = "Einkaufspreis:";
            // 
            // lblIstSt
            // 
            this.lblIstSt.AutoSize = true;
            this.lblIstSt.Location = new System.Drawing.Point(37, 121);
            this.lblIstSt.Name = "lblIstSt";
            this.lblIstSt.Size = new System.Drawing.Size(52, 13);
            this.lblIstSt.TabIndex = 3;
            this.lblIstSt.Text = "Ist-Stand:";
            // 
            // lblSollSt
            // 
            this.lblSollSt.AutoSize = true;
            this.lblSollSt.Location = new System.Drawing.Point(322, 23);
            this.lblSollSt.Name = "lblSollSt";
            this.lblSollSt.Size = new System.Drawing.Size(58, 13);
            this.lblSollSt.TabIndex = 4;
            this.lblSollSt.Text = "Soll-Stand:";
            // 
            // txbLagerort
            // 
            this.txbLagerort.Location = new System.Drawing.Point(123, 51);
            this.txbLagerort.Name = "txbLagerort";
            this.txbLagerort.Size = new System.Drawing.Size(141, 20);
            this.txbLagerort.TabIndex = 6;
            // 
            // txbEinkauf
            // 
            this.txbEinkauf.Location = new System.Drawing.Point(123, 84);
            this.txbEinkauf.Name = "txbEinkauf";
            this.txbEinkauf.Size = new System.Drawing.Size(73, 20);
            this.txbEinkauf.TabIndex = 7;
            // 
            // txbIst
            // 
            this.txbIst.Location = new System.Drawing.Point(123, 118);
            this.txbIst.Name = "txbIst";
            this.txbIst.Size = new System.Drawing.Size(73, 20);
            this.txbIst.TabIndex = 8;
            // 
            // txbSoll
            // 
            this.txbSoll.Location = new System.Drawing.Point(386, 20);
            this.txbSoll.Name = "txbSoll";
            this.txbSoll.Size = new System.Drawing.Size(73, 20);
            this.txbSoll.TabIndex = 9;
            // 
            // btnHinzufugen
            // 
            this.btnHinzufugen.Location = new System.Drawing.Point(363, 106);
            this.btnHinzufugen.Name = "btnHinzufugen";
            this.btnHinzufugen.Size = new System.Drawing.Size(96, 28);
            this.btnHinzufugen.TabIndex = 11;
            this.btnHinzufugen.Text = "Hinzufügen";
            this.btnHinzufugen.UseVisualStyleBackColor = true;
            this.btnHinzufugen.Click += new System.EventHandler(this.btnHinzufugen_Click);
            // 
            // rdbBezeichnung
            // 
            this.rdbBezeichnung.AutoSize = true;
            this.rdbBezeichnung.Location = new System.Drawing.Point(15, 68);
            this.rdbBezeichnung.Name = "rdbBezeichnung";
            this.rdbBezeichnung.Size = new System.Drawing.Size(114, 17);
            this.rdbBezeichnung.TabIndex = 0;
            this.rdbBezeichnung.Text = "nach Bezeichnung";
            this.rdbBezeichnung.UseVisualStyleBackColor = true;
            this.rdbBezeichnung.CheckedChanged += new System.EventHandler(this.rdbRadiobuttons_CheckedChanged);
            // 
            // rdbLagerort
            // 
            this.rdbLagerort.AutoSize = true;
            this.rdbLagerort.Location = new System.Drawing.Point(15, 101);
            this.rdbLagerort.Name = "rdbLagerort";
            this.rdbLagerort.Size = new System.Drawing.Size(91, 17);
            this.rdbLagerort.TabIndex = 1;
            this.rdbLagerort.Text = "nach Lagerort";
            this.rdbLagerort.UseVisualStyleBackColor = true;
            this.rdbLagerort.CheckedChanged += new System.EventHandler(this.rdbRadiobuttons_CheckedChanged);
            // 
            // txbArtBez
            // 
            this.txbArtBez.Location = new System.Drawing.Point(123, 20);
            this.txbArtBez.Name = "txbArtBez";
            this.txbArtBez.Size = new System.Drawing.Size(113, 20);
            this.txbArtBez.TabIndex = 12;
            // 
            // rdbUnsort
            // 
            this.rdbUnsort.AutoSize = true;
            this.rdbUnsort.Checked = true;
            this.rdbUnsort.Location = new System.Drawing.Point(15, 36);
            this.rdbUnsort.Name = "rdbUnsort";
            this.rdbUnsort.Size = new System.Drawing.Size(68, 17);
            this.rdbUnsort.TabIndex = 2;
            this.rdbUnsort.TabStop = true;
            this.rdbUnsort.Text = "unsortiert";
            this.rdbUnsort.UseVisualStyleBackColor = true;
            this.rdbUnsort.CheckedChanged += new System.EventHandler(this.rdbRadiobuttons_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 518);
            this.Controls.Add(this.gbSortieren);
            this.Controls.Add(this.gbArtikel);
            this.Controls.Add(this.lstArtikel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbArtikel.ResumeLayout(false);
            this.gbArtikel.PerformLayout();
            this.gbSortieren.ResumeLayout(false);
            this.gbSortieren.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lstArtikel;
        private System.Windows.Forms.ColumnHeader cohArtNr;
        private System.Windows.Forms.ColumnHeader cohBezeichnung;
        private System.Windows.Forms.ColumnHeader cohLagerort;
        private System.Windows.Forms.ColumnHeader cohEinkauf;
        private System.Windows.Forms.ColumnHeader cohIstStand;
        private System.Windows.Forms.ColumnHeader cohSollStand;
        private System.Windows.Forms.ColumnHeader cohInvDiff;
        private System.Windows.Forms.GroupBox gbArtikel;
        private System.Windows.Forms.TextBox txbArtBez;
        private System.Windows.Forms.Button btnHinzufugen;
        private System.Windows.Forms.TextBox txbSoll;
        private System.Windows.Forms.TextBox txbIst;
        private System.Windows.Forms.TextBox txbEinkauf;
        private System.Windows.Forms.TextBox txbLagerort;
        private System.Windows.Forms.Label lblSollSt;
        private System.Windows.Forms.Label lblIstSt;
        private System.Windows.Forms.Label lblEinPreis;
        private System.Windows.Forms.Label lblLagerort;
        private System.Windows.Forms.Label lblArtBez;
        private System.Windows.Forms.GroupBox gbSortieren;
        private System.Windows.Forms.RadioButton rdbLagerort;
        private System.Windows.Forms.RadioButton rdbBezeichnung;
        private System.Windows.Forms.RadioButton rdbUnsort;
    }
}


namespace gestione_libreria
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnCarica = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.lblCodice = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblAutore = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblTitolo = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnCancella = new System.Windows.Forms.Button();
            this.listBoxRicerca = new System.Windows.Forms.ListBox();
            this.btnRicerca = new System.Windows.Forms.Button();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButtonAutore = new System.Windows.Forms.RadioButton();
            this.radioButtonTitolo = new System.Windows.Forms.RadioButton();
            this.lblRicerca = new System.Windows.Forms.Label();
            this.txtRicerca = new System.Windows.Forms.TextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btnDraw = new System.Windows.Forms.Button();
            this.lsbTotale = new System.Windows.Forms.ListBox();
            this.btnSalvataggio = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(38, 41);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(788, 371);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnCarica);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(780, 342);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Carica da FILE";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnCarica
            // 
            this.btnCarica.Location = new System.Drawing.Point(224, 113);
            this.btnCarica.Name = "btnCarica";
            this.btnCarica.Size = new System.Drawing.Size(319, 136);
            this.btnCarica.TabIndex = 0;
            this.btnCarica.Text = "Carica da FILE";
            this.btnCarica.UseVisualStyleBackColor = true;
            this.btnCarica.Click += new System.EventHandler(this.btnCarica_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.textBox3);
            this.tabPage2.Controls.Add(this.lblCodice);
            this.tabPage2.Controls.Add(this.textBox2);
            this.tabPage2.Controls.Add(this.lblAutore);
            this.tabPage2.Controls.Add(this.textBox1);
            this.tabPage2.Controls.Add(this.lblTitolo);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(780, 342);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Inserisci";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(258, 209);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 60);
            this.button1.TabIndex = 6;
            this.button1.Text = "INSERISCI";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(475, 118);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 5;
            // 
            // lblCodice
            // 
            this.lblCodice.AutoSize = true;
            this.lblCodice.Location = new System.Drawing.Point(472, 78);
            this.lblCodice.Name = "lblCodice";
            this.lblCodice.Size = new System.Drawing.Size(51, 17);
            this.lblCodice.TabIndex = 4;
            this.lblCodice.Text = "Codice";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(272, 118);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 3;
            // 
            // lblAutore
            // 
            this.lblAutore.AutoSize = true;
            this.lblAutore.Location = new System.Drawing.Point(269, 78);
            this.lblAutore.Name = "lblAutore";
            this.lblAutore.Size = new System.Drawing.Size(50, 17);
            this.lblAutore.TabIndex = 2;
            this.lblAutore.Text = "Autore";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(83, 118);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 1;
            // 
            // lblTitolo
            // 
            this.lblTitolo.AutoSize = true;
            this.lblTitolo.Location = new System.Drawing.Point(80, 78);
            this.lblTitolo.Name = "lblTitolo";
            this.lblTitolo.Size = new System.Drawing.Size(43, 17);
            this.lblTitolo.TabIndex = 0;
            this.lblTitolo.Text = "Titolo";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnCancella);
            this.tabPage3.Controls.Add(this.listBoxRicerca);
            this.tabPage3.Controls.Add(this.btnRicerca);
            this.tabPage3.Controls.Add(this.radioButton3);
            this.tabPage3.Controls.Add(this.radioButtonAutore);
            this.tabPage3.Controls.Add(this.radioButtonTitolo);
            this.tabPage3.Controls.Add(this.lblRicerca);
            this.tabPage3.Controls.Add(this.txtRicerca);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(780, 342);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Ricerca";
            this.tabPage3.UseVisualStyleBackColor = true;
            this.tabPage3.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // btnCancella
            // 
            this.btnCancella.Location = new System.Drawing.Point(572, 271);
            this.btnCancella.Name = "btnCancella";
            this.btnCancella.Size = new System.Drawing.Size(150, 41);
            this.btnCancella.TabIndex = 7;
            this.btnCancella.Text = "Elimina";
            this.btnCancella.UseVisualStyleBackColor = true;
            // 
            // listBoxRicerca
            // 
            this.listBoxRicerca.FormattingEnabled = true;
            this.listBoxRicerca.ItemHeight = 16;
            this.listBoxRicerca.Items.AddRange(new object[] {
            "Lista dei libri ricercati:"});
            this.listBoxRicerca.Location = new System.Drawing.Point(31, 228);
            this.listBoxRicerca.Name = "listBoxRicerca";
            this.listBoxRicerca.Size = new System.Drawing.Size(393, 84);
            this.listBoxRicerca.TabIndex = 6;
            // 
            // btnRicerca
            // 
            this.btnRicerca.Location = new System.Drawing.Point(214, 154);
            this.btnRicerca.Name = "btnRicerca";
            this.btnRicerca.Size = new System.Drawing.Size(150, 41);
            this.btnRicerca.TabIndex = 5;
            this.btnRicerca.Text = "Cerca";
            this.btnRicerca.UseVisualStyleBackColor = true;
            this.btnRicerca.Click += new System.EventHandler(this.btnRicerca_Click);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(434, 111);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(149, 21);
            this.radioButton3.TabIndex = 4;
            this.radioButton3.Text = "Ricerca per Codice";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButtonAutore
            // 
            this.radioButtonAutore.AutoSize = true;
            this.radioButtonAutore.Location = new System.Drawing.Point(434, 75);
            this.radioButtonAutore.Name = "radioButtonAutore";
            this.radioButtonAutore.Size = new System.Drawing.Size(148, 21);
            this.radioButtonAutore.TabIndex = 3;
            this.radioButtonAutore.Text = "Ricerca per Autore";
            this.radioButtonAutore.UseVisualStyleBackColor = true;
            // 
            // radioButtonTitolo
            // 
            this.radioButtonTitolo.AutoSize = true;
            this.radioButtonTitolo.Checked = true;
            this.radioButtonTitolo.Location = new System.Drawing.Point(434, 42);
            this.radioButtonTitolo.Name = "radioButtonTitolo";
            this.radioButtonTitolo.Size = new System.Drawing.Size(141, 21);
            this.radioButtonTitolo.TabIndex = 2;
            this.radioButtonTitolo.TabStop = true;
            this.radioButtonTitolo.Text = "Ricerca per Titolo";
            this.radioButtonTitolo.UseVisualStyleBackColor = true;
            // 
            // lblRicerca
            // 
            this.lblRicerca.AutoSize = true;
            this.lblRicerca.Location = new System.Drawing.Point(28, 42);
            this.lblRicerca.Name = "lblRicerca";
            this.lblRicerca.Size = new System.Drawing.Size(176, 17);
            this.lblRicerca.TabIndex = 1;
            this.lblRicerca.Text = "Inserisci il libro da cercare:";
            // 
            // txtRicerca
            // 
            this.txtRicerca.Location = new System.Drawing.Point(31, 74);
            this.txtRicerca.Name = "txtRicerca";
            this.txtRicerca.Size = new System.Drawing.Size(311, 22);
            this.txtRicerca.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.btnDraw);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(780, 342);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Disegna";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // btnDraw
            // 
            this.btnDraw.Location = new System.Drawing.Point(315, 151);
            this.btnDraw.Name = "btnDraw";
            this.btnDraw.Size = new System.Drawing.Size(150, 41);
            this.btnDraw.TabIndex = 6;
            this.btnDraw.Text = "Disegna";
            this.btnDraw.UseVisualStyleBackColor = true;
            this.btnDraw.Click += new System.EventHandler(this.btnDraw_Click);
            // 
            // lsbTotale
            // 
            this.lsbTotale.FormattingEnabled = true;
            this.lsbTotale.ItemHeight = 16;
            this.lsbTotale.Items.AddRange(new object[] {
            "Lista LIBRI:"});
            this.lsbTotale.Location = new System.Drawing.Point(968, 66);
            this.lsbTotale.Name = "lsbTotale";
            this.lsbTotale.Size = new System.Drawing.Size(446, 340);
            this.lsbTotale.TabIndex = 1;
            // 
            // btnSalvataggio
            // 
            this.btnSalvataggio.Location = new System.Drawing.Point(216, 451);
            this.btnSalvataggio.Name = "btnSalvataggio";
            this.btnSalvataggio.Size = new System.Drawing.Size(155, 60);
            this.btnSalvataggio.TabIndex = 7;
            this.btnSalvataggio.Text = "Salva su FILE";
            this.btnSalvataggio.UseVisualStyleBackColor = true;
            this.btnSalvataggio.Click += new System.EventHandler(this.btnSalvataggio_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1442, 566);
            this.Controls.Add(this.btnSalvataggio);
            this.Controls.Add(this.lsbTotale);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Gestione Libreria";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnCarica;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ListBox lsbTotale;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label lblCodice;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblAutore;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblTitolo;
        private System.Windows.Forms.Button btnSalvataggio;
        private System.Windows.Forms.RadioButton radioButtonTitolo;
        private System.Windows.Forms.Label lblRicerca;
        private System.Windows.Forms.TextBox txtRicerca;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButtonAutore;
        private System.Windows.Forms.Button btnCancella;
        private System.Windows.Forms.ListBox listBoxRicerca;
        private System.Windows.Forms.Button btnRicerca;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button btnDraw;
    }
}


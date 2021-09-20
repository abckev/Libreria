using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace gestione_libreria
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        struct libro
        {
            public string titolo;
            public string autore;
            public string codice;
        }
        
        static int num_elementi = 30;
        libro[] db = new libro[num_elementi];
        static int i = 0;
        private void btnCarica_Click(object sender, EventArgs e)
        {
            OpenFileDialog apri = new OpenFileDialog();
            apri.Filter = "file di testo|*txt";
            if (apri.ShowDialog() == DialogResult.OK)
            {
                StreamReader leggi = new StreamReader(apri.FileName);
                string lettura = leggi.ReadLine();
                while(lettura != null)
                {
                    string[] letto = lettura.Split('-');
                    db[i].titolo = letto[0];
                    db[i].autore = letto[1];
                    db[i].codice = letto[2];
                    lsbTotale.Items.Add(lettura);
                    i++;
                    lettura = leggi.ReadLine();
                }
                leggi.Close();
            }
            else
                MessageBox.Show("Non hai selezionato nessun file");
            apri.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "")
            {
                db[i].titolo = textBox1.Text;
                db[i].autore = textBox2.Text;
                db[i].codice = textBox3.Text;
                i++;
                lsbTotale.Items.Add(textBox1.Text + '-' + textBox2.Text + '-' + textBox3.Text);
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox1.Focus();
            }
            else
                MessageBox.Show("Non hai inserito tutti i campi");
        }

        private void btnSalvataggio_Click(object sender, EventArgs e)
        {
            SaveFileDialog chiudi = new SaveFileDialog();
            chiudi.Filter = "file di testo|*txt";
            if (chiudi.ShowDialog() == DialogResult.OK)
            {
                StreamWriter scrivi = new StreamWriter(chiudi.FileName);
                for(int j = 0; j < i; j++)
                {
                    scrivi.WriteLine(db[j].titolo + '-' + db[j].autore + '-' + db[j].codice);
                }
                scrivi.Close();
            }
            else
                MessageBox.Show("Non hai selezionato nessun file per salvare i dati");
            chiudi.Dispose();
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void btnRicerca_Click(object sender, EventArgs e)
        {
            
            if (txtRicerca.Text != "")
            {
                if (radioButtonTitolo.Checked)
                {
                    for(int j = 0; j < i; j++)
                    {
                        if(db[j].titolo == txtRicerca.Text)
                        {
                            listBoxRicerca.Items.Add(db[j].titolo + '-' + db[j].autore + '-' + db[j].codice);
                        }
                    }
                }
                else
                    if (radioButtonAutore.Checked)
                    {
                    for (int j = 0; j < i; j++)
                    {
                        if (db[j].autore == txtRicerca.Text)
                        {
                            listBoxRicerca.Items.Add(db[j].titolo + '-' + db[j].autore + '-' + db[j].codice);
                        }
                    }
                }
                else
                    for (int j = 0; j < i; j++)
                    {
                        if (db[j].codice == txtRicerca.Text)
                        {
                            listBoxRicerca.Items.Add(db[j].titolo + '-' + db[j].autore + '-' + db[j].codice);
                        }
                    }
                if(listBoxRicerca.Items.Count > 0)
                {
                    btnCancella.Enabled = true;
                }
            }
            else
                MessageBox.Show("Non hai inserito tutti i campi");

            txtRicerca.Clear();
        }

        private void btnCancella_Click(object sender, EventArgs e)
        {
        //    Array.Clear(db, 0, i);
        //    lsbTotale.Items.Remove(listBoxRicerca.SelectedItem);
        //    for (int j = 0; j < lsbTotale.Items.Count; j++)
        //    {
        //        string prova = lsbTotale.Items[j].ToString();
        //        string[] dividi = prova.Split('-');
        //        db[j].titolo = dividi[0];
        //        db[j].autore = dividi[1];
        //        db[j].codice = dividi[2]; 
        //    }
        //    i = lsbTotale.Items.Count;
        //    listBoxRicerca.Items.Remove(listBoxRicerca.SelectedItem);
        }

        private void btnDraw_Click(object sender, EventArgs e)
        {
            FormMain secondo = new FormMain();
            secondo.Show();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

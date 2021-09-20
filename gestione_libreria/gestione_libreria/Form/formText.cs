using gestione_libreria.Observer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gestione_libreria
{
    public partial class formText : Form, IObserver
    {
        public formText()
        {
            InitializeComponent();
        }

        // Metodo ereditato dalla classe IObserver
        public void Update(int count)
        {
            setText(count);
        }

        // Conta il numero di interazioni sul pulsante inc/dec
        private void setText(int count)
        {
            label1.Text = count.ToString();
        }

        private void formText_Load(object sender, EventArgs e)
        {

        }
    }
}
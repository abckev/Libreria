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
    public partial class FormMain : Form
    {
        private Counter counter;
        public FormMain()
        {
            counter = new Counter();
            InitializeComponent();

            //text
            formText frmText = new formText();
            frmText.Show();
            counter.RegisterObserver(frmText);

            //rectangle
            formRectangle frmRec = new formRectangle();
            frmRec.Show();
            counter.RegisterObserver(frmRec);

            //circle
            formCircle frmCirc = new formCircle();
            frmCirc.Show();
            counter.RegisterObserver(frmCirc);
        }


        private void FormMain_Load_1(object sender, EventArgs e)
        {

        }

        private void btnDec_Click(object sender, EventArgs e)
        {
            counter.Decrement();
        }

        private void btnInc_Click(object sender, EventArgs e)
        {
            counter.Increment();
        }
    }
}
using gestione_libreria;
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
    public partial class formCircle : Form, IObserver
    {
        public formCircle()
        {
            InitializeComponent();
        }

        public void Update(int count)
        {
            updateCircle(count);
        }

        private void updateCircle(int count)
        {
            this.CreateGraphics().Clear(this.BackColor);
            Graphics g = this.CreateGraphics();
            Pen pen = new Pen(Color.Red);
            g.DrawEllipse(pen, 10, 10, count * 10, count * 10);
        }

        private void formCircle_Load(object sender, EventArgs e)
        {

        }

        private void formCircle_Load_1(object sender, EventArgs e)
        {

        }
    }
}

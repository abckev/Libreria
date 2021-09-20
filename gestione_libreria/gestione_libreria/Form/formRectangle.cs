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
    public partial class formRectangle : Form, IObserver
    {
        public formRectangle()
        {
            InitializeComponent();
        }

        public void Update(int count)
        {
            updateRectangle(count);
        }

        private void updateRectangle(int count)
        {
            this.CreateGraphics().Clear(this.BackColor);
            System.Drawing.SolidBrush myBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Red);
            System.Drawing.Graphics formGraphics;
            formGraphics = this.CreateGraphics();

            formGraphics.FillRectangle(myBrush, new Rectangle(0, 0, count * 10, count * 10));
            myBrush.Dispose();
            formGraphics.Dispose();
        }

        private void formRectangle_Load(object sender, EventArgs e)
        {

        }
    }
}

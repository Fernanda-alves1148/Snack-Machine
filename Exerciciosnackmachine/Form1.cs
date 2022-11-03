using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exerciciosnackmachine
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Temporizador_Tick(object sender, EventArgs e)
        {
            if (barradeprogresso.Value < 100)
            {
                barradeprogresso.Value = barradeprogresso.Value + 2;
            }
            else
            {
                Temporizador.Enabled = false;
                this.Visible = false;
                Form2 visivel = new Form2();
                visivel.ShowDialog();
            }
        }
    }
}

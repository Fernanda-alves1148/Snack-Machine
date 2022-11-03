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
    public partial class Form2 : Form
    {
        double valor = 0;
        public Form2()
        {
            InitializeComponent();
        }

        private void btnmm_Click(object sender, EventArgs e)
        {
            valor = valor - 3.5;
            if (valor > 0)
            {
                txtValor.Text = (Convert.ToString(valor) + "Retire seu troco.");
            }
            else
            {
                txtValor.Text = "Obrigado";
            }
        }

        private void btncoca_Click(object sender, EventArgs e)
        {
            valor = valor - 5;
            if (valor > 0)
            {
                txtValor.Text = (Convert.ToString(valor) + "Retire seu troco.");
            }
            else
            {
                txtValor.Text = "Obrigado";
            }
        }

        private void btntwix_Click(object sender, EventArgs e)
        {
            valor = valor - 3.8;
            if (valor > 0)
            {
                txtValor.Text = (Convert.ToString(valor) + "Retire seu troco.");
            }
            else
            {
                txtValor.Text = "Obrigado";
            }
        }

        private void btnoreo_Click(object sender, EventArgs e)
        {
            valor = valor - 4;
            if (valor > 0)
            {
                txtValor.Text = (Convert.ToString(valor) + "Retire seu troco.");
            }
            else
            {
                txtValor.Text = "Obrigado";
            }
        }

        private void btnskittles_Click(object sender, EventArgs e)
        {
            valor = valor - 6.5;
            if (valor > 0)
            {
                txtValor.Text = (Convert.ToString(valor) + "Retire seu troco.");
            }
            else
            {
                txtValor.Text = "Obrigado";
            }
        }

        private void btnhersh_Click(object sender, EventArgs e)
        {
            valor = valor - 4.5;
            if (valor > 0)
            {
                txtValor.Text = (Convert.ToString(valor) + "Retire seu troco.");
            }
            else
            {
                txtValor.Text = "Obrigado";
            }
        }

        private void btnfritos_Click(object sender, EventArgs e)
        {
            valor = valor - 2;
            if (valor > 0)
            {
                txtValor.Text = (Convert.ToString(valor) + "Retire seu troco.");
            }
            else
            {
                txtValor.Text = "Obrigado";
            }
        }

        private void btnlays_Click(object sender, EventArgs e)
        {
            valor = valor - 7.5;
            if (valor > 0)
            {
                txtValor.Text = (Convert.ToString(valor) + "Retire seu troco.");
            }
            else
            {
                txtValor.Text = "Obrigado";
            }
        }

        private void btndoritos_Click(object sender, EventArgs e)
        {
            valor = valor - 7;
            if (valor > 0)
            {
                txtValor.Text = (Convert.ToString(valor) + "Retire seu troco.");
            }
            else
            {
                txtValor.Text = "Obrigado";
            }
        }

        private void btninserir_Click(object sender, EventArgs e)
        {
            int prov = Convert.ToInt32(txtValor.Text);
            if (prov == 2 || prov == 5 || prov == 10 || prov== 20)
            {
                valor = valor + prov;
                if (valor >= 2)
                {
                    btnfritos.Enabled = true;
                }
                if (valor >= 7)
                {
                    btndoritos.Enabled = true;
                }
                if (valor >= 7.5)
                {
                    btnlays.Enabled = true;
                }
                if (valor >= 4.5)
                {
                    btnhersh.Enabled = true;
                }
                if (valor >= 6.5)
                {
                    btnskittles.Enabled = true;
                }
                if (valor >= 4)
                {
                    btnoreo.Enabled = true;
                }
                if (valor >= 3.8)
                {
                    btntwix.Enabled = true;
                }
                if (valor >= 5)
                {
                    btncoca.Enabled = true;
                }
                if (valor >= 3.5)
                {
                    btnmm.Enabled = true;
                }
            }
        }

        private void btnfinalizar_Click(object sender, EventArgs e)
        {
            txtValor.Text = "Insira o Valor";
            valor = 0;
            btntwix.Enabled = false;
            btnskittles.Enabled = false;
            btnmm.Enabled = false;
            btncoca.Enabled = false;
            btndoritos.Enabled = false;
            btnfritos.Enabled = false;
            btnoreo.Enabled = false;
            btnlays.Enabled = false;
            btnhersh.Enabled = false;
        }
    }
}

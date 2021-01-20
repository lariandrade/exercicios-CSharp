using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prj_Ex04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SomenteNumero(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == ',' ))
            {
                e.Handled = true;
            }
        }

        private void BtnPesoIdeal(object sender, EventArgs e)
        {
            double altura = 0;
            double peso = 0;

            if (rdBFeminino.Checked)
            {
                altura = double.Parse(txtAltura.Text);

                peso = (62.1 * altura) - 44.7;

                lblPeso.Text = peso.ToString();

            }
            else if (rdBMasculino.Checked)
            {
                altura = double.Parse(txtAltura.Text);

                peso = (72.7 * altura) - 58;

                lblPeso.Text = peso.ToString();
            }
            
        }

        private void BtnNovo(object sender, EventArgs e)
        {
            txtAltura.Text = "";
            lblPeso.Text = "";
            rdBFeminino.Checked = false;
            rdBMasculino.Checked = false;
        }

    }
}

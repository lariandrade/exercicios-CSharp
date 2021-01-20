using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prj_EX01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ApenasNumeros(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar) || e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

 
        private void BtnVerifica(object sender, EventArgs e)
        {
            int peso = int.Parse(txtPesoPeixe.Text);
            int multa = 0;
            int aumento = 0;

            if(peso <= 50)
            {
                label5.Text = "ZERO";
                label4.Text = "ZERO";
            }
            else if(peso > 50)
            {

                aumento = peso - 50;
                multa = aumento * 4;
                label4.Text = aumento.ToString() + " kg";
                label5.Text = "R$ " + multa.ToString();
            }
        }

        private void BtnNew(object sender, EventArgs e)
        {
            txtPesoPeixe.Text = "";
            txtPesoPeixe.Focus();
            label4.Text = "";
            label5.Text = "";
        }

    }
}

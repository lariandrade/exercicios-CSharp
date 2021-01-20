using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prj_EX02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnLimpar(object sender, EventArgs e)
        {
            txtCodigo.Text = "";
            txtHoras.Text = "";
            lblHorasExcesso.Text = "0";
            lblSalarioExcedente.Text = "0";
            lblSalarioTotal.Text = "0";
            txtCodigo.Focus();
        }

        private void BtnSair(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnCalcular(object sender, EventArgs e)
        {
            int intHoras = int.Parse(txtHoras.Text);
            int intExcesso = 0;
            int intSalarioEx = 0;
            int total = 0;

            if(intHoras <=50 )
            {
                intHoras = intHoras * 10;

                lblHorasExcesso.Text = "0";
                lblSalarioExcedente.Text = "0";
                lblSalarioTotal.Text = intHoras.ToString();

            }
            else if(intHoras > 50)
            {
                intExcesso = intHoras - 50; //horas extras
                intSalarioEx = intExcesso * 20; //horas extras x 20 reais 
                total = intSalarioEx + 500; //horas extras + 500

                lblHorasExcesso.Text = intExcesso.ToString();
                lblSalarioExcedente.Text = intSalarioEx.ToString();
                lblSalarioTotal.Text = total.ToString();
               
            }
        }

        private void SomenteNumero(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar) || e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
        }
    }
}

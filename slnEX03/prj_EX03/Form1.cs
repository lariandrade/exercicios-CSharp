using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prj_EX03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnNovo(object sender, EventArgs e)
        {
            lblCategoria.Text = "";
            rdB5a7.Checked = false;
            rdB8a11.Checked = false;
            rdB12a13.Checked = false;
            rdB14a17.Checked = false;
            rdB18ouMais.Checked = false;
        }

        private void BtnSair(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnClassificar(object sender, EventArgs e)
        {
            if(rdB5a7.Checked)
            {
                lblCategoria.Text = "Infantil A";
            }
            else if (rdB8a11.Checked)
            {
                lblCategoria.Text = "Infantil B";
            }
            else if(rdB12a13.Checked)
            {
                lblCategoria.Text = "Juvenil A";
            }
            else if(rdB14a17.Checked)
            {
                lblCategoria.Text = "Juvenil B";
            }   
            else if(rdB18ouMais.Checked)
            {
                lblCategoria.Text = "Adulto";
            }
        }
    }
}

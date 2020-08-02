using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraDerivadas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btMostrar_Click(object sender, EventArgs e)
        {
            lblMostrar.Text = txtFuncion.Text;
        }
        #region *------- Aumentar valores a txtFunction, calculadora -------*
        private void btNumero0_Click(object sender, EventArgs e)
        {
            aumentarTxtBox("0");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            aumentarTxtBox("1");
        }

        private void btNumero2_Click(object sender, EventArgs e)
        {
            aumentarTxtBox("2");
        }

        private void btNumero3_Click(object sender, EventArgs e)
        {
            aumentarTxtBox("3");
        }

        private void btNumero4_Click(object sender, EventArgs e)
        {
            aumentarTxtBox("4");
        }

        private void btNumero5_Click(object sender, EventArgs e)
        {
            aumentarTxtBox("5");
        }

        private void btNumero6_Click(object sender, EventArgs e)
        {
            aumentarTxtBox("6");
        }

        private void btNumero7_Click(object sender, EventArgs e)
        {
            aumentarTxtBox("7");
        }

        private void btNumero8_Click(object sender, EventArgs e)
        {
            aumentarTxtBox("8");
        }

        private void btNumero9_Click(object sender, EventArgs e)
        {
            aumentarTxtBox("9");
        }

        private void btParentesis1_Click(object sender, EventArgs e)
        {
            aumentarTxtBox("()");
        }

        private void btParentesis2_Click(object sender, EventArgs e)
        {
            aumentarTxtBox(")");
        }

        private void btSuma_Click(object sender, EventArgs e)
        {
            aumentarTxtBox("+");
        }

        private void btResta_Click(object sender, EventArgs e)
        {
            aumentarTxtBox("-");
        }

        private void btMultiplicaion_Click(object sender, EventArgs e)
        {
            aumentarTxtBox("*");
        }

        private void btDivision_Click(object sender, EventArgs e)
        {
            aumentarTxtBox("/");
        }

        private void btSen_Click(object sender, EventArgs e)
        {
            aumentarTxtBox("sen()");
        }

        private void btCos_Click(object sender, EventArgs e)
        {
            aumentarTxtBox("cos()");
        }

        private void btTan_Click(object sender, EventArgs e)
        {
            aumentarTxtBox("tan()");
        }

        private void btCtan_Click(object sender, EventArgs e)
        {
            aumentarTxtBox("ctan()");
        }

        private void btSec_Click(object sender, EventArgs e)
        {
            aumentarTxtBox("sec()");
        }

        private void btCsec_Click(object sender, EventArgs e)
        {
            aumentarTxtBox("csec()");
        }

        private void btAsen_Click(object sender, EventArgs e)
        {
            aumentarTxtBox("asen()");
        }

        private void btAcos_Click(object sender, EventArgs e)
        {
            aumentarTxtBox("acos()");
        }

        private void btAtan_Click(object sender, EventArgs e)
        {
            aumentarTxtBox("atan()");
        }

        private void btActan_Click(object sender, EventArgs e)
        {
            aumentarTxtBox("actan()");
        }

        private void btAsec_Click(object sender, EventArgs e)
        {
            aumentarTxtBox("asec()");
        }

        private void btAcsec_Click(object sender, EventArgs e)
        {
            aumentarTxtBox("acsec()");
        }

        private void btSenh_Click(object sender, EventArgs e)
        {
            aumentarTxtBox("senh()");
        }

        private void btCosh_Click(object sender, EventArgs e)
        {
            aumentarTxtBox("cosh()");
        }

        private void btTanh_Click(object sender, EventArgs e)
        {
            aumentarTxtBox("tanh()");
        }

        private void btCtanh_Click(object sender, EventArgs e)
        {
            aumentarTxtBox("ctanh()");
        }

        private void btSech_Click(object sender, EventArgs e)
        {
            aumentarTxtBox("sech()");
        }

        private void btCsech_Click(object sender, EventArgs e)
        {
            aumentarTxtBox("csech()");
        }

        private void btLimpiar_Click(object sender, EventArgs e)
        {
            txtFuncion.Text = "";
        }
        private void btBorrar_Click(object sender, EventArgs e)
        {
            int p = txtFuncion.SelectionStart;
            String t = txtFuncion.Text;
            if (p >= 1)
            {
                txtFuncion.Text = t.Substring(0, p - 1) + t.Substring(p, t.Length - p);
                txtFuncion.SelectionStart = p - 1;
            }
        }
        private void aumentarTxtBox(String t)
        {
            int p = txtFuncion.SelectionStart;
            txtFuncion.Text = txtFuncion.Text.Insert(p, t);
            txtFuncion.SelectionStart = p + 1;
        }
        #endregion -----

    }
}

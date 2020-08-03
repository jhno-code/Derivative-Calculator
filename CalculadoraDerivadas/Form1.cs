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
        private String Funcion;
        private String[] TokenFuncion;
        private String Derivada;
        public Form1()
        {
            InitializeComponent();
        }

        #region ------------ Clicks en botones ------------
        private void btMostrar_Click(object sender, EventArgs e)
        {
            lblMostrar.Text = txtFuncion.Text;
        }
        private void btDerivar_Click(object sender, EventArgs e)
        {
            Funcion = txtFuncion.Text;
            tokenizar();
            derivar();
        }

        #region *------- Aumentar valores a txtFunction, calculadora -------*
        private void btX_Click(object sender, EventArgs e)
        {
            aumentarTxtBox("X");
        }
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
        private void btPotencia_Click(object sender, EventArgs e)
        {
            aumentarTxtBox("^()");
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

        #endregion

        #region ---------------- Tokenizer ------------------
        private void tokenizar()
        {
            TokenFuncion =  Funcion.Split(' ');
        }
        #endregion

        #region --------------- Derivar -----------
        private void derivar()
        {
            if (valido())
            {
                hallarDerivada();
                //lblMostrar.Text = Derivada;
                lblMostrar.Text = Funcion;
            }
            else lblMostrar.Text = "ERROR!, FUNCION NO VALIDA.";
        }
        private void hallarDerivada()
        {

        }
        #endregion

        #region ----------- Validar -----------
        private bool valido()
        {
            String[] t = TokenFuncion;
            // verificar si existen variables desconocidas
            foreach (string s in t)
            {
                if (!terminoValido(s)) return false;
            }
            // Verificar si existen errores de funcion

            return true;
        }
        #region --------------- Validar terminos --------------
        private bool terminoValido(string t)
        {
            if (Char.IsNumber(t, 0) || esFuncionTrigonometrica(t) || esOperador(t) || t.Equals("x") || t.Equals("(") || t.Equals(")")) return true;
            return false;
        }
        private bool esFuncionTrigonometrica(string t)
        {
            string[] a = { "sen", "cos", "tan", "ctan", "sec", "csec" };
            for (int k = 0; k < a.Length; k++)
            {
                if (t.Equals(a[k]) || t.Equals(a[k] + "h") || t.Equals("a" + a[k])) return true;
            }
            return false;
        }
        private bool esOperador(string t)
        {
            string[] a = { "+", "-", "*", "/", "^" };
            for (int k = 0; k < a.Length; k++)
            {
                if (t.Equals(a[k])) return true;
            }
            return false;
        }
        #endregion

        #region ----------------- Validar string (funcion) -------------
        #endregion
        #endregion
    }
}

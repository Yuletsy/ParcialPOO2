using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Funciones.Parcial
{
    public partial class Form1 : Form
    {
        private int a;
        private int n;
        private string valueText;

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonDivr_Click(object sender, EventArgs e)
        {
            n = int.Parse(textBoxEntrada.Text);
            for (int i = 1; i <= n; i++)
            {
                double b = Math.IEEERemainder(n, i);
                if (b == 0)
                {
                    valueText = valueText + i.ToString() + "  ";
                    textBoxResult.Text = valueText;
                }

            }
        }

        private void buttonMultp_Click(object sender, EventArgs e)
        {
            n = int.Parse(textBoxEntrada.Text);
            for (int i = 0; i <= 9; i++)
            {
                a = n * i;
                valueText = valueText + a.ToString() + "  ";
                textBoxResult.Text = valueText;
            }
        }

        private void buttonFact_Click(object sender, EventArgs e)
        {
            a = 1;
            n = int.Parse(textBoxEntrada.Text);
            for (int i = 1; i <= n; i++)
            {
                a = a * i;
            }
            valueText = valueText + a.ToString();
            textBoxResult.Text = valueText;

        }

        private void buttonFibon_Click(object sender, EventArgs e)
        {
            a = 0;
            int b = 1;
            int z = 0;
            n = int.Parse(textBoxEntrada.Text);
            valueText = valueText + b.ToString() + "  ";
            textBoxResult.Text = valueText;
            for (int i = 1; i < n; i++)
            {
                z = a;
                a = b;
                b = z + a;
                valueText = valueText + b.ToString() + "  ";
                textBoxResult.Text = valueText;

            }
        }

        private void buttonSerie_Click(object sender, EventArgs e)
        {

            n = int.Parse(textBoxEntrada.Text);
            for (int i = 1; i <= n; i++)
            {
                double b = Math.Pow(i, 2);
                valueText = valueText + b.ToString() + "  ";
                textBoxResult.Text = valueText;
            }
        }
          private void buttonBorrar_Click(object sender, EventArgs e)
        {
            textBoxEntrada.Clear();
            textBoxResult.Clear();
            valueText = "";
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

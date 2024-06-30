using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Final_de_PROGRAMACIÓN_III.Forms
{
    public partial class NumerosForm : Form
    {
        public NumerosForm()
        {
            InitializeComponent();
        }

        private void ejercicio1_Click(object sender, EventArgs e)
        {
            int number = int.Parse(txtInput.Text);
            lblResultado.Text = Numeros.Mayor(number).ToString();
        }

        private void ejercicio2_Click(object sender, EventArgs e)
        {
            int number = int.Parse(txtInput.Text);
            lblResultado.Text = Numeros.SumaPares(number).ToString();
        }

        private void ejercicio3_Click(object sender, EventArgs e)
        {
            int number = int.Parse(txtInput.Text);
            lblResultado.Text = Numeros.MoverMayor(number).ToString();
        }

        private void ejercicio4_Click(object sender, EventArgs e)
        {
            int number = int.Parse(txtInput.Text);
            lblResultado.Text = Numeros.EstaOrdenado(number).ToString();
        }

        private void ejercicio5_Click(object sender, EventArgs e)
        {
            int number = int.Parse(txtInput.Text);
            lblResultado.Text = Numeros.CantDigPares(number).ToString();
        }

        private void NumerosForm_Load(object sender, EventArgs e)
        {
            LoadTheme();
        }

        private void LoadTheme()
        {
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = ThemeColor.SecondaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColor.PrimaryColor;
                }
            }
            lblResultado.ForeColor = ThemeColor.SecondaryColor;
            txtInput.ForeColor = ThemeColor.PrimaryColor;
            txtInput.BackColor = ThemeColor.PrimaryColor;
            txtInput.ForeColor = Color.White;
            label1.ForeColor = ThemeColor.SecondaryColor;
            label2.ForeColor = ThemeColor.SecondaryColor;
        }
    }
}

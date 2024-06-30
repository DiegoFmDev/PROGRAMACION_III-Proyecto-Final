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
    public partial class CadenasForm : Form
    {
        public CadenasForm()
        {
            InitializeComponent();
        }

        private void btnEjercicio1_Click(object sender, EventArgs e)
        {
            string input = txtInput.Text;
            lblResult.Text = Cadenas.CantPal(input).ToString();
        }

        private void btnEjercicio2_Click(object sender, EventArgs e)
        {
            string input = txtInput.Text;
            lblResult.Text = Cadenas.EliminarVoc(input);
        }

        private void btnEjercicio3_Click(object sender, EventArgs e)
        {
            string input = txtInput.Text;
            lblResult.Text = Cadenas.CadenaMasLarga(input);
        }

        private void btnEjercicio4_Click(object sender, EventArgs e)
        {
            string input = txtInput.Text;
            lblResult.Text = Cadenas.EliminaPrim(input);
        }

        private void btnEjercicio5_Click(object sender, EventArgs e)
        {
            string input = txtInput.Text;
            lblResult.Text = Cadenas.InvertirPal(input);
        }
        private void CadenasForm_Load(object sender, EventArgs e)
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
                    btn.BackColor = ThemeColor.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                }
            }
            lblResult.ForeColor = ThemeColor.SecondaryColor;
            txtInput.ForeColor = ThemeColor.PrimaryColor;
            txtInput.BackColor = ThemeColor.PrimaryColor;
            txtInput.ForeColor = Color.White;
            label2.ForeColor = ThemeColor.PrimaryColor;
            CALCULAR.ForeColor = ThemeColor.SecondaryColor;
        }
    }
}
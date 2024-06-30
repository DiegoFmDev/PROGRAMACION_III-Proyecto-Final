using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Final_de_PROGRAMACIÓN_III.Forms
{
    public partial class SeriesForm : Form
    {
        public SeriesForm()
        {
            InitializeComponent();
        }

        private void btnFibonacci_Click(object sender, EventArgs e)
        {
            int n = int.Parse(txtInput.Text);
            lblResultado.Text = "Fibo(" + n + ") -> " + Series.Fibonacci(n);
        }

        private void btnSerie1_Click(object sender, EventArgs e)
        {
            int n = int.Parse(txtInput.Text);
            lblResultado.Text = "Serie1 (" + n + ") -> " + Series.Serie1(n);
        }
        
        private void btnSumaSerie_Click(object sender, EventArgs e)
        {
            int n = int.Parse(txtInput.Text);
            lblResultado.Text = "SumaSerie(" + n + ") -> " + Series.SumaSerie(n);
        }

        private void btnSerie2_Click(object sender, EventArgs e)
        {
            int n = int.Parse(txtInput.Text);
            lblResultado.Text = "Serie2(" + n + ") -> " + Series.Serie2(n);
        }

        private void btnSumaSerie2_Click(object sender, EventArgs e)
        {
            int n = int.Parse(txtInput.Text);
            lblResultado.Text = "SumaSerie2(" + n + ") -> " + Series.SumaSerie2(n);
        }
        private void SeriesForm_Load(object sender, EventArgs e)
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
            lblResultado.ForeColor = ThemeColor.SecondaryColor;
            txtInput.ForeColor = ThemeColor.PrimaryColor;
            label4.ForeColor = ThemeColor.SecondaryColor;
            label1.ForeColor = ThemeColor.PrimaryColor;
            txtInput.BackColor = ThemeColor.PrimaryColor;
            txtInput.ForeColor = Color.White;
        }
    }
}

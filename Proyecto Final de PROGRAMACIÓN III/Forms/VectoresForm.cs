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
    public partial class VectoresForm : Form
    {
        public VectoresForm()
        {
            InitializeComponent();
        }

        private void btnContarPares_Click(object sender, EventArgs e)
        {
            int[] vector = GetVectorFromInput();
            int count = Vectores.CountEvens(vector);
            lblResult.Text = $"Cantidad de pares: {count}";
        }

        private void btnMergeSort_Click(object sender, EventArgs e)
        {
            int[] vector = GetVectorFromInput();
            Vectores.MergeSort(vector, 0, vector.Length - 1);
            lblResult.Text = $"Vector ordenado (MergeSort):\n    {string.Join(", ", vector)}";

        }

        private void btnInsertionSort_Click(object sender, EventArgs e)
        {
            int[] vector = GetVectorFromInput();
            Vectores.InsertionSort(vector);
            lblResult.Text = $"Vector ordenado (InsertionSort):\n    {string.Join(", ", vector)}";
        }

        private void btnEliminarX_Click(object sender, EventArgs e)
        {
            int[] vector = GetVectorFromInput();
            int x = int.Parse(txtParameter.Text);
            vector = Vectores.RemoveElement(vector, x);
            lblResult.Text = $"Vector sin {x}:\n    {string.Join(", ", vector)}";
        }

        private void btnInvertir_Click(object sender, EventArgs e)
        {
            int[] vector = GetVectorFromInput();
            int a = int.Parse(txtParameterA.Text);
            int b = int.Parse(txtParameterB.Text);
            Vectores.InvertSection(vector, a, b);
            lblResult.Text = $"Vector invertido:\n    {string.Join(", ", vector)}";
        }

        private int[] GetVectorFromInput()
        {
            return txtVectorInput.Text.Split(',').Select(int.Parse).ToArray();
        }

        private void VectoresForm_Load(object sender, EventArgs e)
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
            txtVectorInput.ForeColor = ThemeColor.PrimaryColor;
            label1.ForeColor = ThemeColor.SecondaryColor;
            label2.ForeColor = ThemeColor.SecondaryColor;
            label3.ForeColor = ThemeColor.SecondaryColor;
            label4.ForeColor = ThemeColor.SecondaryColor;
            txtParameter.BackColor = ThemeColor.SecondaryColor;
            txtParameterA.BackColor = ThemeColor.SecondaryColor;
            txtParameterB.BackColor = ThemeColor.SecondaryColor;
            txtVectorInput.BackColor = ThemeColor.PrimaryColor;
            txtParameter.ForeColor = Color.White;
            txtParameterA.ForeColor = Color.White;
            txtParameterB.ForeColor = Color.White;
            txtVectorInput.ForeColor = Color.White;
        }
    }
}

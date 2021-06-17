using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Лабораторная_работа__3
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private void InitBtn_Click(object sender, EventArgs e)
        {
            try
            {
                double ax = Convert.ToDouble(inputAx.Text);
                double ay = Convert.ToDouble(inputAy.Text);
                double az = Convert.ToDouble(inputAz.Text);
                double bx = Convert.ToDouble(inputBx.Text);
                double by = Convert.ToDouble(inputBy.Text);
                double bz = Convert.ToDouble(inputBz.Text);
                Vector a = new Vector(new double[] { ax, ay, az });
                Vector b = new Vector(new double[] { bx, by, bz });
                Box.Text += $"Vector a = {a}\n";
                Box.Text += $"Vector b = {b}\n";
                Box.Text += $"a + b = {(a + b)}\n";
                Box.Text += $"a - b = {(b - a)}\n";
                Box.Text += $"a * b = {Vector.DotProduct(a, b)}\n";
                Box.Text += $"a x b = {Vector.CrossProduct(a, b)}\n";
                Box.Text += $"(a + a) x b = {Vector.CrossProduct(a + a, b)}\n";
                if (Vector.Collinearity(a, b) == true)
                    Box.Text += "Vectors are collinear\n";
                else
                    Box.Text += "Vectors are noncollinear\n";
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
        private void ClearBtn_Click(object sender, EventArgs e)
        {
            Box.Clear();
        }
    }
}

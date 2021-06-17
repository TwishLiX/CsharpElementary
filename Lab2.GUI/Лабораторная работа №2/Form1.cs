using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Лабораторная_работа__2
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private void StartBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int count = 0, min = 0, max = 0;
                int N = Convert.ToInt32(InputN.Text);
                int M = Convert.ToInt32(InputM.Text);
                if (N > 0)
                {
                    Triangle[] N_triangles = new Triangle[N];
                    for (int i = 0; i < N; i++)
                    {
                        do
                        {
                            N_triangles[i] = new Triangle();
                        } while (N_triangles[i].isExists() == false);
                    }
                    for (int i = 0; i < N; i++)
                    {
                        if (N_triangles[min].getSquare() > N_triangles[i].getSquare())
                            min = i;
                        if (N_triangles[max].getSquare() < N_triangles[i].getSquare())
                            max = i;
                    }
                    for (int i = 0; i < N; i++)
                    {
                        NBox.Text += $"The {i + 1} triangle:\n";
                        NBox.Text += N_triangles[i].PrintTriangles();
                    }
                    MinMaxBox.Text += $"Minimum square has triangle {min + 1}, Maximum square has triangle {max + 1}. Information about them:\n";
                    MinMaxBox.Text += $"Minimum: AB = {String.Format("{0:0.00}", N_triangles[min].getSideAB())}cm, BC = {String.Format("{0:0.00}", N_triangles[min].getSideBC())}cm, AC = {String.Format("{0:0.00}", N_triangles[min].getSideAC())}cm, SQ = {String.Format("{0:0.00}", N_triangles[min].getSquare())}cm^2.\n";
                    MinMaxBox.Text += $"Maximum: AB = {String.Format("{0:0.00}", N_triangles[max].getSideAB())}cm, BC = {String.Format("{0:0.00}", N_triangles[max].getSideBC())}cm, AC = {String.Format("{0:0.00}", N_triangles[max].getSideAC())}cm, SQ = {String.Format("{0:0.00}", N_triangles[max].getSquare())}cm^2.";
                }
                Right[] M_triangles = new Right[M];
                for (int i = 0; i < M; i++)
                {
                    do
                    {
                        M_triangles[i] = new Right();
                    } while (M_triangles[i].isSquareness() == false || M_triangles[i].isExists() == false);
                }
                for (int i = 0; i < M; i++)
                {
                    MBox.Text += $"The {i + 1} triangle:\n";
                    MBox.Text += M_triangles[i].PrintTriangles();
                }
                for (int i = 0; i < M; i++)
                {
                    for (int j = 0; j < M; j++)
                    {
                        if ((M_triangles[i].getSideAB() == M_triangles[j].getSideAB() && M_triangles[i].getSideBC() == M_triangles[j].getSideBC() && i != j && i < j) || (M_triangles[i].getSideAB() == M_triangles[j].getSideBC() && M_triangles[i].getSideBC() == M_triangles[j].getSideAB() && i != j && i < j) || (M_triangles[i].getSideAB() == M_triangles[j].getSideAB() && M_triangles[i].getSideAC() == M_triangles[j].getSideAC() && i != j && i < j) || (M_triangles[i].getSideAB() == M_triangles[j].getSideAC() && M_triangles[i].getSideAC() == M_triangles[j].getSideAB() && i != j && i < j) || (M_triangles[i].getSideBC() == M_triangles[j].getSideBC() && M_triangles[i].getSideAC() == M_triangles[j].getSideAC() && i != j && i < j) || (M_triangles[i].getSideBC() == M_triangles[j].getSideAC() && M_triangles[i].getSideAC() == M_triangles[j].getSideBC() && i != j && i < j) || (M_triangles[i].getSideAB() == M_triangles[j].getSideBC() && M_triangles[i].getSideAC() == M_triangles[j].getSideAC() && i != j && i < j) || (M_triangles[i].getSideAB() == M_triangles[j].getSideAC() && M_triangles[i].getSideBC() == M_triangles[j].getSideBC() && i != j && i < j) || (M_triangles[i].getSideBC() == M_triangles[j].getSideAC() && M_triangles[i].getSideAB() == M_triangles[j].getSideAB() && i != j && i < j))
                        {
                            RepetitionsBox.Text += $"{i + 1} and {j + 1} rectangle triangles are the same.\n";
                            count++;
                        }
                    }
                }
                if (count == 0 && M > 0)
                    RepetitionsBox.Text += "The same triangles don't exist.";
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
        private void ClearBtn_Click(object sender, EventArgs e)
        {
            NBox.Clear();
            MBox.Clear();
            MinMaxBox.Clear();
            RepetitionsBox.Clear();
        }
    }
}

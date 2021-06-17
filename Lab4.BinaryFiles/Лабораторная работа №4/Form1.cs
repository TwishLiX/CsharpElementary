using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Лабораторная_работа__4
{
    public partial class MainForm : Form
    {
        public int N;
        public int M;
        int min, max;
        Triangle[] N_triangles;
        Right[] M_triangles;
        public MainForm()
        {
            InitializeComponent();
        }
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (NBox.Text == String.Empty)
            {
                MessageBox.Show("There are no data to save.");
            }
            else
            {
                SaveFileDialog save = new SaveFileDialog();
                save.DefaultExt = "*.bin";
                save.Filter = "Binary files (*.bin) | *.bin";
                save.AddExtension = true;
                if (save.ShowDialog() == DialogResult.OK)
                {
                    string filename = save.FileName;
                    FileStream fs = new FileStream(filename, FileMode.OpenOrCreate, FileAccess.Write);
                    BinaryWriter bw = new BinaryWriter(fs, Encoding.UTF8);
                    bw.Write(N);
                    bw.Write(M);
                    for (int i = 0; i < N; i++)
                    {
                        N_triangles[i].Write(bw);
                    }
                    for (int i = 0; i < M; i++)
                    {
                        M_triangles[i].Write(bw);
                    }
                    bw.Close();
                    fs.Close();
                }
            }
        }
        private void LoadBtn_Click(object sender, EventArgs e)
        {
            if (NBox.Text != String.Empty)
            {
                MessageBox.Show("Textbox must be empty!\nClear textbox to load data.");
            }
            else
            {
                OpenFileDialog open = new OpenFileDialog();
                open.DefaultExt = "*.bin";
                open.Filter = "Binary files (*.bin) | *.bin";
                open.AddExtension = true;
                if (open.ShowDialog() == DialogResult.OK)
                {
                    string filename = open.FileName;
                    FileStream fs = new FileStream(filename, FileMode.Open, FileAccess.Read);
                    BinaryReader br = new BinaryReader(fs, Encoding.UTF8);
                    N = br.ReadInt32();
                    M = br.ReadInt32();
                    N_triangles = new Triangle[N];
                    M_triangles = new Right[M];
                    for (int i = 0; i < N; i++)
                    {
                        N_triangles[i] = new Triangle();
                        N_triangles[i] = N_triangles[i].Read(br);
                    }
                    for (int i = 0; i < M; i++)
                    {
                        M_triangles[i] = new Right();
                        M_triangles[i] = M_triangles[i].Read(br);
                    }
                    Calculate();
                    Out();
                    br.Close();
                    fs.Close();
                }
            }
        }
        private void StartBtn_Click(object sender, EventArgs e)
        {
            Init();
        }
        private void Init()
        {
            try
            {
                N = Convert.ToInt32(InputN.Text);
                M = Convert.ToInt32(InputM.Text);
                if (N > 0)
                {
                    N_triangles = new Triangle[N];
                    for (int i = 0; i < N; i++)
                    {
                        do
                        {
                            N_triangles[i] = new Triangle();
                        } while (N_triangles[i].isExists() == false);
                    }
                }
                M_triangles = new Right[M];
                for (int i = 0; i < M; i++)
                {
                    do
                    {
                        M_triangles[i] = new Right();
                    } while (M_triangles[i].isSquareness() == false || M_triangles[i].isExists() == false);
                }
                Calculate();
                Out();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
        private void Calculate()
        {
            min = 0; max = 0;
            for (int i = 0; i < N; i++)
            {
                if (N_triangles[min].getSquare() > N_triangles[i].getSquare())
                    min = i;
                if (N_triangles[max].getSquare() < N_triangles[i].getSquare())
                    max = i;
            }
        }
        private void Out()
        {
            int count = 0;
            for (int i = 0; i < N; i++)
            {
                NBox.Text += $"The {i + 1} triangle:\n";
                NBox.Text += N_triangles[i].PrintTriangles();
            }
            if (N > 0)
            {
                NBox.Text += $"Minimum square has triangle {min + 1}, Maximum square has triangle {max + 1}. Information about them:\n";
                NBox.Text += $"Minimum: AB = {String.Format("{0:0.00}", N_triangles[min].getSideAB())}cm, BC = {String.Format("{0:0.00}", N_triangles[min].getSideBC())}cm, AC = {String.Format("{0:0.00}", N_triangles[min].getSideAC())}cm, SQ = {String.Format("{0:0.00}", N_triangles[min].getSquare())}cm^2.\n";
                NBox.Text += $"Maximum: AB = {String.Format("{0:0.00}", N_triangles[max].getSideAB())}cm, BC = {String.Format("{0:0.00}", N_triangles[max].getSideBC())}cm, AC = {String.Format("{0:0.00}", N_triangles[max].getSideAC())}cm, SQ = {String.Format("{0:0.00}", N_triangles[max].getSquare())}cm^2.\n\n";

            }
            for (int i = 0; i < M; i++)
            {
                NBox.Text += $"The {i + 1} right triangle:\n";
                NBox.Text += M_triangles[i].PrintTriangles();
            }
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    if ((M_triangles[i].getSideAB() == M_triangles[j].getSideAB() && M_triangles[i].getSideBC() == M_triangles[j].getSideBC() && i != j && i < j) || (M_triangles[i].getSideAB() == M_triangles[j].getSideBC() && M_triangles[i].getSideBC() == M_triangles[j].getSideAB() && i != j && i < j) || (M_triangles[i].getSideAB() == M_triangles[j].getSideAB() && M_triangles[i].getSideAC() == M_triangles[j].getSideAC() && i != j && i < j) || (M_triangles[i].getSideAB() == M_triangles[j].getSideAC() && M_triangles[i].getSideAC() == M_triangles[j].getSideAB() && i != j && i < j) || (M_triangles[i].getSideBC() == M_triangles[j].getSideBC() && M_triangles[i].getSideAC() == M_triangles[j].getSideAC() && i != j && i < j) || (M_triangles[i].getSideBC() == M_triangles[j].getSideAC() && M_triangles[i].getSideAC() == M_triangles[j].getSideBC() && i != j && i < j) || (M_triangles[i].getSideAB() == M_triangles[j].getSideBC() && M_triangles[i].getSideAC() == M_triangles[j].getSideAC() && i != j && i < j) || (M_triangles[i].getSideAB() == M_triangles[j].getSideAC() && M_triangles[i].getSideBC() == M_triangles[j].getSideBC() && i != j && i < j) || (M_triangles[i].getSideBC() == M_triangles[j].getSideAC() && M_triangles[i].getSideAB() == M_triangles[j].getSideAB() && i != j && i < j))
                    {
                        NBox.Text += $"{i + 1} and {j + 1} rectangle triangles are the same.\n";
                        count++;
                    }
                }
            }
            if (count == 0 && M > 0)
                NBox.Text += "The same triangles don't exist.";
        }
        private void ClearBtn_Click(object sender, EventArgs e)
        {
            NBox.Clear();
        }
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (NBox.Text != String.Empty)
            {
                var result = MessageBox.Show("Do you want to record data in file(s)?", "Exit", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    SaveBtn_Click(sender, e);
                }
                if (result == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
            }
        }
    }
}

using System;
using System.Threading;
using System.Windows.Forms;

namespace Лабораторная_работа__6
{
    public partial class Form1 : Form
    {
        public int count1 = 0;
        public int count2 = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void StartBtn_Click(object sender, EventArgs e)
        {
            Threads threads = new Threads();
            threads.Execution();
            Display();
        }

        private void WritePriorityChoosing_SelectedIndexChanged(object sender, EventArgs e)
        {
            Threads threads = new Threads();
            switch (WritePriorityChoosing.Text)
            {
                case "Lowest":
                    threads.write.Priority = ThreadPriority.Lowest;
                    break;
                case "BelowNormal":
                    threads.write.Priority = ThreadPriority.BelowNormal;
                    break;
                case "Normal":
                    threads.write.Priority = ThreadPriority.Normal;
                    break;
                case "AboveNormal":
                    threads.write.Priority = ThreadPriority.AboveNormal;
                    break;
                case "Highest":
                    threads.write.Priority = ThreadPriority.Highest;
                    break;
            }
            count1++;
            if (count1 >= 1 && count2 >= 1)
            {
                StartBtn.Enabled = true;
            }
        }

        private void ReadPriorityChoosing_SelectedIndexChanged(object sender, EventArgs e)
        {
            Threads threads = new Threads();
            switch (ReadPriorityChoosing.Text)
            {
                case "Lowest":
                    threads.read.Priority = ThreadPriority.Lowest;
                    break;
                case "BelowNormal":
                    threads.read.Priority = ThreadPriority.BelowNormal;
                    break;
                case "Normal":
                    threads.read.Priority = ThreadPriority.Normal;
                    break;
                case "AboveNormal":
                    threads.read.Priority = ThreadPriority.AboveNormal;
                    break;
                case "Highest":
                    threads.read.Priority = ThreadPriority.Highest;
                    break;
            }
            count2++;
            if (count1 >= 1 && count2 >= 1)
            {
                StartBtn.Enabled = true;
            }
        }

        public void Display()
        {
            DisplayBox.Text = Threads.content;
        }
    }
}

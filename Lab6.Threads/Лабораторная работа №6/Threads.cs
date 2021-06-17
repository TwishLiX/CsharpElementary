using System;
using System.IO;
using System.Threading;

namespace Лабораторная_работа__6
{
    class Threads
    {
        const int size = 100;
        public static int[] numbers = new int[size];
        public static string content;
        public Thread write = new Thread(Writing);
        public Thread read = new Thread(Reading);
        public void Execution()
        {
            write.Start();
            write.Join();
            read.Start();
            read.Join();
        }

        public static void Writing()
        {
            Random rand = new Random();
            StreamWriter w = new StreamWriter("threads.txt");
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rand.Next(-100, 100);
                w.Write($"\t{numbers[i]}");
            }
            w.Close();
        }

        public static void Reading()
        {
            StreamReader r = new StreamReader("threads.txt");
            content = r.ReadToEnd();
            r.Close();
        }
    }
}

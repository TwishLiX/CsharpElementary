using System;

namespace LAB2CSHARP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input an amount (N) of triangles : ");
            int N = int.Parse(Console.ReadLine());
            Triangles[] N_triangles = new Triangles[N];
            Console.WriteLine("Input an amount (M) of rectangle triangles : ");
            int M = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Triangles[] M_triangles = new Triangles[M];
            Triangles triangles = new Triangles();
            triangles.getTriangles(N_triangles);
            triangles.printTriangles(N_triangles);
            triangles.printMinMaxSquare(N_triangles);
            Console.WriteLine();
            triangles.getRightTriangles(M_triangles);
            triangles.printRightTriangles(M_triangles);
            triangles.printRepetitions(M_triangles);
            Console.ReadKey();
        }
    }
    class Triangle
    {
        public double[] pointX = new double[3];
        public double[] pointY = new double[3];
        public Triangle()
        {
            Random rand = new Random();
            for (int i = 0; i < 3; i++)
            {
                pointX[i] = rand.Next(-9, 9);
                pointY[i] = rand.Next(-9, 9);
            }
        }
        public double getSideAB()
        {
            return Math.Sqrt(Math.Pow(pointX[1] - pointX[0], 2) + Math.Pow(pointY[1] - pointY[0], 2));
        }
        public double getSideBC()
        {
            return Math.Sqrt(Math.Pow(pointX[2] - pointX[1], 2) + Math.Pow(pointY[2] - pointY[1], 2));
        }
        public double getSideAC()
        {
            return Math.Sqrt(Math.Pow(pointX[2] - pointX[0], 2) + Math.Pow(pointY[2] - pointY[0], 2));
        }
        public bool getExistence()
        {
            if ((getSideAB() + getSideBC() > getSideAC()) && getSideAB() > 0 && getSideBC() > 0 && getSideAC() > 0 || (getSideBC() + getSideAC() > getSideAB()) && getSideAB() > 0 && getSideBC() > 0 && getSideAC() > 0 || (getSideAB() + getSideAC() > getSideBC()) && getSideAB() > 0 && getSideBC() > 0 && getSideAC() > 0)
                return true;
            else
                return false;
        }
        public double getAngleA()
        {
            return Math.Acos((getSideAC() * getSideAC() + getSideAB() * getSideAB() - getSideBC() * getSideBC()) / (2 * getSideAB() * getSideAC())) * 180 / Math.PI;
        }
        public double getAngleB()
        {
            return Math.Acos((getSideAB() * getSideAB() + getSideBC() * getSideBC() - getSideAC() * getSideAC()) / (2 * getSideAB() * getSideBC())) * 180 / Math.PI;
        }
        public double getAngleC()
        {
            return Math.Acos((getSideAC() * getSideAC() + getSideBC() * getSideBC() - getSideAB() * getSideAB()) / (2 * getSideBC() * getSideAC())) * 180 / Math.PI;
        }
        public double getPerimeter()
        {
            return getSideAB() + getSideBC() + getSideAC();
        }
        public double getSquare()
        {
            return Math.Sqrt(getPerimeter() * (getPerimeter() - getSideBC()) * (getPerimeter() - getSideAB()) * (getPerimeter() - getSideAC()));
        }
    }
    class Right : Triangle
    {
        public bool getSquareness()
        {
            if ((getSideAB() * getSideAB() + getSideBC() * getSideBC() == getSideAC() * getSideAC()) && getSideAB() > 0 && getSideBC() > 0 && getSideAC() > 0 || (getSideAB() * getSideAB() + getSideAC() * getSideAC() == getSideBC() * getSideBC()) && getSideAB() > 0 && getSideBC() > 0 && getSideAC() > 0 || (getSideAC() * getSideAC() + getSideBC() * getSideBC() == getSideAB() * getSideAB()) && getSideAB() > 0 && getSideBC() > 0 && getSideAC() > 0)
                return true;
            else
                return false;
        }
    }
    class Triangles : Right
    {
        public double count;
        public void getTriangles(Triangles[] N_triangles)
        {
            for (int i = 0; i < N_triangles.Length; i++)
            {
                do
                {
                    N_triangles[i] = new Triangles();
                } while (N_triangles[i].getExistence() == false);
            }
        }
        public void printTriangles(Triangles[] N_triangles)
        {
            for (int i = 0; i < N_triangles.Length; i++)
            {
                Console.WriteLine($"Information about the {i + 1} triangle :");
                Console.WriteLine($"Side AB = {String.Format("{0:0.00}", N_triangles[i].getSideAB())}cm, BC = {String.Format("{0:0.00}", N_triangles[i].getSideBC())}cm, AC = {String.Format("{0:0.00}", N_triangles[i].getSideAC())}cm");
                Console.WriteLine($"Angle A = {String.Format("{0:0.00}", N_triangles[i].getAngleA())} degrees, B = {String.Format("{0:0.00}", N_triangles[i].getAngleB())} degrees, C = {String.Format("{0:0.00}", N_triangles[i].getAngleC())} degrees");
                Console.WriteLine($"Perimeter = {String.Format("{0:0.00}", N_triangles[i].getPerimeter())}cm, Square = {String.Format("{0:0.00}", N_triangles[i].getSquare())}cm^2");
                Console.WriteLine();
            }
        }
        public int getMaxSquare(Triangles[] N_triangles)
        {
            int max = 0;
            for (int i = 0; i < N_triangles.Length; i++)
            {
                if (N_triangles[max].getSquare() < N_triangles[i].getSquare())
                    max = i;
            }
            return max;
        }
        public int getMinSquare(Triangles[] N_triangles)
        {
            int min = 0;
            for (int i = 0; i < N_triangles.Length; i++)
            {
                if (N_triangles[min].getSquare() > N_triangles[i].getSquare())
                    min = i;
            }
            return min;
        }
        public void printMinMaxSquare(Triangles[] N_triangles)
        {
            Console.WriteLine($"Minimum square has triangle {getMinSquare(N_triangles) + 1}, Maximum square has triangle {getMaxSquare(N_triangles) + 1}.");
            Console.WriteLine("Information about them :");
            Console.WriteLine($"Minimum: AB = {String.Format("{0:0.00}", N_triangles[getMinSquare(N_triangles)].getSideAB())}cm, BC = {String.Format("{0:0.00}", N_triangles[getMinSquare(N_triangles)].getSideBC())}cm, AC = {String.Format("{0:0.00}", N_triangles[getMinSquare(N_triangles)].getSideAC())}cm, SQ = {String.Format("{0:0.00}", N_triangles[getMinSquare(N_triangles)].getSquare())}cm^2.");
            Console.WriteLine($"Maximum: AB = {String.Format("{0:0.00}", N_triangles[getMaxSquare(N_triangles)].getSideAB())}cm, BC = {String.Format("{0:0.00}", N_triangles[getMaxSquare(N_triangles)].getSideBC())}cm, AC = {String.Format("{0:0.00}", N_triangles[getMaxSquare(N_triangles)].getSideAC())}cm, SQ = {String.Format("{0:0.00}", N_triangles[getMaxSquare(N_triangles)].getSquare())}cm^2.");
        }
        public void getRightTriangles(Triangles[] M_triangles)
        {
            for (int i = 0; i < M_triangles.Length; i++)
            {
                do
                {
                    M_triangles[i] = new Triangles();
                } while (M_triangles[i].getSquareness() == false || M_triangles[i].getExistence() == false);
            }
        }
        public void printRightTriangles(Triangles[] M_triangles)
        {
            for (int i = 0; i < M_triangles.Length; i++)
            {
                Console.WriteLine($"Information about the {i + 1} right triangle :");
                Console.WriteLine($"Side AB = {String.Format("{0:0.00}", M_triangles[i].getSideAB())}cm, BC = {String.Format("{0:0.00}", M_triangles[i].getSideBC())}cm, AC = {String.Format("{0:0.00}", M_triangles[i].getSideAC())}cm");
                Console.WriteLine($"Angle A = {String.Format("{0:0.00}", M_triangles[i].getAngleA())} degrees, B = {String.Format("{0:0.00}", M_triangles[i].getAngleB())} degrees, C = {String.Format("{0:0.00}", M_triangles[i].getAngleC())} degrees");
                Console.WriteLine($"Perimeter = {String.Format("{0:0.00}", M_triangles[i].getPerimeter())}cm, Square = {String.Format("{0:0.00}", M_triangles[i].getSquare())}cm^2");
                Console.WriteLine();
            }
        }
        public void printRepetitions(Triangles[] M_triangles)
        {
            for (int i = 0; i < M_triangles.Length; i++)
            {
                for (int j = 0; j < M_triangles.Length; j++)
                {
                    if ((M_triangles[i].getSideAB() == M_triangles[j].getSideAB() && M_triangles[i].getSideBC() == M_triangles[j].getSideBC() && i != j && i < j) || (M_triangles[i].getSideAB() == M_triangles[j].getSideBC() && M_triangles[i].getSideBC() == M_triangles[j].getSideAB() && i != j && i < j) || (M_triangles[i].getSideAB() == M_triangles[j].getSideAB() && M_triangles[i].getSideAC() == M_triangles[j].getSideAC() && i != j && i < j) || (M_triangles[i].getSideAB() == M_triangles[j].getSideAC() && M_triangles[i].getSideAC() == M_triangles[j].getSideAB() && i != j && i < j) || (M_triangles[i].getSideBC() == M_triangles[j].getSideBC() && M_triangles[i].getSideAC() == M_triangles[j].getSideAC() && i != j && i < j) || (M_triangles[i].getSideBC() == M_triangles[j].getSideAC() && M_triangles[i].getSideAC() == M_triangles[j].getSideBC() && i != j && i < j) || (M_triangles[i].getSideAB() == M_triangles[j].getSideBC() && M_triangles[i].getSideAC() == M_triangles[j].getSideAC() && i != j && i < j) || (M_triangles[i].getSideAB() == M_triangles[j].getSideAC() && M_triangles[i].getSideBC() == M_triangles[j].getSideBC() && i != j && i < j) || (M_triangles[i].getSideBC() == M_triangles[j].getSideAC() && M_triangles[i].getSideAB() == M_triangles[j].getSideAB() && i != j && i < j) || (M_triangles[i].getSideAB() == M_triangles[j].getSideAB() && M_triangles[i].getSideBC() == M_triangles[j].getSideBC() && M_triangles[i].getSideAC() == M_triangles[j].getSideAC() && i != j && i < j))
                    {
                        Console.WriteLine($"{i + 1} and {j + 1} rectangle triangles are the same.");
                        count++;
                    }
                }
            }
            if (count == 0)
                Console.WriteLine("The same triangles don't exist.");
        }
    }
}
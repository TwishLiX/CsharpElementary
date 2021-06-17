using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лабораторная_работа__2
{
    class Triangle
    {
        static int f = 0;
        public double[] pointX;
        public double[] pointY;
        public Triangle()
        {
            pointX = new double[3];
            pointY = new double[3];
            Random rand = new Random(f++);
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
        public bool isExists()
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
        public double getHalfPerimeter()
        {
            return getPerimeter() / 2;
        }
        virtual public double getSquare()
        {
            return Math.Sqrt(getHalfPerimeter() * (getHalfPerimeter() - getSideBC()) * (getHalfPerimeter() - getSideAB()) * (getHalfPerimeter() - getSideAC()));
        }
        public string PrintTriangles()
        {
            string data = "";
            for (int i = 0; i < 3; i++)
            {
                data += $"X = {pointX[i]}\t Y = {pointY[i]}\n";
            }
            data += $"Side AB = {String.Format("{0:0.00}", getSideAB())}cm, BC = {String.Format("{0:0.00}", getSideBC())}cm, AC = {String.Format("{0:0.00}", getSideAC())}cm\n";
            data += $"Angle A = {String.Format("{0:0.00}", getAngleA())} degrees, B = {String.Format("{0:0.00}", getAngleB())} degrees, C = {String.Format("{0:0.00}", getAngleC())} degrees\n";
            data += $"Perimeter = {String.Format("{0:0.00}", getPerimeter())}cm, Square = {String.Format("{0:0.00}", getSquare())}cm^2\n";
            data += $"------------------------------------------------------------------\n";
            return data;
        }
    }
}

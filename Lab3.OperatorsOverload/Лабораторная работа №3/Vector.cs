using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лабораторная_работа__3
{
    class Vector
    {
        private int dim;
        private double[] vector;
        public Vector(int dim)
        {
            this.dim = dim;
            this.vector = new double[dim];
        }
        public Vector(double[] vector)
        {
            this.vector = vector;
        }
        public double this[int i]
        {
            get { return vector[i]; } set { vector[i] = value; }
        }
        public override string ToString()
        {
            string str = "(";
            for (int i = 0; i < 2; i++)
            {
                str += vector[i].ToString() + ", ";
            }
            str += vector[2].ToString() + ")";
            return str;
        }
        public static Vector operator +(Vector a, Vector b)
        {
            Vector result = new Vector(3);
            for (int i = 0; i < 3; i++)
            {
                result[i] = a[i] + b[i];
            }
            return result;
        }
        public static Vector operator -(Vector a, Vector b)
        {
            Vector result = new Vector(3);
            for (int i = 0; i < 3; i++)
            {
                result[i] = a[i] - b[i];
            }
            return result;
        }
        public static double DotProduct(Vector a, Vector b)
        {
            double result = 0.0;
            for (int i = 0; i < 3; i++)
            {
                result += a[i] * b[i];
            }
            return result;
        }
        public static Vector CrossProduct(Vector a, Vector b)
        {
            Vector result = new Vector(3);
            result[0] = a[1] * b[2] - a[2] * b[1];
            result[1] = a[2] * b[0] - a[0] * b[2];
            result[2] = a[0] * b[1] - a[1] * b[0];
            return result;
        }
        public static bool Collinearity(Vector a, Vector b)
        {
            if (a[0] / b[0] == a[1] / b[1] && a[0] / b[0] == a[2] / b[2])
                return true;
            else
                return false;
        }
    }
}
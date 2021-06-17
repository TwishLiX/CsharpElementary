using System.IO;

namespace Лабораторная_работа__4
{
    class Right : Triangle
    {
        public bool isSquareness()
        {
            if ((getSideAB() * getSideAB() + getSideBC() * getSideBC() == getSideAC() * getSideAC()) && getSideAB() > 0 && getSideBC() > 0 && getSideAC() > 0 || (getSideAB() * getSideAB() + getSideAC() * getSideAC() == getSideBC() * getSideBC()) && getSideAB() > 0 && getSideBC() > 0 && getSideAC() > 0 || (getSideAC() * getSideAC() + getSideBC() * getSideBC() == getSideAB() * getSideAB()) && getSideAB() > 0 && getSideBC() > 0 && getSideAC() > 0)
                return true;
            else
                return false;
        }
        override public double getSquare()
        {
            if (getSideAB() < getSideAC() && getSideBC() < getSideAC() || getSideAB() == getSideBC() && getSideAB() < getSideAC() && getSideBC() < getSideAC())
                return (getSideAB() * getSideBC()) / 2;
            if (getSideAB() < getSideBC() && getSideAC() < getSideBC() || getSideAB() == getSideAC() && getSideAB() < getSideBC() && getSideAC() < getSideBC())
                return (getSideAB() * getSideAC()) / 2;
            if (getSideBC() < getSideAB() && getSideAC() < getSideAB() || getSideBC() == getSideAC() && getSideBC() < getSideAB() && getSideAC() < getSideAB())
                return (getSideBC() * getSideAC()) / 2;
            else
                return 1;
        }
        public Right Read(BinaryReader br)
        {
            Right temp = new Right();
            for (int i = 0; i < 3; i++)
            {
                temp.pointX[i] = br.ReadDouble();
                temp.pointY[i] = br.ReadDouble();
            }
            return temp;
        }
    }
}

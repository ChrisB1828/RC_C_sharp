using System;
using System.Collections.Generic;
using System.Text;

namespace Day7_Object
{
    class Shape
    {
        public int mala1;
        public int mala2;
        public int mala3;
        public int mala4;
        public int mala5;

        public Shape(int mala1, int mala2, int mala3)
        {
            this.mala1 = mala1;
            this.mala2 = mala2;
            this.mala3 = mala3;
        }
        public Shape(int mala1, int mala2, int mala3, int mala4)
        {
            this.mala1 = mala1;
            this.mala2 = mala2;
            this.mala3 = mala3;
            this.mala4 = mala4;
        }
        public Shape(int mala1, int mala2, int mala3, int mala4, int mala5)
        {
            this.mala1 = mala1;
            this.mala2 = mala2;
            this.mala3 = mala3;
            this.mala4 = mala4;
            this.mala5 = mala5;
        }

        public void PrintTriangle()
        {
            Console.WriteLine("Malu garumi ir " + mala1 + ", " + mala2 + ", " + mala3);
        }
        public void PrintSquare()
        {
            Console.WriteLine("Malu garumi ir " + mala1 + ", " + mala2 + ", " + mala3 + ", " + mala4);
        }
        public void PrintPentagone()
        {
            Console.WriteLine("Malu garumi ir " + mala1 + ", " + mala2 + ", " + mala3 + ", " + mala4 + ", " + mala5);
        }

        public void PerimetrTri()
        {
            int perimetr = mala1 + mala2 + mala3;
            Console.WriteLine("Perimetrs ir " + perimetr);
        }
        public void PerimetrSq()
        {
            int perimetr = mala1 + mala2 + mala3 + mala4;
            Console.WriteLine("Perimetrs ir " + perimetr);
        }
        public void PerimetrPenta()
        {
            int perimetr = mala1 + mala2 + mala3 + mala4 + mala5;
            Console.WriteLine("Perimetrs ir " + perimetr);
        }

    }
}

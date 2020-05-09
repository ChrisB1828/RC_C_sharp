using System;
using System.Collections.Generic;
using System.Text;

namespace Day7_Object
{
    class Trijsturis
    {
        public int mala1;
        public int mala2;
        public int mala3;

        public Trijsturis(int mala1, int mala2, int mala3)
        {
            this.mala1 = mala1;
            this.mala2 = mala2;
            this.mala3 = mala3;
        }

        public Trijsturis(int mala1, int mala2)
        {
            this.mala1 = mala1;
            this.mala2 = mala2;
        }

        public void Pirnt()
        {
            Console.WriteLine(mala1 + " " + mala2 + " " + mala3);
        }
    }
}

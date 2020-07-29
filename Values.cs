using System;
using System.Collections.Generic;
using System.Text;

namespace inheritance
{
    class Values
    {
        protected int p, l;
        public void Nilai(int a, int b)
    {
            p = a;
            l = b;
    }
    }

    class luasPersegiPanjang : Values {
    public int area()
    {
    return (p * l);
    }
    }
    class KelilingPersegiPanjang : Values {
    public int area()
    {
    return ((p + l) * 2);
    }
    }
}

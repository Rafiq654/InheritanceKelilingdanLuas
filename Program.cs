using System;
using System.Collections.Generic;
using System.Text;

namespace inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            luasPersegiPanjang a = new luasPersegiPanjang();
            KelilingPersegiPanjang b = new KelilingPersegiPanjang();
            
            a.Nilai(3 ,4);
            b.Nilai(3, 4);
            
            Console.WriteLine("Luas Persegi Panjang = " + a.area());
            Console.WriteLine("Keliling Persegi Panjang = " + b.area());

            Console.ReadKey();

        }
    }
}

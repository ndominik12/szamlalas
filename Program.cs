using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace szamlalas
{
    internal class Program
    {
        static int[] meres = { 36, 48, 39, -1, 30, 43, -1, 76, 67, 82, 73, 75, 64, 73, 69, 63 };

        static void Main(string[] args)
        {
            int osszeg = 0;
            for (int i = 0; i < meres.Length; i++)
                if (meres[i] != -1) osszeg += meres[i];

            Console.WriteLine("2. feladat");
            Console.WriteLine("Osszesen " + osszeg + " kerekparost szamoltak.");
        }
    }
}
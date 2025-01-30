using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jarmu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sportauto a1 = new Sportauto("Ferrari", "488 GTB", 2020, 330);
            Console.WriteLine(a1);

            a1.Gyorsit(50);
            a1.Fekez(20);

            Console.WriteLine(1);
        }
    }
}

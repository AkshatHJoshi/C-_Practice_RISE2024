using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace project1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Nullable<int> i = null;
            Console.WriteLine(i);

            int? a = 10;
            int? c = null;

            int b = a ?? 10;
            Console.WriteLine(b);

            if (Nullable.Compare<int>(a, c) < 0)
            {
                Console.WriteLine("values mached");
            }

            Console.WriteLine(Nullable.Compare<int>(c, a) > 0);


            Console.ReadLine();
        }
    }
}


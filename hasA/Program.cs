using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System;
namespace hasA
{

    class A
    {
        public int i;
        public int j;

        public A(int i, int j)
        {
            this.i = i;
            this.j = j;
        }
    }

    class B
    {
        public int m;
        public int n;
        A a2;
        public B(int m, int n, A a)
        {
            this.m = m;
            this.n = n;
            a2 = a;

        }
        public void mymethod() { Console.WriteLine(a2.i); }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            A a1 = new A(10, 11);

            B b = new B(20, 25, a1);

            Console.WriteLine("Akshat");
            b.mymethod();

            Console.ReadLine();

        }
    }
}


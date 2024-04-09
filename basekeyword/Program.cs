using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basekeyword
{

    class A                                                                   //base class
    {
        public int i;
         
        public A()
        {
            Console.WriteLine("i am base class constructor default");
        }
        public A(int x)
        {
            Console.WriteLine("i am base class constructor with argument");
        }
        public void display()
        {
            Console.WriteLine("Hello... Akshat Joshi...");
        }
    }

    class B : A                                                      //derived class
    {
        public int j = 20;

        public B()
        {
            Console.WriteLine("i am derived class constructor");
        }
        public B(int x)
        {
            Console.WriteLine("i am derived class constructor with parameters "+x );
        }

        public void display()
        {
            Console.WriteLine("Hi...  how are you...");
        }
    }

    class C : B                                                       // de-derived class
    {
        public int k;

        public C(int l, int m) : base(m)                                       // calling base class parameter constructor
        {
           
            Console.WriteLine("i am de-derived class constructor"+base.j+" "+l);   // calling base class property
        }

        public void display()
        { 
            base.display();                                                        // calling base class's method
            Console.WriteLine("Hiii... I am fine Akshat...");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            C c = new C(10,30);
             c.display();

            Console.ReadLine();
        }
    }
}

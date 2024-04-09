using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace overhiding
{

    class A
    {
        public int i;
        public int j;

        public virtual void method()
        {
            Console.WriteLine("i am method from base class");
        }
    }
    class B : A
    {

        public int k;
        public int l;
        public override void method()
        {
            Console.WriteLine("i am method from derived class");
        }
       
    }

    internal class Program
    {
        static void Main(string[] args)
        {
          //  
            Console.WriteLine();
            A r;                               // reference of base class
            B b = new B();                     //object of derived class
            A a = new A();                     //object of base class

            r = b;
            r.method();                         // it always calls a method of base class 
                                                // because the referance is of base class
                                                // is called overhiding

            Console.ReadLine();
                                       // to overcome the problem of overhiding write "virtual"
                                       // keyword in base's method and write "override" keyword in derived 
                                       // class's method .....then we are able to call derived class's method
                                       // by using referance of base class and object of derived class
                                       // (A r;  and  B b = new B();   and r=b;
        }
    }
}

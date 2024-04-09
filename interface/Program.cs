using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @interface
{
    // object is not created 
    interface A
    {                                             //By default, members of an interface are abstract
                                                  //and public.

        // variables is not allowed in interface
        int i { get; }                        // interface can also have property

        /* public */
        void method();                            // in interface there is no need of public
        void show1();
    }
    interface B
    {
        void method();
        void show2();
    }

    class C : A
    {
        public int x = 13;
        public int i
        {
            get { return x; }
        }

        public void method()                                    // here public is needed 
        {
            Console.WriteLine("i am method method of interface A");
        }

        public void show1()
        {
            Console.WriteLine("i am show method of interface A");
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {

            A a = new C();
            a.method();



            Console.ReadLine();
        }
    }
}


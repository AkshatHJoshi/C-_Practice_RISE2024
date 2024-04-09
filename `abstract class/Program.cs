using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _abstract_class
{

     public abstract class A                         // all virtual method must have body 
    {

       public int b = 10;                       // also var is allowed in abstract class
        public abstract void greet();

        public abstract int a { get; }

        public virtual void mymethod()
        {
            Console.WriteLine("i am mymethod from abstrat class");
        }

    }

    public class B : A
    {

       
        public override int a { get { return 5; } }
                                                               //override is needed for implementaion of 
                                                               // abstract methods
        public override void mymethod()
        {
            Console.WriteLine("i am mymethod from implimented class");
            Console.WriteLine(b);
        }

        public override void greet()
        {
            Console.WriteLine("i am greet method from implimentor class");
        }


    }



    internal class Program
    {
        static void Main(string[] args)
        {


            A ob = new B();
            ob.mymethod();
            ob.greet();
            
            Console.WriteLine(ob.a);
            Console.ReadLine();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace new_and_override
{

    class A
    {
        public virtual void method()                       // virtual method means it can be override in derived class
        {                                                  // always comes in pair vertual and override.
                                                           // it is not allowed in hairarchy of 3 class like
                                                           //  virtual - new - override
                                                           // in this case if referanse of base class and object of
                                                           // derived class (like A a= new B()) and a.method()
                                                           // calling then it calles a override method from class B
                                                           //
                                                           // new keyword is used to overhide in inheritance like
                                                           //(like A a= new B()) and a.method() then it calles from
                                                           //base class method
            Console.WriteLine("i am from base class");     // new keyword and nothing ( like - public void method())
        }                                                  //is same only difference is that without new program gives 
                                                           // warning so its good practice to use new 
    }

    class B : A 
    {
        public override void method()
        {
            Console.WriteLine("i am from deraived class");
        }
    }

    class C : B 
    {
        public override void method()
        {
            Console.WriteLine("i am from de - deraived class");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
             A a = new A();
            B b = new B();                                          // this b is a object of a class B
            C c = new C();
            A a1;                                            // this a1 is a1 is a reference of a class A 
            a1 = b;                      // this is called runtime polimorphizam .... here  we are passing object of
                                         // class B in reference of Class A
                                   
            a1.method();        


            Console.ReadLine();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sealedkeyword
{

    public class BaseClass
    {
                                              // This method can be overridden by derived classes
        public virtual void see()
        {
            Console.WriteLine("BaseClass see");
        }

       
       
    }

    public class DerivedClass : BaseClass
    {
        public sealed override void see()            // this method can not be override further 
                                                     // beacause of sealed keyword 
        {
            Console.WriteLine("DerivedClass see");
        }

                                               // This method can override the base method
       
    }

    public class dederived: DerivedClass
    {
        public override void see()                            // so this is not possible 
        {
            Console.WriteLine(" de-DerivedClass see");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            
            BaseClass b = new DerivedClass();
            b.see();

            BaseClass c = new dederived();
            c.see();                                      // error 
             

            Console.ReadLine();

        }
    }
}

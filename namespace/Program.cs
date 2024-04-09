using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @namespace
    
{
    using teamA.teamB;                   // this can use to call any proprties under teamA and
                                         // teamB namespace

    internal class Program
    {

        public class B
        {
            public int i = 10;
        }
        static void Main(string[] args)
        {

            Console.WriteLine("i am under scope of namespace teamA");
            B b = new B();
            
            //  b.show();                               // error because it is under the scope of
                                                        // team b which is not access
                                                        // by using only teamA 


            C cl = new C();
            cl.show();
            

            teamA.A ob = new teamA.A();                 // to access properties of teamA namespace
            ob.method();

            teamA.teamB.C ob1= new teamA.teamB.C();     // to access properties of teamB namespace
            ob1.show();

            Console.ReadLine();

        }
    }


}
namespace teamA
{
    namespace teamB                               // nested namespace
    {
        public class C
        {
            public void show()
            {
                Console.WriteLine("i am method from teamB");
            }
        }
    }
    public class A 
    { 
      public void method () 
        {
            Console.WriteLine("i am method from teamA");
        }

    
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{

    /*  class po
      {
          public int i;
          public static int j;

          public int method
          {

          }

          public static int method
          {

          }

          public po()
          {
              i= 1;
          }


      }*/

    enum MyEnum
    {
        red, yellow, black
    }

    class A
    {

        int sum = 0; int b;
        public A()
        {
            Console.WriteLine("i am class A constructor");
        }
        public void mymethod()
        {
            Console.WriteLine("i am class A");
        }

        public void mymethod2(params int[] b)
        {

            foreach (var i in b)
            {
                sum = sum + i;

            }

            Console.WriteLine(sum);
        }
        public void mymethod3(ref int d)
        {
            d = d + 10;
            Console.WriteLine(d);
        }

        public void mymethod4(out int o)
        {
            o = 10;
            o = o + 100;
            Console.WriteLine(o);
        }
    }
    internal class Program
    {



        static void Main(string[] args)
        {
            int o;
            int c = 5;
            int myNum = 10;
            char myChar = 'A';
            double myDouble = 397329470394;
            string myString = "Akshat Joshi";
            // bool myBool = false;

            Console.WriteLine(myNum);
            Console.WriteLine(myChar);
            Console.WriteLine(myDouble);
            Console.WriteLine(myString);

            int[] arr = { 1, 2, 3, 4, 5, 10 };
            A a = new A();
            a.mymethod();
            a.mymethod2(arr);





            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }




            int[,] arr1 = { { 1, 2 }, { 3, 4 } };


            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.WriteLine(arr1[i, j]);
                }
            }


            MyEnum e = MyEnum.yellow;
            Console.WriteLine(e);


            a.mymethod3(ref c);


            a.mymethod4(out o);
            Console.WriteLine(o + 10);


            //  Nullable<int> nu = null;

            int? nu1 = null;


            Console.WriteLine(nu1);


            Console.ReadLine();
        }
    }
}


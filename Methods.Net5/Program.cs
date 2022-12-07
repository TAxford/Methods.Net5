using System;

namespace Methods.Net5
{
    internal class Program
    {

        /*static void Main(string[] args)
        {
            WriteSomething();
            WriteSomethingSpecific("I am an argument and am called from a method");
        }

        //method example
        // access modifer (static) return type methd name (parameter1, parameter2)
        /*public static void WriteSomething()
        {
            Console.WriteLine("I am called from a method");
        }*/

        /*public static void WriteSomethingSpecific(string myText)
        {
            Console.WriteLine(myText);
            Console.Read();
        }*/


        //examples of methods with retrurn value and parameters
        static void Main(string[] args)
        {
            int result = Add(15, 31);
            Console.WriteLine(result);
            Console.Read();
        }

        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        

        




    }
}

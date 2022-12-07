using System;

namespace Methods.Net5
{
    internal class Program
    {

        static void Main(string[] args)
        {
            WriteSomething();
            WriteSomethingSpecific("I am an argument and am called from a method");
        }

        //method example
        // access modifer (static) return type methd name (parameter1, parameter2)
        public static void WriteSomething()
        {
            Console.WriteLine("I am called from a method");
        }

        public static void WriteSomethingSpecific(string myText)
        {
            Console.WriteLine(myText);
            Console.Read();
        }

        

        




    }
}

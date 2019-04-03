using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    public class Program
    {
        static string helloReference = "Hello Reference!";

        static void Main()
        { 
            Console.WriteLine("Hello World!");

            string helloString = "Hello String!";
            Console.WriteLine(helloString);

            HelloMethod();

            HelloParameter("Hello Parameter!");

            //non-void return type method
            Console.WriteLine(HelloReturn());

            //
            Console.WriteLine(helloReference);

            //arrays and foreach loop
            HelloForEach();

            //calling non-static from static
            Instance instance = new Instance();
            instance.HelloInstance();
        }

   

        static void HelloMethod()
        {
            var s = "Hello Method!";
            Console.WriteLine(s);
        }

        static void HelloParameter(string p)
        {
            Console.WriteLine(p);
        }

        static string HelloReturn()
        {
            
            return "Hello Return!";
        }

        static void HelloForEach()
        {
            char[] helloForEach = { 'H', 'e', 'l', 'l', 'o', ' ', 'F', 'o', 'r', 'E', 'a', 'c', 'h', '!' };
            foreach (char letter in helloForEach)
            {
                Console.Write(letter);
            }
            Console.WriteLine();
        }

        //calling non-static from static
        public class Instance
        {
            public void HelloInstance()
            {
                Console.WriteLine("Hello Instance!");
            }

        }


    }
}

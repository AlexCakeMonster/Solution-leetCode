using System;
using System.Collections;
using System.Linq;


namespace П
{
    class Program
    {
        
        static void Main(string[] args)
        {
            try
            {
                throw null;
            }

            catch (Exception) { }

            Console.WriteLine("Hello World");


            Console.ReadKey();
        }
    }
}

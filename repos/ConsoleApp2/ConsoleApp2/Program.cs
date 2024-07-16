using System;

namespace ConsoleApp2
{
    class Program
    {
     class Sampler2
        {
            static string who = "class";
            static void F()
            {
                string who = "F";
            }
            static void G()
            {
                F();
                Console.WriteLine(who);
            }
        }   
       
    }
}

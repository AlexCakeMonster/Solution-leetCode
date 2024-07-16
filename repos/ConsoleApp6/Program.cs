using System;

namespace ConsoleApp6
{
    class MyClass
    {
        public bool IsLuckyTicket(string ticket)
        {           
            char[] ticketNamberArray = ticket.ToCharArray();
            
            if(ticketNamberArray.Length == 6)
            {
                int[] ticketIntArray = new int[ticketNamberArray.Length];

                for (int i = 0; i < ticketNamberArray.Length; i++)
                {
                    if (char.IsDigit(ticketNamberArray[i]))
                    {
                        string q = Convert.ToString(ticketNamberArray[i]);
                        ticketIntArray[i] = Int32.Parse(q);
                    }
                    else
                    {
                        return false;
                    }
                                       
                }


                int sumOfTheFirstNumbers = ticketIntArray[0] + ticketIntArray[1] + ticketIntArray[2];
                int sumOfTheSecondNumbers = ticketIntArray[3] + ticketIntArray[4] + ticketIntArray[5];                

                if(sumOfTheFirstNumbers == sumOfTheSecondNumbers)
                {
                    return true;
                }                
            }

            return false;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass();            
            Console.WriteLine(myClass.IsLuckyTicket("5g2561"));
            
        }
    }
}

using System;

public class Class1
{
	public Class1()
	{
		static void Main(string[] args)
        {
            do
            {
                Console.Write("x = ");
                int x = Convert.ToInt32(Console.ReadLine());
                Console.Write("y = ");
                int y = Convert.ToInt32(Console.ReadLine());
                int sum = x + y;
                Console.WriteLine("Result: {0}", sum);
            }
            while (true);
        }
	}
}
using System;
using System.IO;
using System.Text;

namespace Txt
{
    class Program
    {
        static void Main(string[] args)
        {
            var fail = new FileStream("test.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            var writer = new StreamWriter(fail);
            Console.WriteLine("Введите текст.");
            string text = Console.ReadLine();
            writer.WriteLine(text);
            writer.Close();
            StreamReader reader = File.OpenText("test.txt");
            string input;
            while((input = reader.ReadLine()) != null)
            {
                Console.WriteLine(input);
            }

            Console.ReadKey();
        }
    }
}

using System;
namespace Less05_task03
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass instance = new MyClass();

            Console.WriteLine(instance[2]);
            //выход за пределы массива
            Console.WriteLine(instance[10]);

            Console.ReadKey();
        }
    }

    class MyClass
    {
        string[] array = new string[3] { "one", "two", "three" };

        public string this[int index]
        {
            get
            {
                if(index < array.Length && index >= 0)
                {
                    return array[index];
                }
                else
                {
                    return "index out of range";
                }
            }

            set
            {
                if (index < array.Length && index >= 0)
                {
                    array[index] = value;
                }
                else
                {
                    ;
                }
            }
        }
    }
}
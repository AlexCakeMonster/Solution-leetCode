using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            Converter converter = new Converter(94.15, 100.47, 117.37);
            Console.WriteLine(converter.ConvertingEurToRub(1000));
            Console.WriteLine(converter.ConvertingRubToUsd(1000));

            Console.ReadKey();
        }
    }
}

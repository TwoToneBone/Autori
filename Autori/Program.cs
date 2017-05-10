using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autori
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split('-');
            string output = string.Empty;

            foreach (var input in inputs)
            {
                output += input[0].ToString();
            }

            Console.WriteLine(output);
        }
    }
}

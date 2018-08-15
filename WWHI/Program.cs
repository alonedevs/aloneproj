using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WWHI
{
    class Program
    {
        static void Main(string[] args)
        {
            answer.GetArray();
            while (true)
            {
                Console.Write("А что если бы ");
                Console.ReadLine();
                Console.WriteLine(answer.GetAnswer());
            }
        }
    }
}

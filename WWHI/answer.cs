using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WWHI
{
    class answer
    {
        static string[] Answers = { };
        static void GetArray()
        {
            StreamReader fs = new StreamReader(@"answers.txt");
            for (int i = 0; i < fs.ReadToEnd().Length; i++)
            {
                Answers[i] = fs.ReadLine();
            }
        }
        public static string GetAnswer()
        {
            {
                Random rnd = new Random();
                return Answers[rnd.Next(0, Answers[].Lenght)];
            }
        }
    }
}



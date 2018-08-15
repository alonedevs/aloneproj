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
        static List<string> Answers = new List<string>();
        public static void GetArray()
        {
            using (StreamReader fs = new StreamReader("answers.txt", System.Text.Encoding.Default))
            {
                string str;
                while ((str = fs.ReadLine()) != null)
                {
                    Answers.Add(str);
                }
            }
        }
        public static string GetAnswer()
        {
            Random rand = new Random();
            return Answers[rand.Next(Answers.Count)];
        }
    }
}

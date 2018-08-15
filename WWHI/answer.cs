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
<<<<<<< HEAD
        static List<string> Answers = new List<string>();
        public static void GetArray()
=======
        static string[] Answers = { };
        static void GetArray()
>>>>>>> b8bc9f79a520da82c74d9115ccef76805e1af812
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
<<<<<<< HEAD
            Random rand = new Random();
            return Answers[rand.Next(Answers.Count)];
=======
            {
                Random rnd = new Random();
                return Answers[rnd.Next(0, Answers[].Lenght)];
            }
>>>>>>> b8bc9f79a520da82c74d9115ccef76805e1af812
        }
    }
}



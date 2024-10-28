using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ocjenskaVjezba01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite znakove: ");
            string s1 = Console.ReadLine();

            if (s1.Length < 5)
            {
                Console.WriteLine(s1);
            }
            else
            {
                string s2 = s1.Substring(2, s1.Length - 4);
                Console.WriteLine(s2);
            }

            Console.ReadKey();

        }
    }
}

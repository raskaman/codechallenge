using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            //Staircase();

            Console.ReadLine();
        }

        public static void Staircase()
        {
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i < n + 1; i++)
            {
                Console.Write(string.Concat(Enumerable.Repeat(" ", n - i)) + string.Concat(Enumerable.Repeat("#", i)) + (i < n ? "\n" : ""));
            }
        }
    }
}

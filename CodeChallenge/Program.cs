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

            SaveTheProisoner();

            Console.ReadLine();
        }
        /*
            1 
            5 2 1

            5 prisioners, 2 sweets, distributions starts 1

3
5 2 1
5 2 1
5 2 1
        */
        private static void SaveTheProisoner()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[][] arrMulti = new int[n][];

            for (int i = 0; i < n; i++)
            {
                string[] arr_temp = Console.ReadLine().Split(' ');
                int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);
                arrMulti[i] = arr;
            }

            for (int i = 0; i < arrMulti.Length; i++)
            {
                var prisioners = arrMulti[i][0];
                var sweets = arrMulti[i][1];
                var startDistribution = arrMulti[i][2];

                int poison = startDistribution + (sweets - 1);

                int rounds = sweets / prisioners;
                if (rounds > 1)
                {
                    poison = poison - (rounds * prisioners);
                }

                if (poison > prisioners)
                {
                    poison = poison - prisioners;
                }
                else if (poison == 0) {
                    poison = startDistribution;
                }
                Console.Write(poison + (i < n-1 ? "\n" : ""));                
            }
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

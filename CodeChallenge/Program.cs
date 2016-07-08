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
5 2 4
5 2 5
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

                int poison;

                if (sweets > prisioners)
                {
                    var dif = sweets % prisioners;
                    sweets = dif == 0 ? prisioners : dif;
                }

                poison = startDistribution + sweets - 1;

                if (poison > prisioners)
                {
                    poison = poison - prisioners;
                }
                
                Console.WriteLine(poison);
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

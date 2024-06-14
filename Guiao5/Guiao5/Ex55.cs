using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guiao5
{
    internal class Ex55
    {
        public static void find_pairs_v1(int[] a, int v)
        {
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = i + 1; j < a.Length; j++)
                {
                    if (a[i] + a[j] == v)
                    {
                        Console.WriteLine("{0,5} {1,5}", a[i], a[j]);
                    }
                }
            }
        }

        public static void find_pairs_v2(int[] a, int v)
        {
            Console.WriteLine("Output from find_pairs_v2:");
            int[] pc = new int[v + 1];

            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] <= v)
                    pc[a[i]] = 1;
            }

            for (int i = 0; i < a.Length; i++)
            {
                if (2 * a[i] < v && pc[v - a[i]] != 0)
                    Console.WriteLine("{0,5} {1,5}", a[i], v - a[i]);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guiao5
{
    internal class Ex51
    {
        public static int F1(int n)
        {
            int r = 0;
            for (int i = 1; i <= n; i++)
                r += 1;
            return r;
        }

        public static int F2(int n)
        {
            int r = 0;
            for (int i = 1; i <= n; i++)
                for (int j = 1; j <= i; j++)
                    r += 1;
            return r;
        }

        public static int F3(int n)
        {
            int r = 0;
            for (int i = 1; i <= n; i++)
                for (int j = 1; j <= n; j++)
                    r += 1;
            return r;
        }

        public static int F4(int n)
        {
            int r = 0;
            for (int i = 1; i <= n; i++)
                r += i;
            return r;
        }

        public static int F5(int n)
        {
            int r = 0;
            for (int i = 1; i <= n; i++)
                for (int j = i; j <= n; j++)
                    r += 1;
            return r;
        }

        public static int F6(int n)
        {
            int r = 0;
            for (int i = 1; i <= n; i++)
                for (int j = 1; j <= i; j++)
                    r += j;
            return r;
        }
    }
}

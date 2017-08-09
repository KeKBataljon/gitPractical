using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace git_Practical
{
    class CalcMax
    {
        private int n;
        private int[] arr;
        private Random ra;
        private int max;

        public CalcMax()
        {

        }

        public CalcMax(int nMax)
        {
            n = nMax;
            ra = new Random();
            max = 0;
            calcMax(n);
        }

        private int calcMax(int n)
        {
            arr = new int[n];
            max = 0;

            for (int i = 0; i < n; i++)
            {
                arr[i] = ra.Next(0, 100);
            }

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }

            return max;
        }

        public string toString()
        {
            return Convert.ToString(max);
        }
    }
}

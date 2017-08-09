using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace git_Practical
{
    class CalcMin
    {
        private int n;
        private int[] arr;
        private Random rand;
        private int min;

        public CalcMin()
        {

        }

        public CalcMin(int n1)
        {
            n = n1;
            rand = new Random();
            min = 0;
            calcMin(n);

        }

        private int calcMin(int n)
        {
            arr = new int[n];
            min = 100;
            for (int i = 0; i < n; i++)
            {
                arr[i] = rand.Next(0, 100);
            }
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }
            return min;
        }

        public string toString()
        {
            return Convert.ToString(min);
        }
    }
}

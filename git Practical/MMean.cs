using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace git_Practical
{
    class MMean
    {
        private int n;
        private int[] arr;
        private Random rand;
        private double mean;

        public MMean()
        {

        }

        public MMean(int no)
        {
            n = no;
            rand = new Random();
            mean = 0;
            calcMean(n);
        }

        private void calcMean(int n)
        {
            arr = new int[n];
            double sum = 0;

            for (int i = 0; i < n; i++)
            {
                arr[i] = rand.Next(0, 100000);
                sum = sum + arr[i];
            }

            mean = (sum / n);
        }

        public string toString()
        {
            return Convert.ToString(mean);
        }
    }
}

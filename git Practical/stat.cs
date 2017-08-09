using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace git_Practical
{
    class stat
    {
        private int[] array;
        private double median;

        public stat(int n)
        {
            array = random(n);
            Array.Sort<int>(array);
            median = calcMedian(array);
        }
        private double calcMedian(int[] array)
        {
            decimal Median = 0;
            int size = array.Length;
            int mid = size / 2;
            Median = (size % 2 != 0) ? (decimal)array[mid] : ((decimal)array[mid] + (decimal)array[mid + 1]) / 2;
            return Convert.ToDouble(Median);
        }

        private int[] random(int n)
        {
            Random random = new Random();
            int[] array = new int[n];

            for (int i = 0; i < n; i++)
            {
                array[i] = random.Next(0, 20);
            }

            return array;
        }

        public double getMedian()
        {
            return median;
        }
        public int[] getArray()
        {
            return array;
        }
    }
}

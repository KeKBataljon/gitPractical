using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace git_Practical
{
    class StatCalc
    {
        private int n;
        private int[] arrayOfRanNum;
        private int max;
        private int min;
        private double mean;
        private double median;
        private double standardDeviation;

        public StatCalc()
        {

        }

        public StatCalc(int nOfRanderNumbers)
        {
            n = nOfRanderNumbers;
            arrayOfRanNum = generateRandomNumbers(n);
            max = calcMax(arrayOfRanNum);
            min = calcMin(arrayOfRanNum);
            mean = calcAve(arrayOfRanNum);
            median = calcMedian(arrayOfRanNum);
            standardDeviation = calcStanDev(arrayOfRanNum);
           
        }


        //method to generate random numbers
        public int[] generateRandomNumbers(int n)
        {
            Random random = new Random();
            int[] arrayOfRandomNumbers = new int[n];

            for (int i = 0; i < n; i++)
            {
                arrayOfRandomNumbers [i] = random.Next(0, 100);
            }

            return arrayOfRandomNumbers;
        }

        //method that calculates Max;
        private int calcMax(int [] arrayOfNum)
        {
            int max = 0;
            for (int i = 0; i < arrayOfNum.Length; i++)
            {
                if (arrayOfNum[i] > max)
                {
                    max = arrayOfNum[i];
                }
            }
            return max;
        }

        //method that calculates Min;
        private int calcMin(int [] arrayOfNum)
        {
            int min = 200;
            for (int i = 0; i < arrayOfNum.Length; i++)
            {
                if (arrayOfNum[i] < min)
                {
                    min = arrayOfNum[i];
                }
            }
            return min;
        }

        //A mean is the same as an average;
        private double calcAve(int [] arrayOfNum)
        {
            int total = 0;
            double ave = 0;
            for (int i = 0; i < arrayOfNum.Length; i++)
            {
                total += arrayOfNum[i];
            }
            ave = total / arrayOfNum.Length;
            return ave;
        }

        //method to calculate median
        private double calcMedian(int [] array)
        {
            double median = 0;
            //obtain ordered array:
            int[] orderedArray;
            orderedArray = array.OrderBy( i => i).ToArray();
            //find middle term:
            if (orderedArray.Length % 2 == 0) //n is even
            {
                median = (orderedArray[array.Length / 2] + orderedArray[array.Length / 2 - 1]) / 2;
            }
            else if (orderedArray.Length % 2 != 0) // n is odd
            {
                median = orderedArray[(int)(orderedArray.Length / 2 - 0.5)];
            }
            return median;
        }

        //method calculates standard deviation
        private double calcStanDev(int [] array)
        {
            double sigma = 0;
            double variance = 0;
            double standardDeviation = 0;

            for(int i = 0; i < array.Length; i++)
            {
                sigma += Math.Pow((array[i] - this.mean), 2);
            }
            variance = sigma / array.Length;
            standardDeviation = Math.Sqrt(variance);

            return standardDeviation;
        }
        

        public string getMax()
        {
            return this.max.ToString();
        }

        public String getAve()
        {
            return this.mean.ToString();
        }

        public string getMin()
        {
            return this.min.ToString();
        }

        public string getMedian()
        {
            return this.median.ToString();
        }

        public string getStanDev()
        {
            return this.standardDeviation.ToString();
        }


        public string toString()
        {
            String s = "";

            for (int i = 0; i < arrayOfRanNum.Length; i++)
            {
                s += arrayOfRanNum[i].ToString() + ", ";
            }
            try
            {
                s = s.Remove(s.Length - 2);
            }
            catch (Exception e)
            {
                Console.WriteLine("s.Length < 2");
            }
            return s;
        }

    }


}

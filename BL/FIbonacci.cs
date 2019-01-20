using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class FIbonacci : ISequence
    {
        private const string FIBONACCI_SEQUENCE = "Your Fibonacci sequence: ";
        private int minNum;
        private int maxNum;
        private List<int> arr = new List<int>();

        public void CreateSequences(params int[] num)
        {
            FoundMinMaxNum(num);

            FibSequence();

        }

        private void FoundMinMaxNum(int[] num)
        {
            minNum = maxNum = num[0];

            if (num[0] > num[1])
            {
                minNum = num[1];
                maxNum = num[0];
            }
            else if (num[0] < num[1])
            {
                minNum = num[0];
                maxNum = num[1];
            }

        }

        private void FibSequence()
        {
            int fibFirst = 0;
            int fibSecond = 1;

            while (fibSecond < maxNum)
            {
                int tmp = fibSecond;
                fibSecond += fibFirst;
                fibFirst = tmp;

                if (fibSecond >= minNum && fibSecond <= maxNum)
                {
                    arr.Add(fibSecond);
                }

            }
        }

        public override string ToString()
        {
            string s = string.Format(FIBONACCI_SEQUENCE);

            foreach (var item in arr)
            {
                s += item.ToString() + ", ";
            }

            return s;
        }
    }
}

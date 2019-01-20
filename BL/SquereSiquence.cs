using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class SquereSiquence : ISequence
    {
        private const string SQUERE_SIQUENCE = "Your squere siquence: ";

        private int maxNum = 0;
        private List<int> arr = new List<int>();

        public void CreateSequences(params int[] num)
        {
            maxNum = num[0];

            FormSequence();
        }

        private void FormSequence()
        {
            int num = 1;

            while (Math.Pow(num, 2) < maxNum)
            {
                arr.Add(num);
                num++;                
            }
        }
               
        public override string ToString()
        {
            string s =string.Format(SQUERE_SIQUENCE);

            foreach (var item in arr)
            {
                s += item.ToString() + ", ";
            }

            return s;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class FIbonacci : Sequence
    {
        private const string FIBONACCI_SEQUENCE = "Your Fibonacci sequence: ";

        private void FoundMinMaxLimit(ref long maxLimit, ref long minLimit)
        {
            long tmp = maxLimit;

            if (tmp < minLimit)
            {
                maxLimit = minLimit;
                minLimit = tmp;
            }
        }

        public override void FormSequence(long maxLimit, long minLimit)
        {
            int fibFirst = 0;
            int fibSecond = 1;
            int i = 0;

            this.FoundMinMaxLimit(ref maxLimit, ref minLimit);

            while (fibSecond < maxLimit)
            {
                int tmp = fibSecond;
                fibSecond += fibFirst;
                fibFirst = tmp;


                if (fibSecond >= minLimit && fibSecond <= maxLimit)
                {
                    sequence[i] = fibSecond;
                    i++;
                }
            }
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}

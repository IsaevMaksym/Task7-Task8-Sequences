using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class FIbonacci : Sequence
    {
        public override void FormSequence(long maxLimit, long minLimit)
        {
            long fibFirst = 0;
            long fibSecond = 1;

            this.CorrectMinMaxLimits(ref maxLimit, ref minLimit);

            while (fibSecond < maxLimit)
            {
                long tmp = fibSecond;
                fibSecond += fibFirst;
                fibFirst = tmp;

                if (fibSecond >= minLimit && fibSecond <= maxLimit)
                {
                    _sequence.Enqueue(fibSecond);
                }
            }
        }

        private void CorrectMinMaxLimits(ref long maxLimit, ref long minLimit)
        {

            maxLimit=Math.Abs(maxLimit);
            minLimit=Math.Abs(minLimit);

            long tmp = maxLimit;

            if (tmp < minLimit)
            {
                maxLimit = minLimit;
                minLimit = tmp;
            }
        }

    }
}

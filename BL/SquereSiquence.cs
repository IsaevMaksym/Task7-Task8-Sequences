using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class SquereSiquence : Sequence
    {
        public override void FormSequence(long maxLimit, long minLimit=0)
        {
            int maxLimitSQRT=(int)Math.Sqrt(maxLimit);

            for (int i = 0; i < maxLimitSQRT; i++)
            {
                _sequence.Enqueue(i);
            }
        }
        
    }
}


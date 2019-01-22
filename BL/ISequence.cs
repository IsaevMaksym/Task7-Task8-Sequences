using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
   public interface ISequence:IEnumerator<int>
    {
        void FormSequence(long maxLimit, long minLimit);
    }
}

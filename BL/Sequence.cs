using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public abstract class Sequence
    {
        private const string SQUERE_SIQUENCE = "Your squere siquence: ";
        private const string FIBONACCI_SEQUENCE = "Your Fibonacci sequence: ";

        protected Queue<long> _sequence = new Queue<long>();
        private StringBuilder _stringBuilder = new StringBuilder(200);

        public abstract void FormSequence(long maxLimit, long minLimit = 0);

        public virtual IEnumerator<long> GetEnumerator()
        {
            if (_sequence == null)
            {
                yield return 0;
            }
            foreach (int num in _sequence)
            {
                yield return num;
            }
        }

        public override string ToString()
        {
            if (this is FIbonacci)
            {
                _stringBuilder.Append(FIBONACCI_SEQUENCE);
            }
            else
            {
                _stringBuilder.Append(SQUERE_SIQUENCE);
            }
            foreach (int num in _sequence)
            {
                _stringBuilder.Append(num).Append(", ");
            }

            return _stringBuilder.ToString();
        }
    }
}
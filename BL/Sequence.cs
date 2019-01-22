using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public abstract class Sequence : IEnumerator<int>
    {
        protected int[] sequence;
        protected int position = -1;
        private StringBuilder stringBuilder = new StringBuilder(200);

        public abstract void FormSequence(long maxLimit, long minLimit);

        public int Current
        {
            get
            {
                if (position == -1 || position >= sequence.Length)
                    throw new InvalidOperationException();

                return sequence[position];
            }
        }

        object IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }
        
        public void Dispose()
        {
            this.Dispose();
        }

        public bool MoveNext()
        {
            position++;

            return (position < sequence.Length);
        }

        public void Reset()
        {
            position = -1;
        }

        public override string ToString()
        {
            foreach (int num in sequence)
            {
                stringBuilder.Append(num).Append(", ");
            }
            return stringBuilder.ToString();
        }
    }
}
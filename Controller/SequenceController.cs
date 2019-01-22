using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BL;
using Controller.Utilities;
using SequencesIO;

namespace Controller
{
    public class SequenceController
    {
        const string RULES = "Enter number(s), if you want to create a sequences.\nIf one number - it will create sequence of numbers, which square is less than the"
                            + " inserted number.\nIf enter two numbers - it will create Fibonacci sequence in inserted limits";
                
        private IViever _viever;
        private Sequence _sequence;

        public SequenceController()
            :this(new ConsoleIO())
        {
        }

        public SequenceController(IViever viever)
        {
            _viever = viever;            
        }

        public void Run(string[] args)
        {
            long[] arr;

            if (ArgsValidator.GetNumsFromInsertedArgs(args, out arr))
            {
                if (arr.Length == 0)
                {
                    _viever.ShowMessage(RULES);
                }
                else if (arr.Length == 1)
                {
                    _sequence = new SquereSiquence();
                    _sequence.FormSequence(arr[0]);
                }
                else
                {
                    _sequence = new FIbonacci();
                    _sequence.FormSequence(arr[0], arr[1]);
                }
                
                _viever.ShowMessage(_sequence.ToString());
            }
            else
            {
                _viever.ShowMessage(RULES);
            }
        }

    }
}

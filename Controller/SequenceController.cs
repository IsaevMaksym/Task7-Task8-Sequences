﻿using System;
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

        private ISequence _sequence;
        private IViever _viever;

        public SequenceController()
            :this(new SquereSiquence(), new ConsoleIO())
        {

        }
        public SequenceController(ISequence sequence, IViever viever)
        {
            _viever = viever;
            this._sequence = sequence;
        }

        public void Run(string[] args)
        {
            int[] arr;

            if (ArgsValidator.ValidateArgs(args, out arr))
            {
                if (arr.Length == 0)
                {
                    _viever.ShowMessage(RULES);
                }
                else if (arr.Length == 1)
                {
                    _sequence = new SquereSiquence();
                }
                else
                {
                    _sequence = new FIbonacci();
                }

                _sequence.CreateSequences(arr);

                _viever.ShowMessage(_sequence.ToString());
            }
            else
            {
                _viever.ShowMessage(RULES);
            }
        }

    }
}

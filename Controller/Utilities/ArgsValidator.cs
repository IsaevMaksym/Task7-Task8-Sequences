using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller.Utilities
{
    static class ArgsValidator
    {
        public static bool ValidateArgs(string[] args, out int[] nums)
        {
            bool IsValidated = false;

            if (args.Length <0)
            {
                nums = null;
                return IsValidated;
            }
            else if (ParseInsertedArgs(args, out nums))
            {
                IsValidated = true;
            }

            return IsValidated;
        }

        private static bool ParseInsertedArgs(string[] args, out int[] num)
        {          
            bool isParsed = false;
            num = new int[args.Length];

            for (int i = 0; i < args.Length; i++)
            {
                if (int.TryParse(args[i], out num[i]))
                {
                    isParsed = true;
                }
            }
            
            return isParsed;
        }

    }
}

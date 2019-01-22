using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller.Utilities
{
    static class ArgsValidator
    {
        public static bool GetNumsFromInsertedArgs(string[] args, out long[] nums)
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

        private static bool ParseInsertedArgs(string[] args, out long[] arr)
        {          
            bool isParsed = false;
            List<long> nums = new List<long>(2);
            long num;
                       
            for (int i = 0; i < args.Length; i++)
            {
                
                if (long.TryParse(args[i], out num))
                {
                    isParsed = true;
                    nums.Add(num);                    
                }
                if (nums.Count==2)
                {
                    break;
                }
            }
            arr = nums.ToArray();            
            return isParsed;
        }

    }
}

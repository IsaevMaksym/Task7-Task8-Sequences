using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Controller;


namespace Sequences
{
    class Program
    {
        static void Main(string[] args)
        {
            args = new string[]
            {
                "5",
                "60",
            };
            SequenceController controller = new SequenceController();
            controller.Run(args);
        }
    }
}

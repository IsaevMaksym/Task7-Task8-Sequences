using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SequencesIO
{
    public class ConsoleIO : IViever
    {
        private const string PRESS_ANY_KEY = "Press any key...";

        void IViever.ShowMessage(string s)
        {
            Console.WriteLine(s);
            Console.WriteLine(PRESS_ANY_KEY);
            Console.ReadKey();
        }

    }
}

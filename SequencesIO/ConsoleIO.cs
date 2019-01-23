using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SequencesIO
{
    public class ConsoleIO : IViewer
    {
        private const string PRESS_ANY_KEY = "Press any key...";

        void IViewer.ShowMessage(string s)
        {
            Console.WriteLine(s);
            Console.WriteLine(PRESS_ANY_KEY);
            Console.ReadKey();
        }

    }
}

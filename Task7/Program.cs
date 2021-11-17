using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7
{
    class Program
    {
        static void Main(string[] args)
        {
            Sequence sequence = new Sequence();
            UserInterface.SetInputParameters(sequence);
            Console.WriteLine(SequenceGenerator.GetSequence(sequence));
            Console.ReadKey();
        }
    }
}

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
            string sequenceLength;
            string minSquare;

            do
            {
                Console.WriteLine("Input sequence length:");
                sequenceLength = Console.ReadLine();
            } while (!Validator.IsValid(sequenceLength));

            do
            {
                Console.WriteLine("enter minimal square:");
                minSquare = Console.ReadLine();
            } while (!Validator.IsValid(minSquare));

            Console.WriteLine(SequenceGenerator.GetSequence(int.Parse(sequenceLength), int.Parse(minSquare)));

            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7
{
    class Sequence
    {
        private int sequenceLength;
        private int minimalSquare;

        public int SequenceLength
        {
            get
            {
                return sequenceLength;
            }
            set
            {
                sequenceLength = value;
            }
        }

        public int MinimalSquare
        {
            get
            {
                return minimalSquare;
            }
            set
            {
                minimalSquare = value;
            }
        }
    }
}

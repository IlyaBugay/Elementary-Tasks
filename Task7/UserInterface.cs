using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7
{
    class UserInterface
    {
        public static void SetInputParameters(Sequence sequence)
        {
            sequence.SequenceLength = Validator.ValidateInputValue(Messages.INPUT_SEQUENCE_LENGTH_MESSAGE);
            sequence.MinimalSquare = Validator.ValidateInputValue(Messages.INPUT_MIN_SQUARE_MESSAGE);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Message
    {
        public const string INVITATION = "Please enter <triangle name>, <triangle side#1>, <triangle side#2>, <triangle side#3>";

        public const string CONTINUATION_STRING = "Do you want to continue comparing envelopes? (y/yes)";

        public const string TITLE = "============= Triangles list: ===============";

        public const string NO_ELEMENTS = "No triangles in the list";

        public const ushort SIDES_NUMBER = 3;


        #region Error messages
        public const string NOT_EXIST = "Ooops ... this triangle can`t exist";

        public const string WRONG_NUMBER_OF_ARGS = "Wrong number of args :(";

        public const string INCORRECT_INPUT = "The sides of the triangle are incorrectly entered.";

        public const string NEGATIVE_NUMBER_ERROR = "Please enter a positive number";
        #endregion
    }
}

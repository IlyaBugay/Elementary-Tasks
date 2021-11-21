using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    class LuckyTicketsCounter
    {
        private const string SIMPLE_METHOD_MESSAGE = "Number of lucky tickets by Simple Method - ";
        private const string COMPLICATED_METHOD_MESSAGE = "Number of lucky tickets by Complicated Method - ";

        public int CountLuckyTicketsBySimpleMethod(int min, int max)
        {
            int countSimple = 0;
            for (int i = min; i <= max; i++)
            {
                if (CheckNumBySimpleMethod(i))
                {
                    countSimple++;
                }
            }
            return countSimple;
        }

        public int CountLuckyTicketsByComplicatedMethod(int min, int max)
        {
            int countComplicated = 0;
            for (int i = min; i <= max; i++)
            {
                if (CheckNumByComplicatedMethod(i))
                {
                    countComplicated++;
                }
            }
            return countComplicated;
        }

        private bool CheckNumBySimpleMethod(int num)
        {
            int[] arr = GetIntArray(num);
            return arr[0] + arr[1] + arr[2] == arr[3] + arr[4] + arr[5];
        }

        private bool CheckNumByComplicatedMethod(int num)
        {
            int[] arr = GetIntArray(num);
            return arr[0] + arr[2] + arr[4] == arr[1] + arr[3] + arr[5];
        }

        private int[] GetIntArray(int num)
        {
            int[] output = new int[6];
            output[5] = num % 10;
            output[4] = (num / 10) % 10;
            output[3] = (num / 100) % 10;
            output[2] = (num / 1000) % 10;
            output[1] = (num / 10000) % 10;
            output[0] = (num / 100000) % 10;
            return output;
        }

        public string CompareMethodsResult(int simpleCount, int complicatedCount)
        {
            StringBuilder stringBuilder = new StringBuilder(SIMPLE_METHOD_MESSAGE + simpleCount + "\n" + COMPLICATED_METHOD_MESSAGE + complicatedCount + "\n");
            if (simpleCount < complicatedCount)
            {
                stringBuilder.Append("Complicated Method will produce more lucky tickets on a given range of ticket numbers.");
            }
            else if (simpleCount == complicatedCount)
            {
                stringBuilder.Append("Both methods will produce equal amount of lucky tickets on a given range of numbers.");
            }
            else
            {
                stringBuilder.Append("Simple Method will produce more lucky tickets on a given range of ticket numbers.");
            }
            return stringBuilder.ToString();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            LuckyTicketsCounter counter = new LuckyTicketsCounter();

            int minTicketNum = -1;
            int maxTicketNum = -1;

            do
            {
                do
                {
                    Console.WriteLine("Enter min ticket number:");
                    try
                    {
                        minTicketNum = int.Parse(Console.ReadLine());
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Incorrect input!");
                    }
                } while (minTicketNum < 0);

                Console.WriteLine("Enter max ticket number:");
                do
                {
                    try
                    {
                        maxTicketNum = int.Parse(Console.ReadLine());
                        if (maxTicketNum < minTicketNum)
                        {
                            int temp = minTicketNum;
                            minTicketNum = maxTicketNum;
                            minTicketNum = temp;
                        }
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Incorrect input!");
                    }
                } while (maxTicketNum < 0);

                int luckyTicketsBySimpleMethod = counter.CountLuckyTicketsBySimpleMethod(minTicketNum, maxTicketNum);
                int luckyTicketsByComplicatedMethod = counter.CountLuckyTicketsByComplicatedMethod(minTicketNum, maxTicketNum);
                string result = counter.CompareMethodsResult(luckyTicketsBySimpleMethod, luckyTicketsByComplicatedMethod);

                Console.WriteLine(result);
                Console.WriteLine("\nEnter \"exit\" to finish or press enter to continue!");

            } while (!Console.ReadLine().Trim().Equals("exit", StringComparison.OrdinalIgnoreCase));
        }
    }
}
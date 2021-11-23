using NUnit.Framework;
using Task6;

namespace LuckyTicketsCounterTest
{
    public class Tests
    {
        private LuckyTicketsCounter ticketsCounter = new LuckyTicketsCounter();

        [SetUp]
        public void Setup()
        {
            ticketsCounter = new LuckyTicketsCounter();
        }

        [Test]
        public void CountLuckyTicketsBySimpleMethod()
        {
            //ARRANGE
            int minTicketNumber = 0;
            int maxTicketNumber = 999999;
            int expected = 55252;
            //ACT
            int actual = ticketsCounter.CountLuckyTicketsBySimpleMethod(minTicketNumber, maxTicketNumber);
            //ASSERT
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void CountLuckyTicketsByComplicatedMethod()
        {
            //ARRANGE
            int minTicketNumber = 0;
            int maxTicketNumber = 999999;
            int expected = 55252;
            //ACT
            int actual = ticketsCounter.CountLuckyTicketsByComplicatedMethod(minTicketNumber, maxTicketNumber);
            //ASSERT
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void CompareMethodsResultWhenSimpleGivesMoreLuckyTickets()
        {
            //ARRANGE
            int simpleMethodResult = ticketsCounter.CountLuckyTicketsBySimpleMethod(100001, 111111);
            int complicatedMethodResult = ticketsCounter.CountLuckyTicketsByComplicatedMethod(100000, 111111);
            string expected = "Number of lucky tickets by Simple Method - 294\n" +
                    "Number of lucky tickets by Complicated Method - 726\n" +
                    "Complicated Method will produce more lucky tickets on a given range of ticket numbers.";
            //ACT
            string actual = ticketsCounter.CompareMethodsResult(simpleMethodResult, complicatedMethodResult);
            //ASSERT
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void CompareMethodsResultWhenBothGiveEqualAmountOfLuckyTickets()
        {
            //ARRANGE
            int simpleMethodResult = ticketsCounter.CountLuckyTicketsBySimpleMethod(200000, 111111);
            int complicatedMethodResult = ticketsCounter.CountLuckyTicketsByComplicatedMethod(200000, 111111);
            string expected = "Number of lucky tickets by Simple Method - 0\n" +
                    "Number of lucky tickets by Complicated Method - 0\n" +
                    "Both methods will produce equal amount of lucky tickets on a given range of numbers.";
            //ACT
            string actual = ticketsCounter.CompareMethodsResult(simpleMethodResult, complicatedMethodResult);
            //ASSERT
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void CompareMethodsResultWhenComplicatedGivesMoreLuckyTickets()
        {
            //ARRANGE
            int simpleMethodResult = ticketsCounter.CountLuckyTicketsBySimpleMethod(10101, 101010);
            int complicatedMethodResult = ticketsCounter.CountLuckyTicketsByComplicatedMethod(10101, 101010);
            string expected = "Number of lucky tickets by Simple Method - 4621\n" +
                    "Number of lucky tickets by Complicated Method - 4225\n" +
                    "Simple Method will produce more lucky tickets on a given range of ticket numbers.";
            //ACT
            string actual = ticketsCounter.CompareMethodsResult(simpleMethodResult, complicatedMethodResult);
            //ASSERT
            Assert.AreEqual(expected, actual);
        }
    }
}
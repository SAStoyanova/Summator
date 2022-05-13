using NUnit.Framework;

namespace Summator.Tests
{
    public class Tests
    {
        [Test]

        public void Test_Sum_TwoPossitiveNumbers()
        {
            int result = Summator.Sum(new int[] { 5, 7 });

            Assert.That(result == 12);
        }


        [Test]

        public void Test_Sum_OnePossitiveNumber()
        {
            int result = Summator.Sum(new int[] { 5 });

            Assert.That(result == 5);
        }

        [Test]

        public void Test_Sum_TwoNegativeNumber()
        {
            int result = Summator.Sum(new int[] { -3, -7}); 

            Assert.That(result == -10);
        }

        [Test]

        public void Test_Sum_EmptyArr()
        {
            int result = Summator.Sum(new int[] { });

            Assert.That(result == 0);
        }

        [Test]

        public void Test_Average_TwoPossitiveNumbers()
        {
            int actual = Summator.average(new int[] { 5, 7 });
            int expected = 6;

            Assert.That(actual == expected);
        }

        [Test]

        public void Test_Average_TwoNegativeNumbers()
        {
            int actual = Summator.average(new int[] { -5, -9 });
            int expected = -7;

            Assert.That(actual == expected);
        }
    }
}
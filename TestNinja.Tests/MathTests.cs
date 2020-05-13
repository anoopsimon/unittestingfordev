using NUnit.Framework;
using System.Linq;
using Assert = NUnit.Framework.Assert;
using Math = TestNinja.Fundamentals.Math;

namespace TestNinja.Tests
{
    [TestFixture]
    public class MathTests
    {
        private Math _math;

        [SetUp]
        public void Setup() {
             _math = new Math();
        }

        [Test]
        [Ignore("This requirement will change in release 3")]
        public void Math_Add_WhenCalled_ReturnSumOfArgument()
        {

            var result= _math.Add(10, 10);

            Assert.That(result ,Is.EqualTo(20));

        }


        [Test]
        public void Math_GetOddNumbers_LimitGreaterThanZero_ReturnOddNumbersUptoLimit()
        {
            var result = _math.GetOddNumbers(5);

            Assert.That(result, Is.EquivalentTo(new[] { 1, 3, 5 }));
            Assert.That(result, Is.Ordered);
            Assert.That(result, Is.Unique);

        }


      
        



        [Test]
        [TestCase(2,1,2)]
        [TestCase(1, 2,2)]
        [TestCase(2, 2,2)]
        public void Math_Max_FirstArgumentIsGreater_ReturnMaxArgument(int argument1 , int argument2,int expected) {

            var result = _math.Max(argument1, argument2);

            Assert.That(result, Is.EqualTo(expected));

        }

       
    }
}

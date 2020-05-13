using NUnit.Framework;
using TestNinja.Fundamentals;
using Assert = NUnit.Framework.Assert;

namespace TestNinja.Tests
{
    [TestFixture]
    public class ErrorLoggerTests
    {
        [Test]
        public void Log_WhenCalled_SetLastErrorProperty()
        {
            var logger = new ErrorLogger();
            var logText = "Anoop Simon is a developer";
            logger.Log(logText);

            Assert.That(logger.LastError, Is.EqualTo(logText));


        }

        [Test]
        [TestCase(null)]
        [TestCase(" ")]
        [TestCase("")]
        public void Log_InvalidError_ThroArgumentNullException(string error)
        {
            var logger = new ErrorLogger();

            Assert.That(() => logger.Log(error), Throws.ArgumentNullException);

         }

        [Test]
        public void Log_ValidationError_RasieErrorLoggedEvent()
        {
            var logger = new ErrorLogger();
            var logText = "Anoop Simon is a developer";
            logger.Log(logText);

            Assert.That(logger.LastError, Is.EqualTo(logText));


        }
    }
}

using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using TestNinja.Fundamentals;
using Assert = NUnit.Framework.Assert;

namespace TestNinja.Tests
{

    [TestFixture]
    public class HTMLFormatterTests
    {
        [Test]
        public void FormatAsBold_WhenCalled_ShouldReturnStringWithStrongElement()
        {
            var formatter = new HtmlFormatter();
            var data = "Anoop Simon";
            var result= formatter.FormatAsBold(data);

            Assert.That(result,Is.EqualTo($"<strong>{data }</strong>").IgnoreCase);
        }
    }
}

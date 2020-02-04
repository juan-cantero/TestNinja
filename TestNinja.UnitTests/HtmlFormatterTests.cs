using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    class HtmlFormatterTests
    {   
        [Test]
        [TestCase("hola")]
        [TestCase("Chau")]
        public static void FormatAsBold_ShouldEnclose_StringWithStrongTags(string word)
        {
            var htmlFormatter = new HtmlFormatter();
            var result = htmlFormatter.FormatAsBold(word);
            Assert.That(result, Is.EqualTo($"<strong>{word}</strong>"));
        }
    }
}

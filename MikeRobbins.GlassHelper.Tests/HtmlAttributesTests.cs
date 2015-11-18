using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace MikeRobbins.GlassHelper.Tests
{
    [TestFixture]
    public class HtmlAttributesTests
    {
        [Test]
        public void Renders_Correct_CSS_Class()
        {
            //Arrange
            var htmlAttributes = new HtmlAttributes();

            //Act
            Dictionary<string, object> attributes = htmlAttributes.CssClass("Hello World").Render();

            //Assert
            Assert.That(attributes["class"], Is.EqualTo("Hello World"));
        }

        [Test]
        public void Renders_Correct_Attribute()
        {
            //Arrange
            var htmlAttributes = new HtmlAttributes();

            //Act
            Dictionary<string, object> attributes = htmlAttributes.Attribute("data-url", "http://www.google.com").Render();

            //Assert
            Assert.That(attributes["data-url"], Is.EqualTo("http://www.google.com"));
        }

        [Test]
        public void Renders_Correct_Chained_Attributes()
        {
            //Arrange
            var htmlAttributes = new HtmlAttributes();

            //Act
            Dictionary<string, object> attributes = htmlAttributes.Attribute("data-url", "http://www.google.com").Attribute("data-search", "find").Render();

            //Assert
            Assert.That(attributes["data-url"], Is.EqualTo("http://www.google.com"));
            Assert.That(attributes["data-search"], Is.EqualTo("find"));
        }
    }
}

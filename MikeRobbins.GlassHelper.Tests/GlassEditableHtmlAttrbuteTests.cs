using System.Collections.Specialized;
using NUnit.Framework;

namespace MikeRobbins.GlassHelper.Tests
{
    [TestFixture]
    public class GlassEditableHtmlAttrbuteTests
    {
        [Test]
        public void Renders_Correct_Editable_CSS_Class()
        {
            //Arrange
            var htmlAttributes = new HtmlAttributes();

            //Act
            NameValueCollection attributes = htmlAttributes.CssClass("Hello World").RenderEditable();

            //Assert
            Assert.That(attributes["class"], Is.EqualTo("Hello World"));
        }

        [Test]
        public void Renders_Correct_Editable_Attribute()
        {
            //Arrange
            var htmlAttributes = new HtmlAttributes();

            //Act
            NameValueCollection attributes = htmlAttributes.Attribute("data-url", "http://www.google.com").RenderEditable();

            //Assert
            Assert.That(attributes["data-url"], Is.EqualTo("http://www.google.com"));
        }

        [Test]
        public void Renders_Correct_Chained_Attributes()
        {
            //Arrange
            var htmlAttributes = new HtmlAttributes();

            //Act
            NameValueCollection attributes = htmlAttributes.Attribute("data-url", "http://www.google.com").Attribute("data-search", "find").RenderEditable();

            //Assert
            Assert.That(attributes["data-url"], Is.EqualTo("http://www.google.com"));
            Assert.That(attributes["data-search"], Is.EqualTo("find"));
        }
    }
}
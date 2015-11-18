using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;

namespace MikeRobbins.GlassHelper
{
    public class HtmlAttributes
    {
        private NameValueCollection _nameValueCollection = new NameValueCollection();

        public HtmlAttributes CssClass(string cssClass)
        {
            _nameValueCollection.Add("class", cssClass);

            return this;
        }

        public HtmlAttributes Image(int height, int width)
        {
            _nameValueCollection.Add("height", height.ToString());
            _nameValueCollection.Add("width", width.ToString());

            return this;
        }

        public HtmlAttributes Attribute(string attributeName, string attributeValue)
        {
            _nameValueCollection.Add(attributeName, attributeValue);

            return this;
        }

        public NameValueCollection RenderEditable()
        {
            return _nameValueCollection;
        }

        public Dictionary<string, object> Render()
        {
            return ToDictionary(_nameValueCollection);
        }

        public static Dictionary<string, object> ToDictionary(NameValueCollection nvc)
        {
            return nvc.AllKeys.ToDictionary<string, string, object>(k => k, k => nvc[k]);
        }
    }
}

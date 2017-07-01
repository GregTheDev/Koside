using Kodi.Skinning;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Koside.PropertyModels
{
    public class SkinNode
    {
        protected XmlNode _node;
        protected SkinFile _skinFile;

        [Browsable(false)]
        public SkinFile Window { get { return this._skinFile; } }

        public SkinNode(XmlNode node, SkinFile skinFile)
        {
            this._node = node;
            this._skinFile = skinFile;
        }

        protected int ReadInt(string path, int defaultValue)
        {
            XmlNode childNode = _node.SelectSingleNode(path);

            if (childNode == null) return defaultValue;

            int value;

            if (Int32.TryParse(childNode.InnerText, out value))
                return value;
            else
                return defaultValue;
        }

        protected string ReadString(string path, string defaultValue)
        {
            XmlNode childNode = _node.SelectSingleNode(path);

            if (childNode == null) return defaultValue;

            if (String.IsNullOrEmpty(childNode.InnerText))
                return defaultValue;
            else
                return childNode.InnerText;
        }

        protected string ReadAttributeString(string attributeName, string defaultValue)
        {
            if (_node.Attributes[attributeName] == null)
                return defaultValue;
            else
                return _node.Attributes[attributeName].InnerText;
        }
    }
}

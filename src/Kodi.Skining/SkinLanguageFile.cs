using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Kodi.Skinning
{
    public class SkinLanguageFile
    {
        private XmlDocument _languageDocument;
        private XmlNode _stringsNode;
        private Dictionary<string, string> _strings;

        public SkinLanguageFile(string fileName)
        {
            _languageDocument = new XmlDocument();
            _languageDocument.Load(fileName);

            _stringsNode = _languageDocument.SelectSingleNode("/strings");
            _strings = new Dictionary<string, string>();

            if (_stringsNode == null)
                throw new ArgumentException(String.Format("Invalid strings file: Unable to find <strings> node in file {0}.", fileName));

            LoadStrings(_stringsNode);
        }

        private void LoadStrings(XmlNode _stringsNode)
        {
            XmlNodeList allStrings = _stringsNode.SelectNodes("string");

            foreach (XmlNode stringNode in allStrings)
            {
                _strings.Add(stringNode.Attributes["id"].InnerText, stringNode.InnerText);
            }
        }

        public Dictionary<string, string>.KeyCollection Keys { get { return _strings.Keys; } }

        public bool HasKey(string key)
        {
            return _strings.ContainsKey(key);
        }

        public string ValueForKey(string key)
        {
            return _strings[key];
        }
    }
}

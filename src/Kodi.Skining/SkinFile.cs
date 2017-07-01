using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;

namespace Kodi.Skinning
{
    public class SkinFile
    {
        private XmlDocument _skinDocument;
        private IEnumerable<string> _languages;
        private SkinLanguageFile _languageFile;

        private SkinFile(XmlDocument skinDocument, string baseFolderPath)
        {
            this._skinDocument = skinDocument;
            this.BaseFolderPath = baseFolderPath;
        }

        public static SkinFile Open(string fileName)
        {
            if (!File.Exists(fileName))
                throw new ArgumentException("File not found", "fileName");

            string directoryPath = Path.GetDirectoryName(fileName);
            string skinBaseFolder = Directory.GetParent(directoryPath).FullName;

            XmlDocument skinDocument = new XmlDocument();
            skinDocument.Load(fileName);

            SkinFile skinFile = new SkinFile(skinDocument, skinBaseFolder);

            return skinFile;
        }

        private void LoadLanguages()
        {
            List<string> languageFolders = new List<string>();

            string searchFolder = Path.Combine(this.BaseFolderPath, SkinLookups.FOLDER_LANGUAGES);
            string[] pathPieces;

            foreach (string directoryPath in Directory.EnumerateDirectories(searchFolder))
            {
                pathPieces = directoryPath.Split(Path.DirectorySeparatorChar);

                languageFolders.Add(pathPieces[pathPieces.Length - 1]);
            }

            this._languages = languageFolders;
        }

        public string BaseFolderPath { get; private set; }
        public XmlDocument Document { get { return _skinDocument; } }
        public IEnumerable<string> Languages 
        { 
            get 
            {
                if (this._languages == null)
                    this.LoadLanguages();

                return _languages; 
            }
        }
        public SkinLanguageFile Strings
        {
            get
            {
                if (_languageFile == null)
                    _languageFile = new SkinLanguageFile(Path.Combine(this.BaseFolderPath, "language", "english", "strings.xml"));

                return _languageFile;
            }
        }
    }
}

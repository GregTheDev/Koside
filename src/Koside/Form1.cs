using Kodi.Skinning;
using Koside.PropertyModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace Koside
{
    public partial class Form1 : Form
    {
        private SkinFile _skinFile;

        public Form1()
        {
            InitializeComponent();

            this.skinTreeView1.NodeChanged += skinTreeView1_NodeChanged;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                _skinFile = SkinFile.Open(this.openFileDialog1.FileName);

                this.skinTreeView1.LoadSkinFile(_skinFile.Document);

                this.tsCmbLanguages.Items.AddRange(_skinFile.Languages.ToArray());

                if (tsCmbLanguages.Items.Count > 0)
                    tsCmbLanguages.SelectedIndex = 0;
            }
        }

        private void skinTreeView1_NodeChanged(object sender, TreeViewEventArgs e)
        {
            XmlNode windowNode = (XmlNode)e.Node.Tag;

            if (windowNode == null) return;

            this.txtNodeXml.Text = this.PrettyPrintXml(windowNode.OuterXml);

            if (windowNode.Name == SkinLookups.NODE_WINDOW)
            {
                this.propertyGrid1.SelectedObject = new WindowModel(windowNode, _skinFile);
                return;
            }
            else if (windowNode.Name == SkinLookups.NODE_CONTROL)
            {
                if (windowNode.Attributes == null) return;
                if (windowNode.Attributes["type"] == null) return;

                ControlModel propertyModel = null;

                if (windowNode.Attributes["type"].InnerText == "label")
                {
                    propertyModel = new LabelControlModel(windowNode, _skinFile);
                }
                else if (windowNode.Attributes["type"].InnerText == "image")
                {
                    propertyModel = new ImageControlModel(windowNode, _skinFile);
                }
                else if (windowNode.Attributes["type"].InnerText == "group")
                {
                    propertyModel = new GroupControlModel(windowNode, _skinFile);
                }

                if (propertyModel != null)
                    this.propertyGrid1.SelectedObject = propertyModel;
            }
        }

        private string PrettyPrintXml(string xml)
        {
            var stringBuilder = new StringBuilder();

            var element = XElement.Parse(xml);

            var settings = new XmlWriterSettings();
            settings.OmitXmlDeclaration = true;
            settings.Indent = true;
            settings.NewLineOnAttributes = true;

            using (var xmlWriter = XmlWriter.Create(stringBuilder, settings))
            {
                element.Save(xmlWriter);
            }

            return stringBuilder.ToString();
        }
    }
}

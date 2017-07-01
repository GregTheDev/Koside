using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Koside.Controls
{
    public class SkinRootTreeNode : TreeNode
    {
        private XmlDocument _skinFileDocument;

        public SkinRootTreeNode(XmlDocument skinFileDocument, string fileName)
        {
            this._skinFileDocument = skinFileDocument;

            this.Text = fileName;
        }

        public void ProcessAndAddChildren()
        {
            foreach (XmlNode childNode in _skinFileDocument.ChildNodes)
            {
                // No need to include xml declaration node in the treeview.
                if (childNode.NodeType == XmlNodeType.XmlDeclaration) continue;

                BaseSkinTreeNode childTreeNode = SkinTreeNodeFactory.GetTreeNodeForSkinNode(childNode);

                childTreeNode.ProcessAndAddChildren();

                this.Nodes.Add(childTreeNode);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Koside.Controls
{
    public class BaseSkinTreeNode : TreeNode
    {
        protected const int IMG_ELEMENT = 0;
        protected const int IMG_CONTROL = 2;
        protected const int IMG_GROUP = 4;
        protected const int IMG_IMAGE = 6;
        protected const int IMG_IMAGE_LIST = 8;
        protected const int IMG_LABEL = 10;

        protected XmlNode _skinNode;

        public XmlNode SkinNode { get { return _skinNode; } }

        public BaseSkinTreeNode(XmlNode skinNode)
        {
            this._skinNode = skinNode;

            this.Tag = skinNode;
            this.Text = skinNode.Name;
        }

        public virtual void ProcessAndAddChildren()
        {
            foreach (XmlNode childNode in _skinNode.ChildNodes)
            {
                this.Nodes.Add(InternalProcessNode(childNode));
            }
        }

        private TreeNode InternalProcessNode(XmlNode node)
        {
            BaseSkinTreeNode newNode = SkinTreeNodeFactory.GetTreeNodeForSkinNode(node);

            newNode.ProcessAndAddChildren();

////            if (newNode.ProcessChildNodes)
//            //{
//                foreach (XmlNode childNode in node.ChildNodes)
//                {
//                    newNode.Nodes.Add(InternalProcessNode(childNode));
//                }
//            //}

            return newNode;
        }
    }
}

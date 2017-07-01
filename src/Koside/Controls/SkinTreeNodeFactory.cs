using Kodi.Skinning;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Koside.Controls
{
    public class SkinTreeNodeFactory
    {
        public static BaseSkinTreeNode GetTreeNodeForSkinNode(XmlNode skinNode)
        {
            if (skinNode.Name == SkinLookups.NODE_CONTROL)
                return GetNodeForControl(skinNode);
            else if (skinNode.Name == SkinLookups.NODE_WINDOW)
                return new GenericSkinTreeNode(skinNode);
            else if (skinNode.NodeType == XmlNodeType.Comment)
                return new CommentTreeNode(skinNode);

            return new BaseSkinTreeNode(skinNode);
        }

        private static BaseSkinTreeNode GetNodeForControl(XmlNode skinNode)
        {
            string controlType = skinNode.Attributes["type"].InnerText;

            if (controlType == SkinLookups.CONTROL_GROUP)
                return new GroupTreeNode(skinNode);
            else if (controlType == SkinLookups.CONTROL_IMAGE)
                return new ImageTreeNode(skinNode);
            else if (controlType == SkinLookups.CONTROL_IMAGE_MULTI)
                return new MultiImageTreeNode(skinNode);
            else if (controlType == SkinLookups.CONTROL_LIST)
                return new ListTreeNode(skinNode);
            else if (controlType == SkinLookups.CONTROL_LABEL)
                return new LabelTreeNode(skinNode);

            return new GenericSkinTreeNode(skinNode);
        }
    }
}

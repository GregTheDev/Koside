using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Koside.Controls
{
    public class CommentTreeNode : BaseSkinTreeNode
    {
        public CommentTreeNode(XmlNode skinNode)
            : base(skinNode)
        {
            this.Text = "// " + skinNode.InnerText;
        }
    }
}

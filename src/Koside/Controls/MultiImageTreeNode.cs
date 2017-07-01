using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Koside.Controls
{
    public class MultiImageTreeNode : BaseSkinTreeNode
    {
        public MultiImageTreeNode(XmlNode skinNode)
            : base(skinNode)
        {
            this.Text = "multiImage";
        }
    }
}

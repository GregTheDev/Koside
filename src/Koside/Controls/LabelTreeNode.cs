using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Koside.Controls
{
    public class LabelTreeNode : BaseSkinTreeNode
    {
        public LabelTreeNode(XmlNode skinNode)
            : base(skinNode)
        {
            this.Text = "label";
            this.ImageIndex = IMG_LABEL;
            this.SelectedImageIndex = IMG_LABEL;
        }

        public override void ProcessAndAddChildren()
        {
            // Label doesn't have child nodes, only properties, so do nothing
            return;
        }
    }
}

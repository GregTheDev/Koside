using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Koside.Controls
{
    public class ImageTreeNode : BaseSkinTreeNode
    {
        public ImageTreeNode(XmlNode skinNode)
            : base(skinNode)
        {
            this.Text = "image";
            this.ImageIndex = IMG_IMAGE;
            this.SelectedImageIndex = IMG_IMAGE;
        }

        public override void ProcessAndAddChildren()
        {
            // Image doesn't have child nodes, only properties, so do nothing
            return;
        }
    }
}

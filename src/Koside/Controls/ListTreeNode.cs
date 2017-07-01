using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Koside.Controls
{
    public class ListTreeNode : BaseSkinTreeNode
    {
        public ListTreeNode(XmlNode skinNode)
            : base(skinNode)
        {
            this.Text = "list";
            //xxx
            this.ImageIndex = IMG_ELEMENT;
            this.SelectedImageIndex = IMG_ELEMENT;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Koside.Controls
{
    public class GroupTreeNode : BaseSkinTreeNode
    {
        public GroupTreeNode(XmlNode skinNode)
            : base(skinNode)
        {
            this.Text = "group";
            this.ImageIndex = IMG_GROUP;
            this.SelectedImageIndex = IMG_GROUP;
        }
    }
}

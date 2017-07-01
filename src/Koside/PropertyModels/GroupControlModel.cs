using Kodi.Skinning;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Koside.PropertyModels
{
    public class GroupControlModel : ControlModel
    {
        public GroupControlModel(XmlNode windowNode, SkinFile skinFile)
            : base(windowNode, skinFile)
        {
        }

        [Description("Specifies the default control that will be focused within the group when the group receives focus. Note that the group remembers it's previously focused item and will return to it.")]
        [Category("Group")]
        public string DefaultControl { get { return ReadString("defaultcontrol", ""); } set { ;} }
    }
}

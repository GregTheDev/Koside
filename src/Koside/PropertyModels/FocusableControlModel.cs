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
    //http://kodi.wiki/view/Default_Control_Tags
    public class FocusableControlModel : ControlModel
    {
        public FocusableControlModel(XmlNode windowNode, SkinFile skinFile)
            : base(windowNode, skinFile)
        {

        }

        [Description("")]
        public string OnUp { get; set; }
        [Description("")]
        public string OnDown { get; set; }
        [Description("")]
        public string OnLeft { get; set; }
        [Description("")]
        public string OnRight { get; set; }
        [Description("")]
        public string HitRect { get; set; }
        [Description("")]
        public string Enable { get; set; }
        [Description("")]
        public string PulseOnSelect { get; set; }
    }
}

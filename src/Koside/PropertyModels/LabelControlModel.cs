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
    public class LabelControlModel : ControlModel
    {
        private ControlValueModel _value;

        public ControlValueModel Value { get { return _value; } set { ;} }

        public LabelControlModel(XmlNode windowNode, SkinFile skinFile)
            : base(windowNode, skinFile)
        {
            this._value = new ControlValueModel(ReadString("label", ""), this);
        }

        [Description("Can be left, right, or center. Aligns the text within the given label <width>. Defaults to left.")]
        [DefaultValue("left")]
        public string Align { get; set; }

        [Description("Can be top or center. Aligns the text within its given label <height>. Defaults to top.")]
        public string AlignY { get; set; }

        [Description("When true, the text will scroll if longer than the label's <width>. If false, the text will be truncated. Defaults to false.")]
        [DefaultValue(true)]
        public bool Scroll { get; set; }

        [Description("Specifies the text which should be drawn.")]
        public ControlValueModel Label { get { return _value; } set { ;} }

        [Description("Specifies the information that should be presented. XBMC will auto-fill in this info in place of the <label>")]
        public string Info { get; set; }

        [Description("Specifies a number that should be presented. This is just here to allow a skinner to use a number rather than a text label (as any number given to <label> will be used to lookup in strings.xml).")]
        public string Number { get; set; }

        [Description("The angle the text should be rendered at, in degrees. A value of 0 is horizontal.")]
        public string Angle { get; set; }

        [Description("Specifies whether or not this label is filled with a path. Long paths are shortened by compressing the file path while keeping the actual filename full length. ")]
        public string Haspath { get; set; }

        [Description("Specifies the font to use from the font.xml file. ")]
        public string Font { get { return ReadString("font", ""); } set { ;} }

        [Description("Specifies the color the text should be, in hex AARRGGBB format, or a name from the colour theme.")]
        public string Textcolor { get; set; }

        [Description("Specifies the color of the drop shadow on the text, in AARRGGBB format, or a name from the colour theme.")]
        public string Shadowcolor { get; set; }

        [Description("If true, any text that doesn't fit on one line will be wrapped onto multiple lines. ")]
        public string WrapMultiLine { get; set; }

        [Description("Scroll speed of text in pixels per second. Defaults to 60. ")]
        [DefaultValue("60")]
        public string ScrollSpeed { get; set; }

        [Description("Specifies the suffix used in scrolling labels. Defaults to \" | \". ")]
        [DefaultValue(" | ")]
        public string ScrollSuffix { get; set; }
    }
}

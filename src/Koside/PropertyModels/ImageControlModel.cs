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
    public class ImageControlModel : ControlModel
    {

        public ImageControlModel(XmlNode windowNode, SkinFile skinFile)
            : base(windowNode, skinFile)
        {
        }

        [Description("This specifies how the image will be drawn inside the box defined by <width> and <height>.")]
        public string AspectRatio { get { return ReadString("aspectratio", ""); } set { ;} }

        [Description("Specifies the image file which should be displayed.")]
        public string Texture { get { return ReadString("texture", ""); } set { ;} }

        [Description("Specifies the image file which should be displayed as a border around the image. Use the <bordersize> to specify the size of the border. The <width>,<height> box specifies the size of the image plus border.")]
        public string BorderTexture { get { return ReadString("bordertexture", ""); } set { ;} }

        [Description("Specifies the size of the border. A single number specifies the border should be the same size all the way around the image, whereas a comma separated list of 4 values indicates left,top,right,bottom values.")]
        public string BorderSize { get { return ReadString("bordersize", ""); } set { ;} }

        [Description("Specifies the information that this image control is presenting. XBMC will select the texture to use based on this tag.")]
        public string Info { get { return ReadString("info", ""); } set { ;} }

        [Description("This specifies a crossfade time that will be used whenever the underlying <texture> filename changes. The previous image will be held until the new image is ready, and then they will be crossfaded. This is particularly useful for a large thumbnail image showing the focused item in a list, or for fanart or other large backdrops.")]
        public string FadeTime { get { return ReadString("fadetime", ""); } set { ;} }

        [Description("For images inside a container, you can specify background=\"true\" to load the textures in a background worker thread.")]
        public string Background { get { return ReadString("background", ""); } set { ;} }
    }
}

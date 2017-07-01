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
	// http://kodi.wiki/view/Window_Structure
    public class WindowModel : SkinNode
    {
        public WindowModel(XmlNode node, SkinFile skinFile)
            : base(node, skinFile)
        {
        	LoadEvents();
        }
        
        private void LoadEvents()
        {
/*        	
            XmlNode tempNode;

            tempNode = this._node.SelectSingleNode("animation[.= '" + AnimationField.EVENT_WINDOWOPEN + "']");
            if (tempNode != null) this._windowOpen = new AnimationField(this, tempNode);

            tempNode = this._node.SelectSingleNode("animation[.= '" + AnimationField.EVENT_WINDOWCLOSE + "']");
            if (tempNode != null) this._windowClose = new AnimationField(this, tempNode);      
*/            
        }

        [Description("Optional: the build-in function to execute when the window opens.")]
        [Category("Window")]
        public string onload { get { return ReadString("onload", ""); } set {;} }

        [Description("Optional: the build-in function to execute when the window closes.")]
        [Category("Window")]
        public string onunload { get { return ReadString("onunload", ""); } set { ;} }

        [Description("This specifies the default control of the window. This is the id of the control that will receive focus when the window is first opened.")]
        [Category("Window")]
        public string defaultcontrol { get { return ReadString("defaultcontrol", ""); } set { ;} }

        [Description("Specifies whether the window needs clearing prior to rendering, and if so which colour to use. Defaults to clearing to black. Set to 0 (or 0x00000000) to have no clearing at all.")]
        [Category("Window")]
        public string backgroundcolor { get { return ReadString("backgroundcolor", ""); } set { ;} }

        [Description("Setting this tag to true, or yes, indicates that the music or video overlay may be shown when this window is active.")]
        [Category("Window")]
        public string allowoverlay { get { return ReadString("allowoverlay", ""); } set { ;} }

        [Description("Specifies the conditions under which a dialog will be visible. Applies only to type=\"dialog\" windows.")]
        [Category("Window")]
        public string visible { get { return ReadString("visible", ""); } set { ;} }

        //xxx
        //[Description("Specifies the animation effect to perform when opening or closing the window.")]
        //[Category("Window")]
        //public AnimationField animation { get { return ReadString("animation", ""); } set; }

        [Description("This specifies the \"depth\" that the window should be drawn at.")]
        [Category("Window")]
        public string zorder { get { return ReadString("zorder", ""); } set { ;} }

        [Description("This block is used to specify how Kodi should compute the coordinates of all controls.")]
        [Category("Window")]
        public string coordinates { get { return ReadString("coordinates", ""); } set { ;} }

        [Description("Sets the horizontal “origin” position of the window. Defaults to 0 if not present.")]
        [Category("Window")]
        public string posx { get { return ReadString("posx", "0"); } set { ;} }

        [Description("Sets the vertical “origin” position of the window. Defaults to 0 if not present.")]
        [Category("Window")]
        public string posy { get { return ReadString("posy", "0"); } set { ;} }

        [Description("Sets a conditional origin for the window. The window will display at (x,y) whenever the origin condition is met. You can have as many origin tags as you like – they are evaluated in the order present in the file, and the first one for which the condition is met wins.")]
        [Category("Window")]
        public string origin { get { return ReadString("origin", ""); } set { ;} }

        [Description("This can be used to specify a window to force Kodi to go to on press of the Back button. The value is the name of the window.")]
        [Category("Window")]
        public string previouswindow { get { return ReadString("previouswindow", ""); } set { ;} }

        [Description("This tag lets you use view id's beyond 50 to 59 it also lets you set the order in which they cycle with the change view button in the skin. Only useful in My<Foo>.xml windows.")]
        [Category("Window")]
        public string views { get { return ReadString("views", ""); } set { ;} }

        [Description("This is the block the defines all controls that will appear on this window.")]
        [Category("Window")]
        public string controls { get { return ReadString("controls", ""); } set { ;} }
    }
}

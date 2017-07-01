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
    [PropertyTabAttribute(typeof(Koside.Design.SkinNodeAnimationsTab), PropertyTabScope.Component)]
    public abstract class ControlModel : SkinNode, ICustomTypeDescriptor
    {
        protected ControlModel(XmlNode windowNode, SkinFile skinFile)
            : base(windowNode, skinFile)
        {
            // Setup animations (other properties are read "live")

            LoadAnimations();
        }

        private void LoadAnimations()
        {
            XmlNode tempNode;

            tempNode = this._node.SelectSingleNode("animation[.= '" + AnimationField.EVENT_WINDOWOPEN + "']");
            if (tempNode != null) this._windowOpen = new AnimationField(this, tempNode);

            tempNode = this._node.SelectSingleNode("animation[.= '" + AnimationField.EVENT_WINDOWCLOSE + "']");
            if (tempNode != null) this._windowClose = new AnimationField(this, tempNode);

            tempNode = this._node.SelectSingleNode("animation[.= '" + AnimationField.EVENT_VISIBLE + "']");
            if (tempNode != null) this._visible = new AnimationField(this, tempNode);

            tempNode = this._node.SelectSingleNode("animation[.= '" + AnimationField.EVENT_HIDDEN + "']");
            if (tempNode != null) this._hidden = new AnimationField(this, tempNode);

            tempNode = this._node.SelectSingleNode("animation[.= '" + AnimationField.EVENT_FOCUS + "']");
            if (tempNode != null) this._focus = new AnimationField(this, tempNode);

            tempNode = this._node.SelectSingleNode("animation[.= '" + AnimationField.EVENT_UNFOCUS + "']");
            if (tempNode != null) this._unfocus = new AnimationField(this, tempNode);

            tempNode = this._node.SelectSingleNode("animation[.= '" + AnimationField.EVENT_CONDITIONAL + "']");
            if (tempNode != null) this._conditional = new AnimationField(this, tempNode);

            tempNode = this._node.SelectSingleNode("animation[.= '" + AnimationField.EVENT_VISIBLECHANGE + "']");
            if (tempNode != null) this._visibleChange = new AnimationField(this, tempNode);
        }

        #region Properties

        [Description("Only used to make things clear for the skinner. Not read by XBMC at all.")]
        [Category("Control")]
        public string Description { get { return ReadString("description", ""); } set { ;} }

        [Description("The type of control.")]
        [Category("Control")]
        public string Type { get { return ReadString("type", ""); } set { ;} }

        [Description("Specifies the control's id. The value this takes depends on the control type, and the window that you are using the control on.")]
        [Category("Control")]
        public string Id { get { return ReadString("id", ""); } set { ;} }

        [Description("Specifies where the left edge of the control should be drawn, relative to it's parent's left edge. If an \"r\" is included (eg 180r) then the measurement is taken from the parent's right edge (in the left direction).")]
        [Category("Control")]
        public string Left { get { return ReadString("left", ""); } set { ;} }

        [Description("Specifies where the top edge of the control should be drawn, relative to it's parent's top edge. If an \"r\" is included (eg 180r) then the measurement is taken from the parent's bottom edge (in the up direction).")]
        [Category("Control")]
        public string Top { get { return ReadString("top", ""); } set { ;} }

        [Description("Specifies where the right edge of the control should be drawn.")]
        [Category("Control")]
        public string Right { get { return ReadString("right", ""); } set { ;} }

        [Description("Specifies where the bottom edge of the control should be drawn.")]
        [Category("Control")]
        public string Bottom { get { return ReadString("bottom", ""); } set { ;} }

        [Description("Aligns the control horizontally at the given coordinate measured from the left side of the parent control.")]
        [Category("Control")]
        public string CenterLeft { get; set; }

        [Description("Aligns the control horizontally at the given coordinate measured from the right side of the parent control.")]
        [Category("Control")]
        public string CenterRight { get; set; }

        [Description("Aligns the control vertically at the given coordinate measured from the top side of the parent control.")]
        [Category("Control")]
        public string CenterTop { get; set; }

        [Description("Aligns the control vertically at the given coordinate measured from the bottom side of the parent control.")]
        [Category("Control")]
        public string CenterBottom { get; set; }

        [Description("Specifies the width that should be used to draw the control.")]
        [Category("Control")]
        public int Width { get { return ReadInt("width", 0); } set { ;} }

        [Description("Specifies the height that should be used to draw the control.")]
        [Category("Control")]
        public string Weight { get { return ReadString("weight", ""); } set { ;} }

        [Description("Specifies a condition as to when this control will be visible. Can be true, false, or a condition.")]
        [DefaultValue("true")]
        [Category("Control")]
        public string Visible { get { return ReadString("visible", ""); } set { ;} }

        [Description("Specifies the location (relative to the parent's coordinates) of the camera. Useful for the 3D animations such as rotatey. Format is <camera x=\"20\" y=\"30\" />")]
        [Category("Control")]
        public string Camera { get { return ReadString("camera", ""); } set { ;} }

        [Description("This specifies the color to be used for the texture basis. It's in hex AARRGGBB format.")]
        [DefaultValue("FFFFFFFF")]
        [Category("Control")]
        public string ColorDiffuse { get; set; }

        [Category("Include")]
        public string Include { get { return ReadString("include", ""); } set { ;} }

        #endregion

        #region Animations
        private AnimationField _windowOpen;
        private AnimationField _windowClose;
        private AnimationField _visible;
        private AnimationField _hidden;
        private AnimationField _focus;
        private AnimationField _unfocus;
        private AnimationField _conditional;
        private AnimationField _visibleChange;

        [Description("Performed once only when the window is opened.")]
        public AnimationField OnWindowOpen { get { return this._windowOpen; } set { this._windowOpen = value; } }

        [Description("Performed once only when the window is closed. No animation is performed when switching to fullscreen video, however.")]
        public AnimationField OnWindowClose { get { return this._windowClose; } set { this._windowClose = value; } }

        [Description("Performed when the control becomes visible via its <visible> tag.")]
        public AnimationField OnVisible { get { return this._visible; } set { this._visible = value; } }

        [Description("Performed when the control becomes hidden via its <visible> tag.")]
        public AnimationField OnHidden { get { return this._hidden; } set { this._hidden = value; } }

        [Description("Performed when the control gains focus.")]
        public AnimationField OnFocus { get { return this._focus; } set { this._focus = value; } }

        [Description("Performed when the control loses focus.")]
        public AnimationField OnUnfocus { get { return this._unfocus; } set { this._unfocus = value; } }

        [Description("Performed when the control's condition attribute is filled.")]
        public AnimationField OnConditional { get { return this._conditional; } set { this._conditional = value; } }

        [Description("The same as the Visible type, except the reverse animation is auto-created for the Hidden type. Just saves having to have both animations if the animation is the same in both directions (ie just reversed).")]
        public AnimationField OnVisibleChange { get { return this._visibleChange; } set { this._visibleChange = value; } }

        #endregion

        #region ICustomTypeDescriptor

        AttributeCollection ICustomTypeDescriptor.GetAttributes()
        {
            return TypeDescriptor.GetAttributes(this, true);
        }

        string ICustomTypeDescriptor.GetClassName()
        {
            return TypeDescriptor.GetClassName(this, true);
        }

        string ICustomTypeDescriptor.GetComponentName()
        {
            return TypeDescriptor.GetComponentName(this, true);
        }

        TypeConverter ICustomTypeDescriptor.GetConverter()
        {
            return TypeDescriptor.GetConverter(this, true);
        }

        EventDescriptor ICustomTypeDescriptor.GetDefaultEvent()
        {
            return TypeDescriptor.GetDefaultEvent(this, true);
        }

        PropertyDescriptor ICustomTypeDescriptor.GetDefaultProperty()
        {
            return TypeDescriptor.GetDefaultProperty(this, true);
        }

        object ICustomTypeDescriptor.GetEditor(Type editorBaseType)
        {
            return TypeDescriptor.GetEditor(this, editorBaseType, true);
        }

        EventDescriptorCollection ICustomTypeDescriptor.GetEvents(Attribute[] attributes)
        {
            return TypeDescriptor.GetEvents(this, attributes);
        }

        EventDescriptorCollection ICustomTypeDescriptor.GetEvents()
        {
            return TypeDescriptor.GetEvents(this);
        }

        PropertyDescriptorCollection ICustomTypeDescriptor.GetProperties(Attribute[] attributes)
        {
            PropertyDescriptorCollection props;

            if (attributes == null)
                props = TypeDescriptor.GetProperties(this, true);
            else
                props = TypeDescriptor.GetProperties(this,attributes, true);

            //PropertyDescriptor[] propArray = new PropertyDescriptor[props.Count];

            List<PropertyDescriptor> eventProperties = new List<PropertyDescriptor>();

            int i = 0;

            foreach (PropertyDescriptor property in props)
            {
                // Include all of the non animation properties
                if (property.PropertyType != typeof(Koside.PropertyModels.AnimationField))
                    eventProperties.Add(TypeDescriptor.CreateProperty(property.ComponentType, property, null)); //new CategoryAttribute(property.PropertyType.Name));

                i++;
            }

            return new PropertyDescriptorCollection(eventProperties.ToArray());
        }

        PropertyDescriptorCollection ICustomTypeDescriptor.GetProperties()
        {
            return ((ICustomTypeDescriptor)this).GetProperties(null);
        }

        object ICustomTypeDescriptor.GetPropertyOwner(PropertyDescriptor pd)
        {
            return this;
        }

        #endregion
    }
}

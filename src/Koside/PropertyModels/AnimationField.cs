using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Koside.PropertyModels
{
    [Editor(typeof(AnimationTypeEditor), typeof(System.Drawing.Design.UITypeEditor))]
    public class AnimationField : SkinNode
    {
        public const string EVENT_WINDOWOPEN = "WindowOpen";
        public const string EVENT_WINDOWCLOSE = "WindowClose";
        public const string EVENT_VISIBLE = "Visible";
        public const string EVENT_HIDDEN = "Hidden";
        public const string EVENT_FOCUS = "Focus";
        public const string EVENT_UNFOCUS = "Unfocus";
        public const string EVENT_CONDITIONAL = "Conditional";
        public const string EVENT_VISIBLECHANGE = "VisibleChange";

        private const string ATTR_EFFECT = "effect";

        private ControlModel _owner;
        private XmlNode _ownerNode;

        //internal AnimationField(ControlModel owner, XmlNode ownerNode, string eventName)
        //    : base(null, owner.Window)
        //{
        //    this._owner = owner;
        //    this._ownerNode = ownerNode;

        //    this.Effects = new List<AnimationEffectField>();

        //    XmlNode myNode = ownerNode.SelectSingleNode("animation[.= " + eventName + "]");
        //    this._node = myNode;

        //    // The animation might not actually exist in the xml file, but we need the property 
        //    // to exist for the property editor.
        //    // If an animation is set in the property editor then the corresponding node will
        //    // be created in the xml document.
        //    if (myNode != null)
        //    {
        //        if (this.IsSingleAnimation)
        //            LoadFromSingleAnimation();
        //        else
        //            LoadFromMultipleAnimations();
        //    }
        //}

        public AnimationField(ControlModel owner, XmlNode animationNode)
            : base(animationNode, owner.Window)
        {
            this._owner = owner;
            this.Effects = new List<AnimationEffectField>();

            if (this.IsSingleAnimation)
                LoadFromSingleAnimation();
            else
                LoadFromMultipleAnimations();
        }

        public override string ToString()
        {
            if (this.IsSingleAnimation)
                return this._node.Attributes[ATTR_EFFECT].InnerText;
            else
                return String.Format("{0} effects", this.Effects.Count);
        }

        public string EventName { get; internal set; }
        public List<AnimationEffectField> Effects { get; internal set; }

        private void LoadFromMultipleAnimations()
        {
            throw new NotImplementedException();
        }

        private void LoadFromSingleAnimation()
        {
            this.EventName = this._node.InnerText;

            AnimationEffectField effect = new AnimationEffectField(this._node, _owner);

            this.Effects.Add(effect);
        }

        private bool IsSingleAnimation
        {
            get
            {
                return (_node.SelectNodes("effect").Count == 0);
            }
        }

    }
}

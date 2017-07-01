using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Koside.PropertyModels
{
    public class AnimationEffectField : SkinNode
    {
        public AnimationEffectField(XmlNode effectNode, ControlModel owner)
            : base(effectNode, owner.Window)
        {
        }

        public override string ToString()
        {
            return this.Effect;
        }

        [Description("Specifies the effect to use. Currently \"fade\", \"slide\", \"rotate\", \"rotatex\", \"rotatey\", and \"zoom\" are supported.")]
        public string Effect { get { return ReadAttributeString("effect", ""); } set { ;} }

        [Description("Specifies the length of time that the animation will run, in milliseconds.")]
        public string Time { get { return ReadAttributeString("time", ""); } set { ;} }

        [Description("The time to delay the transistion before starting it, in milliseconds.")]
        public string Delay { get { return ReadAttributeString("delay", ""); } set { ;} }

        [Description("The start state of the control for this transistion.")]
        public string Start { get { return ReadAttributeString("start", ""); } set { ;} }

        [Description("The end state of the control for this transistion. Similar to the start state, except that the end state is always kept after the animation is finished, and until the control changes its state.")]
        public string End { get { return ReadAttributeString("end", ""); } set { ;} }

        [Description("Amount to accelerate or decelerate during a “slide”, “zoom” or “rotate” transistion. For deceleration, use a negative value. A value of -1 will cause the control to come to rest at its end coordinates. Defaults to 0.")]
        public string Acceleration { get { return ReadAttributeString("acceleration", ""); } set { ;} }

        [Description("Center of the rotation or zoom to perform with a \"rotate\" or \"zoom\" transistion.")]
        public string Center { get { return ReadAttributeString("center", ""); } set { ;} }

        [Description("The conditions under which this animation should be performed. Defaults to being always performed.")]
        public string Condition { get { return ReadAttributeString("condition", ""); } set { ;} }

        [Description("If \"false\" the animation is not reversed if it is interrupted when it is finished.")]
        public string Reversible { get { return ReadAttributeString("reversible", ""); } set { ;} }

        [Description("If \"true\" will make your animation loop.")]
        public string Loop { get { return ReadAttributeString("loop", ""); } set { ;} }

        [Description("If \"true\" will make your animation pulse.")]
        public string Pulse { get { return ReadAttributeString("pulse", ""); } set { ;} }

        [Description("Tween is like an advanced acceleration attribute that can be applied to all animations. Instead of a steady acceleration or deceleration, you can specify curves that the animation should follow.")]
        public string Tween { get { return ReadAttributeString("tween", ""); } set { ;} }

        [Description("Easing basically defines the direction of the tween and can be one of \"out\", \"inout\" and \"in\".")]
        public string Easing { get { return ReadAttributeString("easing", ""); } set { ;} }
    }
}

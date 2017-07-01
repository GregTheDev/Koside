using System;
using System.Xml;

namespace Koside.PropertyModels
{
	public class EventField : SkinNode
	{
        private ControlModel _owner;

        public EventField(ControlModel owner, XmlNode eventNode)
            : base(eventNode, owner.Window)
        {
            this._owner = owner;

        }

        public string Script { get { return ReadString("effect", ""); } set {; } }
    }
}

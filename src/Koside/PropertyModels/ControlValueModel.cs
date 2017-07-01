using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koside.PropertyModels
{
    [Editor(typeof(ControlValueTypeEditor), typeof(System.Drawing.Design.UITypeEditor))]
    [TypeConverter(typeof(ControlValueTypeConverter))]
    public class ControlValueModel
    {
        private ControlModel _owner;
        private string _value;

        public ControlValueModel(string value, ControlModel owner)
        {
            this._value = value;
            this._owner = owner;
        }

        public ControlModel Owner { get { return this._owner; } }
        public string Value { get { return _value; } set { _value = value; } }
    }
}

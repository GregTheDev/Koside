using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koside.PropertyModels
{
    public class ControlValueTypeConverter : TypeConverter
    {
        //public override bool CanConvertFrom(ITypeDescriptorContext context, Type t)
        //{
        //    if (t == typeof(string))
        //    {
        //        return true;
        //    }
        //    return base.CanConvertFrom(context, t);
        //}

        public override bool CanConvertTo(ITypeDescriptorContext context, Type destType)
        {
            if (destType == typeof(string))
            {
                return true;
            }
            return base.CanConvertTo(context, destType);
        }

        public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
        {
            return base.CanConvertFrom(context, sourceType);
        }

        public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destType)
        {
            if (destType == typeof(string))
            {
                ControlValueModel valueModel = (ControlValueModel)value;

                if (valueModel.Owner.Window.Strings.HasKey(valueModel.Value))
                {
                    return valueModel.Owner.Window.Strings.ValueForKey(valueModel.Value);
                }
            }
            return base.ConvertTo(context, culture, value, destType);
        }

        public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
        {
            if (value is ControlValueModel)
                return value;

            return base.ConvertFrom(context, culture, value);
        }
    }
}

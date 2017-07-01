using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.Design;

namespace Koside.Design
{
    public class SkinNodeAnimationsTab : PropertyTab
    {
        public override System.ComponentModel.PropertyDescriptorCollection GetProperties(object component)
        {
            return this.GetProperties(component, null);
        }

        public override System.ComponentModel.PropertyDescriptorCollection GetProperties(object component, Attribute[] attributes)
        {
            PropertyDescriptorCollection props;

            if (attributes == null)
                props = TypeDescriptor.GetProperties(component, true);
            else
                props = TypeDescriptor.GetProperties(component, attributes, true);

            //PropertyDescriptor[] propArray = new PropertyDescriptor[props.Count];

            List<PropertyDescriptor> eventProperties = new List<PropertyDescriptor>();

            int i = 0;

            foreach (PropertyDescriptor property in props)
            {
                // Create a new PropertyDescriptor from the old one
                if (property.PropertyType == typeof(Koside.PropertyModels.AnimationField))
                    eventProperties.Add(TypeDescriptor.CreateProperty(property.ComponentType, property, null)); //new CategoryAttribute(property.PropertyType.Name));

                i++;
            }

            return new PropertyDescriptorCollection(eventProperties.ToArray());
        }

        public override string TabName
        {
            get { return "Animations"; }
        }

        public override System.Drawing.Bitmap Bitmap
        {
            get
            {
                return Properties.Resources.Animation_10763_24;
                //return base.Bitmap;
            }
        }
    }
}

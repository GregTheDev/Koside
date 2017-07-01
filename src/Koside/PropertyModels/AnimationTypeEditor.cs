using Koside.Dialogs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace Koside.PropertyModels
{
    internal class AnimationTypeEditor : UITypeEditor
    {
        public AnimationTypeEditor()
        {
        }

        public override UITypeEditorEditStyle GetEditStyle(ITypeDescriptorContext context)
        {
            // Indicates that this editor can display a Form-based interface. 
            return UITypeEditorEditStyle.Modal;
        }

        public override object EditValue(ITypeDescriptorContext context, IServiceProvider provider, object value)
        {
            // Attempts to obtain an IWindowsFormsEditorService.
            IWindowsFormsEditorService edSvc = (IWindowsFormsEditorService)provider.GetService(typeof(IWindowsFormsEditorService));

            if (edSvc == null)
            {
                return null;
            }

            // Displays a StringInputDialog Form to get a user-adjustable string value. 
            using (AnimationEditorDialog editorDialog = new AnimationEditorDialog((AnimationField)value))
            {
                if (edSvc.ShowDialog(editorDialog) == DialogResult.OK)
                {
                    return editorDialog.NewValue;
                }
            }

            // If OK was not pressed, return the original value 
            return value;
        }
    }
}

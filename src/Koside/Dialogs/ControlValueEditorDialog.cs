using Kodi.Skinning;
using Koside.PropertyModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Koside.Dialogs
{
    public partial class ControlValueEditorDialog : Form
    {
        private ControlValueModel _controlValue;
        private ControlValueModel _newValue;

        public ControlValueEditorDialog()
        {
            InitializeComponent();
        }

        public ControlValueEditorDialog(ControlValueModel controlValue)
            : this()
        {
            this._controlValue = controlValue;

            LoadStrings(controlValue.Owner.Window.Strings);
        }

        private void LoadStrings(SkinLanguageFile stringsFile)
        {
            foreach (string key in stringsFile.Keys)
            {
                ListViewItem newItem = this.lvStrings.Items.Add(key);
                newItem.SubItems.Add(stringsFile.ValueForKey(key));

                if (newItem.Text == this._controlValue.Value)
                    newItem.Selected = true;
            }
        }

        private void lvStrings_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.lvStrings.SelectedItems.Count > 0)
                this.NewValue.Value = this.lvStrings.SelectedItems[0].Text;
        }

        public ControlValueModel NewValue 
        { 
            get
            {
                if (_newValue == null)
                    _newValue = new ControlValueModel("", _controlValue.Owner);

                return _newValue;
            }
        }

    }
}

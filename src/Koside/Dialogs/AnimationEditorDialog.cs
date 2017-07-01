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
    public partial class AnimationEditorDialog : Form
    {
        private AnimationField _controlValue;

        public AnimationField NewValue { get { return this._controlValue;} }

        public AnimationEditorDialog()
        {
            InitializeComponent();
        }

        public AnimationEditorDialog(PropertyModels.AnimationField animationField)
            : this()
        {
            this._controlValue = animationField;

            if (animationField != null)
                SetupUi();
        }

        private void SetupUi()
        {
            this.Text = this._controlValue.EventName;

            foreach (AnimationEffectField effect in this._controlValue.Effects)
            {
                this.lbEffects.Items.Add(effect);
            }

            if (this.lbEffects.Items.Count > 0)
            {
                this.lbEffects.SelectedIndex = 0;
                this.lbEffects.Focus();
            }
        }

        private void lbEffects_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.propertyGrid1.SelectedObject = this.lbEffects.SelectedItem;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Koside.Controls
{
    public partial class SkinTreeView : UserControl
    {
        private XmlDocument _skinFile;

        public event TreeViewEventHandler NodeChanged;

        public SkinTreeView()
        {
            InitializeComponent();

            this.treeView1.AfterSelect += treeView1_AfterSelect;
        }

        public void LoadSkinFile(XmlDocument skinFile)
        {
            this._skinFile = skinFile;

            BuildTreeStructure();
        }

        private void BuildTreeStructure()
        {
            this.treeView1.SuspendLayout();

            try
            {
                SkinRootTreeNode rootNode = new SkinRootTreeNode(_skinFile, "file.xml");

                rootNode.ProcessAndAddChildren();
                rootNode.Expand();

                this.treeView1.Nodes.Add(rootNode);
            }
            finally
            {
                this.treeView1.ResumeLayout();
            }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.IsSelected)
            {
                if (this.NodeChanged != null)
                    this.NodeChanged(this, e);
            }
        }

    }
}

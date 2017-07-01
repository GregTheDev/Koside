namespace Koside.Controls
{
    partial class SkinTreeView
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SkinTreeView));
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.nodeTypeImageList = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.ImageIndex = 0;
            this.treeView1.ImageList = this.nodeTypeImageList;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            this.treeView1.SelectedImageIndex = 0;
            this.treeView1.Size = new System.Drawing.Size(150, 150);
            this.treeView1.TabIndex = 0;
            // 
            // nodeTypeImageList
            // 
            this.nodeTypeImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("nodeTypeImageList.ImageStream")));
            this.nodeTypeImageList.TransparentColor = System.Drawing.Color.Magenta;
            this.nodeTypeImageList.Images.SetKeyName(0, "XMLIntellisenseElement_10423_24.bmp");
            this.nodeTypeImageList.Images.SetKeyName(1, "XMLIntellisenseElement_10423_32.bmp");
            this.nodeTypeImageList.Images.SetKeyName(2, "Control_433_24.bmp");
            this.nodeTypeImageList.Images.SetKeyName(3, "Control_433_32.bmp");
            this.nodeTypeImageList.Images.SetKeyName(4, "GroupBox_680_24.bmp");
            this.nodeTypeImageList.Images.SetKeyName(5, "GroupBox_680_32.bmp");
            this.nodeTypeImageList.Images.SetKeyName(6, "ImageButton_735_24.bmp");
            this.nodeTypeImageList.Images.SetKeyName(7, "ImageButton_735_32.bmp");
            this.nodeTypeImageList.Images.SetKeyName(8, "ImageListControl_683_24.bmp");
            this.nodeTypeImageList.Images.SetKeyName(9, "ImageListControl_683_32.bmp");
            this.nodeTypeImageList.Images.SetKeyName(10, "Label_684_24.bmp");
            this.nodeTypeImageList.Images.SetKeyName(11, "Label_684_32.bmp");
            this.nodeTypeImageList.Images.SetKeyName(12, "TextBox_708_24.bmp");
            this.nodeTypeImageList.Images.SetKeyName(13, "TextBox_708_32.bmp");
            // 
            // SkinTreeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.treeView1);
            this.Name = "SkinTreeView";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ImageList nodeTypeImageList;
    }
}

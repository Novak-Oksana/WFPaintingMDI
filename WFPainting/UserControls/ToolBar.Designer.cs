namespace WFPainting.UserControls
{
    partial class ToolBar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ToolBar));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnnewpage = new System.Windows.Forms.ToolStripButton();
            this.btnopen = new System.Windows.Forms.ToolStripButton();
            this.btnsave = new System.Windows.Forms.ToolStripButton();
            this.toolFigure = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolWidth = new System.Windows.Forms.ToolStripComboBox();
            this.btncolor = new System.Windows.Forms.ToolStripButton();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.fontToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.colorToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.verticalAlignToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.centerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.topToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.bottomToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.horizontalAlignToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.centerToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.leftToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.rightToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.angleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnnewpage,
            this.btnopen,
            this.btnsave,
            this.toolFigure,
            this.toolStripSeparator,
            this.toolStripSeparator1,
            this.toolWidth,
            this.btncolor,
            this.toolStripDropDownButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(548, 25);
            this.toolStrip1.TabIndex = 10;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnnewpage
            // 
            this.btnnewpage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnnewpage.Image = ((System.Drawing.Image)(resources.GetObject("btnnewpage.Image")));
            this.btnnewpage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnnewpage.Name = "btnnewpage";
            this.btnnewpage.Size = new System.Drawing.Size(23, 22);
            this.btnnewpage.Text = "&New";
            // 
            // btnopen
            // 
            this.btnopen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnopen.Image = ((System.Drawing.Image)(resources.GetObject("btnopen.Image")));
            this.btnopen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnopen.Name = "btnopen";
            this.btnopen.Size = new System.Drawing.Size(23, 22);
            this.btnopen.Text = "&Open";
            // 
            // btnsave
            // 
            this.btnsave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnsave.Image = ((System.Drawing.Image)(resources.GetObject("btnsave.Image")));
            this.btnsave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(23, 22);
            this.btnsave.Text = "&Save";
            // 
            // toolFigure
            // 
            this.toolFigure.Items.AddRange(new object[] {
            "Rectangle",
            "RectangleRound",
            "Ellipse",
            "Line"});
            this.toolFigure.Name = "toolFigure";
            this.toolFigure.Size = new System.Drawing.Size(95, 25);
            this.toolFigure.Text = "Type Figure";
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolWidth
            // 
            this.toolWidth.Items.AddRange(new object[] {
            "Thin",
            "Normal",
            "Thick"});
            this.toolWidth.Name = "toolWidth";
            this.toolWidth.Size = new System.Drawing.Size(95, 25);
            this.toolWidth.Text = "Width";
            // 
            // btncolor
            // 
            this.btncolor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btncolor.Image = ((System.Drawing.Image)(resources.GetObject("btncolor.Image")));
            this.btncolor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btncolor.Name = "btncolor";
            this.btncolor.Size = new System.Drawing.Size(23, 22);
            this.btncolor.Text = "toolStripButton1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fontToolStripMenuItem1,
            this.colorToolStripMenuItem2,
            this.verticalAlignToolStripMenuItem,
            this.horizontalAlignToolStripMenuItem,
            this.angleToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(29, 22);
            this.toolStripDropDownButton1.Text = "toolStripDropDownButton1";
            // 
            // fontToolStripMenuItem1
            // 
            this.fontToolStripMenuItem1.Name = "fontToolStripMenuItem1";
            this.fontToolStripMenuItem1.Size = new System.Drawing.Size(158, 22);
            this.fontToolStripMenuItem1.Text = "Font";
            // 
            // colorToolStripMenuItem2
            // 
            this.colorToolStripMenuItem2.Name = "colorToolStripMenuItem2";
            this.colorToolStripMenuItem2.Size = new System.Drawing.Size(158, 22);
            this.colorToolStripMenuItem2.Text = "Color";
            // 
            // verticalAlignToolStripMenuItem
            // 
            this.verticalAlignToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.centerToolStripMenuItem,
            this.topToolStripMenuItem1,
            this.bottomToolStripMenuItem1});
            this.verticalAlignToolStripMenuItem.Name = "verticalAlignToolStripMenuItem";
            this.verticalAlignToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.verticalAlignToolStripMenuItem.Text = "Vertical align";
            // 
            // centerToolStripMenuItem
            // 
            this.centerToolStripMenuItem.Name = "centerToolStripMenuItem";
            this.centerToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.centerToolStripMenuItem.Text = "Center";
            // 
            // topToolStripMenuItem1
            // 
            this.topToolStripMenuItem1.Name = "topToolStripMenuItem1";
            this.topToolStripMenuItem1.Size = new System.Drawing.Size(109, 22);
            this.topToolStripMenuItem1.Text = "Near";
            // 
            // bottomToolStripMenuItem1
            // 
            this.bottomToolStripMenuItem1.Name = "bottomToolStripMenuItem1";
            this.bottomToolStripMenuItem1.Size = new System.Drawing.Size(109, 22);
            this.bottomToolStripMenuItem1.Text = "Far";
            // 
            // horizontalAlignToolStripMenuItem
            // 
            this.horizontalAlignToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.centerToolStripMenuItem1,
            this.leftToolStripMenuItem1,
            this.rightToolStripMenuItem1});
            this.horizontalAlignToolStripMenuItem.Name = "horizontalAlignToolStripMenuItem";
            this.horizontalAlignToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.horizontalAlignToolStripMenuItem.Text = "Horizontal align";
            // 
            // centerToolStripMenuItem1
            // 
            this.centerToolStripMenuItem1.Name = "centerToolStripMenuItem1";
            this.centerToolStripMenuItem1.Size = new System.Drawing.Size(109, 22);
            this.centerToolStripMenuItem1.Text = "Center";
            // 
            // leftToolStripMenuItem1
            // 
            this.leftToolStripMenuItem1.Name = "leftToolStripMenuItem1";
            this.leftToolStripMenuItem1.Size = new System.Drawing.Size(109, 22);
            this.leftToolStripMenuItem1.Text = "Near";
            // 
            // rightToolStripMenuItem1
            // 
            this.rightToolStripMenuItem1.Name = "rightToolStripMenuItem1";
            this.rightToolStripMenuItem1.Size = new System.Drawing.Size(109, 22);
            this.rightToolStripMenuItem1.Text = "Far";
            // 
            // angleToolStripMenuItem
            // 
            this.angleToolStripMenuItem.Name = "angleToolStripMenuItem";
            this.angleToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.angleToolStripMenuItem.Text = "Angle";
            // 
            // ToolBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.toolStrip1);
            this.Name = "ToolBar";
            this.Size = new System.Drawing.Size(548, 25);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnnewpage;
        private System.Windows.Forms.ToolStripButton btnopen;
        private System.Windows.Forms.ToolStripButton btnsave;
        private System.Windows.Forms.ToolStripComboBox toolFigure;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripComboBox toolWidth;
        private System.Windows.Forms.ToolStripButton btncolor;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem fontToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem colorToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem verticalAlignToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem centerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem topToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem bottomToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem horizontalAlignToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem centerToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem leftToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem rightToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem angleToolStripMenuItem;
    }
}

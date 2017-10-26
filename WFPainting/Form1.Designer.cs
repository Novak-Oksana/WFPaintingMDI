namespace WFPainting
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.toolBar1 = new WFPainting.UserControls.ToolBar();
            this.mainMenu1 = new WFPainting.UserControls.MainMenu();
            this.toolBox1 = new WFPainting.UserControls.ToolBox();
            this.pdraw2 = new WFPainting.Pdraw();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 503);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(752, 22);
            this.statusStrip1.TabIndex = 10;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(67, 17);
            this.toolStripStatusLabel1.Text = "Current x, y";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(22, 17);
            this.toolStripStatusLabel2.Text = "0:0";
            // 
            // tabControl
            // 
            this.tabControl.Location = new System.Drawing.Point(122, 52);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(630, 448);
            this.tabControl.TabIndex = 12;
            // 
            // toolBar1
            // 
            this.toolBar1.command = null;
            this.toolBar1.Location = new System.Drawing.Point(0, 20);
            this.toolBar1.Name = "toolBar1";
            this.toolBar1.Size = new System.Drawing.Size(573, 26);
            this.toolBar1.TabIndex = 15;
            // 
            // mainMenu1
            // 
            this.mainMenu1.command = null;
            this.mainMenu1.Location = new System.Drawing.Point(0, 0);
            this.mainMenu1.Name = "mainMenu1";
            this.mainMenu1.Size = new System.Drawing.Size(436, 28);
            this.mainMenu1.TabIndex = 14;
            // 
            // toolBox1
            // 
            this.toolBox1.command = null;
            this.toolBox1.Location = new System.Drawing.Point(1, 52);
            this.toolBox1.Name = "toolBox1";
            this.toolBox1.Size = new System.Drawing.Size(115, 440);
            this.toolBox1.TabIndex = 13;
            // 
            // pdraw2
            // 
            this.pdraw2.BackColor = System.Drawing.SystemColors.Window;
            this.pdraw2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pdraw2.command = null;
            this.pdraw2.Location = new System.Drawing.Point(49, 60);
            this.pdraw2.Name = "pdraw2";
            this.pdraw2.Size = new System.Drawing.Size(21, 18);
            this.pdraw2.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 525);
            this.Controls.Add(this.toolBar1);
            this.Controls.Add(this.mainMenu1);
            this.Controls.Add(this.toolBox1);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.statusStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Pdraw pdraw2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.TabControl tabControl;
        private UserControls.ToolBox toolBox1;
        private UserControls.MainMenu mainMenu1;
        private UserControls.ToolBar toolBar1;
    }
}


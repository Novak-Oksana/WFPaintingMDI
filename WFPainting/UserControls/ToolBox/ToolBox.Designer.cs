namespace WFPainting.UserControls
{
    partial class ToolBox
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
            this.pColor1 = new WFPainting.PColor();
            this.pOpen1 = new WFPainting.POpen();
            this.pSave1 = new WFPainting.PSave();
            this.pWidth1 = new WFPainting.PWidth();
            this.select_figure1 = new WFPainting.select_figure();
            this.pTextSet1 = new WFPainting.UserControls.PTextSet();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pColor1
            // 
            this.pColor1.command = null;
            this.pColor1.Location = new System.Drawing.Point(0, 61);
            this.pColor1.Name = "pColor1";
            this.pColor1.Size = new System.Drawing.Size(107, 28);
            this.pColor1.TabIndex = 5;
            // 
            // pOpen1
            // 
            this.pOpen1.command = null;
            this.pOpen1.Location = new System.Drawing.Point(3, 158);
            this.pOpen1.Name = "pOpen1";
            this.pOpen1.Size = new System.Drawing.Size(107, 50);
            this.pOpen1.TabIndex = 4;
            // 
            // pSave1
            // 
            this.pSave1.command = null;
            this.pSave1.Location = new System.Drawing.Point(3, 113);
            this.pSave1.Name = "pSave1";
            this.pSave1.Size = new System.Drawing.Size(107, 48);
            this.pSave1.TabIndex = 3;
            // 
            // pWidth1
            // 
            this.pWidth1.command = null;
            this.pWidth1.Location = new System.Drawing.Point(0, 89);
            this.pWidth1.Name = "pWidth1";
            this.pWidth1.Size = new System.Drawing.Size(106, 28);
            this.pWidth1.TabIndex = 2;
            // 
            // select_figure1
            // 
            this.select_figure1.command = null;
            this.select_figure1.Location = new System.Drawing.Point(0, 28);
            this.select_figure1.Name = "select_figure1";
            this.select_figure1.Size = new System.Drawing.Size(116, 28);
            this.select_figure1.TabIndex = 0;
            // 
            // pTextSet1
            // 
            this.pTextSet1.command = null;
            this.pTextSet1.Location = new System.Drawing.Point(0, 234);
            this.pTextSet1.Name = "pTextSet1";
            this.pTextSet1.Size = new System.Drawing.Size(122, 212);
            this.pTextSet1.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Figure Settings";
            // 
            // ToolBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pTextSet1);
            this.Controls.Add(this.pColor1);
            this.Controls.Add(this.pOpen1);
            this.Controls.Add(this.pSave1);
            this.Controls.Add(this.pWidth1);
            this.Controls.Add(this.select_figure1);
            this.Name = "ToolBox";
            this.Size = new System.Drawing.Size(125, 465);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private select_figure select_figure1;
        private PWidth pWidth1;
        private PColor pColor1;
        private POpen pOpen1;
        private PSave pSave1;
        private PTextSet pTextSet1;
        private System.Windows.Forms.Label label3;
    }
}

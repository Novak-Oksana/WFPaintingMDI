namespace WFPainting
{
    partial class PColor
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
            this.btncolor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btncolor
            // 
            this.btncolor.Location = new System.Drawing.Point(3, 0);
            this.btncolor.Name = "btncolor";
            this.btncolor.Size = new System.Drawing.Size(100, 21);
            this.btncolor.TabIndex = 0;
            this.btncolor.Text = "Color";
            this.btncolor.UseVisualStyleBackColor = true;
            // 
            // PColor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btncolor);
            this.Name = "PColor";
            this.Size = new System.Drawing.Size(107, 28);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btncolor;
    }
}

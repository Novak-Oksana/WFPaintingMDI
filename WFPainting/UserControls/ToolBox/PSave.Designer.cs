namespace WFPainting
{
    partial class PSave
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
            this.btnsave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnsave
            // 
            this.btnsave.BackColor = System.Drawing.SystemColors.Control;
            this.btnsave.Location = new System.Drawing.Point(0, 3);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(100, 40);
            this.btnsave.TabIndex = 0;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = false;
            // 
            // PSave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnsave);
            this.Name = "PSave";
            this.Size = new System.Drawing.Size(104, 47);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnsave;
    }
}

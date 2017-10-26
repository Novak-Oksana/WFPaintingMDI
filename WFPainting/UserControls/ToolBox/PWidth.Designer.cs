namespace WFPainting
{
    partial class PWidth
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
            this.box_width = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // box_width
            // 
            this.box_width.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.box_width.FormattingEnabled = true;
            this.box_width.Items.AddRange(new object[] {
            "Thin",
            "Normal",
            "Thick"});
            this.box_width.Location = new System.Drawing.Point(3, 3);
            this.box_width.Name = "box_width";
            this.box_width.Size = new System.Drawing.Size(100, 21);
            this.box_width.TabIndex = 0;
            // 
            // PWidth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.box_width);
            this.Name = "PWidth";
            this.Size = new System.Drawing.Size(106, 28);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ComboBox box_width;
    }
}

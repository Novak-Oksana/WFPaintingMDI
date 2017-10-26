namespace WFPainting
{
    partial class select_figure
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
            this.box_figure = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // box_figure
            // 
            this.box_figure.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.box_figure.FormattingEnabled = true;
            this.box_figure.Items.AddRange(new object[] {
            "Rectangle",
            "RectangleRound",
            "Ellipse",
            "Line"});
            this.box_figure.Location = new System.Drawing.Point(3, 3);
            this.box_figure.Name = "box_figure";
            this.box_figure.Size = new System.Drawing.Size(100, 21);
            this.box_figure.TabIndex = 0;
            // 
            // select_figure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.box_figure);
            this.Name = "select_figure";
            this.Size = new System.Drawing.Size(110, 28);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ComboBox box_figure;
    }
}

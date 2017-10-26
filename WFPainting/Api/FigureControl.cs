using System;
using System.Drawing;
using System.Windows.Forms;

namespace WFPainting.Api
{
  //  [Serializable()]
    public partial class FigureControl : UserControl
    {
        private CFigure figure;
        private Image image;
        private CText text;

        public Point Start { get; private set; }
        public Point End { get; private set; }
        public Point mouseLocation = new Point();
        bool resize = false;

        public FigureDrawing Type { set; get; }
        public int LineW { set; get; }
        public Color Color { set; get; }

        public FigureControl(CFigure figure, CText text)
        {
            InitializeComponent();
            this.figure = figure;
            this.text = text;
            textBox.Text = text.Text;
            textBox.Font = text.TextFont;
            textBox.ForeColor = text.TextColor;

            colorToolStripMenuItem.DropDownItemClicked += ChangeColor;
            widthToolStripMenuItem.DropDownItemClicked += ChangeWidth;
            typeFigureToolStripMenuItem.DropDownItemClicked += ChangeType;

            fontToolStripMenuItem.Click += ChangeFont;
            colorToolStripMenuItem1.Click += ChangeColorText;
            verticalAlignToolStripMenuItem.DropDownItemClicked += TextVerticalAlignToolStripMenuItem_DropDownItemClicked;
            horizontalAlignToolStripMenuItem.DropDownItemClicked += TextHorizontalAlignToolStripMenuItem_DropDownItemClicked;

            angleToolStripMenuItem.Click += ChangeAngle;

            MouseMove += Figure_MouseMove;
            MouseDown += Figure_MouseDown;
            MouseUp += Figure_MouseUp;
        }

        private void TextVerticalAlignToolStripMenuItem_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            switch (e.ClickedItem.Text)
            {
                case "Center":
                    text.VerticalAlign = StringAlignment.Center;
                    break;
                case "Near":
                    text.VerticalAlign = StringAlignment.Near;
                    break;
                case "Far":
                    text.VerticalAlign = StringAlignment.Far;
                    break;
                default: break;
            }
            ReDrawText();
        }


        private void TextHorizontalAlignToolStripMenuItem_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            switch (e.ClickedItem.Text)
            {
                case "Center":
                    text.HorizontalAlign = StringAlignment.Center;
                    break;
                case "Near":
                    text.HorizontalAlign = StringAlignment.Near;
                    break;
                case "Far":
                    text.HorizontalAlign = StringAlignment.Far;
                    break;
                default: break;
            }
            ReDrawText();
        }

        private void Figure_MouseUp(object sender, MouseEventArgs e)
        {
            resize = false;
        }

        private void Figure_MouseDown(object sender, MouseEventArgs e)
        {
            mouseLocation = e.Location;

            if (e.Button == MouseButtons.Right)
            {
                ContextMenuStrip.Show(Cursor.Position);
            }
            resize = (e.X > Size.Width - 10 || e.Y > Size.Height - 10);
        }

        private void Figure_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.X > Size.Width - 5)
                Cursor.Current = Cursors.SizeWE;
            else if (e.Y > Size.Height - 5)
                Cursor.Current = Cursors.SizeNS;
            else
                Cursor.Current = Cursors.Hand;
            if (e.Button == MouseButtons.Left)
            {
                if (!resize)
                {
                    {
                        PictureBox pb = sender as PictureBox;
                        int x_shift = e.X - mouseLocation.X;
                        int y_shift = e.Y - mouseLocation.Y;
                        Start = new Point(Start.X + e.X - mouseLocation.X, Start.Y + e.Y - mouseLocation.Y);
                        End = new Point(End.X + e.X - mouseLocation.X, End.Y + e.Y - mouseLocation.Y);
                        Location = new Point(Location.X + x_shift, Location.Y + y_shift);
                    }
                }
                else
                {
                    Height += e.Y - mouseLocation.Y;
                    Width += e.X - mouseLocation.X;
                    End = new Point(End.X + e.X - mouseLocation.X, End.Y + e.Y - mouseLocation.Y);
                    mouseLocation = e.Location;
                }
            }
        }

        private void ChangeAngle(object sender, EventArgs e)
        {
            throw new NotImplementedException();
            // ReDrawText();
        }

        private void ChangeColorText(object sender, EventArgs e)
        {
            ColorDialog dlgColor = new ColorDialog();
            if (dlgColor.ShowDialog() == DialogResult.OK)
            {
                text.TextColor = dlgColor.Color;
            }
            ReDrawText();
        }

        private void ChangeFont(object sender, EventArgs e)
        {
            FontDialog dlg = new FontDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                text.TextFont = dlg.Font;
            }
            ReDrawText();
        }

        private void ChangeType(object sender, ToolStripItemClickedEventArgs e)
        {
            switch (e.ClickedItem.Text)
            {
                case "Rectangle":
                    figure.Type = FigureDrawing.Rectangle;
                    break;
                case "RectangleRound":
                    figure.Type = FigureDrawing.RoundRectangle;
                    break;
                case "Ellipse":
                    figure.Type = FigureDrawing.Round;
                    break;
                case "Line":
                    figure.Type = FigureDrawing.Line;
                    break;

            }
            ReDraw();
        }

        private void ChangeWidth(object sender, ToolStripItemClickedEventArgs e)
        {
            switch (e.ClickedItem.Text)
            {
                case "Thin":
                    figure.LineW = 1;
                    break;
                case "Normal":
                    figure.LineW = 3;
                    break;
                case "Thick":
                    figure.LineW = 5;
                    break;
            }
            ReDraw();
            //textBox.Font = new Font("Tahoma", figure.LineW);
        }

        private void ChangeColor(object sender, ToolStripItemClickedEventArgs e)
        {
            switch (e.ClickedItem.Text)
            {
                case "Red":
                    figure.Color = Color.Red;
                    break;
                case "Blue":
                    figure.Color = Color.Blue;
                    break;
                case "Green":
                    figure.Color = Color.Green;
                    break;
            }
            ReDraw();
        }

        private void ReDraw()
        {
            Graphics graphics = Graphics.FromImage(image);
            graphics.Clear(Color.White);
            figure.Draw(graphics, Width - 1, Height - 1);
            Refresh();
        }

        private void FigureControl_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(Color.White);
            e.Graphics.DrawImage(image, 0, 0);
        }

        private void FigureControl_Resize(object sender, System.EventArgs e)
        {
            if (Width != 0 && Height != 0)
            {
                image = new Bitmap(Width, Height);
                ReDraw();
            }
            textBox.Left = Width / 2 - textBox.Width / 2;
            textBox.Top = Height / 2 - textBox.Height / 2;

        }

        private void ReDrawText()
        {
            textBox.Font = text.TextFont;
            textBox.ForeColor = text.TextColor;

         //   textBox.TextAlign = text.HorizontalAlign;
        }

        public CText GetText()
        {
            return text;
        }

        public CFigure GetFigure()
        {
            return figure;
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            text.Text = textBox.Text;
           // text.TextColor = textBox.ForeColor;
          
        }
    }
}


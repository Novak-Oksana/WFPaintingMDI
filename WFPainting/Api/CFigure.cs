using System;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace WFPainting.Api
{
    [Serializable]
    public class CFigure
    {
        public int X1 { set; get; }
        public int Y1 { set; get; }
        public int X2 { set; get; }
        public int Y2 { set; get; }
        public int Width { set; get; }
        public int Height { set; get; }

        public Color Color { set; get; }
        public int LineW { set; get; }
        public FigureDrawing Type { set; get; }

        public CFigure()
        { }

        public CFigure(int x1, int y1, int x2, int y2)
        {
            if (x2 < x1)
            {
                X1 = x2;
                X2 = x1;
            }
            else
            {
                X1 = x1;
                X2 = x2;
            }
            if (y2 < y1)
            {
                Y1 = y2;
                Y2 = y1;
            }
            else
            {
                Y1 = y1;
                Y2 = y2;
            }
            Width = X2 - X1;
            Height = Y2 - Y1;
        }

        private GraphicsPath RoundRectangle(int x, int y, int width, int height, int diameter)
        {
            GraphicsPath path = new GraphicsPath();

            Rectangle bounds = new Rectangle(x, y, width, height);
            Size size = new Size(diameter, diameter);
            Rectangle arc = new Rectangle(bounds.Location, size);
            path.AddArc(arc, 180, 90);
            arc.X = bounds.Right - diameter;
            path.AddArc(arc, 270, 90);
            arc.Y = bounds.Bottom - diameter;
            path.AddArc(arc, 0, 90);
            arc.X = bounds.Left;
            path.AddArc(arc, 90, 90);
            arc.Y = bounds.Top;
            path.CloseFigure();
            return path;
        }

        private GraphicsPath CreatePath(int width, int height)
        {
            GraphicsPath path = new GraphicsPath();
            if (Type == FigureDrawing.Rectangle)
                path.AddRectangle(new Rectangle(0, 0, width, height));
            else if (Type == FigureDrawing.Round)
                path.AddEllipse(new Rectangle(0, 0, width, height));
            else if (Type == FigureDrawing.Line)
                path.AddLine(000, 000, width, height);
            else if (Type == FigureDrawing.RoundRectangle)
                path = RoundRectangle(0, 0, width, height, 20);

            return path;
        }

        public void Draw(Graphics graphics, int viewWidth, int viewHeight)
        {
            Pen pen = new Pen(Color, LineW);
            pen.Alignment = PenAlignment.Inset;
            graphics.DrawPath(pen, CreatePath(viewWidth, viewHeight));
        }
    }
}

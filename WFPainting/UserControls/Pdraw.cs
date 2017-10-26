using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using WFPainting.Api;

namespace WFPainting
{
    public partial class Pdraw : TabPage
    {
        private int x = 0;
        private int y = 0;

        private List<FigureControl> figures = new List<FigureControl>();

        public StatusStrip statusStrip;
       // public XCommand command;
        public XData data = null;
        public XCommand command { get; set; }

    public Pdraw()
        {
            InitializeComponent();
        }

        private void Pdraw_MouseDown(object sender, MouseEventArgs e)
        {
            x = e.X;
            y = e.Y;
        }

        private void Pdraw_MouseMove(object sender, MouseEventArgs e)
        {
            statusStrip.Items[1].Text = "" + e.X + ":" + e.Y;
            statusStrip.Invalidate();
            statusStrip.Refresh();
        }

        private void Pdraw_MouseUp(object sender, MouseEventArgs e)
        {
            CFigure figure = new CFigure(x, y, e.X, e.Y);
            figure.Type = command.data.method;// data.method;
            figure.Color = data.color;
            figure.LineW = data.width;

            CText text = new CText();

            AddFigure(figure, text);
        }

        public void AddFigure(CFigure figure, CText text)
        {
            FigureControl figureControl = new FigureControl(figure, text);
            figureControl.Size = new Size(figure.Width, figure.Height);
            figureControl.Left = figure.X1;
            figureControl.Top = figure.Y1;

            Controls.Add(figureControl);
            figures.Add(figureControl);

            Refresh();
        }

        public List<FigureControl> GetFigureControls()
        {
            return figures;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFPainting.Api;

namespace WFPainting
{
    
    public class XData
    {

        public Color color = Color.Red;
        public int width = 1;
        public FigureDrawing method = FigureDrawing.Rectangle;
        public Image image;
        //   public List<CFigure> figures = new List<CFigure>();

       // public string textString = "";
        public int textAngle = 0;
        public Color textColor = Color.Blue;
        public StringAlignment horizontalAlign = StringAlignment.Center;
        public StringAlignment verticalAlign = StringAlignment.Center;
        public Font textFont = new Font(new FontFamily("Arial"), 20);
    }
}

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
    public class XCommand
    {
        public XData data = new XData();
        public Form1 form;
      //  public XData data { get; private set; } = new XData();
        public Pdraw pdraw;

        //    public delegate void setColorText(Color textColor);
        ///  public delegate void setTextFont(Font textFont);

        public void setType(object sender, EventArgs e, string type)
        {
            switch (type)
            {
                case "Rectangle":
                    data.method = FigureDrawing.Rectangle;
                    break;
                case "RectangleRound":
                    data.method = FigureDrawing.RoundRectangle;
                    break;
                case "Ellipse":
                    data.method = FigureDrawing.Round;
                    break;
                case "Line":
                    data.method = FigureDrawing.Line;
                    break;
                    //  default: break;
            }
        }

        public void setColor(object sender, EventArgs e)
        {
            ColorDialog dlgColor = new ColorDialog();
            if (dlgColor.ShowDialog() == DialogResult.OK)
            {
                data.color = dlgColor.Color;
            }
        }

        public void setWidth(object sender, EventArgs e, string lineWidth)
        {
            switch (lineWidth)
            {
                case "Thin":
                    data.width =1;
                    break;
                case "Normal":
                    data.width =3;
                    break;
                case "Thick":
                    data.width =5;
                    break;
            }
        }

        public void setTextColor(object sender, EventArgs e)
        {
            ColorDialog dlgColor = new ColorDialog();
            if (dlgColor.ShowDialog() == DialogResult.OK)
            {
                data.textColor = dlgColor.Color;
            }
        }

        public void setTextFont(object sender, EventArgs e)
        {
            FontDialog dlg = new FontDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                data.textFont = dlg.Font;
            }
        }

        public void setTextAngle(object sender, EventArgs e, int angle)
        {
            data.textAngle = angle;
        }

        public void setVerticalAlign(object sender, EventArgs e, string align)
        {
            switch (align)
            {
                case "Center": { data.verticalAlign = StringAlignment.Center; break; }
                case "Near": { data.verticalAlign = StringAlignment.Near; break; }
                case "Far": { data.verticalAlign = StringAlignment.Far; break; }
                default: break;
            }
        }

        public void setHorizontalAlign(object sender, EventArgs e, string align)
        {
            switch (align)
            {
                case "Center": { data.horizontalAlign = StringAlignment.Center; break; }
                case "Near": { data.horizontalAlign = StringAlignment.Near; break; }
                case "Far": { data.horizontalAlign = StringAlignment.Far; break; }
                default: break;
            }
        }

        public void saveFigures(object sender, EventArgs e)
        {
            SaveFileDialog dgSave = new SaveFileDialog();
            string[] ext = { "JSON (*.json)|*.json", "XML (*.xml) | *.xml", "YAML (*.yaml)|*.yaml", "BIN (*.bin)|*.bin" };
            dgSave.Filter = String.Join("|", ext);
            if (dgSave.ShowDialog() == DialogResult.OK)
            {
                List<TabMemento> tabMementoList = new List<TabMemento>();
                foreach (TabPage tabPage in form.GetTabControl().TabPages)
                {
                    Pdraw pdraw = (Pdraw)tabPage;

                    TabMemento tabMemento = new TabMemento();
                    tabMementoList.Add(tabMemento);
                    tabMemento.tabName = pdraw.Text;

                    foreach (FigureControl figureControl in pdraw.GetFigureControls())
                    {
                        FigureMemento figureMemento = new FigureMemento();
                        figureMemento.figure = figureControl.GetFigure();
                        figureMemento.text = figureControl.GetText();
                        tabMemento.mementoList.Add(figureMemento);
                    }
                }
                SOFactory.GetInstance(dgSave.FileName).Save(tabMementoList);
            }
        }

        public void openFigures(object sender, EventArgs e)
        {
            OpenFileDialog dgOpen = new OpenFileDialog();
            string ext = "(*.json; *.xml; *.yaml; *.bin)| *.json; *.xml; *.yaml; *.bin";
            dgOpen.Filter = ext;
            if (dgOpen.ShowDialog() == DialogResult.OK)
            {
                form.GetTabControl().TabPages.Clear();
                List<TabMemento> tabMementoList = SOFactory.GetInstance(dgOpen.FileName).Open();
                foreach (TabMemento tabMemento in tabMementoList)
                {
                    Pdraw pdraw = form.AddNewTab(tabMemento.tabName);
                    foreach (FigureMemento figureMemento in tabMemento.mementoList)
                    {
                        pdraw.AddFigure(figureMemento.figure, figureMemento.text);
                    }
                }
            }
        }


    }
}
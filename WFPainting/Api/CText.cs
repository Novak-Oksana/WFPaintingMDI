using System;
using System.Drawing;

namespace WFPainting.Api
{
    [Serializable]
    public class CText
    {
        private string fontName = "Tahoma";
        private float fontSize = 16;
        public string Text { get; set; }
        //   public Font TextFont { get; set; }
       // [NonSerialized]
        public Font TextFont
        {
            get
            {
                return new Font(fontName, fontSize);
            }
            set
            {
                fontName = value.Name;
                fontSize = value.Size;
            }
        }
        public int TextAngle { get; set; }
        public Color TextColor { get; set; }
        public StringAlignment HorizontalAlign { get; set; }
        public StringAlignment VerticalAlign { get; set; }

    }
}

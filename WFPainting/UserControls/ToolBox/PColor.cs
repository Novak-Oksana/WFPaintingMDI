using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFPainting
{
    public partial class PColor : UserControl
    {
        public XCommand command { get; set; }

        public PColor()
        {
            InitializeComponent();
            btncolor.Click += new EventHandler((s, e) => command.setColor(s, e));
        }
   
    }
}

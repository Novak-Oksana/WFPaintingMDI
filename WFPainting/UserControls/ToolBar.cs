using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFPainting.UserControls
{
    public partial class ToolBar : UserControl
    {
        public XCommand command { get; set; }

        public ToolBar()
        {
            InitializeComponent();
            btnsave.Click += new EventHandler((s, e) => command.saveFigures(s, e));
            btnopen.Click += new EventHandler((s, e) => command.openFigures(s, e));
            btncolor.Click += new EventHandler((s, e) => command.setColor(s, e));
            toolFigure.SelectedIndexChanged += new EventHandler((s, e) => command.setType(s, e, toolFigure.SelectedItem.ToString()));
            toolWidth.SelectedIndexChanged += new EventHandler((s, e) => command.setWidth(s, e, toolWidth.SelectedItem.ToString()));

            fontToolStripMenuItem1.Click += new EventHandler((s, e) => command.setTextFont(s, e));
            colorToolStripMenuItem2.Click += new EventHandler((s, e) => command.setTextColor(s, e));
        }
    }
}

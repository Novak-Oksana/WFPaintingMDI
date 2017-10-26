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
    public partial class MainMenu : UserControl
    {
        public XCommand command { get; set; }

        public MainMenu()
        {
            InitializeComponent();
            saveToolStripMenuItem.Click += new EventHandler((s, e) => command.saveFigures(s, e));
            openToolStripMenuItem.Click += new EventHandler((s, e) => command.openFigures(s, e));
            typeFigureToolStripMenuItem.DropDownItemClicked += new ToolStripItemClickedEventHandler((s, e) => command.setType(s, e, e.ClickedItem.Text));
            colorToolStripMenuItem.Click += new EventHandler((s, e) => command.setColor(s, e));
            widthToolStripMenuItem.DropDownItemClicked += new ToolStripItemClickedEventHandler((s, e) => command.setWidth(s, e, e.ClickedItem.Text));


            colorToolStripMenuItem2.Click += new EventHandler((s, e) => command.setTextColor(s, e));
            fontToolStripMenuItem.Click += new EventHandler((s, e) => command.setTextFont(s, e));
        }
    }
}

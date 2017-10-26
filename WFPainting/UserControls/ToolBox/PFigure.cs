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
    public partial class select_figure : UserControl
    {
        public XCommand command { get; set; }

        public select_figure()
        {
            InitializeComponent();
            box_figure.SelectedIndex = 0;
            box_figure.SelectedIndexChanged += new EventHandler((s, e) => command.setType(s, e, box_figure.SelectedItem.ToString()));
        }

    }
}

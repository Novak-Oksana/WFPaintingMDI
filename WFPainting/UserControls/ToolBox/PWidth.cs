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
    public partial class PWidth : UserControl
    {
        public XCommand command { get; set; }

        public PWidth()
        {           
            InitializeComponent();
            box_width.SelectedIndex = 0;
            box_width.SelectedIndexChanged += new EventHandler((s, e) => command.setWidth(s, e, box_width.SelectedItem.ToString()));
        }


    }
}

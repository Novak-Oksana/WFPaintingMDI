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
    public partial class PTextSet : UserControl
    {
        public XCommand command { get; set; }
        public PTextSet()
        {
            InitializeComponent();
            comboBoxVerticalAlign.SelectedIndex = 0;
            comboBoxHorizontalAlign.SelectedIndex = 0;
            btnTextColor.Click += new EventHandler((s, e) => command.setTextColor(s, e));
            btnFont.Click += new EventHandler((s, e) => command.setTextFont(s, e));
            numericUpDownAngle.ValueChanged += new EventHandler((s, e) => command.setTextAngle(s, e, (int)numericUpDownAngle.Value));
            comboBoxVerticalAlign.SelectedIndexChanged += new EventHandler((s, e) => command.setVerticalAlign(s, e, comboBoxVerticalAlign.SelectedItem.ToString()));
            comboBoxHorizontalAlign.SelectedIndexChanged += new EventHandler((s, e) => command.setHorizontalAlign(s, e, comboBoxHorizontalAlign.SelectedItem.ToString()));
        }
    }
}

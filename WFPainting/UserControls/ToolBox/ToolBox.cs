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
    public partial class ToolBox : UserControl
    {
        public XCommand command { get; set; }
        
        public ToolBox()
        {
            InitializeComponent();
            Load += setCommand;
        }

        private void setCommand(object sender, EventArgs e)
        {
            pWidth1.command = command;
            pColor1.command = command;
            select_figure1.command = command;
            pSave1.command = command;
            pOpen1.command = command;
            pTextSet1.command = command;
        }
    }
}

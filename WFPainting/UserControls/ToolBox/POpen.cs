using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFPainting.Api;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace WFPainting
{
    public partial class POpen : UserControl
    {
        public XCommand command { get; set; }
        public Form1 form;

        public POpen()
        {
            InitializeComponent();
            btnopen.Click += new EventHandler((s, e) => command.openFigures(s, e));
        }
    }
}

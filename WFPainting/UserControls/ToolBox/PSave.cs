using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WFPainting.Api;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Drawing.Imaging;

namespace WFPainting
{
    public partial class PSave : UserControl
    {
        public XCommand command { get; set; }

        public PSave()
        {
            InitializeComponent();
            btnsave.Click += new EventHandler((s, e) => command.saveFigures(s, e));
        }
        
    }
}

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using WFPainting.Api;

namespace WFPainting
{
    public partial class Form1 : Form
    {
        public XCommand command = null;

        public Form1()
        {

            InitializeComponent();
            command = new XCommand();
            command.form = this;
            AddNewTab("page" + (tabControl.TabPages.Count + 1));

            toolBox1.command = command;
            mainMenu1.command = command;
            toolBar1.command = command;
        }

        public Pdraw AddNewTab(string text)
        {
            Pdraw pdraw = new Pdraw();
            pdraw.Text = text;
            pdraw.data = command.data;
            pdraw.command = command;
            pdraw.statusStrip = statusStrip1;
            tabControl.TabPages.Add(pdraw);
            tabControl.SelectTab(pdraw);
            return pdraw;
        }

        private void btnnewpage_Click(object sender, EventArgs e)
        {
            AddNewTab("page" + (tabControl.TabPages.Count + 1));
        }

        public TabControl GetTabControl()
        {
            return tabControl;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EVE_Intel_Monitor
{
    public partial class HelpForm : Form
    {
        int x, y;
        public HelpForm(int x,int y)
        {
            this.x = x+150;
            this.y = y+100;
            InitializeComponent();

        }

        private void HelpForm_Load(object sender, EventArgs e)
        {
            this.Location = new Point(x, y);

        }
    }
}

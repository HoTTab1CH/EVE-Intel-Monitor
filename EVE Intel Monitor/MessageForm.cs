using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Runtime.InteropServices;
using System.Drawing.Drawing2D;


namespace EVE_Intel_Monitor
{

    public partial class MessageForm : Form
    {
        Model model;

        public MessageForm(Model model)
        {
            this.model = model;
            InitializeComponent();

            this.SetDesktopLocation(model.MessageFormX, model.MessageFormY);
            ShowMessages();
        }
        void ShowMessages()
        {
            label1.Text = model.LastReports[0];
            label2.Text = model.LastReports[1];
            label3.Text = model.LastReports[2];

            timertick2.Enabled = true;

        }
        private void timertick2_Tick(object sender, EventArgs e)
        {
            ShowMessages();
        }
        private void MessageForm_Load(object sender, EventArgs e)
        {
            this.Location = new Point(model.MessageFormX, model.MessageFormY);
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.TransparencyKey = System.Drawing.Color.Black;
            this.TopMost = true;

        }

        #region Move form by dragging button
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void button1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        #endregion

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            model.Close = true;
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void clearReportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            model.ClrLastReports();
        }
    }
}

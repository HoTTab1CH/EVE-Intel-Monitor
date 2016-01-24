using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.IO;
using System.Media;

namespace EVE_Intel_Monitor
{

    public partial class Form1 : Form
    {
        MessageForm messageForm;
        Model model;
        HelpForm helpForm;

        public Form1()
        {
            InitializeComponent();

            model = new Model();
            messageForm = new MessageForm(model);

            //filling form from settings
            tbChatMonitor.Text = model.ChatName;
            for (int i = 0; i < model.Systems.Count; i++)
            {
                lstbSystemList.Items.Add(model.Systems[i].ToUpper());
            }

            //buttons on start
            if (model.TimerEnable == true)
                btnStart.Enabled = false;
            else
                btnStop.Enabled = false;


            //open transparent form with last messages
            messageForm.Show();
        }

        private void tmrTick_Tick(object sender, EventArgs e)
        {
            //just reading the file every tick (1s)
            model.Run();
            lblReport1.Text = model.LastReports[0];
            lblReport2.Text = model.LastReports[1];
            lblReport3.Text = model.LastReports[2];
            //            tmrTick.Enabled = model.TimerEnable;
        }
        private void btnFullReset_Click(object sender, EventArgs e)
        {
            tmrTick.Enabled = false;
            model.ChatName = tbChatMonitor.Text;
            model.FullReset();

            lblReport1.Text = model.LastReports[0];
            lblReport2.Text = model.LastReports[1];
            lblReport3.Text = model.LastReports[2];

            btnStart.Enabled = true;
            btnStop.Enabled = false;
            lblChar.Text = model.Character;
            lblCurrentChat.Text = model.ChatName;
            tbChatMonitor.Text = model.ChatName;

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            model.ClrLastReports();
            lblReport1.Text = model.LastReports[0];
            lblReport2.Text = model.LastReports[1];
            lblReport3.Text = model.LastReports[2];
        }
        private void btnAddSystem_Click(object sender, EventArgs e)
        {
            if (tbSystem.Text != null && tbSystem.Text != "" && tbSystem.Text != " ")
            {
                model.Systems.Add(tbSystem.Text);
                lstbSystemList.Items.Add(tbSystem.Text);
            }
        }
        private void btnRemoveAll_Click(object sender, EventArgs e)
        {
            lstbSystemList.Items.Clear();
            model.Systems.Clear();
        }
        private void btnRemove_Click(object sender, EventArgs e)
        {
            string temp = lstbSystemList.SelectedItem.ToString();
            lstbSystemList.Items.Remove(temp);
            for (int i = 0; i < model.Systems.Count; i++)
                if (model.Systems[i].Contains(temp))
                    model.Systems.RemoveAt(i);
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Chat name
            Properties.Settings.Default.ChatName = tbChatMonitor.Text;

            //Systems
            Properties.Settings.Default.SystemList = new System.Collections.Specialized.StringCollection();
            for (int i = 0; i < model.Systems.Count; i++)
                Properties.Settings.Default.SystemList.Add(model.Systems[i]);

            //messageForm location
            if (messageForm.Location.X >= Screen.PrimaryScreen.Bounds.Width ||
                messageForm.Location.Y >= Screen.PrimaryScreen.Bounds.Height ||
                messageForm.Location.X < 0 ||
                messageForm.Location.Y < 0)
            {
                Properties.Settings.Default.MessageFormX = 0;
                Properties.Settings.Default.MessageFormY = 0;

            }
            else
            {
                Properties.Settings.Default.MessageFormX = messageForm.Location.X;
                Properties.Settings.Default.MessageFormY = messageForm.Location.Y;

            }

            //main form location
            if (this.Location.X > Screen.PrimaryScreen.Bounds.Width ||
                this.Location.Y > Screen.PrimaryScreen.Bounds.Height ||
                this.Location.X < 0 ||
                this.Location.Y < 0)
            {
                Properties.Settings.Default.MainFormX = 0;
                Properties.Settings.Default.MainFormY = 0;
            }
            else
            {
                Properties.Settings.Default.MainFormX = this.Location.X;
                Properties.Settings.Default.MainFormY = this.Location.Y;

            }

            Properties.Settings.Default.Save();

            // Clean up any components being used.
            tmrTick.Enabled = false;
            base.Dispose();
        }




        private void Form1_Resize(object sender, EventArgs e)
        {
            if (FormWindowState.Minimized == this.WindowState)
            {
                this.WindowState = FormWindowState.Minimized;
                this.ShowInTaskbar = false;
                notifyIconMainForm.ShowBalloonTip(100);
            }
        }

        private void notifyIconMainForm_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            // Set the WindowState to normal if the form is minimized.
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.WindowState = FormWindowState.Normal;
                // Activate the form.
                this.Show();
                this.Activate();
                this.ShowInTaskbar = true;
            }
            else if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Minimized;
                this.ShowInTaskbar = false;
            }


        }


        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Close the form, which closes the application.
            this.Close();
        }

        private void mFileExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            model.startGetFileName();
            if (model.TimerEnable == true)
            {
                model.Run();

                tmrTick.Enabled = model.TimerEnable;

                btnStart.Enabled = false;
                btnStop.Enabled = true;

                lblCurrentChat.Text = model.ChatName;
                lblChar.Text = model.Character;
                tbChatMonitor.Text = model.ChatName;
            }
        }

        public void btnStop_Click(object sender, EventArgs e)
        {
            tmrTick.Enabled = model.TimerEnable = false;

            btnStart.Enabled = true;
            btnStop.Enabled = false;
        }

        private void tmrCloseForm_Tick(object sender, EventArgs e)
        {
            //closing app if true;
            if (model.Close == true)
                this.Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            helpForm = new HelpForm(this.Location.X, this.Location.Y);
            helpForm.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Location = new Point(model.MainFormX, model.MainFormY);
        }

        private void clearReportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            model.ClrLastReports();
        }
    }
}

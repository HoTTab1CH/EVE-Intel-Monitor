namespace EVE_Intel_Monitor
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblReport1 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.tmrTick = new System.Windows.Forms.Timer(this.components);
            this.lblChar = new System.Windows.Forms.Label();
            this.btnFullReset = new System.Windows.Forms.Button();
            this.tbChatMonitor = new System.Windows.Forms.TextBox();
            this.lblReport2 = new System.Windows.Forms.Label();
            this.lblReport3 = new System.Windows.Forms.Label();
            this.lstbSystemList = new System.Windows.Forms.ListBox();
            this.tbSystem = new System.Windows.Forms.TextBox();
            this.AddSystem = new System.Windows.Forms.Button();
            this.btnRemoveAll = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIconMainForm = new System.Windows.Forms.NotifyIcon(this.components);
            this.RightClick = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.clearReportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lblCurrentChat = new System.Windows.Forms.Label();
            this.tmrCloseForm = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.RightClick.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblReport1
            // 
            this.lblReport1.AutoSize = true;
            this.lblReport1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblReport1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblReport1.Location = new System.Drawing.Point(6, 16);
            this.lblReport1.Name = "lblReport1";
            this.lblReport1.Size = new System.Drawing.Size(17, 16);
            this.lblReport1.TabIndex = 2;
            this.lblReport1.Text = "   ";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(6, 95);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(85, 23);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear Reports";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // tmrTick
            // 
            this.tmrTick.Interval = 1000;
            this.tmrTick.Tick += new System.EventHandler(this.tmrTick_Tick);
            // 
            // lblChar
            // 
            this.lblChar.AutoSize = true;
            this.lblChar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChar.Location = new System.Drawing.Point(6, 16);
            this.lblChar.Name = "lblChar";
            this.lblChar.Size = new System.Drawing.Size(29, 20);
            this.lblChar.TabIndex = 5;
            this.lblChar.Text = "     ";
            // 
            // btnFullReset
            // 
            this.btnFullReset.Location = new System.Drawing.Point(90, 18);
            this.btnFullReset.Name = "btnFullReset";
            this.btnFullReset.Size = new System.Drawing.Size(75, 23);
            this.btnFullReset.TabIndex = 6;
            this.btnFullReset.Text = "Refresh";
            this.btnFullReset.UseVisualStyleBackColor = true;
            this.btnFullReset.Click += new System.EventHandler(this.btnFullReset_Click);
            // 
            // tbChatMonitor
            // 
            this.tbChatMonitor.Location = new System.Drawing.Point(6, 19);
            this.tbChatMonitor.Name = "tbChatMonitor";
            this.tbChatMonitor.Size = new System.Drawing.Size(75, 20);
            this.tbChatMonitor.TabIndex = 7;
            // 
            // lblReport2
            // 
            this.lblReport2.AutoSize = true;
            this.lblReport2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblReport2.Location = new System.Drawing.Point(6, 41);
            this.lblReport2.Name = "lblReport2";
            this.lblReport2.Size = new System.Drawing.Size(14, 16);
            this.lblReport2.TabIndex = 2;
            this.lblReport2.Text = "  ";
            // 
            // lblReport3
            // 
            this.lblReport3.AutoSize = true;
            this.lblReport3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblReport3.Location = new System.Drawing.Point(6, 66);
            this.lblReport3.Name = "lblReport3";
            this.lblReport3.Size = new System.Drawing.Size(14, 16);
            this.lblReport3.TabIndex = 2;
            this.lblReport3.Text = "  ";
            // 
            // lstbSystemList
            // 
            this.lstbSystemList.FormattingEnabled = true;
            this.lstbSystemList.Location = new System.Drawing.Point(6, 47);
            this.lstbSystemList.Name = "lstbSystemList";
            this.lstbSystemList.ScrollAlwaysVisible = true;
            this.lstbSystemList.Size = new System.Drawing.Size(72, 82);
            this.lstbSystemList.TabIndex = 9;
            // 
            // tbSystem
            // 
            this.tbSystem.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbSystem.Location = new System.Drawing.Point(6, 19);
            this.tbSystem.Name = "tbSystem";
            this.tbSystem.Size = new System.Drawing.Size(72, 20);
            this.tbSystem.TabIndex = 7;
            this.tbSystem.Tag = "";
            // 
            // AddSystem
            // 
            this.AddSystem.Location = new System.Drawing.Point(91, 19);
            this.AddSystem.Name = "AddSystem";
            this.AddSystem.Size = new System.Drawing.Size(75, 23);
            this.AddSystem.TabIndex = 10;
            this.AddSystem.Text = "Add";
            this.AddSystem.UseVisualStyleBackColor = true;
            this.AddSystem.Click += new System.EventHandler(this.btnAddSystem_Click);
            // 
            // btnRemoveAll
            // 
            this.btnRemoveAll.Location = new System.Drawing.Point(91, 77);
            this.btnRemoveAll.Name = "btnRemoveAll";
            this.btnRemoveAll.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveAll.TabIndex = 11;
            this.btnRemoveAll.Text = "Remove All";
            this.btnRemoveAll.UseVisualStyleBackColor = true;
            this.btnRemoveAll.Click += new System.EventHandler(this.btnRemoveAll_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(91, 48);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 12;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(539, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mFileExit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // mFileExit
            // 
            this.mFileExit.Name = "mFileExit";
            this.mFileExit.Size = new System.Drawing.Size(92, 22);
            this.mFileExit.Text = "Exit";
            this.mFileExit.Click += new System.EventHandler(this.mFileExit_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.aboutToolStripMenuItem.Text = "Help";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // notifyIconMainForm
            // 
            this.notifyIconMainForm.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIconMainForm.BalloonTipText = "Minimized";
            this.notifyIconMainForm.BalloonTipTitle = "EVE Intel Monitor";
            this.notifyIconMainForm.ContextMenuStrip = this.RightClick;
            this.notifyIconMainForm.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIconMainForm.Icon")));
            this.notifyIconMainForm.Text = "EVE Intel";
            this.notifyIconMainForm.Visible = true;
            this.notifyIconMainForm.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIconMainForm_MouseDoubleClick);
            // 
            // RightClick
            // 
            this.RightClick.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearReportsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.RightClick.Name = "contextMenuStrip1";
            this.RightClick.Size = new System.Drawing.Size(145, 48);
            // 
            // clearReportsToolStripMenuItem
            // 
            this.clearReportsToolStripMenuItem.Name = "clearReportsToolStripMenuItem";
            this.clearReportsToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.clearReportsToolStripMenuItem.Text = "Clear Reports";
            this.clearReportsToolStripMenuItem.Click += new System.EventHandler(this.clearReportsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(6, 47);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 14;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(6, 76);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 15;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstbSystemList);
            this.groupBox1.Controls.Add(this.tbSystem);
            this.groupBox1.Controls.Add(this.AddSystem);
            this.groupBox1.Controls.Add(this.btnRemove);
            this.groupBox1.Controls.Add(this.btnRemoveAll);
            this.groupBox1.Location = new System.Drawing.Point(187, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(172, 139);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Systems to monitor";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbChatMonitor);
            this.groupBox2.Controls.Add(this.btnStop);
            this.groupBox2.Controls.Add(this.btnFullReset);
            this.groupBox2.Controls.Add(this.btnStart);
            this.groupBox2.Location = new System.Drawing.Point(9, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(169, 139);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chat to monitor";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblChar);
            this.groupBox3.Location = new System.Drawing.Point(365, 27);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(169, 70);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Your character";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblReport1);
            this.groupBox4.Controls.Add(this.lblReport2);
            this.groupBox4.Controls.Add(this.lblReport3);
            this.groupBox4.Controls.Add(this.btnClear);
            this.groupBox4.Location = new System.Drawing.Point(9, 172);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(525, 127);
            this.groupBox4.TabIndex = 19;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Last reports";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.lblCurrentChat);
            this.groupBox5.Location = new System.Drawing.Point(365, 104);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(169, 62);
            this.groupBox5.TabIndex = 20;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Current chat";
            // 
            // lblCurrentChat
            // 
            this.lblCurrentChat.AutoSize = true;
            this.lblCurrentChat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentChat.Location = new System.Drawing.Point(6, 16);
            this.lblCurrentChat.Name = "lblCurrentChat";
            this.lblCurrentChat.Size = new System.Drawing.Size(29, 20);
            this.lblCurrentChat.TabIndex = 5;
            this.lblCurrentChat.Text = "     ";
            // 
            // tmrCloseForm
            // 
            this.tmrCloseForm.Enabled = true;
            this.tmrCloseForm.Interval = 1000;
            this.tmrCloseForm.Tick += new System.EventHandler(this.tmrCloseForm_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 305);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(555, 344);
            this.MinimumSize = new System.Drawing.Size(555, 344);
            this.Name = "Form1";
            this.Text = "EVE Intel Monitor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.RightClick.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblReport1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblChar;
        private System.Windows.Forms.Button btnFullReset;
        private System.Windows.Forms.TextBox tbChatMonitor;
        private System.Windows.Forms.Label lblReport2;
        private System.Windows.Forms.Label lblReport3;
        private System.Windows.Forms.ListBox lstbSystemList;
        private System.Windows.Forms.TextBox tbSystem;
        private System.Windows.Forms.Button AddSystem;
        private System.Windows.Forms.Button btnRemoveAll;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        public System.Windows.Forms.Timer tmrTick;
        private System.Windows.Forms.NotifyIcon notifyIconMainForm;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mFileExit;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label lblCurrentChat;
        public System.Windows.Forms.Timer tmrCloseForm;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        public System.Windows.Forms.ContextMenuStrip RightClick;
        private System.Windows.Forms.ToolStripMenuItem clearReportsToolStripMenuItem;
    }
}


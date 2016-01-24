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
    public class Model
    {
        public Model()
        {
            SetSettings();

            alarm = new SoundPlayer(Properties.Resources.alarm_beep);
            LastReports = new List<string>();
            for (int i = 0; i < 3; i++)
                LastReports.Add(" ");
        }

        SoundPlayer alarm;
        List<String> systems = new List<string>();
        List<string> lastReports;
        FileStream stream;
        long lastStreamPos = 0;

        string eveChatLogDir = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments).ToString() + "\\EVE\\logs\\Chatlogs";
        string fleetFileName;
        string character;
        string chatName;
        int messageFormX, messageFormY;
        int mainFormX, mainFormY;

        int newReports;
        bool timerEnable;
        bool close;

        public List<string> LastReports
        {
            get
            {
                return lastReports;
            }

            set
            {
                lastReports = value;
            }
        }
        public List<string> Systems
        {
            get
            {
                return systems;
            }

            set
            {
                systems = value;
            }
        }
        public bool TimerEnable
        {
            get
            {
                return timerEnable;
            }

            set
            {
                timerEnable = value;
            }
        }

        public string ChatName
        {
            get
            {
                return chatName;
            }

            set
            {
                chatName = value;
            }
        }
        public string Character
        {
            get
            {
                return character;
            }

            set
            {
                character = value;
            }
        }
        public int MessageFormX
        {
            get
            {
                return messageFormX;
            }

            set
            {
                messageFormX = value;
            }
        }
        public int MessageFormY
        {
            get
            {
                return messageFormY;
            }

            set
            {
                messageFormY = value;
            }
        }
        public int NewReports
        {
            get
            {
                return newReports;
            }

            set
            {
                newReports = value;
            }
        }
        public bool Close
        {
            get
            {
                return close;
            }

            set
            {
                close = value;
            }
        }

        public int MainFormX
        {
            get
            {
                return mainFormX;
            }

            set
            {
                mainFormX = value;
            }
        }

        public int MainFormY
        {
            get
            {
                return mainFormY;
            }

            set
            {
                mainFormY = value;
            }
        }

        private void SetSettings()
        {
            //load settings chat
            if (Properties.Settings.Default.ChatName != null)
                chatName = Properties.Settings.Default.ChatName;
            else
            {
                Properties.Settings.Default.ChatName = "Corp";
                Properties.Settings.Default.Save();
                chatName = Properties.Settings.Default.ChatName;

            }
            //loading system list settings
            if (Properties.Settings.Default.SystemList != null)
                for (int i = 0; i < Properties.Settings.Default.SystemList.Count; i++)
                    Systems.Add(Properties.Settings.Default.SystemList[i]);

            MessageFormX = Properties.Settings.Default.MessageFormX;
            MessageFormY = Properties.Settings.Default.MessageFormY;

            MainFormX = Properties.Settings.Default.MainFormX;
            MainFormY = Properties.Settings.Default.MainFormY;

        }


        public void startGetFileName()
        {

            try
            {
                fleetFileName = getNewestFleetFile();
            }
            catch
            {
                TimerEnable = false;
                MessageBox.Show("Chat '" + ChatName + "' was not found or is too old. \nDefault chat was set as 'Corp'", "Error");
                ChatName = "Corp";
                return;
            }
            if(ChatName!= "" && ChatName!=null && ChatName!= " ")
            TimerEnable = true;

        }
        public void ClrLastReports()
        {
            //writes to the gui so that you ca see the number of things
            LastReports[0] = LastReports[1] = LastReports[2] = "";

            //  lblChar.Text = character;
        }
        public void FullReset()
        {
            //basicly reset all vars then start over
            TimerEnable = false;
            fleetFileName = "";
            lastStreamPos = 0;
            character = "";
            ClrLastReports();
            startGetFileName();
            Run();
        }
        public void Run()
        {
            if (TimerEnable == false)
                return;
            fancy(fleetFileName);
        }
        #region file reads

        ArrayList readFile(string path)
        {
            ArrayList newLines = new ArrayList();
            //opens the file and has some flags so that
            //windows doesn't have a cow that some other
            //process is using it.
            stream = File.Open(path, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);

            //basicly checks if file is null
            if (stream.CanSeek)
            {
                //resumes at the last part that we looked at
                //so this makes it so that we're not re-reading
                //the whole file each time.
                stream.Seek(lastStreamPos, SeekOrigin.Begin);
                StreamReader reader = new StreamReader(stream, Encoding.Unicode, false);
                String line;
                //reading it via lines
                while ((line = reader.ReadLine()) != null)
                {
                    //adding new lines to the array because
                    //we're not really parseing the data
                    //here.
                    if (!newLines.Contains(line))
                    {
                        newLines.Add(line);
                    }
                }
                //setting our last position so that
                //we don't have to re-read the whole
                //file and idealy saving some cpu.
                lastStreamPos = stream.Position;
            }

            return newLines;
        }

        string getNewestFleetFile()
        {
            //this gets an array of full paths to all files
            //in the chatlog directory
            string[] files = Directory.GetFiles(eveChatLogDir);
            ArrayList fleetfiles = new ArrayList();

            //these are for limiting how many files it looks
            //for. It doesn't look at the hours but I subtract
            //2 hours here incase you joined the fleet before
            //downtime this number can be tweeked and probably
            //will be later but this was just a magic number
            //i pulled out of no where.
            string testime = DateTime.UtcNow.ToString("yyyyMMdd");
            string testTime1 = DateTime.UtcNow.AddHours(-2).ToString("yyyyMMdd");

            //loop to look check all files in dir
            foreach (string fileName in files)
            {
                //limit to only files with "chatName" in the name
                if (fileName.Contains(chatName))
                {
                    //checks to limit the number of returned files (cpu time saving only)
                    if (fileName.Contains(testime) || fileName.Contains(testTime1))
                    {
                        if (!fleetfiles.Contains(fileName))
                        {
                            //these are only here for a smaller list so its less time to sort
                            fleetfiles.Add(fileName);
                        }
                    }
                }
            }

            //in practice this isn't actually needed but msdn says to not rely on
            //the returned order so .sort is here to hopfuly sort by name.
            fleetfiles.Sort();

            //returns the very last one in the array so that we get the newest file.
            return fleetfiles[fleetfiles.Count - 1].ToString();
        }

        #endregion

        //this is the magic part where i parse the
        //lines of chat.
        private void fancy(string file)
        {
            //gets the newLines since last read
            ArrayList lines = readFile(file);

            //updating new reports count
            NewReports = 0;

            //checks to see if there are lines in the new lines so that we can not waste cpu time if there are no new lines.
            if (lines.Count > 0)
            {
                //loop for all of the new lines
                foreach (string line in lines)
                {
                    //this is just so that you know which fleet the program is listening too.
                    if (line.Contains("  Listener:        "))
                    {
                        //gets the character name out of the the line
                        character = line.Substring(19, line.Length - 19);
                        //pushes to the gui
                        ClrLastReports();
                    }

                    //this is just a sanity check
                    if (line.Length > 25)
                    {
                        //this is a fancy way that I'm checking to
                        //make sure the line is valid since these
                        //are the brackets on the beging and end of
                        //the timestamp so that we can ignore some
                        //of the other lines that ccp puts at the
                        //begining of the file.
                        if (line[1].Equals('[') && line[23].Equals(']') || line[0].Equals('[') && line[22].Equals(']'))
                        {
                            //this gets the actual chat with out the
                            //username or any of that since we only
                            //care about the x. I did it
                            string chat = line.Substring(line.IndexOf('>') + 1, line.Length - line.IndexOf('>') - 1);

                            MonitorAndDisplay(chat);

                        }
                    }
                }
            }
            PlayAlarm();
        }

        public void MonitorAndDisplay(string chat)
        {
            //so I don't have to check for two different chars
            string chatTemp = chat.ToUpper();
            for (int i = 0; i < Systems.Count; i++)
                if (chatTemp.Contains(Systems[i]))
                {
                    LastReports[2] = LastReports[1];
                    LastReports[1] = LastReports[0];
                    LastReports[0] = chat.ToString();
                    NewReports++;
                }
        }

        public void PlayAlarm()
        {
            if (NewReports > 0)
                alarm.Play();
        }


    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NAudio.Wave;
using NAudio.Wave.SampleProviders;

namespace BeatSaberDiscordLink
{
    public partial class Form1 : Form
    {
        private WaveOutEvent outputDevice;
        private MediaFoundationReader mediaReader;
        dynamic currSong;
        List<dynamic> currSongDiffInfoLookup = new List<dynamic>();
        public string requestFrom { get; set; }


        bool downloadEnabled = false;
        public Form1()
        {
            InitializeComponent();

            if (!(Properties.Settings.Default.token == ""))
            {
                BotTokenIn.Text = Properties.Settings.Default.token;
            }
        }

        // ######################## LOADING SONGS ########################
        private void button1_Click(object sender, EventArgs e)
        {
            if (outputDevice == null)
            {
                outputDevice = new WaveOutEvent();
                outputDevice.PlaybackStopped += OnPlaybackStopped;
            }
            if (mediaReader == null)
            {
                try
                {
                    mediaReader = new MediaFoundationReader((string)currSong.versions[0].previewURL);
                    outputDevice.Init(mediaReader);
                }
                catch
                {
                    mediaReader = new MediaFoundationReader(@"https://na.cdn.beatsaver.com/f6dbd83b699872e2e42c2fc90337ef0ac2ab8f30.mp3");
                    outputDevice.Init(mediaReader);
                }
            }
            outputDevice.Play();
        }
        private void OnPlaybackStopped(object sender, StoppedEventArgs args)
        {
            outputDevice.Dispose();
            outputDevice = null;
            mediaReader.Dispose();
            mediaReader = null;
        }

        private async void LoadSong(String ID)
        {
            currSong = await BSAPI.PullFullMap(ID);

            mediaReader = new MediaFoundationReader((string)currSong.versions[0].previewURL);
            if (outputDevice == null)
            {
                outputDevice = new WaveOutEvent();
                outputDevice.PlaybackStopped += OnPlaybackStopped;
            }
            outputDevice.Init(mediaReader);

            pictureBox2.ImageLocation = currSong.versions[0].coverURL;
            DisplayInformation();
        }

        public int LoadSong(dynamic newSong)
        {
            if (this.InvokeRequired)
            {
                // We're on a thread other than the GUI thread
                this.Invoke(new MethodInvoker(() => LoadSong(newSong)));
                return 0;
            }

            currSong = newSong;

            try
            {
                mediaReader = new MediaFoundationReader((string)currSong.versions[0].previewURL);
                if (outputDevice == null)
                {
                    outputDevice = new WaveOutEvent();
                    outputDevice.PlaybackStopped += OnPlaybackStopped;
                }
                outputDevice.Init(mediaReader);

                pictureBox2.ImageLocation = currSong.versions[0].coverURL;
                //AddToLog(currSong.toString());
                DisplayInformation();

            }
            catch
            {
                return -1;
            }
            if (downloadEnabled)
            {
                string id = currSong.id;
                downloadSong(id);
            }
            return 0;

        }

        private void downloadSong(string id)
        {
            System.Diagnostics.Process.Start("beatsaver://" + id);
        }

        private void DisplayInformation()
        {
            //set title
            TitleLink.Enabled = true;
            IngameTitle.Enabled = true;
            TitleLink.Visible = true;
            IngameTitle.Visible = true;
            TitleLink.Text = currSong.name;
            if (currSong.metadata.songSubName == "")
            {
                IngameTitle.Text = "In-Game: " + currSong.metadata.songName;
            }
            else
            {
                IngameTitle.Text = "In-Game: " + currSong.metadata.songName + "(" + currSong.metadata.songSubName + ")";
            }
            if (HistoryContextMenuStrip.Items.Count > 9)
            {
                HistoryContextMenuStrip.Items.RemoveAt(0);
            }
            string prepText = currSong.id + ": " + currSong.name;
            HistoryContextMenuStrip.Items.Add(prepText);

            label2.Text = "From User: " + requestFrom;

            notifyIcon1.ShowBalloonTip(500, "BeatSaberDiscordLink", "New Download: " + currSong.name, ToolTipIcon.None);
            loadDifficultyDisplay();
        }

        private void loadDifficultyDisplay()
        {
            listBox1.Items.Clear();
            currSongDiffInfoLookup.Clear();
            resetDiffSongInfo();
            listBox1.Visible = true;
            foreach (dynamic currSongDiff in currSong.versions[0].diffs)
            {
                listBox1.Items.Add(currSongDiff.characteristic + " " + currSongDiff.difficulty);
                currSongDiffInfoLookup.Add(currSongDiff);
            }
        }

        private void resetDiffSongInfo()
        {
            listBox1.SelectedIndex = -1;
            SongInfoPanel.Visible = false;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1) { return; }

            if (!SongInfoPanel.Visible)
            {
                SongInfoPanel.Visible = true;
                //CheckboxPanel.Enabled = false;
            }

            dynamic currSongDiff = currSongDiffInfoLookup.ElementAt(listBox1.SelectedIndex);

            CurrSongDetails2.Text =
                // I forgot i need to fix this (working on it) (Int32.Parse(currSong.metadata.duration.toString()) / 60) + ";" + (Int32.Parse(currSong.metadata.duration.toString()) % 60) + "\n" +
                currSongDiff.nps + "\n" +
                currSongDiff.njs + "\n" +
                currSongDiff.offset + "\n" +
                currSongDiff.notes + "\n" +
                currSongDiff.bombs + "\n" +
                currSongDiff.obstacles + "\n" +
                currSongDiff.events;
            CinemaBox.Checked = currSongDiff.cinema;
            CBox.Checked = currSongDiff.chroma;
            NEBox.Checked = currSongDiff.ne;
            MEBox.Checked = currSongDiff.me;

            ParityText1.Visible = !(NEBox.Checked || MEBox.Checked);
            ParityText2.Visible = !(NEBox.Checked || MEBox.Checked);
            ModchartsDontNeedParity.Visible = (NEBox.Checked || MEBox.Checked);
            ParityText2.Text =
               currSongDiff.paritySummary.warns + "\n" +
               currSongDiff.paritySummary.errors + "\n" +
               currSongDiff.paritySummary.resets;
        }


        private void button2_Click(object sender, EventArgs e)
        {
            LoadSong(textBox1.Text);
            requestFrom = "BeatSaberDiscordLink";
        }

        private void CheckBox_EnabledChanged(object sender, EventArgs e)
        {

        }

        // ######################## BOT STUFF ########################
        public void AddToLog(string entry)
        {
            if (this.InvokeRequired)
            {
                // We're on a thread other than the GUI thread
                this.Invoke(new MethodInvoker(() => AddToLog(entry)));
                return;
            }

            botlog.AppendText(entry + System.Environment.NewLine);
            //botlog.Text += entry + System.Environment.NewLine;
        }

        private void BotStartButton_Click(object sender, EventArgs e)
        {
            string t = BotTokenIn.Text;
            string cid = ChannelIDIn.Text;
            Task.Run(() => DiscordAPI.StartBot(t, cid));
            // add in delay or somthing idk
            BotStopButton.Enabled = true;
            ChannelIDIn.Enabled = false;

        }

        private void BotStopButton_Click(object sender, EventArgs e)
        {
            DiscordAPI.Exit();
            BotTokenIn.Enabled = true;
            BotTokenIn.UseSystemPasswordChar = false;
            BotStopButton.Enabled = false;
            Form.ActiveForm.Text = "BSDiscordLink | Not Logged In";
            ChannelIDIn.Enabled = true;
            BotStartButton.Enabled = true;
        }

        public void BotReady(string username, string userPFP)
        {
            if (this.InvokeRequired)
            {
                // We're on a thread other than the GUI thread
                this.Invoke(new MethodInvoker(() => BotReady(username, userPFP)));
                return;
            }
            BotPFPBox.LoadAsync(userPFP);
            Form.ActiveForm.Text = "BSDiscordLink | Logged in as: " + username;
            BotTokenIn.Enabled = false;
            BotStartButton.Enabled = false;
            BotTokenIn.UseSystemPasswordChar = true;
        }

        // Other thigns

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                this.Hide();
                e.Cancel = true;
            }
            else
            {
                Program.ExitApp();
            }
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.ExitApp();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pictureBox2.ImageLocation = @"https://na.cdn.beatsaver.com/f6dbd83b699872e2e42c2fc90337ef0ac2ab8f30.jpg";
        }

        private void TitleLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://beatsaver.com/maps/" + currSong.id);
        }

        private void Form1_TextChanged(object sender, EventArgs e)
        {
            notifyIcon1.Text = Form1.ActiveForm.Text;
        }

        private void ToggleDownloadCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            downloadEnabled = ToggleDownloadCheckbox.Checked;
        }

        private void HistoryContextMenuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            LoadSong(e.ClickedItem.Text.Substring(0, e.ClickedItem.Text.IndexOf(":")));
        }

        private void savetokenStripMenuItem1_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure to store your current token?", "BSDiscordLink | Store Token", MessageBoxButtons.OKCancel);
            if (confirmResult == DialogResult.OK)
            {
                Properties.Settings.Default.token = BotTokenIn.Text;
                Properties.Settings.Default.Save();
            }
            else
            {
                // do nothing
            }
        }

        private void cleartokenStripMenuItem1_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure to delete your current token?", "BSDiscordLink | Delete Token", MessageBoxButtons.OKCancel);
            if (confirmResult == DialogResult.OK)
            {
                Properties.Settings.Default.token = "";
                Properties.Settings.Default.Save();
            }
            else
            {
                // do nothing
            }

        }


        private void notifyIcon1_Click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) {
                this.Show();
                this.BringToFront();
                this.Focus();
            }
            else { 
            // do nothing
            }
        }
    }
}
/* TODO:
 * 
 *  - add options to notify thingy
 *  - and i guess look at more information from the api? DONE
 *  
 */










/*
https://stackoverflow.com/questions/6620165/how-can-i-parse-json-with-c

As was answered here - Deserialize JSON into C# dynamic object?

It's pretty simple using Json.NET:

dynamic stuff = JsonConvert.DeserializeObject("{ 'Name': 'Jon Smith', 'Address': { 'City': 'New York', 'State': 'NY' }, 'Age': 42 }");

string name = stuff.Name;
string address = stuff.Address.City;
Or using Newtonsoft.Json.Linq :

dynamic stuff = JObject.Parse("{ 'Name': 'Jon Smith', 'Address': { 'City': 'New York', 'State': 'NY' }, 'Age': 42 }");

string name = stuff.Name;
string address = stuff.Address.City;
*/

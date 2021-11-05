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
        private AudioFileReader audioFile;
        private MediaFoundationReader mediaReader;
        dynamic currSong;

        bool startstop = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.ExitApp();
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.ExitApp();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pictureBox2.ImageLocation = @"https://na.cdn.beatsaver.com/f6dbd83b699872e2e42c2fc90337ef0ac2ab8f30.jpg";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (outputDevice == null) {
                outputDevice = new WaveOutEvent();
                outputDevice.PlaybackStopped += OnPlaybackStopped;
            }
            if (mediaReader == null) {
                try {
                    mediaReader = new MediaFoundationReader((string)currSong.versions[0].previewURL);
                    outputDevice.Init(mediaReader);
                } catch {
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
            if (outputDevice == null) {
                outputDevice = new WaveOutEvent();
                outputDevice.PlaybackStopped += OnPlaybackStopped;
            }
            outputDevice.Init(mediaReader);

            pictureBox2.ImageLocation = currSong.versions[0].coverURL;

        }

        public void LoadSong(dynamic newSong)
        {
            currSong = newSong;

            mediaReader = new MediaFoundationReader((string)currSong.versions[0].previewURL);
            if (outputDevice == null) {
                outputDevice = new WaveOutEvent();
                outputDevice.PlaybackStopped += OnPlaybackStopped;
            }
            outputDevice.Init(mediaReader);

            pictureBox2.ImageLocation = currSong.versions[0].coverURL;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoadSong(textBox1.Text);
        }

        public void AddToLog(string entry)
        {
            botlog.Text += entry + "\n";
        }

        private void BotStartButton_Click(object sender, EventArgs e)
        {
            string t = BotTokenIn.Text;
            Task.Run(() => DiscordAPI.StartBot(t));
            // add in delay or somthing idk
            BotStopButton.Enabled = true;
            BotTokenIn.Enabled = false;
            BotTokenIn.UseSystemPasswordChar = true;
            BotStopButton.Enabled = true;
        }

        private void BotStopButton_Click(object sender, EventArgs e)
        {
            Task.Run(() => DiscordAPI.Exit());
            BotTokenIn.Enabled = true;
            BotTokenIn.UseSystemPasswordChar = false;
            BotStopButton.Enabled = false;
        }
    }
}

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

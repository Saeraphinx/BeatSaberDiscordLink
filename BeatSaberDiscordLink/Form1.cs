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
                mediaReader = new MediaFoundationReader(@"https://na.cdn.beatsaver.com/f6dbd83b699872e2e42c2fc90337ef0ac2ab8f30.mp3");
                outputDevice.Init(mediaReader);
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
    }
}

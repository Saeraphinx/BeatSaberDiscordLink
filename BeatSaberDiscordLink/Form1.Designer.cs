using System;
using System.Windows.Forms;

namespace BeatSaberDiscordLink
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
            if (disposing && (components != null)) {
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
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.savetokenStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cleartokenStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.HistoryToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.HistoryContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BotPFPBox = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.botlog = new System.Windows.Forms.TextBox();
            this.BotStartButton = new System.Windows.Forms.Button();
            this.BotStopButton = new System.Windows.Forms.Button();
            this.BotTokenIn = new System.Windows.Forms.TextBox();
            this.TitleLink = new System.Windows.Forms.LinkLabel();
            this.IngameTitle = new System.Windows.Forms.Label();
            this.ChannelIDIn = new System.Windows.Forms.TextBox();
            this.ChannelLabel = new System.Windows.Forms.Label();
            this.ToggleDownloadCheckbox = new System.Windows.Forms.CheckBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.NEBox = new System.Windows.Forms.CheckBox();
            this.CBox = new System.Windows.Forms.CheckBox();
            this.CinemaBox = new System.Windows.Forms.CheckBox();
            this.CurrSongDetails1 = new System.Windows.Forms.Label();
            this.SongInfoPanel = new System.Windows.Forms.Panel();
            this.ParityText2 = new System.Windows.Forms.Label();
            this.ParityText1 = new System.Windows.Forms.Label();
            this.CheckboxPanel = new System.Windows.Forms.Panel();
            this.MEBox = new System.Windows.Forms.CheckBox();
            this.CurrSongDetails2 = new System.Windows.Forms.Label();
            this.ModchartsDontNeedParity = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BotPFPBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SongInfoPanel.SuspendLayout();
            this.CheckboxPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "BSDiscordLink | Not Logged In";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.savetokenStripMenuItem1,
            this.cleartokenStripMenuItem1,
            this.toolStripSeparator2,
            this.HistoryToolStripMenuItem1,
            this.toolStripSeparator1,
            this.quitToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.ShowImageMargin = false;
            this.contextMenuStrip1.Size = new System.Drawing.Size(145, 104);
            // 
            // savetokenStripMenuItem1
            // 
            this.savetokenStripMenuItem1.Name = "savetokenStripMenuItem1";
            this.savetokenStripMenuItem1.Size = new System.Drawing.Size(144, 22);
            this.savetokenStripMenuItem1.Text = "Save Token";
            this.savetokenStripMenuItem1.Click += new System.EventHandler(this.savetokenStripMenuItem1_Click);
            // 
            // cleartokenStripMenuItem1
            // 
            this.cleartokenStripMenuItem1.Name = "cleartokenStripMenuItem1";
            this.cleartokenStripMenuItem1.Size = new System.Drawing.Size(144, 22);
            this.cleartokenStripMenuItem1.Text = "Clear Saved Token";
            this.cleartokenStripMenuItem1.Click += new System.EventHandler(this.cleartokenStripMenuItem1_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(141, 6);
            // 
            // HistoryToolStripMenuItem1
            // 
            this.HistoryToolStripMenuItem1.DropDown = this.HistoryContextMenuStrip;
            this.HistoryToolStripMenuItem1.Name = "HistoryToolStripMenuItem1";
            this.HistoryToolStripMenuItem1.Size = new System.Drawing.Size(144, 22);
            this.HistoryToolStripMenuItem1.Text = "History";
            // 
            // HistoryContextMenuStrip
            // 
            this.HistoryContextMenuStrip.Name = "HistoryContextMenuStrip";
            this.HistoryContextMenuStrip.OwnerItem = this.HistoryToolStripMenuItem1;
            this.HistoryContextMenuStrip.ShowImageMargin = false;
            this.HistoryContextMenuStrip.Size = new System.Drawing.Size(36, 4);
            this.HistoryContextMenuStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.HistoryContextMenuStrip_ItemClicked);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(141, 6);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.ToolTipText = "Quits Application";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // BotPFPBox
            // 
            this.BotPFPBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BotPFPBox.Image = global::BeatSaberDiscordLink.Properties.Resources.reallybaglogo;
            this.BotPFPBox.Location = new System.Drawing.Point(516, 12);
            this.BotPFPBox.Name = "BotPFPBox";
            this.BotPFPBox.Size = new System.Drawing.Size(53, 50);
            this.BotPFPBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BotPFPBox.TabIndex = 1;
            this.BotPFPBox.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.ErrorImage = global::BeatSaberDiscordLink.Properties.Resources.error;
            this.pictureBox2.Location = new System.Drawing.Point(376, 80);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(193, 178);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(376, 264);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(27, 24);
            this.button1.TabIndex = 3;
            this.button1.Text = "⏯";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Black;
            this.textBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.MaxLength = 5;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(46, 20);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = "d00c";
            // 
            // button2
            // 
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(64, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 21);
            this.button2.TabIndex = 6;
            this.button2.Text = "Load Key";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // botlog
            // 
            this.botlog.AcceptsReturn = true;
            this.botlog.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.botlog.ForeColor = System.Drawing.Color.White;
            this.botlog.Location = new System.Drawing.Point(12, 220);
            this.botlog.MaxLength = 0;
            this.botlog.Multiline = true;
            this.botlog.Name = "botlog";
            this.botlog.ReadOnly = true;
            this.botlog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.botlog.Size = new System.Drawing.Size(358, 68);
            this.botlog.TabIndex = 7;
            this.botlog.TabStop = false;
            // 
            // BotStartButton
            // 
            this.BotStartButton.ForeColor = System.Drawing.Color.White;
            this.BotStartButton.Location = new System.Drawing.Point(395, 12);
            this.BotStartButton.Name = "BotStartButton";
            this.BotStartButton.Size = new System.Drawing.Size(53, 23);
            this.BotStartButton.TabIndex = 8;
            this.BotStartButton.Text = "botStartButton";
            this.BotStartButton.UseVisualStyleBackColor = false;
            this.BotStartButton.Click += new System.EventHandler(this.BotStartButton_Click);
            // 
            // BotStopButton
            // 
            this.BotStopButton.Enabled = false;
            this.BotStopButton.Location = new System.Drawing.Point(454, 11);
            this.BotStopButton.Name = "BotStopButton";
            this.BotStopButton.Size = new System.Drawing.Size(56, 23);
            this.BotStopButton.TabIndex = 9;
            this.BotStopButton.Text = "botStopButton";
            this.BotStopButton.UseVisualStyleBackColor = false;
            this.BotStopButton.Click += new System.EventHandler(this.BotStopButton_Click);
            // 
            // BotTokenIn
            // 
            this.BotTokenIn.BackColor = System.Drawing.Color.Black;
            this.BotTokenIn.ForeColor = System.Drawing.Color.White;
            this.BotTokenIn.Location = new System.Drawing.Point(395, 42);
            this.BotTokenIn.Name = "BotTokenIn";
            this.BotTokenIn.Size = new System.Drawing.Size(115, 20);
            this.BotTokenIn.TabIndex = 10;
            // 
            // TitleLink
            // 
            this.TitleLink.Enabled = false;
            this.TitleLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLink.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.TitleLink.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.TitleLink.Location = new System.Drawing.Point(12, 65);
            this.TitleLink.Margin = new System.Windows.Forms.Padding(0);
            this.TitleLink.Name = "TitleLink";
            this.TitleLink.Size = new System.Drawing.Size(358, 23);
            this.TitleLink.TabIndex = 11;
            this.TitleLink.TabStop = true;
            this.TitleLink.Text = "linkLabel1";
            this.TitleLink.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TitleLink.Visible = false;
            this.TitleLink.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.TitleLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.TitleLink_LinkClicked);
            // 
            // IngameTitle
            // 
            this.IngameTitle.Enabled = false;
            this.IngameTitle.Location = new System.Drawing.Point(16, 88);
            this.IngameTitle.Name = "IngameTitle";
            this.IngameTitle.Size = new System.Drawing.Size(354, 15);
            this.IngameTitle.TabIndex = 12;
            this.IngameTitle.Text = "label1";
            this.IngameTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.IngameTitle.Visible = false;
            // 
            // ChannelIDIn
            // 
            this.ChannelIDIn.BackColor = System.Drawing.Color.Black;
            this.ChannelIDIn.ForeColor = System.Drawing.Color.White;
            this.ChannelIDIn.Location = new System.Drawing.Point(289, 42);
            this.ChannelIDIn.Name = "ChannelIDIn";
            this.ChannelIDIn.Size = new System.Drawing.Size(100, 20);
            this.ChannelIDIn.TabIndex = 13;
            // 
            // ChannelLabel
            // 
            this.ChannelLabel.AutoSize = true;
            this.ChannelLabel.Location = new System.Drawing.Point(310, 17);
            this.ChannelLabel.Name = "ChannelLabel";
            this.ChannelLabel.Size = new System.Drawing.Size(60, 13);
            this.ChannelLabel.TabIndex = 14;
            this.ChannelLabel.Text = "Channel ID";
            // 
            // ToggleDownloadCheckbox
            // 
            this.ToggleDownloadCheckbox.AutoSize = true;
            this.ToggleDownloadCheckbox.Location = new System.Drawing.Point(145, 14);
            this.ToggleDownloadCheckbox.Name = "ToggleDownloadCheckbox";
            this.ToggleDownloadCheckbox.Size = new System.Drawing.Size(134, 17);
            this.ToggleDownloadCheckbox.TabIndex = 15;
            this.ToggleDownloadCheckbox.Text = "EnableAutoDownloads";
            this.ToggleDownloadCheckbox.UseVisualStyleBackColor = true;
            this.ToggleDownloadCheckbox.CheckedChanged += new System.EventHandler(this.ToggleDownloadCheckbox_CheckedChanged);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.Black;
            this.listBox1.ForeColor = System.Drawing.Color.White;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            ""});
            this.listBox1.Location = new System.Drawing.Point(12, 106);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(123, 108);
            this.listBox1.Sorted = true;
            this.listBox1.TabIndex = 16;
            this.listBox1.Visible = false;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // NEBox
            // 
            this.NEBox.AutoCheck = false;
            this.NEBox.AutoSize = true;
            this.NEBox.BackColor = System.Drawing.Color.Black;
            this.NEBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.NEBox.ForeColor = System.Drawing.Color.White;
            this.NEBox.Location = new System.Drawing.Point(12, 33);
            this.NEBox.Margin = new System.Windows.Forms.Padding(0);
            this.NEBox.Name = "NEBox";
            this.NEBox.Size = new System.Drawing.Size(109, 17);
            this.NEBox.TabIndex = 18;
            this.NEBox.Text = "Noodle Extenions";
            this.NEBox.UseVisualStyleBackColor = false;
            this.NEBox.EnabledChanged += new System.EventHandler(this.CheckBox_EnabledChanged);
            // 
            // CBox
            // 
            this.CBox.AutoCheck = false;
            this.CBox.AutoSize = true;
            this.CBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CBox.Location = new System.Drawing.Point(59, 17);
            this.CBox.Margin = new System.Windows.Forms.Padding(0);
            this.CBox.Name = "CBox";
            this.CBox.Size = new System.Drawing.Size(62, 17);
            this.CBox.TabIndex = 19;
            this.CBox.Text = "Chroma";
            this.CBox.UseVisualStyleBackColor = false;
            this.CBox.EnabledChanged += new System.EventHandler(this.CheckBox_EnabledChanged);
            // 
            // CinemaBox
            // 
            this.CinemaBox.AutoCheck = false;
            this.CinemaBox.AutoSize = true;
            this.CinemaBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CinemaBox.Location = new System.Drawing.Point(60, 0);
            this.CinemaBox.Margin = new System.Windows.Forms.Padding(0);
            this.CinemaBox.Name = "CinemaBox";
            this.CinemaBox.Size = new System.Drawing.Size(61, 17);
            this.CinemaBox.TabIndex = 20;
            this.CinemaBox.Text = "Cinema";
            this.CinemaBox.UseVisualStyleBackColor = false;
            this.CinemaBox.EnabledChanged += new System.EventHandler(this.CheckBox_EnabledChanged);
            // 
            // CurrSongDetails1
            // 
            this.CurrSongDetails1.AutoSize = true;
            this.CurrSongDetails1.Location = new System.Drawing.Point(3, 1);
            this.CurrSongDetails1.Name = "CurrSongDetails1";
            this.CurrSongDetails1.Size = new System.Drawing.Size(50, 104);
            this.CurrSongDetails1.TabIndex = 21;
            this.CurrSongDetails1.Text = "Duration:\r\nNPS:\r\nNJS:\r\nOffset: \r\nNotes:\r\nBombs:\r\nWalls:\r\nEvents:";
            // 
            // SongInfoPanel
            // 
            this.SongInfoPanel.Controls.Add(this.ParityText2);
            this.SongInfoPanel.Controls.Add(this.ParityText1);
            this.SongInfoPanel.Controls.Add(this.CheckboxPanel);
            this.SongInfoPanel.Controls.Add(this.CurrSongDetails2);
            this.SongInfoPanel.Controls.Add(this.CurrSongDetails1);
            this.SongInfoPanel.Controls.Add(this.ModchartsDontNeedParity);
            this.SongInfoPanel.Location = new System.Drawing.Point(138, 106);
            this.SongInfoPanel.Name = "SongInfoPanel";
            this.SongInfoPanel.Size = new System.Drawing.Size(232, 108);
            this.SongInfoPanel.TabIndex = 22;
            this.SongInfoPanel.Visible = false;
            // 
            // ParityText2
            // 
            this.ParityText2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ParityText2.Location = new System.Drawing.Point(193, 65);
            this.ParityText2.Name = "ParityText2";
            this.ParityText2.Size = new System.Drawing.Size(39, 41);
            this.ParityText2.TabIndex = 25;
            this.ParityText2.Text = "8888\r\n8888\r\n8888";
            this.ParityText2.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // ParityText1
            // 
            this.ParityText1.AutoSize = true;
            this.ParityText1.Location = new System.Drawing.Point(108, 67);
            this.ParityText1.Name = "ParityText1";
            this.ParityText1.Size = new System.Drawing.Size(84, 39);
            this.ParityText1.TabIndex = 24;
            this.ParityText1.Text = "Parity Warnings:\r\nParity Errors:\r\nParity Resets:";
            // 
            // CheckboxPanel
            // 
            this.CheckboxPanel.Controls.Add(this.MEBox);
            this.CheckboxPanel.Controls.Add(this.CinemaBox);
            this.CheckboxPanel.Controls.Add(this.CBox);
            this.CheckboxPanel.Controls.Add(this.NEBox);
            this.CheckboxPanel.Location = new System.Drawing.Point(111, 0);
            this.CheckboxPanel.Name = "CheckboxPanel";
            this.CheckboxPanel.Size = new System.Drawing.Size(121, 66);
            this.CheckboxPanel.TabIndex = 22;
            // 
            // MEBox
            // 
            this.MEBox.AutoCheck = false;
            this.MEBox.AutoSize = true;
            this.MEBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.MEBox.Location = new System.Drawing.Point(0, 50);
            this.MEBox.Margin = new System.Windows.Forms.Padding(0);
            this.MEBox.Name = "MEBox";
            this.MEBox.Size = new System.Drawing.Size(121, 17);
            this.MEBox.TabIndex = 21;
            this.MEBox.Text = "Mapping Extensions";
            this.MEBox.UseVisualStyleBackColor = false;
            // 
            // CurrSongDetails2
            // 
            this.CurrSongDetails2.AutoSize = true;
            this.CurrSongDetails2.Location = new System.Drawing.Point(49, 2);
            this.CurrSongDetails2.Name = "CurrSongDetails2";
            this.CurrSongDetails2.Size = new System.Drawing.Size(43, 104);
            this.CurrSongDetails2.TabIndex = 23;
            this.CurrSongDetails2.Text = "00:00\r\nNPS:\r\nNJS:\r\nOffset: \r\nNotes:\r\nBombs:\r\nWalls:\r\nEvents:";
            // 
            // ModchartsDontNeedParity
            // 
            this.ModchartsDontNeedParity.ForeColor = System.Drawing.Color.Red;
            this.ModchartsDontNeedParity.Location = new System.Drawing.Point(120, 67);
            this.ModchartsDontNeedParity.Name = "ModchartsDontNeedParity";
            this.ModchartsDontNeedParity.Size = new System.Drawing.Size(100, 41);
            this.ModchartsDontNeedParity.TabIndex = 26;
            this.ModchartsDontNeedParity.Text = "Parity is a myth";
            this.ModchartsDontNeedParity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ModchartsDontNeedParity.Visible = false;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(409, 264);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 24);
            this.label2.TabIndex = 24;
            this.label2.Text = "From User:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            this.AcceptButton = this.button2;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(581, 297);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.ToggleDownloadCheckbox);
            this.Controls.Add(this.ChannelLabel);
            this.Controls.Add(this.ChannelIDIn);
            this.Controls.Add(this.IngameTitle);
            this.Controls.Add(this.TitleLink);
            this.Controls.Add(this.BotTokenIn);
            this.Controls.Add(this.BotStopButton);
            this.Controls.Add(this.BotStartButton);
            this.Controls.Add(this.botlog);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.BotPFPBox);
            this.Controls.Add(this.SongInfoPanel);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "BSDiscordLink | Not Logged In";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.TextChanged += new System.EventHandler(this.Form1_TextChanged);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BotPFPBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.SongInfoPanel.ResumeLayout(false);
            this.SongInfoPanel.PerformLayout();
            this.CheckboxPanel.ResumeLayout(false);
            this.CheckboxPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private PictureBox pictureBox2;
        private Button button1;
        private TextBox textBox1;
        private Button button2;
        private TextBox botlog;
        private Button BotStartButton;
        private Button BotStopButton;
        private TextBox BotTokenIn;
        private LinkLabel TitleLink;
        public PictureBox BotPFPBox;
        private Label IngameTitle;
        private TextBox ChannelIDIn;
        private Label ChannelLabel;
        private CheckBox ToggleDownloadCheckbox;
        private ToolStripMenuItem HistoryToolStripMenuItem1;
        private ContextMenuStrip HistoryContextMenuStrip;
        private ListBox listBox1;
        private CheckBox NEBox;
        private CheckBox CBox;
        private CheckBox CinemaBox;
        private Label CurrSongDetails1;
        private Panel SongInfoPanel;
        private Panel CheckboxPanel;
        private Label CurrSongDetails2;
        private CheckBox MEBox;
        private Label ParityText1;
        private Label ParityText2;
        private Label ModchartsDontNeedParity;
        private Label label2;
        private ToolStripMenuItem savetokenStripMenuItem1;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem cleartokenStripMenuItem1;
    }
}


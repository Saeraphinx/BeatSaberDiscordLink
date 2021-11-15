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
            this.DiffName = new System.Windows.Forms.Label();
            this.NEBox = new System.Windows.Forms.CheckBox();
            this.CBox = new System.Windows.Forms.CheckBox();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BotPFPBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "BSDiscordLink | Not Logged In";
            this.notifyIcon1.Visible = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HistoryToolStripMenuItem1,
            this.toolStripSeparator1,
            this.quitToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.ShowImageMargin = false;
            this.contextMenuStrip1.Size = new System.Drawing.Size(88, 54);
            // 
            // HistoryToolStripMenuItem1
            // 
            this.HistoryToolStripMenuItem1.DropDown = this.HistoryContextMenuStrip;
            this.HistoryToolStripMenuItem1.Name = "HistoryToolStripMenuItem1";
            this.HistoryToolStripMenuItem1.Size = new System.Drawing.Size(87, 22);
            this.HistoryToolStripMenuItem1.Text = "History";
            // 
            // HistoryContextMenuStrip
            // 
            this.HistoryContextMenuStrip.Name = "HistoryContextMenuStrip";
            this.HistoryContextMenuStrip.OwnerItem = this.HistoryToolStripMenuItem1;
            this.HistoryContextMenuStrip.ShowImageMargin = false;
            this.HistoryContextMenuStrip.Size = new System.Drawing.Size(36, 4);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(84, 6);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(87, 22);
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
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // botlog
            // 
            this.botlog.AcceptsReturn = true;
            this.botlog.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.botlog.ForeColor = System.Drawing.Color.White;
            this.botlog.Location = new System.Drawing.Point(12, 216);
            this.botlog.MaxLength = 0;
            this.botlog.Multiline = true;
            this.botlog.Name = "botlog";
            this.botlog.ReadOnly = true;
            this.botlog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.botlog.Size = new System.Drawing.Size(358, 72);
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
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            ""});
            this.listBox1.Location = new System.Drawing.Point(12, 107);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.listBox1.TabIndex = 16;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // DiffName
            // 
            this.DiffName.Location = new System.Drawing.Point(142, 103);
            this.DiffName.Name = "DiffName";
            this.DiffName.Size = new System.Drawing.Size(228, 17);
            this.DiffName.TabIndex = 17;
            this.DiffName.Text = "DiffName";
            this.DiffName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.DiffName.Visible = false;
            // 
            // NEBox
            // 
            this.NEBox.AutoEllipsis = true;
            this.NEBox.AutoSize = true;
            this.NEBox.Enabled = false;
            this.NEBox.Location = new System.Drawing.Point(138, 185);
            this.NEBox.Margin = new System.Windows.Forms.Padding(0);
            this.NEBox.Name = "NEBox";
            this.NEBox.Size = new System.Drawing.Size(109, 17);
            this.NEBox.TabIndex = 18;
            this.NEBox.Text = "Noodle Extenions";
            this.NEBox.UseVisualStyleBackColor = true;
            // 
            // CBox
            // 
            this.CBox.AutoSize = true;
            this.CBox.Enabled = false;
            this.CBox.Location = new System.Drawing.Point(138, 168);
            this.CBox.Margin = new System.Windows.Forms.Padding(0);
            this.CBox.Name = "CBox";
            this.CBox.Size = new System.Drawing.Size(62, 17);
            this.CBox.TabIndex = 19;
            this.CBox.Text = "Chroma";
            this.CBox.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(581, 297);
            this.Controls.Add(this.CBox);
            this.Controls.Add(this.NEBox);
            this.Controls.Add(this.DiffName);
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
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "BSDiscordLink | Not Logged In";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.TextChanged += new System.EventHandler(this.Form1_TextChanged);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BotPFPBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
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
        private Label DiffName;
        private CheckBox NEBox;
        private CheckBox CBox;
    }
}


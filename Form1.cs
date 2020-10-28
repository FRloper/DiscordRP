using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Desktop_Rich_Presence.DiscordRpcDemo;

namespace Desktop_Rich_Presence
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private DiscordRpc.EventHandlers handlers;
        private DiscordRpc.RichPresence presence;

        private void Form1_Load(object sender, EventArgs e)
        {
            Hide();
            this.handlers = default(DiscordRpc.EventHandlers);
            DiscordRpc.Initialize("770993580746997780", ref this.handlers, true, null);
            presence.state = "Chattin'";
            presence.startTimestamp = 0;
            presence.largeImageKey = "discord";
            presence.largeImageText = "Discord";
            DiscordRpc.UpdatePresence(ref this.presence);
            // dam, a cuttttttt ;))

        }

        private void detailsToolStripMenuItem_TextChanged(object sender, EventArgs e)
        {
            this.handlers = default(DiscordRpc.EventHandlers);
            DiscordRpc.Initialize("770993580746997780", ref this.handlers, true, null);
            presence.details = toolStripTextBox2.Text;
            presence.state = toolStripTextBox1.Text;
            presence.largeImageKey = toolStripComboBox1.Text;
            presence.largeImageText = "Discord";
            DiscordRpc.UpdatePresence(ref this.presence);
        }

        private void toolStripTextBox1_TextChanged(object sender, EventArgs e)
        {
            this.handlers = default(DiscordRpc.EventHandlers);
            DiscordRpc.Initialize("770993580746997780", ref this.handlers, true, null);
            presence.details = toolStripTextBox2.Text;
            presence.state = toolStripTextBox1.Text;
            presence.largeImageKey = toolStripComboBox1.Text;
            presence.largeImageText = "Discord";
            DiscordRpc.UpdatePresence(ref this.presence);
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void notifyIcon1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Made by 𝗢𝗺𝗮𝗿#9666, First you can Right Click on the System Tray Icon.", "Intro");
            MessageBox.Show("Then you will find ComboBox in the first, choose ''discord''.", "Intro");
            MessageBox.Show("Then the other's can be written down (Instant Changability)", "Intro");
        }

        private void toolStripComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.handlers = default(DiscordRpc.EventHandlers);
            DiscordRpc.Initialize("770993580746997780", ref this.handlers, true, null);
            presence.details = toolStripTextBox2.Text;
            presence.state = toolStripTextBox1.Text;
            presence.largeImageKey = toolStripComboBox1.Text;
            presence.largeImageText = "Discord";
            DiscordRpc.UpdatePresence(ref this.presence);
        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }
    }
}

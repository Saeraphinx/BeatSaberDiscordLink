using Discord.WebSocket;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeatSaberDiscordLink
{
    static class Program
    {
        public static Form1 form1;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(form1 = new Form1());
        }

        public static void ExitApp()
        {
            DiscordAPI.Exit();
            Application.Exit();
        }
    }
}

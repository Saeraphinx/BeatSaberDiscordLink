using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Discord;
using Discord.Net;
using Discord.WebSocket;

namespace BeatSaberDiscordLink
{
    class DiscordAPI
    {
        private readonly DiscordSocketClient _client;

        public int CurrServerId { get; set; }
        public int CurrChannelId { get; set; }
        private IReadOnlyCollection<SocketGuildChannel> Channels { get; }

        static void StartBot()
        {
            new DiscordAPI().MainAsync().GetAwaiter().GetResult();
        }

        public DiscordAPI()
        {
            // It is recommended to Dispose of a client when you are finished
            // using it, at the end of your app's lifetime.
            _client = new DiscordSocketClient();

            _client.Log += LogAsync;
            _client.Ready += ReadyAsync;
            _client.MessageReceived += MessageReceivedAsync;
        }

        public async Task MainAsync()
        {
            // Tokens should be considered secret data, and never hard-coded.
            await _client.LoginAsync(TokenType.Bot, Environment.GetEnvironmentVariable("token"));
            await _client.StartAsync();

            // Block the program until it is closed.
            await Task.Delay(Timeout.Infinite);
        }

        private Task LogAsync(LogMessage log)
        {
            Program.form1.AddToLog(log.ToString());
            return Task.CompletedTask;
        }

        private Task ReadyAsync()
        {
            Program.form1.AddToLog($"{ _client.CurrentUser} is connected!");

            return Task.CompletedTask;
        }

        private async Task MessageReceivedAsync(SocketMessage message)
        {
            // The bot should never respond to itself.
            if (message.Author.Id == _client.CurrentUser.Id)
                return;

            if (message.Content.Contains("!bsr"))
                await readySong(message);
        }

        private async Task readySong(SocketMessage message)
        {
            dynamic temp = await BSAPI.PullFullMap(message.Content.Trim("!bsr".ToCharArray()));
            try {
                _ = temp.error; // will not catch error if things are broken. i inverted the statement
                await message.Channel.SendMessageAsync("Invalid ID. Please use a key. (`!bsr d00c`)");
            } catch {
                Program.form1.LoadSong(temp);
            }
        }

        public void Exit()
        {
            _client.StopAsync();
            _client.Dispose();
        }
    }
}

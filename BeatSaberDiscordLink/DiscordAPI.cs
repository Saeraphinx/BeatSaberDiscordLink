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
        // oh this thing isn't secure at all lmao
        // i have no idea how to get this working otherwise though.
        private static DiscordSocketClient _client;
        public int CurrServerId { get; set; }
        public int CurrChannelId { get; set; }
//        private IReadOnlyCollection<SocketGuildChannel> Channels { get; }

        public static void StartBot(String Token)
        {
            new DiscordAPI().MainAsync(Token).GetAwaiter().GetResult();
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

        public async Task MainAsync(String Token)
        {
            // Tokens should be considered secret data, and never hard-coded.
            await _client.LoginAsync(TokenType.Bot, Token, true);
            await _client.StartAsync();

            // Block the program until it is closed.
            await Task.Delay(Timeout.Infinite);
        }

        private Task LogAsync(LogMessage log)
        {
            //Program.form1.AddToLog(log.ToString());
            return Task.CompletedTask;
        }

        private Task ReadyAsync()
        {
            //Program.form1.AddToLog($"{ _client.CurrentUser} is connected!");
            string _username = _client.CurrentUser.Username;
            string _userPFP = _client.CurrentUser.GetAvatarUrl();
            if (_userPFP == null) {
                _userPFP = _client.CurrentUser.GetDefaultAvatarUrl();
            }

            //Program.form1.BotReady(_username, _userPFP);
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
            dynamic temp = await BSAPI.PullFullMap(message.Content.Trim("!bsr ".ToCharArray()));
            try { //NOTE: apperently this throws errors everytime. IDK why but it feels like everthings working but not the rest of it lmao
                if (temp.error == "Not found") {
                    await message.Channel.SendMessageAsync("Invalid ID. Please use a key. (`!bsr d00c`)");
                } else {
                    Program.form1.LoadSong(temp);
                    await message.Channel.SendMessageAsync("Loaded **" + temp.id + "**: " + temp.name);
                }
            } catch(Exception e) {
                await message.Channel.SendMessageAsync("Error: ```" + e + "```");
            }
        }

        public static void Exit()
        {
            _client.StopAsync();
            _client.Dispose();
        }
    }
}

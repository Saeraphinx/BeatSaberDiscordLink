using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Discord;
using Discord.Net;
using Discord.WebSocket;
using Newtonsoft.Json;


namespace BeatSaberDiscordLink
{
    class DiscordAPI
    {
        // oh this thing isn't secure at all lmao
        // i have no idea how to get this working otherwise though.
        private static DiscordSocketClient _client;
        private static bool BotEnabled = false;
        public ulong CurrServerId { get; set; }
        public ulong CurrChannelId { get; set; }


        //        private IReadOnlyCollection<SocketGuildChannel> Channels { get; }

        public static void StartBot(String Token)
        {
            new DiscordAPI().MainAsync(Token).GetAwaiter().GetResult();
        }

        public static void StartBot(String Token, string CID)
        {
            try {
                new DiscordAPI().MainAsync(Token, CID).GetAwaiter().GetResult();
            } catch {
                // do something
            }
        }

        public DiscordAPI()
        {
            BotEnabled = true;
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

        public async Task MainAsync(String Token, String CID)
        {
            try { CurrChannelId = ulong.Parse(CID); } catch { CurrChannelId = 0; }
            // Tokens should be considered secret data, and never hard-coded.
            await _client.LoginAsync(TokenType.Bot, Token, true);
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
            string _username = _client.CurrentUser.Username;
            string _userPFP = _client.CurrentUser.GetAvatarUrl();
            if (_userPFP == null) {
                _userPFP = _client.CurrentUser.GetDefaultAvatarUrl();
            }

            Program.form1.BotReady(_username, _userPFP);
            return Task.CompletedTask;
        }

        private async Task MessageReceivedAsync(SocketMessage message)
        {
            // The bot should never respond to itself.
            if (message.Author.Id == _client.CurrentUser.Id)
                return;
            if (CurrChannelId == 0) {
                if (message.Content.Contains("!echo")) {
                    await message.Channel.SendMessageAsync(message.Content.Trim("!echo ".ToCharArray()));
                    Program.form1.AddToLog(message.Content);
                }
            } else {
                if (CurrChannelId != message.Channel.Id) {
                    if (message.Content.Contains("!echo")) {
                        await message.Channel.SendMessageAsync(message.Content.Trim("!echo ".ToCharArray()));
                        Program.form1.AddToLog(message.Content);
                    } else {
                        return;
                    }
                }
            }

            if (message.Content.Contains("!bsr"))
                await readySong(message);
        }

        private async Task readySong(SocketMessage message)
        {
            dynamic temp = await BSAPI.PullFullMap(message.Content.Trim("!bsr ".ToCharArray()));
            try { //NOTE: apperently this throws errors everytime. IDK why but it feels like everthings working but not the rest of it lmao
                if (temp.error == "Not Found") {
                    var embed3 = new EmbedBuilder();
                    embed3
                        .WithAuthor(_client.CurrentUser)
                        .WithColor(Color.Orange)
                        .WithTitle("Invalid Key")
                        .WithDescription("Please use a key. (`!bsr d00c`)")
                        //.WithUrl("https://www.beatsaver.com/maps/" + message.Content.Trim("!bsr ".ToCharArray()))
                        .WithCurrentTimestamp();

                    //Your embed needs to be built before it is able to be sent
                    await message.Channel.SendMessageAsync(embed: embed3.Build());
                    //await message.Channel.SendMessageAsync("Invalid ID. Please use a key. (`!bsr d00c`)");
                    return;
                } else {
                    // haha brain go brrr
                    //Program.form1.LoadSong(temp);
                    Program.form1.requestFrom = message.Author.ToString();
                    if (Program.form1.LoadSong(temp) == -1) {
                        throw new Exception("Invalid Song");
                    }
                    String ID = temp.id;
                    String name = temp.name;
                    String cover = temp.versions[0].coverURL;
                    var embed = new EmbedBuilder();
                    embed
                        .WithAuthor(_client.CurrentUser)
                        .WithColor(Color.Green)
                        .WithTitle("Request Received (Link)")
                        .WithDescription("Loaded " + name + " successfully")
                        .WithUrl("https://www.beatsaver.com/maps/" + ID)
                        .WithCurrentTimestamp()
                        .WithThumbnailUrl(cover);

                    await message.Channel.SendMessageAsync(embed: embed.Build());
                    Program.form1.requestFrom = message.Author.ToString();
                    return;
                }
            } catch (Exception e) {
                var embed2 = new EmbedBuilder();
                embed2
                    .WithAuthor(_client.CurrentUser)
                    .WithColor(Color.LightOrange)
                    .WithTitle("Request Received (Link)")
                    .WithDescription("Somthing went wrong. Unable to load " + message.Content.Trim("!bsr ".ToCharArray()) + " successfully.")
                    .WithUrl("https://www.beatsaver.com/maps/" + message.Content.Trim("!bsr ".ToCharArray()))
                    .WithCurrentTimestamp();

                await message.Channel.SendMessageAsync(embed: embed2.Build());
                //await message.Channel.SendMessageAsync("Attempted to Loaded **" + message.Content.Trim("!bsr ".ToCharArray()) + "** with errors. ```" + e + "```");
                return;
            }
        }

        public static void Exit()
        {
            if (!BotEnabled) { return; }
            try {
                _client.StopAsync();
                _client.Dispose();
            } catch { }
            BotEnabled = false;
        }
    }
}

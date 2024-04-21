using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Polling;
using Telegram.Bot.Types;
using Telegram.Bot.Exceptions;
using Newtonsoft.Json;
using System.Drawing;
using Telegram.Bot.Types.Enums;
using SixLabors.ImageSharp.Processing;
using ImageMagick;
using Telegram.Bot.Types.ReplyMarkups;

namespace Telega
{

    internal class Program
    {
        static ITelegramBotClient bot = new TelegramBotClient("7133125353:AAE3r-hTgLoIwH2lyhL-WVn8n3Gozf3vp38");
        public static async Task HandleUpdateAsync(ITelegramBotClient botClient, Update update, CancellationToken cancellationToken)
        {
            Console.WriteLine(JsonConvert.SerializeObject(update));
            if (update.Type == Telegram.Bot.Types.Enums.UpdateType.Message)
            {
                var message = update.Message;
                if (message?.Text?.ToLower() == "/start") { 
                    await botClient.SendTextMessageAsync(message.Chat, "Hello!");
                    return;
                }

                if (message?.Text?.ToLower().StartsWith("/calculate") == true) {
                    string command = message.Text.ToLower().Replace("/calculate", "").Trim();

                    string[] parts = command.Split(new[] { '+', '-', '*', '/' }, StringSplitOptions.RemoveEmptyEntries);
                    char[] operators = command.Where(c => c == '+' || c == '-' || c == '*' || c == '/').ToArray();

                    if (parts.Length > 1 && parts.Length == operators.Length + 1)
                    {
                        double result = 0;
                        if (double.TryParse(parts[0], out result))
                        {
                            for (int i = 1; i < parts.Length; i++)  {
                                double number;
                                if (double.TryParse(parts[i], out number))
                                {
                                    if (operators[i - 1] == '+')
                                    {
                                        result += number;
                                    }
                                    else if (operators[i - 1] == '-')
                                    {
                                        result -= number;
                                    }
                                    else if (operators[i - 1] == '*')
                                    {
                                        result *= number;
                                    }
                                    else if (operators[i - 1] == '/')
                                    {
                                        if (number != 0)
                                        {
                                            result /= number;
                                        }
                                        else
                                        {
                                            await botClient.SendTextMessageAsync(message.Chat, "Division by zero is not allowed!");
                                            return;
                                        }
                                    }
                                }
                                else
                                {
                                    await botClient.SendTextMessageAsync(message.Chat, $"Invalid number: {parts[i]}");
                                    return;
                                }
                            }

                            await botClient.SendTextMessageAsync(message.Chat, $"Result: {result}");
                            return;
                        }
                    }

                    await botClient.SendTextMessageAsync(message.Chat, "Invalid command format!");
                    return;
                }



                if (update.Type == Telegram.Bot.Types.Enums.UpdateType.Message)
                {
                    if (message?.Type == MessageType.Photo)
                    {
                        var photo = message.Photo.LastOrDefault();
                        if (photo != null)
                        {
                            var file = await botClient.GetFileAsync(photo.FileId);
                            using (var stream = new MemoryStream())
                            {
                                await botClient.DownloadFileAsync(file.FilePath, stream);
                                stream.Position = 0;

                                // Переворачиваем изображение на 180 градусов
                                using (var image = new MagickImage(stream))
                                {
                                    image.Rotate(180);
                                    stream.SetLength(0);
                                    image.Write(stream);
                                    stream.Position = 0;
                                }

                                await botClient.SendPhotoAsync(message.Chat.Id, new InputOnlineFile(stream));
                            }
                        }
                    }

                    // ...
                }




                if (message?.Text?.ToLower() == "/picture")
                {
                    using (var stream = System.IO.File.Open(GetRandomPicture(), FileMode.Open))
                    {
                        await botClient.SendPhotoAsync(message.Chat, InputFile.FromStream(stream));
                        return;
                    }
                }


                await botClient.SendTextMessageAsync(message.Chat, "IDK bro!");

            }
        }

        public static async Task HandleErrorAsync(ITelegramBotClient botcClient,
            Exception exception,
            CancellationToken cancellationToken)
        {
            Console.WriteLine(JsonConvert.SerializeObject(exception));
        }

        static string GetRandomPicture()
        {
            string path = @"X:/Pictures";
            var picture = Directory.GetFiles(path);

            Random random = new Random();
            int index = random.Next(picture.Length);

            return picture[index];
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Started bot" + bot.GetMeAsync().Result.FirstName);

            var cts = new CancellationTokenSource();
            var cancellationToken = cts.Token;
            var receiverOptions = new ReceiverOptions
            {
                AllowedUpdates = { },
            };

            bot.StartReceiving(HandleUpdateAsync, HandleErrorAsync, receiverOptions, cancellationToken);

            Console.ReadLine();
        }
    }
}

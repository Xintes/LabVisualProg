using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Polling;
using Telegram.Bot.Types;
using Telegram.Bot.Exceptions;
using Newtonsoft.Json;
using Telegram.Bot.Types.Enums;
using Telegram.Bot.Requests;
using static System.Net.WebRequestMethods;

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



                if (message?.Type == MessageType.Photo)
                {
                    var file = await botClient.GetFileAsync(message.Photo.Last().FileId);

                    string imagePath = @".\photoToRotate.jpg";

                    using (var fileStream = new FileStream(imagePath, FileMode.Create))
                        await botClient.DownloadFileAsync(file.FilePath, fileStream);

                    var imageRotated = System.Drawing.Image.FromFile(imagePath);
                    imageRotated.RotateFlip(System.Drawing.RotateFlipType.Rotate180FlipNone);
                    imageRotated.Save(imagePath);

                    using (var fileStream = new FileStream(imagePath, FileMode.Open))
                        await botClient.SendPhotoAsync(message.Chat, InputFile.FromStream(fileStream));

                    System.IO.File.Delete(imagePath);

                    return;
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

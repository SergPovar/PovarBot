// See https://aka.ms/new-console-template for more information

using Telegram.Bot;

internal class Program
{
    public static void Main(string[] args)
    {
        var bot = new Bot("6252763648:AAHXNZhf1KqAFfwYFQ_P_iFOGzB2cnfcRx0");
        bot.CreateCommands();
        bot.StartReceiving();
        Console.ReadLine();
    }
}
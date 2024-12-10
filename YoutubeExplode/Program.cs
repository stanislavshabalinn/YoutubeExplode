using System;

namespace YoutubeExplode
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите адрес ссылки(URL)");
            string url = Console.ReadLine();

            Console.WriteLine("Куда сохранить файл?");
            string pathdownload = Console.ReadLine();

            Sender sender = new Sender();
            Receiver receiver = new Receiver(url, pathdownload);
            sender.SetCommand(new CommandDownload(receiver));
            sender.GetInfo();
            sender.Download();

            Console.ReadKey();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Text;

namespace YoutubeExplode
{
    class CommandDownload : Command
    {
        protected Receiver receiver;
        public CommandDownload(Receiver receiver)
        {
            if (receiver != null)
                this.receiver = receiver;
        }

        // Выполнить
        public override void Run()
        {
            var video = receiver.GetInfo();
            Console.WriteLine("Команда отправлена.");
            Console.WriteLine(video.Result.Title);
            Console.WriteLine(video.Result.Description);
        }

        public override void Cancel()
        {
            receiver.Download();
            Console.WriteLine("Загрузка видео.");
        }
    }
}
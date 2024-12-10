using System;
using System.Collections.Generic;
using System.Text;
using YoutubeExplode;
using YoutubeExplode.Converter;
using YoutubeExplode.Videos;
using System.Threading.Tasks;


namespace YoutubeExplode
{
    class Receiver
    {
        public YoutubeClient client;
        public string url;
        public string outputFilePath;

        public Receiver(string url, string outputFilePath)
        {
            client = new YoutubeClient();
            this.url = url;
            this.outputFilePath = outputFilePath;
        }

        public async Task<Video> GetInfo()
        {
            var video = await client.Videos.GetAsync(url);
            return video;
        }

        public async void Download()
        {
            await client.Videos.DownloadAsync(url, outputFilePath);
        }

    }
}
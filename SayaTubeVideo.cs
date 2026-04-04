using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace modul6_103082400005
{
    internal class SayaTubeVideo
    {
        private int id;
        private string title;
        private int playCount;

        Random random = new();

        public SayaTubeVideo(string newTitle)
        {
            this.title = newTitle;
            this.id = random.Next(10000, 99999);
            playCount = 0;
        }

        //Getter helper untuk dipanggil di SayaTubeUser
        public int GetPlayCount() { return playCount; }
        public string GetTitle() {  return title; }


        public void IncreasePlayCount(int increaseCount)
        {
            playCount += increaseCount;
        }

        public void PrintVideoDetails()
        {
            Console.WriteLine("My Video Details" +
                $"\nid: {id}" +
                $"\ntitle: {title}" +
                $"\nplay count: {playCount}");
        }
    }
}

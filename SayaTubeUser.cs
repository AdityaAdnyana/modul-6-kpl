using System;
using System.Collections.Generic;
using System.Text;

namespace modul6_103082400005
{
    internal class SayaTubeUser
    {
        private int id;
        private List<SayaTubeVideo> uplodedVideos;
        public string username;

        Random rand = new();

        public SayaTubeUser(string username)
        {


            this.username = username;
            this.id = rand.Next(10000, 99999);
            uplodedVideos = new();

        }

        public int GetTotalVideoPlayCount()
        {
            int totalVideoPlayCount = 0;
            foreach (var video in uplodedVideos)
            {
                totalVideoPlayCount += video.GetPlayCount();
            }

            return totalVideoPlayCount;
        }

        public void AddVideo(SayaTubeVideo newVideo)
        {
            uplodedVideos.Add(newVideo);
        }

        public void PrintAllVideoPlaycount()
        {
            Console.WriteLine($"\nUser: {username}");

            for (int i = 0; i < uplodedVideos.Count; i++)
            {
                Console.WriteLine($"Video {i+1} judul: {uplodedVideos[i].GetTitle()}");
            }

        }
    }
}

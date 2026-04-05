using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace modul6_103082400005
{
    internal class SayaTubeUser
    {
        private int id;
        private List<SayaTubeVideo> uploadedVideos;
        public string username;

        Random rand = new();

        public SayaTubeUser(string username)
        {
            Debug.Assert(username != null, "Username tidak boleh null");
            Debug.Assert(username.Length <= 100, "Panjang username maksimal 100 karakter");

            this.username = username;
            this.id = rand.Next(10000, 99999);
            uploadedVideos = new();

        }

        public int GetTotalVideoPlayCount()
        {
            int totalVideoPlayCount = 0;
            foreach (var video in uploadedVideos)
            {
                totalVideoPlayCount += video.GetPlayCount();
            }

            return totalVideoPlayCount;
        }

        public void AddVideo(SayaTubeVideo newVideo)
        {
            Debug.Assert(newVideo != null, "Video tidak boleh null");
            Debug.Assert(newVideo.GetPlayCount() < int.MaxValue);
            uploadedVideos.Add(newVideo);
        }

        public void PrintAllVideoPlaycount()
        {
            Console.WriteLine($"\nUser: {username}");

            int batasPrint = Math.Min(uploadedVideos.Count, 8);

            for (int i = 0; i < batasPrint; i++)
            {
                
                Console.WriteLine($"Video {i+1} judul: {uploadedVideos[i].GetTitle()}");
            }

            Debug.Assert(batasPrint <= 8, "Jumlah video maksimal yang di-print adalah 8");
        }
    }
}

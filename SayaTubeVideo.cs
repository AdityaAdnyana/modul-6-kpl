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
            Debug.Assert(newTitle != null, "Judul tidak boleh null");
            Debug.Assert(newTitle.Length <= 200, "Panjang karakter tidak boleh lebih dari 200");
            this.title = newTitle;
            this.id = random.Next(10000, 99999);
            playCount = 0;
        }

        //Getter helper untuk dipanggil di SayaTubeUser
        public int GetPlayCount() { return playCount; }
        public string GetTitle() {  return title; }


        public void IncreasePlayCount(int increaseCount)
        {

            Debug.Assert(increaseCount <= 25000000, "Input increase count maksimal 25.000.000 per panggilan");
            Debug.Assert(increaseCount >= 0, "input increase count tidak boleh negatif");

            try
            {
                checked
                {
                    playCount += increaseCount;
                }
            }
            catch (OverflowException ex)
            {
                Console.WriteLine(ex.Message);
            }
                
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

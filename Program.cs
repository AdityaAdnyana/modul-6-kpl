using modul6_103082400005;

class Program
{
    public static void Main()
    {
        SayaTubeUser user = new("Aditya");

        SayaTubeVideo video1 = new("Review Film Mitty oleh I Putu Gde Aditya Stiti Adnyana");
        video1.IncreasePlayCount(12000);
        video1.PrintVideoDetails();

        SayaTubeVideo video2 = new("Review Film Hacker oleh I Putu Gde Aditya Stiti Adnyana");
        video2.IncreasePlayCount(13000);
        video2.PrintVideoDetails();

        SayaTubeVideo video3 = new("Review Film Songebob oleh I Putu Gde Aditya Stiti Adnyana");
        video3.IncreasePlayCount(11000);
        video3.PrintVideoDetails();

        SayaTubeVideo video4 = new("Review Film MyAdventure oleh I Putu Gde Aditya Stiti Adnyana");
        video4.IncreasePlayCount(14000);
        video4.PrintVideoDetails();

        SayaTubeVideo video5 = new("Review Film Adventure Time oleh I Putu Gde Aditya Stiti Adnyana");
        video5.IncreasePlayCount(17000);
        video5.PrintVideoDetails();

        SayaTubeVideo video6 = new("Review Film My Neighboor Totoro oleh I Putu Gde Aditya Stiti Adnyana");
        video6.IncreasePlayCount(14500);
        video6.PrintVideoDetails();

        SayaTubeVideo video7 = new("Review Film Arriety oleh I Putu Gde Aditya Stiti Adnyana");
        video7.IncreasePlayCount(14700);
        video7.PrintVideoDetails();

        SayaTubeVideo video8 = new("Review Film Kiki Delivery Service oleh I Putu Gde Aditya Stiti Adnyana");
        video8.IncreasePlayCount(18000);
        video8.PrintVideoDetails();

        SayaTubeVideo video9 = new("Review Film Porcoroso oleh I Putu Gde Aditya Stiti Adnyana");
        video4.IncreasePlayCount(19000);
        video4.PrintVideoDetails();

        SayaTubeVideo video10 = new("Review Film Sword Art Online oleh I Putu Gde Aditya Stiti Adnyana");
        video4.IncreasePlayCount(14000);
        video4.PrintVideoDetails();

        user.AddVideo(video1);
        user.AddVideo(video2);
        user.AddVideo(video3);
        user.AddVideo(video4);
        user.AddVideo(video5);
        user.AddVideo(video6);
        user.AddVideo(video7);
        user.AddVideo(video8);
        user.AddVideo(video9);
        user.AddVideo(video10);

        user.GetTotalVideoPlayCount();
        user.PrintAllVideoPlaycount();

    }
}
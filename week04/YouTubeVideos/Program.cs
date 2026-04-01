using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> _videos = new List<Video>();
        
        Video v1 = new Video("C# Classes", "BroCode", 180);
        v1.AddComment(new Comment("AI","I knew this"));
        v1.AddComment(new Comment("ShroudingersCar", "Vrooom beep beep"));
        v1.AddComment(new Comment("Socrates","I am."));
        v1.AddComment(new Comment("JuniorDevCosplayer", "I'm a junior Dev and I didn't know this"));
        _videos.Add(v1);

        Video v2 = new Video("It's nice outside", "OutdoorGuy", 120);
        v2.AddComment(new Comment("PapaBear", "ROAAR"));
        v2.AddComment(new Comment("Biggie","Big guy right here"));
        v2.AddComment(new Comment("ItsOv3r", "I knew it"));
        _videos.Add(v2);

        Video v3 = new Video("I planted a tree", "GoGreen", 800);
        v3.AddComment(new Comment("Iceicebaby","This is so cool brrr!"));
        v3.AddComment(new Comment("PapaBear", "ROAAR"));
        v3.AddComment(new Comment("BigNews","Ths is big news"));
        v3.AddComment(new Comment("SmallNews", "This is MASSIVE News"));
        _videos.Add(v3);


        Console.WriteLine();
        foreach (Video video in _videos)
        {
            Console.WriteLine(video.GetDisplayText());
            Console.WriteLine("---------------------");
        }
    }
}
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        List<Video> _listOfVideos = new List<Video>();

        Video video1 = new Video("Strongest people in the world", "Saint_John", 80);
        Comment v1commment1 = new Comment("Mariano", "That's Awesome!");
        video1.AddCommentToVideo(v1commment1);
        Comment v1commment2 = new Comment("Angelica", "I wish I was like that");
        video1.AddCommentToVideo(v1commment2);
        Comment v1commment3 = new Comment("Peter", "I can't believe that's actually a thing!");
        video1.AddCommentToVideo(v1commment3);
        _listOfVideos.Add(video1);

        Video video2 = new Video("How to make pancakes", "Master_Chef99", 190);
        Comment v2commment1 = new Comment("Maria", "They look delicious!");
        video2.AddCommentToVideo(v2commment1);
        Comment v2commment2 = new Comment("Robert", "Thanks for sharing this!!!");
        video2.AddCommentToVideo(v2commment2);
        Comment v2commment3 = new Comment("Nataly", "My pancakes look better than those");
        video2.AddCommentToVideo(v2commment3);
        _listOfVideos.Add(video2);

        Video video3 = new Video("How to make a simple program with C#", "Code_Now_Totorials", 150);
        Comment v3commment1 = new Comment("Kurt", "Well, doesnt seems that bad");
        video3.AddCommentToVideo(v3commment1);
        Comment v3commment2 = new Comment("Matias", "I will try this way, thanks for sharing");
        video3.AddCommentToVideo(v3commment2);
        Comment v3commment3 = new Comment("Dana", "You forgot about the abstraction principle! Visit my channel to check it out...");
        video3.AddCommentToVideo(v3commment3);
        Comment v3commment4 = new Comment("Calvin", "Dana, this is just for beginners, abstraction principle is on the next video!");
        video3.AddCommentToVideo(v3commment4);
        _listOfVideos.Add(video3);

        foreach (Video video in _listOfVideos)
        {
            video.Display();
        }
    }
}
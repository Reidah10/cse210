using System;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("My First Video", "Reid", 300);
        video1.Comments.Add(new Comment("John", "Nice job!"));
        video1.Comments.Add(new Comment("Jared", "Exactly what I needed!"));
        video1.Comments.Add(new Comment("Mia", "Best video I've seen all day!"));

        Video video2 = new Video("A Day in the Life", "Sarah", 360);
        video2.Comments.Add(new Comment("Asa", "Very cool!"));
        video2.Comments.Add(new Comment("Bob", "I'm so jealous."));
        video2.Comments.Add(new Comment("Ben", "Doesn't get better than that!"));

        Video video3 = new Video("New Product!", "Jordan", 278);
        video3.Comments.Add(new Comment("Rex", "That looks awesome!"));
        video3.Comments.Add(new Comment("David", "When can I get some?"));
        video3.Comments.Add(new Comment("Britta", "That looks ... interesting."));

        List<Video> videos = new List<Video>();
        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        foreach (Video video in videos)
        {
            Console.WriteLine($"Video Title: {video.Title}");
            Console.WriteLine($"Creator: {video.Author}");
            Console.WriteLine($"Length: {video.Length}");
            Console.WriteLine($"Comments: {video.Comments.Count}");
            foreach (Comment comment in video.Comments)
            {
                Console.WriteLine($"{comment.Name} says: {comment.Text}");
            }
        }
    }
}

using System;
using System.Collections.Generic;

class Video
{
    public string title;
    public string author;
    public int length; // in seconds
    public List<Comment> comments = new List<Comment>();

    public int GetCommentCount()
    {
        return comments.Count;
    }

    public void DisplayVideoInfo()
    {
        Console.WriteLine($"Title: {title}");
        Console.WriteLine($"Author: {author}");
        Console.WriteLine($"Length: {length} seconds");
        Console.WriteLine($"Number of Comments: {GetCommentCount()}");
        Console.WriteLine("Comments:");
        foreach (Comment comment in comments)
        {
            comment.DisplayComment();
        }
        Console.WriteLine();
    }
}

class Comment
{
    public string commenterName;
    public string commentText;

    public void DisplayComment()
    {
        Console.WriteLine($"- {commenterName}: {commentText}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create videos
        Video video1 = new Video();
        video1.title = "Why Pineapple Belongs on Pizza";
        video1.author = "FoodKing";
        video1.length = 240;
        video1.comments.Add(new Comment { commenterName = "Alex", commentText = "I disagree, but nice points!" });
        video1.comments.Add(new Comment { commenterName = "Jamie", commentText = "Finally, someone said it." });
        video1.comments.Add(new Comment { commenterName = "Casey", commentText = "Never eating pineapple again." });

        Video video2 = new Video();
        video2.title = "Understanding Black Holes";
        video2.author = "SpaceNerd";
        video2.length = 620;
        video2.comments.Add(new Comment { commenterName = "Maya", commentText = "Mind-blowing stuff!" });
        video2.comments.Add(new Comment { commenterName = "Zane", commentText = "Thanks for simplifying it." });

        Video video3 = new Video();
        video3.title = "Basic Guitar Lessons";
        video3.author = "MusicMaster";
        video3.length = 360;
        video3.comments.Add(new Comment { commenterName = "Leo", commentText = "Learning so much!" });
        video3.comments.Add(new Comment { commenterName = "Nora", commentText = "Where’s part 2?" });
        video3.comments.Add(new Comment { commenterName = "Dan", commentText = "Great teacher!" });

        // Add videos to list
        List<Video> videos = new List<Video> { video1, video2, video3 };

        // Display information for each video
        foreach (Video video in videos)
        {
            video.DisplayVideoInfo();
        }
    }
}

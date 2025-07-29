using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create videos
        Video video1 = new Video();
        video1._title = "Why Pineapple Belongs on Pizza";
        video1._author = "FoodKing";
        video1._length = 240;
        video1._comments.Add(new Comment { _commenterName = "Alex", _commentText = "I disagree, but nice points!" });
        video1._comments.Add(new Comment { _commenterName = "Jamie", _commentText = "Finally, someone said it." });
        video1._comments.Add(new Comment { _commenterName = "Casey", _commentText = "Never eating pineapple again." });

        Video video2 = new Video();
        video2._title = "Understanding Black Holes";
        video2._author = "SpaceGeek";
        video2._length = 620;
        video2._comments.Add(new Comment { _commenterName = "Maya", _commentText = "Mind-blowing stuff!" });
        video2._comments.Add(new Comment { _commenterName = "Zane", _commentText = "Thanks for simplifying it." });

        Video video3 = new Video();
        video3._title = "Basic Guitar Lessons";
        video3._author = "GuitarZerotoHero";
        video3._length = 360;
        video3._comments.Add(new Comment { _commenterName = "Leo", _commentText = "Learning so much!" });
        video3._comments.Add(new Comment { _commenterName = "Nora", _commentText = "Where’s part 2?" });
        video3._comments.Add(new Comment { _commenterName = "Dan", _commentText = "Great teacher!" });

        // Add videos to list
        List<Video> videos = new List<Video> { video1, video2, video3 };

        // Display information for each video
        foreach (Video video in videos)
        {
            video.DisplayVideoInfo();
        }
    }
}

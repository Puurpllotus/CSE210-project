using System;
using System.Collections.Generic;

public class Video
{
    public string _title;
    public string _author;
    public int _length;
    public List<Comment> _comments = new List<Comment>();

    public int GetCommentCount()
    {
        return _comments.Count;
    }

    public void DisplayVideoInfo()
    {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Length: {_length} seconds");
        Console.WriteLine($"Number of comments: {GetCommentCount()}");

        foreach (Comment comment in _comments)
        {
            Console.WriteLine($"  {_commenterName(comment)}: {_commentText(comment)}");
        }

        Console.WriteLine();
    }

    private string _commenterName(Comment comment)
    {
        return comment._commenterName;
    }

    private string _commentText(Comment comment)
    {
        return comment._commentText;
    }
}

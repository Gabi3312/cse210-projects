using System;
using System.Collections.Generic;

namespace Foundation1
{
    public class Comment
    {
        public string Name { get; set; }
        public string Text { get; set; }

        public Comment(string name, string text)
        {
            Name = name;
            Text = text;
        }

        public string GetCommentDetails()
        {
            return $"{Name}: {Text}";
        }
    }

    public class Video
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int Length { get; set; } 
        private List<Comment> comments;

        public Video(string title, string author, int length)
        {
            Title = title;
            Author = author;
            Length = length;
            comments = new List<Comment>();
        }

        public void AddComment(Comment comment)
        {
            comments.Add(comment);
        }

        public int GetNumberOfComments()
        {
            return comments.Count;
        }

        public void DisplayComments()
        {
            foreach (var comment in comments)
            {
                Console.WriteLine(comment.GetCommentDetails());
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            
            List<Video> videos = new List<Video>();

           
            Video video1 = new Video("Learning C#", "John", 300);
            video1.AddComment(new Comment("Alice", "Great tutorial!"));
            video1.AddComment(new Comment("Bob", "Thanks for the tips!"));
            video1.AddComment(new Comment("Charlie", "Very helpful."));
            videos.Add(video1);

            Video video2 = new Video("Advanced C# Techniques", "Jackson Smith", 450);
            video2.AddComment(new Comment("David", "Loved the examples!"));
            video2.AddComment(new Comment("Eva", "Can't wait to try it."));
            videos.Add(video2);

            Video video3 = new Video("C# for Beginners", "Mike Johnson", 360);
            video3.AddComment(new Comment("Gabriel", "Clear explanations."));
            video3.AddComment(new Comment("George", "Really enjoyed this!"));
            video3.AddComment(new Comment("Hannah", "Looking forward to more videos."));
            videos.Add(video3);

            
            foreach (var video in videos)
            {
                Console.WriteLine($"Title: {video.Title}");
                Console.WriteLine($"Author: {video.Author}");
                Console.WriteLine($"Length: {video.Length} seconds");
                Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");
                Console.WriteLine("Comments:");
                video.DisplayComments();
                Console.WriteLine();
            }
        }
    }
}

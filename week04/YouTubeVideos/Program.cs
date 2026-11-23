using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create the first video
        Video video1 = new Video("Introduction to C#", "John Smith", 600);

        video1.AddComment(new Comment("David", "This is a very helpful tutorial."));
        video1.AddComment(new Comment("Mary", "I learned a lot from this video."));
        video1.AddComment(new Comment("Peter", "Please make more videos like this."));

        // Create the second video
        Video video2 = new Video("Understanding Object-Oriented Programming", "Sarah Johnson", 900);

        video2.AddComment(new Comment("James", "Excellent explanation of classes."));
        video2.AddComment(new Comment("Grace", "This made programming easier to understand."));
        video2.AddComment(new Comment("Michael", "Very informative lesson."));
        video2.AddComment(new Comment("Esther", "Thank you for sharing this knowledge."));

        // Create the third video
        Video video3 = new Video("Introduction to Web Development", "Daniel Brown", 750);

        video3.AddComment(new Comment("Paul", "HTML and CSS are easier now."));
        video3.AddComment(new Comment("Ruth", "Great explanation."));
        video3.AddComment(new Comment("Joseph", "I enjoyed this tutorial."));

        // Create the fourth video
        Video video4 = new Video("Learning C# Collections", "Emily Wilson", 840);

        video4.AddComment(new Comment("Samuel", "Very useful information."));
        video4.AddComment(new Comment("Rebecca", "I finally understand lists."));
        video4.AddComment(new Comment("Daniel", "Looking forward to the next lesson."));
        video4.AddComment(new Comment("Faith", "Great teaching approach."));

        // Store all videos in a list
        List<Video> videos = new List<Video>
        {
            video1,
            video2,
            video3,
            video4
        };

        // Display the information for each video
        foreach (Video video in videos)
        {
            Console.WriteLine("----------------------------------------");
            Console.WriteLine($"Title: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Length: {video.GetLength()} seconds");
            Console.WriteLine($"Number of comments: {video.GetCommentCount()}");

            Console.WriteLine("Comments:");

            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"{comment.GetCommenterName()}: {comment.GetCommentText()}");
            }

            Console.WriteLine();
        }
    }
}
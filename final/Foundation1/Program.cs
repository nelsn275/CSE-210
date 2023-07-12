using System;

class Program
{
    static void Main(string[] args)
    {
        // Create a new list to put new videos in
        List<Video> videos = new List<Video>();

        // Create each new video with it's proper information
        Video mrBeastVideo = new Video("Giving $100,000$ to Strangers", "Mr Beast", 600);
        Video programmingTutorial = new Video("How to Code in C#", "Nicholas Nelson", 1800);
        Video cookingTutorial = new Video("Make 10 easy meals with 10 Common Ingredients!", "Emma Nelson", 900);

        // Add each new video to a list of videos
        videos.Add(mrBeastVideo);
        videos.Add(programmingTutorial);
        videos.Add(cookingTutorial);

        // Create comments for each video

        // MrBeast comments
        Comment comment1 = new Comment("Bob Richards", "Can I be in your next video?");
        Comment comment2 = new Comment("Nicholas Nelson", "Yeah Mr Beast! I love your chocolate");
        Comment comment3 = new Comment("Ross Geller", "Love the video!");
        // Add MrBeasts comments to his video
        mrBeastVideo.AddComment(comment1);
        mrBeastVideo.AddComment(comment2);
        mrBeastVideo.AddComment(comment3);

        // Programming Tutorial Comments
        Comment comment4 = new Comment("Brother Lythgoe", "Great job Nicholas! You get an A!");
        Comment comment5 = new Comment("Emma Nelson", "You're the best husband ever!");
        Comment comment6 = new Comment("John Doe", "Thanks for the help!");
        // Add comments to my programming video
        programmingTutorial.AddComment(comment4);
        programmingTutorial.AddComment(comment5);
        programmingTutorial.AddComment(comment6);

        // Cooking Tutorial Comments
        Comment comment7 = new Comment("Jane Doe", "Love your recipes!");
        Comment comment8 = new Comment("Rachel Green", "You're the best Emma!");
        Comment comment9 = new Comment("Nicholas Nelson", "Your cooking is awesome");
        // Add comments to Emmas video
        cookingTutorial.AddComment(comment7);
        cookingTutorial.AddComment(comment8);
        cookingTutorial.AddComment(comment9);

        Console.WriteLine();
        foreach (Video video in videos)
        {
            Console.WriteLine($"{video.GetVideoInformation()}");
            Console.WriteLine($"Comments({video.GetNumberOfComments()}) ");
            video.DisplayComments();
            Console.WriteLine();
        }



    }
}
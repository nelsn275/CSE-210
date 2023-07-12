public class Video{
    string title, author;
    int length;
    List<Comment> comments = new List<Comment>();

    public Video(string _title, string _author, int length_seconds)
    {
        title = _title;
        author = _author;
        length = length_seconds;
    }

    public string GetVideoInformation()
    {
        return $"{title}, By: {author}, Length: {length} seconds";
    }

    public void AddComment(Comment comment)
    {
        comments.Add(comment);
    }
    public int GetNumberOfComments()
    {
        int count = 0;
        foreach (Comment comment in comments)
        {
            count ++;
        }
        return count;
    }

    public void DisplayComments()
    {
        foreach (Comment comment in comments)
        {
            Console.WriteLine(comment.GetCommentInformation());
        }
    }

}
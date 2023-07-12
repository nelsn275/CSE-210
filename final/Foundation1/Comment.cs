public class Comment{
    
    public string creator, text;

    public Comment(string _creator, string comment_text)
    {
        creator = _creator;
        text = comment_text;
    }

    public string GetCommentInformation()
    {
        return $"{creator} wrote: '{text}'";
    }

}
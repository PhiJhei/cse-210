public class Video
{
    private string _title;
    private string _author;
    private int _length_in_seconds;
    private List<Comment> _comments = new();

    public Video(string title, string author, int length){
        _title = title;
        _author = author;
        _length_in_seconds = length;
    }
    
    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    public string GetDisplayText()
    {
        string result = $"{_title}: {_author} - {_length_in_seconds}sec";
        foreach (Comment comment in _comments)
        {
            result += "\n" + comment.GetDisplayText();
        }
        return result;
    }
}
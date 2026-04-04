public class Video
{
    private string _title;
    private string _author;
    private int _lengthInSeconds;
    private List<Comment> _comments = new();

    public Video(string title, string author, int length){
        _title = title;
        _author = author;
        _lengthInSeconds = length;
    }
    
    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    public int GetNumberOfComments()
    {
        return _comments.Count();
    }

    public string GetDisplayText()
    {
        string result = $"{_title}: {_author} - {_lengthInSeconds}sec" + "\n" + $"There are {GetNumberOfComments()} comment(s) in this Video.";
        foreach (Comment comment in _comments)
        {
            result += "\n" + comment.GetDisplayText();
        }
        return result;
    }
}
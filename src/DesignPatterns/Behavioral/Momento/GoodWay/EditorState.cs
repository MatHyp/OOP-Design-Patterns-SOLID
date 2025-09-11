public class EditorState
{
    private readonly string _title;
    private readonly string _content;
    private readonly DateTime _stateCreatedAt;
    public EditorState(string title, string content)
    {
        _title = _title;
        _content = content;
        _stateCreatedAt = DateTime.Now;
    }

    public string getTitle()
    {
        return _title;
    }

    public string getContent()
    {
        return _content;
    }
}
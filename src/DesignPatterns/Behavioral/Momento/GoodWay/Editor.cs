public class Editor
{
    private string _title { get; set; }
    private string _content { get; set; }


    public EditorState CreateState()
    {
        return new EditorState(_title, _content);
    }

    public void Restore(EditorState _state)
    {
        _title = _state.getTitle();
        _content = _state.getContent();
    }
}
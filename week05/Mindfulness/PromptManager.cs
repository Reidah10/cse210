public class PromptManager
{
    private List<string> _prompts;
    private List<int> _usedPrompts;
    private Random _random;

    public PromptManager(List<string> prompts)
    {
        _prompts = prompts;
        _usedPrompts = new List<int>();
        _random = new Random();
    }

public string GetNextPrompt()
    {
        if (_usedPrompts.Count == _prompts.Count)
        {
            _usedPrompts.Clear();
        }

        int index;
        do
        {
            index = _random.Next(_prompts.Count);
        } while (_usedPrompts.Contains(index));

        _usedPrompts.Add(index);
        return _prompts[index];
    }
}

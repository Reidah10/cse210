class PromptGenerator
{
    private List<string> _prompts;

    public PromptGenerator()
    {
        _prompts = new List<string>();

        _prompts.Add("What's something you were grateful for today?");
        _prompts.Add("What reminded you that God loves you?");
        _prompts.Add("What was the best part of today?");
        _prompts.Add("Who helped you to smile today?");
        _prompts.Add("What challenge did you overcome today?");
    }

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }

}
class Journal
{
    private List<Entry> _entries;

    public Journal()
    {
        _entries = new List<Entry>();
    }

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        
    }

    public void SaveToFile(string file)
    {
        
    }

    public void LoadFromFile(string file)
    {
        
    }
}
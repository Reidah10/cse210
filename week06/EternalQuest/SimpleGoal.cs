public class SimpleGoal : Goal
{
    private bool _isComplete;
    private bool _isDaily;
    private DateTime _lastCompleted;

    public SimpleGoal(string name, string description, int points, bool isDaily) : base(name, description, points)
    {
        _isComplete = false;
        _isDaily = isDaily;
        _lastCompleted = DateTime.MinValue;
    }

    public override bool RecordEvent()
    {
        if (_isDaily && _lastCompleted.Date == DateTime.Today)
        {
            Console.WriteLine("This daily goal has already been completed today. Try doing another goal.");
            return false;
        }
        _isComplete = true;
        _lastCompleted = DateTime.Today;
        return true;
    }

    public override bool IsComplete()
    {
        if (_isDaily)
        {
            return _lastCompleted.Date == DateTime.Today;
        }
        return _isComplete;
    }

    public override string GetDetailsString()
    {
        string checkbox;

        if (_isComplete)
        {
            checkbox = "[X]";
        }
        else
        {
            checkbox = "[ ]";
        }
        return $"{checkbox} {_name} ({_description})";
    }

    public bool IsDaily()
    {
        return _isDaily;
    }

    public DateTime GetLastCompleted()
    {
        return _lastCompleted;
    }

    public void SetLastCompleted(DateTime lastCompleted)
    {
        _lastCompleted = lastCompleted;

        if (lastCompleted != DateTime.MinValue)
        {
            _isComplete = true;
        }
    }
}
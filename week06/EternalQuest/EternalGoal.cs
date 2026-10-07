public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) : base(name, description, points)
    {
    }

    public override bool RecordEvent()
    {
        // Eternal goals are never complete, so no action is needed here.
        return true;
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override string GetDetailsString()
    {
        return $"[ ] {_name} ({_description})";
    }
}
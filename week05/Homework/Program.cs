using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment = new Assignment("Joe Mama", "Long Division");

        Console.WriteLine(assignment.GetSummary());

        MathAssignment math = new MathAssignment(
            "Joe Mama",
            "Long Division",
            "4.2",
            "6-9");

        Console.WriteLine(math.GetSummary());
        Console.WriteLine(math.GetHomeworkList());

        WritingAssignment writing = new WritingAssignment(
            "Billy Bob",
            "World War II",
            "Man's Search For Meaning");

        Console.WriteLine(writing.GetSummary());
        Console.WriteLine(writing.GetWritingInformation());
    }
}
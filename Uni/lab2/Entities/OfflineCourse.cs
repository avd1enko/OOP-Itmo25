namespace lab2.Entities;

public class OfflineCourse : Course
{
    public string Room { get; set; }

    public OfflineCourse(
        string name,
        DateTime startDate,
        int durationWeeks,
        string description,
        string room
    ) : base(name, startDate, durationWeeks, description)
    {
        Room = room;
    }

    public override string GetCourseType()
    {
        return "Offline";
    }
}
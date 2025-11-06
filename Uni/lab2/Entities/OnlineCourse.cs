namespace lab2.Entities;

public class OnlineCourse : Course
{
    public string Platform { get; set; }

    public OnlineCourse(
        string name,
        DateTime startDate,
        int durationWeeks,
        string description,
        string platform
    ) : base(name, startDate, durationWeeks, description)
    {
        Platform = platform;
    }

    public override string GetCourseType()
    {
        return "Online";
    }
}
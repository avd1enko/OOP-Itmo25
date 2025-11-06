namespace lab2.Entities;

public abstract class Course
{
    public string Name { get; set; }
    public DateTime StartDate { get; set; }
    public int DurationWeeks { get; set; }
    public string Description { get; set; }

    public Teacher? AssignedTeacher { get; set; }

    public List<Student> Students { get; set; }

    public Course(string name, DateTime startDate, int durationWeeks, string description)
    {
        Name = name;
        StartDate = startDate;
        DurationWeeks = durationWeeks;
        Description = description;
        Students = new List<Student>();
    }

    public abstract string GetCourseType();
}
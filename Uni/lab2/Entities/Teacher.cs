namespace lab2.Entities;

public class Teacher
{
    public string Name { get; set; }
    public string Email { get; set; }

    public List<Course> Courses { get; set; }

    public Teacher(string name, string email)
    {
        Name = name;
        Email = email;
        Courses = new List<Course>();
    }

    public void AssignCourse(Course course)
    {
        Courses.Add(course);
        course.AssignedTeacher = this;
    }
}
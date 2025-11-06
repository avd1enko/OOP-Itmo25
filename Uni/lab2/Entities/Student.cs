namespace lab2.Entities;

public class Student
{
    public string Name { get; set; }
    public string Email { get; set; }

    public List<Course> EnrolledCourses { get; set; }

    public Student(string name, string email)
    {
        Name = name;
        Email = email;
        EnrolledCourses = new List<Course>();
    }

    public void Enroll(Course course)
    {
        EnrolledCourses.Add(course);
        course.Students.Add(this);
    }
}
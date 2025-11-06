using System.Collections.Generic;
using lab2.Entities;
using lab2.SystemUni;

namespace lab2
{
    public class UniSystem
    {
        public List<Student> Students { get; private set; } = new();
        public List<Teacher> Teachers { get; private set; } = new();
        public List<Course> Courses { get; private set; } = new();

        private readonly CourseManager _courseManager = new();

        public void AddStudent(Student student)
        {
            Students.Add(student);
        }

        public void AddTeacher(Teacher teacher)
        {
            Teachers.Add(teacher);
        }

        public void AddCourse(Course course)
        {
            Courses.Add(course);
            _courseManager.AddCourse(course);
        }

        public void EnrollStudent(Student student, Course course)
        {
            _courseManager.EnrollStudentInCourse(student, course);
        }
    }
}
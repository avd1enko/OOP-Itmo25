using System.Collections.Generic;
using System.Linq;
using lab2.Entities;

namespace lab2.SystemUni
{
    public class CourseManager
    {
        private List<Course> _courses = new List<Course>();
        private List<Teacher> _teachers = new List<Teacher>();
        private List<Student> _students = new List<Student>();

        public void AddCourse(Course course)
        {
            _courses.Add(course);
        }

        public void AssignTeacherToCourse(Teacher teacher, Course course)
        {
            if (!_teachers.Contains(teacher))
                _teachers.Add(teacher);

            course.AssignedTeacher = teacher;
            teacher.Courses.Add(course);
        }

        public void EnrollStudentInCourse(Student student, Course course)
        {
            if (!_students.Contains(student))
                _students.Add(student);

            course.Students.Add(student);
            student.EnrolledCourses.Add(course);
        }

        public List<Course> GetCoursesByTeacher(Teacher teacher)
        {
            return teacher.Courses;
        }
    }
}
using System;
using Xunit;
using lab2;
using lab2.Entities;
using lab2.SystemUni;

namespace Test
{
    public class UniSystemTests
    {
        [Fact]
        public void AddStudent_ShouldIncreaseCount()
        {
            var uni = new UniSystem();
            var student = new Student("Иван Иванов", "ivan@itmo.ru");
            uni.AddStudent(student);

            Assert.Single(uni.Students);
            Assert.Equal("Иван Иванов", uni.Students[0].Name);
        }

        [Fact]
        public void AddTeacher_ShouldIncreaseCount()
        {
            var uni = new UniSystem();
            var teacher = new Teacher("Петр Петров", "petr@itmo.ru");
            uni.AddTeacher(teacher);

            Assert.Single(uni.Teachers);
            Assert.Equal("Петр Петров", uni.Teachers[0].Name);
        }

        [Fact]
        public void AddCourse_ShouldIncreaseCount()
        {
            var uni = new UniSystem();
            var course = new OnlineCourse("Алгебра", DateTime.Now, 6, "Базовый курс", "Zoom");
            uni.AddCourse(course);

            Assert.Single(uni.Courses);
            Assert.Equal("Алгебра", uni.Courses[0].Name);
        }

        [Fact]
        public void EnrollStudent_ShouldAddStudentToCourse()
        {
            var uni = new UniSystem();
            var student = new Student("Иван Иванов", "ivan@itmo.ru");
            var course = new OfflineCourse("Физика", DateTime.Now, 8, "Базовый курс", "Аудитория 101");

            uni.AddStudent(student);
            uni.AddCourse(course);
            uni.EnrollStudent(student, course);

            Assert.Contains(student, course.Students);
            Assert.Contains(course, student.EnrolledCourses);
        }
    }
}
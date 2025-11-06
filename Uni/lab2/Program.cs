using System;
using lab2.Entities;
using lab2.SystemUni;
class Program
{
    static void Main()
    {
        var system = new CourseManager();

        // Создаем преподавателей
        var teacher1 = new Teacher("Иван Петров", "ivan@itmo.ru");
        var teacher2 = new Teacher("Мария Смирнова", "maria@itmo.ru");

        var student1 = new Student("Алексей", "alexey@itmo.ru");
        var student2 = new Student("Ольга", "olga@itmo.ru");
        var student3 = new Student("Дмитрий", "dmitry@itmo.ru");    

        var course1 = new OnlineCourse("C# для начинающих", DateTime.Now, 6, "Основы языка C#", "Zoom");
        var course2 = new OfflineCourse("Алгоритмы", DateTime.Now, 8, "Базовые алгоритмы", "ИТМО, ауд. 101");
        var course3 = new OnlineCourse("ML Basics", DateTime.Now.AddDays(7), 10, "Машинное обучение с нуля", "MS Teams"); // без преподавателя и студентов
        var course4 = new OfflineCourse("Базы данных", DateTime.Now.AddDays(14), 9, "Основы SQL и реляционных СУБД", "ИТМО, ауд. 202"); // будет только студент
        
        // Добавляем курсы в систему
        system.AddCourse(course1);
        system.AddCourse(course2);
        system.AddCourse(course3);
        system.AddCourse(course4);

        // Назначаем преподавателей
        system.AssignTeacherToCourse(teacher1, course1);
        system.AssignTeacherToCourse(teacher1, course2);

        // Записываем студентов
        system.EnrollStudentInCourse(student1, course1);
        system.EnrollStudentInCourse(student2, course2);
        system.EnrollStudentInCourse(student3, course4);
        system.EnrollStudentInCourse(student1, course4);

        // Выводим все курсы преподавателя Иван Петров
        Console.WriteLine("Курсы преподавателя Иван Петров:");
        var teacherCourses = system.GetCoursesByTeacher(teacher1);
        foreach (var course in teacherCourses)
        {
            Console.WriteLine($"- {course.Name} ({course.GetCourseType()})");
        }

        // Один курс с преподавателем и студентами
        Console.WriteLine($"\n{course1.Name}:");
        Console.WriteLine($"Тип: {course1.GetCourseType()}");
        Console.WriteLine($"Описание: {course1.Description}");
        Console.WriteLine($"Преподаватель: {course1.AssignedTeacher?.Name ?? "Нет"}");
        Console.WriteLine("Студенты:");
        if (course1.Students.Count == 0)
            Console.WriteLine("— Никто не записан");
        else
            foreach (var s in course1.Students)
                Console.WriteLine($"— {s.Name}");

        // Курс без преподавателя и без студентов
        Console.WriteLine($"\n{course3.Name}:");
        Console.WriteLine($"Преподаватель: {course3.AssignedTeacher?.Name ?? "Нет"}");
        Console.WriteLine("Студенты:");
        if (course3.Students.Count == 0)
            Console.WriteLine("— Никто не записан");

        // Курс с одним студентом, но без преподавателя
        Console.WriteLine($"\n{course4.Name}:");
        Console.WriteLine($"Преподаватель: {course4.AssignedTeacher?.Name ?? "Нет"}");
        Console.WriteLine("Студенты:");
        foreach (var s in course4.Students)
            Console.WriteLine($"— {s.Name}");
    }
}
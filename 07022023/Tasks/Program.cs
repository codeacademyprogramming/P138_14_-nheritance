using System;

namespace Tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee("Hikmet Abbasov") {Age = 45, Position = "Developer" };
            Student std = new Student("Nermin Abbaszade") { Age = 39,Point = 86 };
            Human human = new Human("Tofiq Qulamov") { Age = 54 };
            Teacher teacher = new Teacher("Abbas Qulamov") { Age = 67, Position = "Teacher", ExperienceYear = 40 };

            emp.ShowInfo();
            std.ShowInfo();
            human.ShowInfo();
            teacher.ShowInfo();
        }
    }
}

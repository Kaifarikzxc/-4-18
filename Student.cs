using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex18P4
{
    // класс Студент
    public class Student : Applicant
    {
        public int Course { get; set; }

        // Конструктор
        public Student(string name, string surname, DateTime birthday, string Faculty, int course)  : base(name, surname, birthday, Faculty)
        {
            Course = course;
        }
        public new void PrintInfo()
        {
            Console.WriteLine($"Имя: {Name}");
            Console.WriteLine($"Фамилия: {Surname}");
            Console.WriteLine($"Дата рождения: {Birthday.ToShortDateString()}");
            Console.WriteLine($"Факультет: {Faculty}");
            Console.WriteLine($"Курс: {Course}");
        }
    }
}

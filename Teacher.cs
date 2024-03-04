using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex18P4
{
    // класс Учитель
    public class Teacher : Person
    {
        public string Faculty { get; set; }
        public string Post { get; set; }
        public int Experience { get; set; }

        // Конструктор
        public Teacher(string name,string surname, DateTime birthday , string faculty, string post, int experience) : base(name, surname, birthday)
        {
            Faculty = faculty;
            Post = post;
            Experience = experience;
        }
        public void PrintInfo()
        {
            Console.WriteLine($"Имя: {Name}");
            Console.WriteLine($"Фамилия: {Surname}");
            Console.WriteLine($"Дата рождения: {Birthday.ToShortDateString()}");
            Console.WriteLine($"Факультет: {Faculty}");
            Console.WriteLine($"Должность: {Post}");
            Console.WriteLine($"Стаж: {Experience} лет");
        }
    }
}


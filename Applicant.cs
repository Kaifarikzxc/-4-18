using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Ex18P4
{
    // класс Абитуриент
     public class Applicant : Person
     {
        public string Faculty { get; set; }
        private string name;
        private string surname;
        private DateTime birthday;

        // Конструктор
        public Applicant(string name, string surname, DateTime birthday , string faculty)  : base(surname, name, birthday)
        {
            Faculty = faculty;
            this.name = name;
            this.surname = surname;
            this.birthday = birthday;

        }
        public void PrintInfo()
        {
            Console.WriteLine($"Имя: {name}");
            Console.WriteLine($"Фамилия: {surname}");
            Console.WriteLine($"Дата рождения: {birthday.ToShortDateString()}");
            Console.WriteLine($"Факультет: {Faculty}");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex18P4
{
    internal class Program
    {
        static void Main(string[] args)
        {
           //Добовление параметрок к подклассам
            Applicant applicant = new Applicant("Иван", "Иванов", new DateTime(2000, 5, 10), "Физика");
            Student student = new Student("Петр", "Петров", new DateTime(1999, 3, 15), "Информатика", 2);
            Teacher teacher = new Teacher("Дмитрий", "Дмитриев", new DateTime(2000, 10, 20), "Математика", "Учитель", 10);

            // Вывод информации о классах
            Console.WriteLine("Информация об абитуриенте:");
            applicant.PrintInfo();
            Console.WriteLine("\nИнформация о студенте:");
            student.PrintInfo();
            Console.WriteLine("\nИнформация о преподавателе:");
            teacher.PrintInfo();
            Console.ReadLine();
        }
    }
}

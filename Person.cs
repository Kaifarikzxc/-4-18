using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Ex18P4
{
     public abstract class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime Birthday  { get; set; }

        public Person(string name, string surname, DateTime birthday)
        {
             Name = name;
             Surname = surname;
             Birthday = birthday;
        } 
     }
}

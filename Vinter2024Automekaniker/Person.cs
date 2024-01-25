using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vinter2024Automekaniker
{
    public class Person
    {
        public int Id { get; set; }
        public static int IdCounter = 0;
        public string Name { get; set; }
        public string Phone { get; set; }

        public Person(string name, string phone)
        {
            Name = name;
            Phone = phone;
            IdCounter++;
            Id = IdCounter;

        }

        public override string ToString()
        {
            return $"ID: {Id}, Name: {Name}, Phone: {Phone}";
        }
    }
}

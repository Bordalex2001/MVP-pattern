using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    internal class Human
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Human() { }
        public Human(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public override string ToString()
        {
            return $"Name:{Name}\nAge:{Age}";
        }
    }
}

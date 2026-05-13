using System;
using System.Collections.Generic;
using System.Text;

namespace ParProg1
{
    internal class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Hobby { get; set; }

        public Person(string name, int age, string hobby)
        {
            Name = name;
            Age = age;
            Hobby = hobby;
        }

        public void ReadInfo()
        {
            Console.WriteLine($"Name: {Name} | Age: {Age} | Hobby: {Hobby}");
        }
    }
}

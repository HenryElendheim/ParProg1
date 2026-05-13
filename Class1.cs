using System;
using System.Collections.Generic;
using System.Text;

namespace ParProg1
{
    internal class Class1
    {
        class Person
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public string Hobby { get; set; }
        }

        public void MainMethod()
        {
            var person = new Person { Name = "Celine", Age = 27, Hobby = "gaming, musikk, sang og kvalitetstid med venner" };
            Console.WriteLine($"Hei, jeg heter {person.Name}, jeg er {person.Age} år gammel, og på fritiden så liker jeg {person.Hobby}");
        }
    }
}

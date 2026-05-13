using ParProg1;
using System.Net.Cache;

Console.WriteLine("Here you can write a person's name, age and hobby! ");
var inputName = Console.ReadLine();
var inputAge = Convert.ToInt32(Console.ReadLine());
var inputHobby = Console.ReadLine();

var person = new Person(inputName, inputAge, inputHobby);

var person1 = new Person("Henry", 20, "koding, tegning, musikk og gaming");
var person2 = new Person("Celine", 27, "gaming, musikk, sang og kvalitetstid med venner");

person.ReadInfo();
Console.WriteLine($"\nHei jeg heter, {person1.Name} og er {person1.Age} år. jeg liker {person1.Hobby}.\n" +
                  $"Hei, jeg heter {person2.Name}, jeg er {person2.Age} år gammel, og på fritiden så liker jeg {person2.Hobby}.");
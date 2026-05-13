using ParProg1;
using System.Net.Cache;



Console.WriteLine("Here you can write a person's name, age and hobby!");
var inputName = Console.ReadLine();
var inputAge = Convert.ToInt32(Console.ReadLine());
var inputHobby = Console.ReadLine();

var person = new Person(inputName, inputAge, inputHobby);

person.ReadInfo();



//var henry = new Person("Henry", 20, "Coding, tegning, musikk og gaming");
//var celine = new Person("Celine", 27, "Gaming, musikk, sang og kvalitetstid med venner");
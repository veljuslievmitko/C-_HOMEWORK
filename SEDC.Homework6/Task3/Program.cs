using Domain.Classes;
using Domain.Enums;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;

#region Text
/*Create a class Animal. Each Animal has name, color, age and gender. Use enum for Gender.

Find the names of all the animals aged 5 or more
Find all the names of the animals that start with 'A'
Find all male, brown animals
Find the first animal whose name is longer than 10 characters
 */

#endregion


List<Animal> animals = new List<Animal>()
{
    new Animal("Tiger", "yellow", 35, Gender.Male),
    new Animal("Bear", "brown", 45, Gender.Male),
    new Animal("mouse", "black", 3, Gender.Female),
    new Animal("Shark", "grey", 23, Gender.Female),
    new Animal("Dog", "White", 5, Gender.Male),
    new Animal("Anaconda", "Green", 24, Gender.Female)
};

List<Animal> animalOlderThan5 = animals.Where(animal =>animal.Age >5).ToList();
(animals.Where(p => p.Age > 5).ToList()).ForEach(x => Console.WriteLine(x.Name + " is older than 5"));
Console.WriteLine("=====================");
List<Animal> namesThatStartWithA = animals.Where(x => x.Name.ToLower().StartsWith('a')).ToList();
namesThatStartWithA.ForEach(x => Console.WriteLine(x.Name));
Console.WriteLine("=====================");
List<Animal> maleAnimals = animals.Where(x => x.Gender == Gender.Male).ToList();
List<Animal> femaleAnimals = animals.Where(x => x.Gender == Gender.Female).ToList();

Console.WriteLine("=====================");
string animalWithLongName;

if (animals.FirstOrDefault(x => x.Name.Length > 10) == null)
{
 Console.WriteLine("No animal with long name");

} else Console.WriteLine(animals.FirstOrDefault(x => x.Name.Length > 10).Name);





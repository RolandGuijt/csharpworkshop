// See https://aka.ms/new-console-template for more information
using EntityFramework.Database;

using var context = new PersonDbContext();
context.Database.EnsureDeleted();
context.Database.EnsureCreated();
var person = new Person
{
    Name = "John",
    City = "London"
};
context.Persons.Add(person);
context.SaveChanges();

foreach (var currentPerson in context.Persons)
{
    Console.WriteLine($"{currentPerson.Name} from {currentPerson.City} is in the database!");
}

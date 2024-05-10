// See https://aka.ms/new-console-template for more information
using Code_Louisville_Exercise_2;

Console.WriteLine("How many records do you want to add? ");
var numberOfRecords = int.Parse(Console.ReadLine() ?? "0");
 

var recordList = new List<Dog>();
for (int i = 0; i < numberOfRecords; i++)
{
    var myClass = new Dog();


    Console.WriteLine("Enter the value for name");
    myClass.Name = Console.ReadLine();

    Console.WriteLine("Enter the value for color");
    myClass.Color = Console.ReadLine();


    recordList.Add(myClass);
}
foreach (var item in recordList)
{
    Console.WriteLine($"Dog Name: {item.Name} Dog Color:{item.Color}.");
}

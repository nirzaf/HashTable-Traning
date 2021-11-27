// See https://aka.ms/new-console-template for more information

using System.Collections;
using Bogus;

Console.WriteLine("Welcome to Learn about Hash Table using C#");

var myHashtable = new Hashtable();


for (int i = 1; i < 100; i++)
{
    var myFaker = new Faker();
    myHashtable.Add(i, myFaker.Address.City());
}

myHashtable.Remove(50);

foreach (DictionaryEntry hTable in myHashtable)
{
    Console.WriteLine($"Key: {hTable.Key} ,  Values: {hTable.Value}");
}


Console.ReadLine();
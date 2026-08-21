using System.Text.Json;

List<string> election = [];
Console.Clear();
Console.WriteLine("hello");
Console.ReadLine();


List<string> test = ["hej", "hejdå"];

string jsonText = JsonSerializer.Serialize(test);

Console.WriteLine(jsonText);
Console.ReadLine();
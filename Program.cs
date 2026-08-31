string[] parties = ["Red", "Blue", "Green"];
int[] votes = new int[parties.Length];

while (true)
{
    Console.Clear();
    for (int i = 0; i < parties.Length; i++)
        Console.WriteLine($"{i + 1}. {parties[i]}");

    Console.Write("Vote: ");
    string? input = Console.ReadLine();

    if (input == "quit")
        break;

    if (int.TryParse(input, out int choice) && choice >= 1 && choice <= parties.Length)
        votes[choice - 1]++;
}

Console.Clear();
for (int i = 0; i < parties.Length; i++)
    Console.WriteLine($"{parties[i]}: {votes[i]}");

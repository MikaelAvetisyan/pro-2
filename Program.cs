string[] parties = ["Red Party", "Blue Party", "Green Party", "Yellow Party"];
int[] votes = new int[parties.Length];

while (true)
{
    Console.Clear();
    Console.WriteLine("=== Election Machine ===");
    Console.WriteLine("Type the number of the party you want to vote for, then press Enter.");
    Console.WriteLine("Type 'quit' when everyone has voted to see the results.\n");

    for (int i = 0; i < parties.Length; i++)
    {
        Console.WriteLine($"{i + 1}. {parties[i]}");
    }

    Console.Write("\nYour vote: ");
    string? input = Console.ReadLine();

    if (string.Equals(input?.Trim(), "quit", StringComparison.OrdinalIgnoreCase))
    {
        break;
    }

    if (int.TryParse(input, out int choice) && choice >= 1 && choice <= parties.Length)
    {
        votes[choice - 1]++;
        Console.WriteLine("\nVote counted! Pass the keyboard to the next voter.");
    }
    else
    {
        Console.WriteLine("\nInvalid input. Press Enter to try again.");
    }

    Console.ReadLine();
}

Console.Clear();
Console.WriteLine("=== Final Results ===\n");

int totalVotes = votes.Sum();
for (int i = 0; i < parties.Length; i++)
{
    Console.WriteLine($"{parties[i]}: {votes[i]} vote(s)");
}

Console.WriteLine($"\nTotal votes cast: {totalVotes}");

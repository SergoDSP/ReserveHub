string[] rooms = { "Orion", "Atlas", "Nova" };

Console.WriteLine("ReserveHub"); 
Console.WriteLine("1 - Show rooms");
Console.WriteLine("2 - Exit");
Console.WriteLine("Choose an option: ");

int choice = int.Parse(Console.ReadLine()!);

if (choice == 1)
{
    Console.WriteLine("Available rooms:");

    for (int i = 0; i < rooms.Length; i++)
    {
        Console.WriteLine($"{i + 1} - {rooms[i]}");
    }
}
else if (choice == 2)
{
    Console.WriteLine("Goodbye!");
}
else
{
    Console.WriteLine("Invalid option.");
}
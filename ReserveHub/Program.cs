string[] rooms = { "Orion", "Atlas", "Nova" };

bool[] isReserved = { false, false, false };

bool isRunning = true;
while (isRunning)
{
    Console.WriteLine("ReserveHub");
    Console.WriteLine("1 - Show rooms");
    Console.WriteLine("2 - Reserve a room");
    Console.WriteLine("3 - Exit");
    Console.WriteLine("4 - Show statistics");
    Console.WriteLine("Choose an option: ");
   


    if (int.TryParse(Console.ReadLine(), out int choice))
    {
        if (choice == 1)
        {
            ShowRooms(rooms, isReserved);
        }

        else if (choice == 2)
        {
            
           ReserveRoom(rooms, isReserved);

        }
        else if (choice == 3)
        {
            Console.WriteLine("Goodbye!");
            isRunning = false;
        }
        else if (choice == 4)
        {
            ShowStatistics(rooms, isReserved);

        }
        else
        {
            Console.WriteLine("Invalid option.");
        }
    }
    else
    {
        Console.WriteLine("Invalid option.");
    }

   
}

static void ReserveRoom(string[] rooms, bool[] isReserved)
{
    ShowRooms(rooms, isReserved);

    Console.WriteLine("Choose room number: ");
    if (int.TryParse(Console.ReadLine(), out int roomNumber) && roomNumber >= 1 && roomNumber <= rooms.Length)
    {
        if (!isReserved[roomNumber - 1])
        {
            Console.WriteLine($"Room {rooms[roomNumber - 1]} is now reserved.");
            isReserved[roomNumber - 1] = true;
        }
        else
        {
            Console.WriteLine($"Room {rooms[roomNumber - 1]} is already reserved.");
        }
    }
    else
    {
        Console.WriteLine("Invalid room number.");
    }
}
static void ShowRooms(string[] rooms, bool[] isReserved)
{
    Console.WriteLine("Available rooms:");

    for (int i = 0; i < rooms.Length; i++)
    {
        if (isReserved[i])
        {
            Console.WriteLine($"{i + 1} - {rooms[i]} - Reserved");
        }
        else
        {
            Console.WriteLine($"{i + 1} - {rooms[i]} - Available");
        }
    }
}

static void ShowStatistics(string[] rooms, bool[] isReserved)
{
    int reservedCount = 0;
    int availableCount = 0;
    for (int i = 0; i < rooms.Length; i++)
    {
        if (isReserved[i])
        {
            reservedCount++;
        }
        else
        {
            availableCount++;
        }
    }
    Console.WriteLine($"Total rooms: {rooms.Length}");
    Console.WriteLine($"Reserved rooms: {reservedCount}");
    Console.WriteLine($"Available rooms: {availableCount}");
}

   
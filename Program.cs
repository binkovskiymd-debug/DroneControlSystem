using DroneControlSystem;

Console.WriteLine("=== Система управления БПЛА (версия 1.0) ===\n");

Drone[] drones = new Drone[]
{
    new Drone("DJI Mini 3", 85),
    new Drone("Autel EVO Lite", 45),
    new Drone("Parrot Anafi", 15)
};

foreach (Drone d in drones)
{
    d.PrintInfo();

    if (d.BatteryLevel < 20)
    {
        Console.WriteLine("Внимание: заряд ниже 20%! Требуется подзарядка.");
    }

    Console.WriteLine();
}

Console.WriteLine("Программа завершена.");

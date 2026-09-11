using System;

enum DaysOfWeek
{
    Sunday = 0,
    Monday = 1,
    Tuesday = 2,
    Wednesday = 3,
    Thursday = 4,
    Friday = 5,
    Saturday = 6
}

[Flags]
enum FilePermission
{
    Read = 1,
    Write = 2,
    Execute = 4
}

class Program
{
    static void Main()
    {
        // Part 1: DaysOfWeek enum

        int dayNumber = 3;

        DaysOfWeek day = (DaysOfWeek)dayNumber;

        Console.WriteLine($"Day number {dayNumber}: {day}");

        // 3 is converted to Wednesday because Wednesday has value 3.


        // Part 2: FilePermission with [Flags]

        FilePermission permissions =
            FilePermission.Read | FilePermission.Write;

        Console.WriteLine($"Combined permissions: {permissions}");

        // | combines multiple permissions.
        // Read (1) + Write (2) = 3.


        // Check whether Write permission exists

        bool hasWritePermission =
            (permissions & FilePermission.Write) == FilePermission.Write;

        Console.WriteLine($"Has Write permission: {hasWritePermission}");

        // & checks whether a particular permission is present.
    }
}
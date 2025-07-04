using System;

namespace ConsoleUI;

public class Motorcycle : Vehicle
{
    public bool HasSideCart { get; set; }

    public override void DriveAbstract()
    {
        Console.WriteLine("The motorcycle drives on the road on two wheels.");
    }

    public override void DriveVirtual()
    {
        Console.WriteLine("The motorcycle accelerates very quickly.");
    }
}
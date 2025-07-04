using System;

namespace ConsoleUI;

public abstract class Vehicle
{
    public int Year { get; set; } = 0;
    public string Make { get; set; } = "Generic Make";
    public string Model { get; set; } = "Generic Model";

    public abstract void DriveAbstract();

    public virtual void DriveVirtual()
    {
        Console.WriteLine("The vehicle is used for transportation.");
    }
}
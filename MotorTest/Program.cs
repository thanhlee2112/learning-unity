using System;
using System.Threading;

class Program
{
    static void Main()
    {
        var motor = new PlayerMotor( 5f, 10f, 15f );

        float dt = 0.1f;

        Console.WriteLine("=== HOLD RIGHT ===");
        for (int i = 0; i < 10; i++)
        {
            motor.UpdateVelocity(1, dt);
            Console.WriteLine($"Frame {i}: {motor.VelocityX:F2}");
            Thread.Sleep(100);
        }

        Console.WriteLine("\n=== RELEASE ===");
        for (int i = 0; i < 10; i++)
        {
            motor.UpdateVelocity(0, dt);
            Console.WriteLine($"Frame {i}: {motor.VelocityX:F2}");
            Thread.Sleep(100);
        }
    }
}

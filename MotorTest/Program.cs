using System;
using System.Threading;

class Program
{
    static void Main()
    {
        PlayerJump jump = new PlayerJump(12f);

        jump.SetGrounded(true);
        jump.TryJump();

        for (int i = 0; i < 10; i++)
        {
            jump.ApplyGravity(-30f, 0.016f);
            Console.WriteLine($"Frame {i} | Y velocity: {jump.getVerticalVelocity()}");
        }
    }

}

using System;
using System.Threading;

class Program
{
    static void Main()
    {
        PlayerStateMachine sm = new PlayerStateMachine();

        sm.UpdateState(0, 0, true);
        Console.WriteLine(sm.currentState); // Idle

        sm.UpdateState(5, 0, true);
        Console.WriteLine(sm.currentState); // Run

        sm.UpdateState(5, 10, false);
        Console.WriteLine(sm.currentState); // Jump

        sm.UpdateState(5, -10, false);
        Console.WriteLine(sm.currentState); // Fall
    }


}

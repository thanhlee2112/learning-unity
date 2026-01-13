using System;
public class PlayerStateMachine
{
    public PlayerState currentState { get; private set; }

    public PlayerStateMachine()
    {
        currentState = PlayerState.Idle;
    }
    public void UpdateState(float velocityX, float velocityY, bool grounded)
    {
        if (!grounded) 
        {
            currentState = velocityY > 0 ? PlayerState.Jump : PlayerState.Fall;
            return;
        }

        if(Math.Abs(velocityX) >=0.01)
        {
            currentState = PlayerState.Run;
        }
        else
        {
            currentState = PlayerState.Idle;
        }
    }
}
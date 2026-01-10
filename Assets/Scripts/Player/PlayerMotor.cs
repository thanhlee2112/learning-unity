public class PlayerMotor
{
    private int MaxSpeed = 5;
    private int acceleration = 5;
    private int deceleration = 5;
    private float velocityX = 0;
    public float VelocityX { get { return velocityX; } }
    public void Update(float deltaTime, float input)
    {
        if (input != 0)
        {
            velocityX += acceleration * deltaTime;
            if (velocityX > MaxSpeed)
                velocityX = MaxSpeed;
        }
        else
        {
            velocityX -= deceleration * deltaTime;
            if (velocityX < 0)
                velocityX = 0;
        }
    }
    public void MoveTowards(float current, float target, float maxDelta)
    {
        if (Math.Abs(target - current) <= maxDelta)
        {
            current = target;
        }
        else
        {
            current += Math.Sign(target - current) * maxDelta;
        }
    }
}
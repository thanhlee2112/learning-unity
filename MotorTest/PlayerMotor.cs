public class PlayerMotor
{
    private float maxSpeed;
    private float acceleration;
    private float deceleration;
    private float velocityX = 0;
    public float VelocityX { get { return velocityX; } }
    public PlayerMotor(float maxSpeed, float acceleration, float deceleration)
    {
        this.maxSpeed = maxSpeed;
        this.acceleration = acceleration;
        this.deceleration = deceleration;
    }
    public void UpdateVelocity(float input,float deltaTime)
    {
        if (input != 0)
        {
            float targetVelocity = this.maxSpeed * input;
            velocityX = this.MoveTowards(velocityX, targetVelocity, deltaTime * acceleration);
        }
        else
        {
            float targetVelocity = 0f;
            velocityX = this.MoveTowards(velocityX, targetVelocity, deltaTime * deceleration);
        }
    }
    public float MoveTowards(float current, float target, float maxDelta)
    {
        if (Math.Abs(target - current) <= maxDelta)
        {
           return target;
        }
        else
        {
            return current + Math.Sign(target - current) * maxDelta;
        }
    }
}
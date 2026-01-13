public class FacingController
{
    public int Facing { get; private set; } = 1;
    public void UpdateFacing(float velocityX)
    {
        if(velocityX > 0)
        {
            Facing = 1;
        }else if(velocityX < 0)
        {
            Facing = -1;
        }
    }
}
using System;
public class PlayerJump
{
    float jumpForce = 5f;
    bool isGrounded = true;
    float verticalVelocity = 0f;
    public float getVerticalVelocity()
    {
        return this.verticalVelocity;
    }
    public PlayerJump(float jumpForce)
    {
        this.jumpForce = jumpForce;
    }
    public void SetGrounded(bool isGrounded)
    {
        this.isGrounded = isGrounded;
        if (isGrounded && verticalVelocity > 0f)
        {
            verticalVelocity = 0f;
        }
    }
    public void TryJump()
    {
        if (!this.isGrounded)
        {
            return;
        }
        verticalVelocity = jumpForce;
        this.isGrounded = false;
    }
    public void ApplyGravity(float gravity, float deltaTime)
    {
        verticalVelocity += gravity * deltaTime;
    }
}
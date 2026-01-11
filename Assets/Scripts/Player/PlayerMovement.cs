using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    PlayerMotor motor;
    Rigidbody2D rb;
    [Header("Movement Settings")]
    [SerializeField] private float maxSpeed = 5f;
    [SerializeField] private float acceleration = 10f;
    [SerializeField] private float deceleration = 15f;
    void Awake()
    {
        motor = new PlayerMotor(maxSpeed,acceleration,deceleration);
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
     float input = Input.GetAxisRaw("Horizontal");
        motor.UpdateVelocity(input, Time.deltaTime);
    }
    void FixedUpdate()
    {
        rb.linearVelocity = new Vector2(motor.VelocityX,rb.linearVelocity.y);
    }
}

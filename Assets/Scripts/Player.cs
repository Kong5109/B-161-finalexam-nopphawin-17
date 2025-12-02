using UnityEngine;

public class Player : MonoBehaviour
{
    [field: SerializeField] public float MoveSpeed { get; private set; } = 5f;
    [field: SerializeField] private float jumpForce { get; set; } = 10f;
    [field: SerializeField] public bool IsInvulnerable { get; private set; } = false;
    [field: SerializeField] public Rigidbody2D rb { get; set; }

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        Move();
        Jump();
    }

    public void SetMoveSpeed(float newSpeed)
    {
        MoveSpeed = newSpeed;
    }

    public void SetInvulnerability(bool isEnable)
    {
        IsInvulnerable = isEnable;
        Debug.Log("The Invulnerability is " + isEnable);
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        //Use PowerUp when Touch
        PowerUpBase currentPower = collision.GetComponent<PowerUpBase>();
        currentPower?.ApplyEffect(this);
    }

    public void Move()
    {
        float moveInput = Input.GetAxisRaw("Horizontal");
        rb.linearVelocity = new Vector2(moveInput * MoveSpeed, rb.linearVelocity.y);
    }

    public void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpForce);
        }
    }
}


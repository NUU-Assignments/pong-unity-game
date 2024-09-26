using UnityEngine;

public class Paddle1 : MonoBehaviour
{

    public bool isPlayer1;
    public float speed;
    public Rigidbody2D rb;
    private float movement;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isPlayer1)
        {
            movement = Input.GetAxisRaw("Vertical");
        }
        else
        {
            movement = Input.GetAxisRaw("Vertical2");
        }
        rb.linearVelocity = new Vector2(rb.linearVelocityX, movement * speed);
    }
}

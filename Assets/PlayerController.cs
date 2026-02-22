using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5.0f; 
    private Rigidbody2D rb;
    public bool isDead = false;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Only jump if the bird is not dead
        if (Input.GetMouseButtonDown(0) && !isDead)
        {
            // Use rb.velocity (or linearVelocity in newer Unity 6 versions)
            rb.linearVelocity = Vector2.up * speed;
        }
    }

    // This method is called when the bird hits the pipes or the ground
   private void OnCollisionEnter2D(Collision2D other)
{
    isDead = true;
    // Using FindFirstObjectByType to fix the warning
    Object.FindFirstObjectByType<GameManager>().GameOver();
}
}
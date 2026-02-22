using UnityEngine;

public class Obstacles : MonoBehaviour
{
    public float speed = 1.0f;

    private void FixedUpdate()
    {
        // Moves the pipes to the left every frame
        transform.position += ((Vector3.left * speed) * Time.deltaTime);
    }
}
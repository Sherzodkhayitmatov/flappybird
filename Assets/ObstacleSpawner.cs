using UnityEngine;

public class ObstaclesSpawner : MonoBehaviour
{
    public float waitTime = 1.0f;
    private float time = 0f;
    public GameObject obstacles;
    public float direction; // to spawn the obstacles up and down

    void Update()
    {
        if (time > waitTime)
        {
            GameObject go = Instantiate(obstacles);
            go.transform.position = transform.position + new Vector3(0f, Random.Range(-direction, direction), 0f);
            
            Destroy(go, 5); // destroys the pipes after 5 seconds to save memory
            time = 0f;
        }
        if (!Object.FindFirstObjectByType<PlayerController>().isDead) {
    time += Time.deltaTime; 
}

        time += Time.deltaTime; // keep track of time regardless of frame rate
    }
}
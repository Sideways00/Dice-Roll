using UnityEngine;

public class EnemyFollow : MonoBehaviour
{
    public Transform player; // Reference to the player's transform
    public float speed = 5f; // Speed at which the enemy follows the player
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform; // Find the player by tag
    }

    // Update is called once per frame
    void Update()
    {
        if(player != null)
        {
            // Calculate the direction to the player
            Vector3 direction = (player.position - transform.position).normalized;
            // Move the enemy towards the player
            transform.position += direction * speed * Time.deltaTime;
        }
    }
}

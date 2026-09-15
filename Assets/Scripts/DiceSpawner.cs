using UnityEngine;

public class DiceSpawner : MonoBehaviour
{
    public GameObject dicePrefab; // Reference to the dice prefab
    public Transform spawnPoint; // Reference to the spawn point transform
    public float spawnTime = 5f; // Time interval between spawns
    public float throwForce = 10f; // Force applied to the dice when thrown
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("SpawnDice", 0f, spawnTime);
    }

    // Update is called once per frame
    void SpawnDice()
    {
        GameObject dice = Instantiate(dicePrefab, spawnPoint.position, spawnPoint.rotation);
        Rigidbody rb = dice.GetComponent<Rigidbody>();
        if (rb != null)
        {
            rb.AddForce(spawnPoint.forward * throwForce, ForceMode.Impulse);
        }
        Destroy(dice, 10f); // Destroy the dice after 10 seconds to prevent clutter
    }
}

using UnityEngine;

public class EnemyHP : MonoBehaviour
{
    public float health = 15f; // The maximum health of the enemy
    public float damage = 1f; // The amount of damage the enemy takes when hit by the sword
    public DiceRoll diceRoll; // Reference to the DiceRoll script
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }
    void Update()
    {
        // Check if the enemy's health is less than or equal to 0
        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }
    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.CompareTag("Sword"))
        {
            Debug.Log("Enemy hit by sword!" + other.gameObject.name);
            diceRoll.CheckDiceSides(); // Call the CheckDiceSides method from the DiceRoll script
            health -= diceRoll.swordDamage;
            Debug.Log("Enemy hit! Health: " + health);
            Debug.Log("Enemy took " + diceRoll.swordDamage + " damage from the sword.");
        }
    }
}

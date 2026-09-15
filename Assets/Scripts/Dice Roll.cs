using UnityEngine;

public class DiceRoll : MonoBehaviour
{
    public Transform[] diceSides; // Array to hold the transforms of the dice sides
    public int swordDamage; // Variable to hold the sword damage value
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void CheckDiceSides()
    {
        float highest = -1f; // Variable to hold the highest value found
        for (int i = 0; i < diceSides.Length; i++)
        {
            float dot = Vector3.Dot(Vector3.up, diceSides[i].up); // Calculate the dot product between the up vector and the current dice side's up vector
            if (dot > highest) // If the dot product is greater than the current highest value
            {
                highest = dot; // Update the highest value
                swordDamage = i + 1; // Set the sword damage to the index of the current dice side plus one
            }
        }
        Debug.Log("Sword Damage: " + swordDamage); // Log the sword damage value to the console
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

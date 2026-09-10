using UnityEngine;

public class Movement : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    
    public float speed = 0.01f; // Speed of the player movement


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.W))
        {
            transform.position += Vector3.forward * speed;
        }
        if(Input.GetKey(KeyCode.S))
        {
            transform.position += Vector3.back * speed;
        }
        if(Input.GetKey(KeyCode.A))
        {
            transform.position += Vector3.left * speed;
        }
        if(Input.GetKey(KeyCode.D))
        {
            transform.position += Vector3.right * speed;
        }
       
    }
}

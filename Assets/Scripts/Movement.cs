using UnityEngine;

public class Movement : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    
    public float speed = 0.01f; // Speed of the player movement
    public float jumpForce = 10f; // Force of the jump
    private bool grounded = true; // Whether the player is on the ground
    private Rigidbody rb; // Reference to the player's rigidbody

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
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
        if(Input.GetKey(KeyCode.Space) && grounded)
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            grounded = false;
        }
        void OnCollisionStay(Collision collision)
        {
            if(collision.gameObject.CompareTag("Ground"))
            {
                grounded = true;
            }
        }
    }
}

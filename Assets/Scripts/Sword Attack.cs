using UnityEngine;
using System.Collections;
public class SwordAttack : MonoBehaviour
{
    Vector3 startPosition;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        startPosition = transform.localPosition;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            transform.localPosition = startPosition + Vector3.forward * 3f;
        }
        if(Input.GetMouseButtonUp(0))
        {
            transform.localPosition = startPosition;
        }
    }
    
}

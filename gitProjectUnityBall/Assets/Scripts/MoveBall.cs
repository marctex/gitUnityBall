using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBall : MonoBehaviour
{
    private Rigidbody rb;
    public float velocity;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 move = new Vector3(Input.GetAxis("Horizontal"),0, Input.GetAxis("Vertical"));
        rb.AddForce(move * velocity);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("item"))
        {
            Destroy(other.gameObject);
        }
       
    }
}

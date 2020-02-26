using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionScript : MonoBehaviour
{
    public GameObject ball;
    public Rigidbody rb;
    public float force = 10.0F;

    // Start is called before the first frame update
    void Start()
    {
        ball = GameObject.FindWithTag("ball");
        rb = ball.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "ball")
        {
            rb.AddForce(transform.forward * force);
        }
    }
}

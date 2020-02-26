using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarAI : MonoBehaviour
{
    public GameObject ball;
    public float speed = 30.0F;
    float waitTime = 10.0f;
    float timePassed = 0.0f;
    bool waitTimer = false;
    bool pause = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        if(pause == false)
        {
            var lookPosition = new Vector3(ball.transform.position.x, this.transform.position.y, ball.transform.position.z);
            transform.LookAt(lookPosition);
            gameObject.transform.Translate(speed * Time.deltaTime * Vector3.forward);
        }
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "ball")
        {
            if (waitTimer)
            {
                pause = true;
                timePassed += Time.deltaTime;
                if (timePassed >= waitTime)
                {
                    timePassed = 0f;
                    waitTimer = false;
                    pause = false;
                }
            }
        }
    }
}

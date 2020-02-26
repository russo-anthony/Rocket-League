using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallFocus : MonoBehaviour
{
    public GameObject ball;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void LateUpdate()
    {
        transform.LookAt(ball.transform.position);
    }
}

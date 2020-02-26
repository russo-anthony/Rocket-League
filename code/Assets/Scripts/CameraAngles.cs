using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraAngles : MonoBehaviour
{
    public GameObject cam;
    public GameObject cameraPosition;
    public GameObject ballCamPosition;
    public GameObject player;
    public GameObject ball;
    public GameObject camFocus;

    private void Awake()
    {
        ball = GameObject.Find("Soccer Ball");
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ChangeFocus();
    }

    private void LateUpdate()
    {
        if(camFocus == player)
        {
            cam.transform.position = cameraPosition.transform.position;
            cam.transform.LookAt(player.transform.position);
        }

        if(camFocus == ball)
        {
            cam.transform.position = ballCamPosition.transform.position;
            cam.transform.LookAt(ball.transform.position);
        }
    }

    void ChangeFocus()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            if(camFocus == player)
            {
                camFocus = ball;
            }
            else
            {
                camFocus = player;
            }
        }
        
    }

    
}

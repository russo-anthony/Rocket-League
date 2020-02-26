using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 30.0F;
    public float angularSpeed = 1000.0F;
    public float jumpForce = 100.0F;
    public float boostForce = 2500.0F;
    public GameObject pRespawn;
    public GameObject bRespawn;
    public GameObject ball;
    public Rigidbody rb;
    public GameObject b1;
    public GameObject b2;
    public GameObject b3;
    public GameObject b4;
    public GameObject enemy1;
    public GameObject enemy2;
    public GameObject e1Respawn;
    public GameObject e2Respawn;
    public int boost = 0;
    public Text boostNum;
    float waitTime = 3.0f;
    float timePassed = 0.0f;
    bool boostTimer = false;



    void Awake()
    {
        //Debug.Log("Awake Called");
        pRespawn = GameObject.FindWithTag("pSpawn");
        bRespawn = GameObject.FindWithTag("bSpawn");
        ball = GameObject.FindWithTag("ball");
        rb = ball.GetComponent<Rigidbody>();
        boostNum.text = "Boost: " + boost.ToString();

    }
    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log("Start Called");

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && boost > 0)
        {
            boostTimer = true;
            boost--;
            boostNum.text = "Boost: " + boost.ToString();
        }

        if (boostTimer)
        {
            speed = 50.0F;
            timePassed += Time.deltaTime;
            if (timePassed >= waitTime)
            {
                timePassed = 0f;
                boostTimer = false;
                speed = 30.0F;
            }
        }

    }

    void FixedUpdate()
    {

        if (Input.GetKey(KeyCode.W))
        {
            gameObject.transform.Translate(speed * Time.deltaTime * Vector3.forward);
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(angularSpeed * Time.deltaTime * Vector3.down);
        }

        if (Input.GetKey(KeyCode.S))
        {
            gameObject.transform.Translate(speed * Time.deltaTime * Vector3.back);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(angularSpeed * Time.deltaTime * Vector3.up);
        }

        if (Input.GetKey(KeyCode.Space) && gameObject.transform.position.y < 1)
        {
            gameObject.GetComponent<Rigidbody>().AddForce(transform.up * jumpForce);
        }

        
    }

    public void Reset()
    {
        gameObject.transform.position = pRespawn.transform.position;
        gameObject.transform.rotation = pRespawn.transform.rotation;
        enemy1.transform.position = e1Respawn.transform.position;
        enemy2.transform.position = e2Respawn.transform.position;
        ball.transform.position = bRespawn.transform.position;
        rb.velocity = Vector3.zero;
        rb.angularVelocity = Vector3.zero;
        b1.SetActive(true);
        b2.SetActive(true);
        b3.SetActive(true);
        b4.SetActive(true);
        boost = 0;
        boostNum.text = "Boost: " + boost.ToString();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "boost")
        {
            boost++;
            boostNum.text = "Boost: " + boost.ToString();
            other.gameObject.SetActive(false);
        }
    }
}
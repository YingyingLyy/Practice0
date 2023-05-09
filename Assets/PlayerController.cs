using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public Rigidbody rb;
    public float moveSpeed;

    Vector3 input;
    Vector3 startPos;

    public int nextStageIndex;

    // Start is called before the first frame update
    void Start()
    {
        startPos = GetComponent<Transform>().position;
    }

    // Update is called once per frame
    void Update()
    {
        //Get input
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        input = new Vector3(h, 0, v).normalized;


    }

    private void FixedUpdate()
    {
        rb.velocity = input * moveSpeed ;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag != "Ground" && collision.gameObject.tag != "doorTrigger")
        {
            GetComponent<Transform>().position = startPos;
            
        }
       
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other . tag == "finalLine")
        {
            //to next stage
            SceneManager.LoadScene(nextStageIndex);
        }
    }

    public void Quit()
    {
        Application.Quit();
        print("a");
    }
        
}

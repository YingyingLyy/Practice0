using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTrigger : MonoBehaviour
{
    public GameObject door;
    public GameObject Button;
    private double h = -0.44;
    bool isActive;
  
    // Update is called once per frame
    void Update()
    {
        if(isActive && door.GetComponent<Transform>().position .y > h && Button.GetComponent<Transform>().position.y > h)
        {
            door.GetComponent<Transform>().position -= new Vector3(0, 0.3f * Time.deltaTime, 0);
            Button.GetComponent<Transform>().position -= new Vector3(0, 0.3f * Time.deltaTime, 0);
        }
    
    }

    private void OnTriggerEnter (Collider other)
    {
        if (other . tag == "Player")
        {
            //open door 
            isActive = true;
            

        }
    }
}

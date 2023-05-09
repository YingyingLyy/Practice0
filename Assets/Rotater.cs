using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotater : MonoBehaviour
{
    public float rotateSpeed;

    // Update is called once per frame
    void Update()
    {
        GetComponent<Transform>().Rotate(Vector3 . up ,rotateSpeed * Time.deltaTime );
    }
}

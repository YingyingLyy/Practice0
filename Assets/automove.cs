using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class automove : MonoBehaviour
{
    public List<GameObject> gameObjectList;
    private int index = 0  ;
    public float moveSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (index > gameObjectList.Count - 1)
        {
            index = 0 ;
        }
       transform . position =  Vector3.MoveTowards(transform.position, gameObjectList[index].transform.position,moveSpeed* Time.deltaTime);
       
        if(transform . position == gameObjectList[index].transform.position)
        {
            index++;
        }

    }
}

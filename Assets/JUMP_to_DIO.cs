using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JUMP_to_DIO : MonoBehaviour
{
    public GameObject goal;
    Vector3 direction;

    void Start()
    {
        direction = goal.transform.position - transform.position;
        this.transform.position = this.transform.position + direction;
        //this.transform.Translate(direction);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

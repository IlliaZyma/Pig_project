using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class normal_trip_to_THE_WOOORLD : MonoBehaviour
{
    public GameObject goal;
    Vector3 direction;
    float speed = 0.5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        direction = goal.transform.position - transform.position;
        if (direction.magnitude > 3)
        {
            Vector3 velocity = direction.normalized * speed;
            this.transform.position = this.transform.position + direction.normalized;
        }
        
    }
}

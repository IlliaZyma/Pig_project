using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MOVING_from_EGIPT : MonoBehaviour
{
    public GameObject goal;
    Vector3 direction;
    // Start is called before the first frame update
    void Start()
    {
        direction = goal.transform.position - transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position = this.transform.position + direction * 0.001f;
    }
}

using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Pipemobility : MonoBehaviour
{
    public float pipeSpeed = 5;
    // new variable for pipe speed
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (Vector3.left * pipeSpeed) * Time.deltaTime;
    }
}

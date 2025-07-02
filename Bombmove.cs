using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class Bombmove : MonoBehaviour
{
    public float bombspeed = 5;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (Vector3.left * bombspeed) * Time.deltaTime;
    }
}

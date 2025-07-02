using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class Pipeappearing : MonoBehaviour
{
    public GameObject Pipe;
    public float spawnRate = 3;

    private float timer = 0;
    public float heightOffset = 10;
   
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spawnPipe(); 
        // calls the function to spawn the pipe
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate)
        {
            timer = timer + Time.deltaTime;
            // so if the timer is less than the spawn rate it goes up by 1 per frame
        }
        else
        {
            spawnPipe(); 
            timer = 0;
            // if timer is equal to spawnrate then the pipe shall spawn
        }
       
    }

    void spawnPipe()
        // this is the function for making the pipe spawn, we could also do it by instantiatiing the function in start 
        // but thats not a good idea since we i needed to change that we would need to change it everywhere thats why i made this function and added the code down here in spawn pipe
    {
        float lowestPoint = transform.position.y - heightOffset;
        // thats the lowest point since we want to make it appear at diff heights
        float highestPoint = transform.position.y + heightOffset;
        // thats the heighest point
        Instantiate(Pipe, new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint), 0), transform.rotation );
    }
}

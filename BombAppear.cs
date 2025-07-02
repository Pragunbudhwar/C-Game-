using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class BombAppear : MonoBehaviour
{
    public GameObject Bomb;
    public float spawnRate = 6;

    private float timer = 0;
    public float heightOffset = 5;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
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
            Instantiate(Bomb, transform.position, transform.rotation); 
            timer = 0;
            // if timer is equal to spawnrate then the pipe shall spawn
        }
    }
}

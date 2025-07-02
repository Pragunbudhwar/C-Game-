using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CoinAppear : MonoBehaviour
{
    public GameObject Coin;
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
            coinappear();
            timer = 0;
            // if timer is equal to spawnrate then the pipe shall spawn
        }
    }
    public void coinappear()
    {
        float lowestPoint = transform.position.y - heightOffset;
        // thats the lowest point since we want to make it appear at diff heights
        float highestPoint = transform.position.y + heightOffset;
        // thats the heighest point
        Instantiate(Coin, new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint), 0), transform.rotation );
    }
}

using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class CoinMove : MonoBehaviour
{
    public float coinspeed = 5;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (Vector3.left * coinspeed) * Time.deltaTime;
        if (gameObject.layer == 6)
        {
            Destroy(gameObject);
        }
        if (gameObject.layer == 3)
        {
            Destroy(gameObject);
        }
    }
}

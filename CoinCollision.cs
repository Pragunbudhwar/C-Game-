using UnityEngine;

public class CoinCollision : MonoBehaviour
{
    public LogicandFunctionality logicA;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        logicA = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicandFunctionality>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 3)
        {
            logicA.addScore(2);
        }
        
    }
}

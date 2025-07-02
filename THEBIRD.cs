using UnityEngine;

public class THEBIRD : MonoBehaviour
{
    public Rigidbody2D myRigidBody;
    // THIS IS A REF SO THAT THE SCRIPT CAN TALK TO THE RIGID BODY 

    public float flapstrength;
    
    public LogicandFunctionality logic;

    // THE POWER BY WHICH THE BIRD WILL GO UP 
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicandFunctionality>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) == true) // BASICALLY IF THE SPACE BUTTON IS PRESSSED
        {
            myRigidBody.linearVelocity = Vector2.up * flapstrength; //VECTOR2UP IS SHORT HAND FOR 0,1
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == 6)
        logic.gameOver();
        
        if (collision.gameObject.layer == 8)
            logic.removeLife();
    }
    
}




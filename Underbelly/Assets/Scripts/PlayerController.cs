using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public bool hasCarrot;
    public float playerVelocity = 50.0f;
    public float movement = 0f;
    private Rigidbody2D rigidBody2D;
    

    Vector3 position;
    bool colliding;
    // Start is called before the first frame update
    void Start()
    {
        position = transform.position;
        hasCarrot = true;
        rigidBody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        movement = Input.GetAxis("Horizontal");

        rigidBody2D.velocity = new Vector2(movement * playerVelocity, rigidBody2D.velocity.y);
        //we are getting input from left/right arrow keys using the input axis system:

        //position.x += Input.GetAxis("Horizontal") * playerVelocity * Time.deltaTime;
            //"clamp" limits the value of a variable to a min or a max value:
            //position.x = Mathf.Clamp(position.x, -100f, 100f);
        


        //position.y += Input.GetAxis("Vertical") * playerVelocity * Time.deltaTime;
            //max speed of player will be 0.8 in the forward direction:
            //position.y = Mathf.Clamp(position.y, -100f, 100f);

         //transform.position = position;

        
    }

    private void OnTriggerEnter(Collider other)
    {

        colliding = true;

    }

}

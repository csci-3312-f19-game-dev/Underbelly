using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float playerVelocity = 5.0f;
    Vector3 position;

    // Start is called before the first frame update
    void Start()
    {
        position = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        //we are getting input from left/right arrow keys using the input axis system:
        position.x += Input.GetAxis("Horizontal") * playerVelocity * Time.deltaTime;
        //"clamp" limits the value of a variable to a min or a max value:
        position.x = Mathf.Clamp(position.x, -100f, 100f);

        position.y += Input.GetAxis("Vertical") * playerVelocity * Time.deltaTime;
        //max speed of player will be 0.8 in the forward direction:
        position.y = Mathf.Clamp(position.y, -100f, 100f);

        transform.position = position;
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankPlayerController : MonoBehaviour
{
    public float speed;

    public float turnSpeed;

    public float horizontalInput;

    public float verticalInput;




    // Update is called once per frame
    void Update()
    {

        //Move forward
        //transform.Translate(1,0);

        //transform.Translate(Vector2.right);

      //transform.Translate(Vector2.right * Time.deltaTime * speed);

        //Get Input from the User - Do this in Update()
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        //have player forward with vertical input
        transform.Translate(Vector2.right * Time.deltaTime * speed * verticalInput);

        //Rotate the player with horizontal input
        transform.Rotate(Vector3.back, turnSpeed * Time.deltaTime * horizontalInput);
    }
}

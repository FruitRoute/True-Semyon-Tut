using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody RB;
    public int playerSpeed;
    public float sideSpeed;

    void Start()
    {
        RB.useGravity = true;    
    }


    void FixedUpdate()
    {

        RB.AddRelativeForce(0, 0, playerSpeed*100*Time.deltaTime); //Constant Force

        if (Input.GetKey("d"))
        {
            RB.AddRelativeForce(sideSpeed * 100f * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("a"))
        {
            RB.AddRelativeForce(-sideSpeed * 100f * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if(RB.position.y < -1)
        {
            FindObjectOfType<GameManager>().EndGame();
            Debug.Log("Under -1");
        }

    }
   
}
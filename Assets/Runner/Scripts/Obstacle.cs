using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public PlayerMovement playerMovementScript;
    public GameObject playerObject;
    public Vector3 startPoint;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Obstacle")
        {
            playerMovementScript.enabled = false;
            Invoke("GameRestart", 2.0f);
            FindObjectOfType<GameManager>().EndGame();
            Debug.Log("On Obstacle");
        }
    }
}


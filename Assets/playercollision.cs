using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercollision : MonoBehaviour
{


    public PlayerMovementA move;
    
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "pasam")
        {
            Debug.Log("Game over");
            move.enabled = false;
            FindObjectOfType<gamemanager>().EndGame();
        }
        if (collision.collider.tag == "End")
        {
            Debug.Log("eND");
            move.enabled = false;
            FindObjectOfType<gamemanager>().CompleteGame();
        }
    }
    
}

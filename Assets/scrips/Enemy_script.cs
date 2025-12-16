using UnityEditor.Build.Content;
using UnityEngine;

public class Enemy_script : MonoBehaviour
{
    public scoreTracker scoreManager; // stores a refrance to the scoretraker instance in the scene

    public void OnCollisionEnter2D(UnityEngine.Collision2D collision) // detects a colision
    {

        if (collision.gameObject.CompareTag("CannonBall")) // only occurs after a colision with an instane of the canonball object
        {
            Debug.Log("Collision with: " + collision.gameObject.name); //debug log to show that the Cannonball and the enemy colided
             
            scoreManager.addScore(); // calls a method form a refrance that points to the scoreTracker
            Destroy(gameObject); // destroys the enemy object after it cloides with the cannonball       
        }
    }
}

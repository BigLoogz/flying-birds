using UnityEngine;
using UnityEngine.SceneManagement;

public class block_script : MonoBehaviour    
{
    private int counter = 0; // stores a counter in a variable so that every time an instance of a block colides with an instance of a cannonball the counter goes up
    public void OnCollisionEnter2D(UnityEngine.Collision2D collision)// detects a colision
    {
        if (collision.gameObject.CompareTag("CannonBall")) // only occurs after a colision with an instane of the canonball object
        {
            counter++; //counter goes up one
            if (counter == 3) //once the counter reaches 3 (the instance has colided with a cannonball 3 times)
            {
                Destroy(gameObject); //the instance gets deystored this is useful if the enemy is buried underneth or protected by blocks, so now the player can hit the eneny
            }
        }
    }
}

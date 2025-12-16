using Unity.VisualScripting;
using UnityEngine;

public class CannonBall_Script : MonoBehaviour
{
    private Rigidbody2D body;
    private float timer = 8f; // creates a timer a soon as the instance is created 

    void Start()
    {
        body = GetComponent<Rigidbody2D>(); // defines a Rigidbody class object as this objects current rigidbody

        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition); // gets the coordanates of the mouse and then chnages it from its postion on the screen to a postion the scene

        System.Random rand = new(); // allows for a random number to be created from rand

        body.AddForce( new Vector2(10, mousePos.y - transform.position.y) * rand.Next(1,5), ForceMode2D.Impulse );
        // ^ aplies a randmonised force to the ridgid body in the direction of the mouses position as soon as this the instance is created, the forceMode is set to impulse to imatate a projectile being fired^
    }

    void Update()
    {
        timer = timer - Time.deltaTime; // deacreses the timer by one each second for a total of 8 seconds

        if (timer <= 0) { Object.Destroy(this.gameObject); } // once the timer reaches 0 the object is destroyed so that the scene is not overloaded with cannonballs
    }
}

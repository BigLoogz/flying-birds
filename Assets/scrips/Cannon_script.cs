using System.Net.NetworkInformation;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UIElements;

public class Cannon_script : MonoBehaviour
{
    private float recharge = 0; // a timer used to increase time between each shot
    private Rigidbody2D body;
    public GameObject objectToSpawn; // stores the cannonBall object so that it can be spawned later 


    void Start()
    {
        body = GetComponent<Rigidbody2D>(); // defines a Rigidbody class object as this objects current rigidbody
    }

    void Update()
    {
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);  // gets the coordanates of the mouse and then chnages it from its postion on the screen to a postion the scene
        float angle = Mathf.Atan2(mousePos.y - transform.position.y, mousePos.x - transform.position.x) * Mathf.Rad2Deg;
        // ^ uses tan and the distance between the mouse and the cannon obgect in both axis to get the angle in radians and then convets to an angle in degrees and then stores tha anlgle in a variable^

        body.rotation = angle; //sets the rotation of the ridgid body to the angle variable 
        
        if (Input.GetKeyDown(KeyCode.Space) && recharge <= 0) // detects that the user has presed the space bar and the reacharge isnt on a timer
        {
            Debug.Log("CannonBall Fired"); // debug log to show that a cannonball was fired 
            Instantiate(objectToSpawn, transform.position, transform.rotation); // Instantiates a cannonball object at the cannon objects position and rortion

            recharge = 3; //starts the timer for 3 seconds
        }
        recharge -= Time.deltaTime; // decares the timer by one each second
    }
}

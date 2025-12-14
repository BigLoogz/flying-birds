using UnityEngine;

public class Bird_script : MonoBehaviour
{
    private bool fired = false;
    private Rigidbody2D body;
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        bool key = Input.GetKeyDown(KeyCode.Space);
        if (key == true && fired == false)
        {
            fire();
        }
        key = false;
    }

    void fire()
    {
        System.Random rand = new();
        body.AddForce(Vector2.right * rand.Next(10,100), ForceMode2D.Impulse);
    }
}

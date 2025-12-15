using Unity.Mathematics;
using UnityEngine;
using UnityEngine.UIElements;

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
            body.gravityScale = 1;
            fired = true;
        }
        key = false;

        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 objPos = transform.position;

        float angle = Mathf.Atan2(mousePos.y - objPos.y, mousePos.x - objPos.x) * Mathf.Rad2Deg;
        body.rotation = angle;

        void fire()
        {
            System.Random rand = new();
            body.AddForce(Vector2.right * rand.Next(10, 100), ForceMode2D.Impulse);
        }
    }
}

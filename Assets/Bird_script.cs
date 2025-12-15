using Unity.Mathematics;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UIElements;

public class Bird_script : MonoBehaviour
{
    private bool fired = false;
    private Rigidbody2D body;
    Vector2 objPos = new Vector2(-5f,-1f);


    void Start()
    {
        body = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        if (!fired)
        {
            
            float angle = Mathf.Atan2(mousePos.y - objPos.y, mousePos.x - objPos.x) * Mathf.Rad2Deg;
            body.rotation = angle;
        }


        bool key = Input.GetKeyDown(KeyCode.Space);
        if (key == true && fired == false)
        {
            fire(mousePos);
            body.gravityScale = 1;
            fired = true;
        }
        key = false;

        if (Input.GetKeyDown(KeyCode.R) && fired == true)
        {
            body.angularVelocity = 0;
            body.linearVelocity = new Vector2(0,0);
            body.position = objPos;
            body.gravityScale = 0;
            fired = false;
        }

    }

    void fire(Vector2 dir)
    {
        System.Random rand = new();
        if (dir.x < 0) { dir.x = dir.x * -1; }

        body.AddForce( new Vector2(dir.x, dir.y) * rand.Next(500,1000));
    }
}

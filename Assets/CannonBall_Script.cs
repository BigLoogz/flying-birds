using UnityEngine;

public class CannonBall_Script : MonoBehaviour
{
    private Rigidbody2D body;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
        body.position = new Vector2(-8, -3);

        Vector2 dir = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        System.Random rand = new();
        
        if (dir.x < 0) { dir.x = dir.x * -1; }
        body.AddForce(new Vector2(dir.x, dir.y) * rand.Next(500, 1000));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

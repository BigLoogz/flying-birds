using Unity.VisualScripting;
using UnityEngine;

public class CannonBall_Script : MonoBehaviour
{
    private Rigidbody2D body;
    private float timer = 8f;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        System.Random rand = new();
        body.AddForce( new Vector2(10, mousePos.y - transform.position.y) * rand.Next(1,5), ForceMode2D.Impulse );  
    }

    // Update is called once per frame
    void Update()
    {
        timer = timer - Time.deltaTime;
        if (timer <= 0) { Object.Destroy(this.gameObject); }
    }
}

using UnityEngine;

public class Enemy_script : MonoBehaviour
{
    private Rigidbody2D body;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnCollisionEnter2D(UnityEngine.Collision2D collision)
    {
        Debug.Log("Collision with: " + collision.gameObject.name);

        if (collision.gameObject.CompareTag("CannonBall"))
        {
            Destroy(gameObject);
        }
    }
}

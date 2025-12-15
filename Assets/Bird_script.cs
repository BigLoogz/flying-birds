using Unity.Mathematics;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UIElements;

public class Bird_script : MonoBehaviour
{
    private bool fired = false;
    private Rigidbody2D body;
    Vector2 objPos = new Vector2(-5f,-1f);
    public GameObject objectToSpawn;


    void Start()
    {
        body = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        float angle = Mathf.Atan2(mousePos.y - objPos.y, mousePos.x - objPos.x) * Mathf.Rad2Deg;
        body.rotation = angle;
        

        if (Input.GetKeyDown(KeyCode.Space) && fired == false)
        {
            fire();
        }

    }

    void fire()
    {
        Instantiate(objectToSpawn);
    }
}

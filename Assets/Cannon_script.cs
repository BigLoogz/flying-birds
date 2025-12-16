using Unity.Mathematics;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UIElements;

public class Cannon_script : MonoBehaviour
{
    private float recharge = 0;
    private Rigidbody2D body;
    public GameObject objectToSpawn;


    void Start()
    {
        body = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        float angle = Mathf.Atan2(mousePos.y - transform.position.y, mousePos.x - transform.position.x) * Mathf.Rad2Deg;
        body.rotation = angle;
        
        if (Input.GetKeyDown(KeyCode.Space) && recharge <= 0)
        {
            Instantiate(objectToSpawn, transform.position, transform.rotation);
            recharge = 3;
        }
        recharge -= Time.deltaTime;


    }
}

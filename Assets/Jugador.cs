using UnityEngine;

public class Jugador : MonoBehaviour
{
    Rigidbody2D rb;
    public float speed;

    void Start()
    {
        rb =  GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        rb.linearVelocity = new Vector2(horizontal * speed, 0f);
    }
}

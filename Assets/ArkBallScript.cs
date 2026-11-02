using UnityEngine;

public class ArkBallScript : MonoBehaviour
{
    public Vector2 direccionInicial;
    Rigidbody2D rb;
    public float ballSpeed = 1.0f;
    public gameoverpa perder;
    public AudioSource audioSource;
    public AudioClip reboteSound, ladrilloSound, paredSound, muerteSound;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        direccionInicial.x = Random.Range(-3, 3);
        direccionInicial.y = 6;
        rb.linearVelocity = direccionInicial.normalized * ballSpeed;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Piso Muerte"))
        {
            perder.ActivarPanel();
        }

        if (collision.gameObject.CompareTag("Ladrillo"))
        {
            audioSource.PlayOneShot(ladrilloSound);
        }
        else if (collision.gameObject.CompareTag("Pared"))
        {
            audioSource.PlayOneShot(paredSound);
        }
        else if (collision.gameObject.CompareTag("Jugador"))
        {
            audioSource.PlayOneShot(reboteSound);
        }
        else if (collision.gameObject.CompareTag("Piso Muerte"))
        {            
            audioSource.PlayOneShot(muerteSound);
        }
    }

}


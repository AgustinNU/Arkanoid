using UnityEngine;

public class LadrillosScript : MonoBehaviour
{
    int puntaje = 10;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Ball"))
        {
            FindAnyObjectByType<GameManager>().CheckLevelComplete();
            PuntajeScript.instance.SumarPuntos(puntaje);
            Destroy(gameObject);
        }
    }
}

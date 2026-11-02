using UnityEngine;
using TMPro;

public class PuntajeScript : MonoBehaviour
{
    public static PuntajeScript instance;
    public TextMeshProUGUI textoPuntaje;
    private int puntos = 0;

    private void Awake()
    {
        instance = this;
    }

    void Start()
    {
        ActualizarTexto();
    }

    public void SumarPuntos(int cantidad)
    {
        puntos += cantidad;
        ActualizarTexto();
    }

    void ActualizarTexto()
    {
        textoPuntaje.text = "PUNTUACION: " + puntos;
    }
}

using UnityEngine;

public class Pausa : MonoBehaviour
{

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.P))
        {
            Time.timeScale = 0f;
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            Time.timeScale = 1f;
        }
    }
}

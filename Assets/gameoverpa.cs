using UnityEngine;
using UnityEngine.SceneManagement;

public class gameoverpa : MonoBehaviour
{
    void Start()
    {
        gameObject.SetActive(false);    
    }
    public void ActivarPanel()
    {
        gameObject.SetActive(true);
        Time.timeScale = 0f;
    }

    public void Resetear()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}

using System.Threading;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Timeline;

public class GameManager : MonoBehaviour
{
    public void CheckLevelComplete()
    {
        if (transform.childCount <= 1)
        {
            // Load the next level
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameHasEnded=false;
    public float restartDelay = 1f;

    public GameObject completeLevelUI;
    public void EndGame()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("Game Over!");
            // B�ylece d��erken sadece bir kez Game Over! yazacakt�r.
            // Birden fazla Game Over! yazmas�n�n sebebi ise bu metodun FixedUpdate metodu i�inde de �a��r�lmas�d�r.
            Invoke("Restart", restartDelay); // Restart() metodunu �al��t�r�rken restartDelay kadar bekletir. Hemen �al��t�rmaz.
        }
    }

    public void completeLevel()
    {
        completeLevelUI.SetActive(true);
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}

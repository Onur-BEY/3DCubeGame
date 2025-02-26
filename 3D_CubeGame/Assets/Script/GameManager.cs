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
            // Böylece düşerken sadece bir kez Game Over! yazacaktır.
            // Birden fazla Game Over! yazmasının sebebi ise bu metodun FixedUpdate metodu içinde de çağırılmasıdır.
            Invoke("Restart", restartDelay); // Restart() metodunu çalıştırırken restartDelay kadar bekletir. Hemen çalıştırmaz.
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

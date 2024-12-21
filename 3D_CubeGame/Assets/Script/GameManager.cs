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
            // Böylece düþerken sadece bir kez Game Over! yazacaktýr.
            // Birden fazla Game Over! yazmasýnýn sebebi ise bu metodun FixedUpdate metodu içinde de çaðýrýlmasýdýr.
            Invoke("Restart", restartDelay); // Restart() metodunu çalýþtýrýrken restartDelay kadar bekletir. Hemen çalýþtýrmaz.
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

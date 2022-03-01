using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject gameOverCanvas;

    private void Start()
    {
        // start the game
        Time.timeScale = 1;
    }

    public void GameOver()
    {
        // show gameOverCanvas
        gameOverCanvas.SetActive(true);
        
        // pause the game
        Time.timeScale = 0;
    }

    public void Restart()
    {
        SceneManager.LoadScene(0);
    }

}

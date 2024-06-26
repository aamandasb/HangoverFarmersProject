using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject gameOverUI;

    public void updateScene(string Main)
    {
        SceneManager.LoadScene(Main);
    }
    public void doExitGame()
    {
        Application.Quit();
    }

    public void gameOver()
    {
        gameOverUI.SetActive(true);
    }

    public void voltar (string FarmHub)
    {
        SceneManager.LoadScene(FarmHub);
    }

}

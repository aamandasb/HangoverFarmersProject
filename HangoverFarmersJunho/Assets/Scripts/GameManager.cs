using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
<<<<<<< Updated upstream
    public GameObject gameOverUI;

    public void updateScene(string Main)
=======

    public void updateScene(string main) 
>>>>>>> Stashed changes
    {
        SceneManager.LoadScene(main);
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

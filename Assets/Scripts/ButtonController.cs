using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonController : MonoBehaviour
{

    public GameObject pauseScreen;

    public void loadMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void playAgain()
    {
        SceneManager.LoadScene("Gameplay");
    }

    public void pauseGame()
    {
        Time.timeScale = 0;
        pauseScreen.SetActive(true);
    }

    public void resumeGame()
    {
        Time.timeScale = 1;
        pauseScreen.SetActive(false);
    }
}

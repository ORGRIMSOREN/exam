using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Pause : MonoBehaviour
{
    public static bool GamePause = false;
    public GameObject pausemenu;
    
    

    public void resume()
    {
        pausemenu.SetActive(false);
        Time.timeScale = 1f;
        GamePause = false;
    }
    public void pausegame()
    {
        pausemenu.SetActive(true);
        Time.timeScale = 0f;
        GamePause = true;
    }
    public void loadmenu()
    {
        SceneManager.LoadScene("開始畫面");
    }
    public void quitgame()
    {
        Application.Quit();
    }
}

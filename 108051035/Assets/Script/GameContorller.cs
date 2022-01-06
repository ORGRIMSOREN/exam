using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameContorller : MonoBehaviour
{
    
    public GameObject gameOverText;
    public GameObject books;
    private void Start()
    {
        gameOverText.SetActive(false);
    
    }
    //重來
    public void GameOver()
    {
        gameOverText.SetActive(true);
    }
    private void Update()
    {
        if (gameOverText.activeSelf == true)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                SceneManager.LoadScene("遊戲場景");
                
            }
            else
            {
                SceneManager.LoadScene("Boss場景");
            }
        }
        
    }
}

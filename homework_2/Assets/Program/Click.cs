using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Click : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }
    public void QuitGame()
    {
        Application.Quit();
    }
    public void BackMenu()
    {
        SceneManager.LoadScene(0);
    }
    public void ChangeMenu()
    {
        SceneManager.LoadScene(2);
    }
}

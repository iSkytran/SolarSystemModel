using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuHandler : MonoBehaviour
{
    public void OnStart()
    {
        SceneManager.LoadScene("Game");
    }

    public void OnQuit()
    {
        Application.Quit();
    }
}

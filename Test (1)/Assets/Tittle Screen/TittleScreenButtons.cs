using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TittleScreenButtons : MonoBehaviour
{

    public void StartButton()
    {
        SceneManager.LoadScene(2);
    }
    public void SettingsButton()
    {
        SceneManager.LoadScene(1);
    }
    public void exitButton()
    {
        Application.Quit();
    }
}

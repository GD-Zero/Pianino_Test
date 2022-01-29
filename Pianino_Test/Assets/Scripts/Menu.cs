using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void LoadL1()
    {
        SceneManager.LoadScene(1);
    }

    public void LoadL2()
    {
        SceneManager.LoadScene(2);
    }

    public void LoadL3()
    {
        SceneManager.LoadScene(3);
    }

    public void Exit()
    {
        Application.Quit();
    }
}

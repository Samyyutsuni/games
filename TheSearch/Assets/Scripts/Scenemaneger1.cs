using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.SceneManagement;

public class Scenemaneger1 : MonoBehaviour
{

    // Use this for initialization
    public void gotoFase1()
    {
        SceneManager.LoadScene(1);
    }

    public void gotoMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void gotoWiner()
    {
        SceneManager.LoadScene(2);
    }

    public void exitgame()
    {
        Application.Quit();
    }

}

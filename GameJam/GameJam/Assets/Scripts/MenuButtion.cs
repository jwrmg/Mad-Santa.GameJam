﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButtion : MonoBehaviour
{
    public void PlayGame (string name)
    {
        SceneManager.LoadScene(name);
    }
    public void QuitGame()
    {
        Application.Quit();
    }

}

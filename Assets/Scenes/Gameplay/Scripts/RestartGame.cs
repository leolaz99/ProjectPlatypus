﻿using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartGame : MonoBehaviour
{
    public void RestartLevel()
    {
        SceneManager.LoadScene(0);
    }
}

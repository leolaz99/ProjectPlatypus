using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenPause : MonoBehaviour
{
    [SerializeField] KeyCode pauseKey;

    void Update()
    {
        if (Input.GetKeyDown(pauseKey) && PauseManager.instance.isIntroEnd == true)
        {
            PauseManager.instance.OpenClosePause();
        }
          
    }
}

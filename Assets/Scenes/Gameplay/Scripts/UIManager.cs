﻿using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] Image heart1;
    [SerializeField] Image heart2;
    [SerializeField] Image heart3;

    void Update()
    {
        if (PlayerLife.instance.life == 2)
            heart3.gameObject.SetActive(false);

        if (PlayerLife.instance.life == 1)
            heart2.gameObject.SetActive(false);

        if (PlayerLife.instance.life == 0)
            heart1.gameObject.SetActive(false);
    }
}

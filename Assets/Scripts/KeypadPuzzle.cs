using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeypadPuzzle : MonoBehaviour
{
    public int[] code;

    int currentIndex;
    bool isFinished;
    [SerializeField] Light greenLight;
    [SerializeField] Light redLight;
    float redLightTimer;
    public GameObject key;

    public void Start()
    {
        greenLight.enabled = false;
        key.SetActive(false);
    }

    public void Update()
    {
        if (redLightTimer > 0)
        {
            redLight.enabled = true;
            redLightTimer -= Time.deltaTime;
        }
        else
        {
            redLight.enabled = false;
        }
    }

    public void OnPress(int number)
    {
        if (isFinished)
        {
            return;
        }
           

        if (code[currentIndex] == number)
        {
            if (++currentIndex == code.Length)
            {
                isFinished = true;

                greenLight.enabled = true;
                key.SetActive(true);
            }
        }
        else
        {
            redLightTimer = 1f;
            currentIndex = 0;
        }
    }
}


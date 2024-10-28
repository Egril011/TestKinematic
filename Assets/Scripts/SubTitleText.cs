using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SubTitleText : MonoBehaviour
{
    public Image fadeBackGround;
    public TMP_Text message;
    private float messageTimer;

    internal void ShowText(string text, float time)
    {
        message.text = text;
        fadeBackGround.enabled = true;
        messageTimer = time;
    }

    internal void ShowText(string text)
    {
        ShowText(text, text.Length * 0.25f);
    }


    public void Update() 
    {
        if (messageTimer > 0)
        {
            messageTimer -= Time.deltaTime;
            if (messageTimer < 0)
            {
                Clear();
            }
        }


    void Start()
    {
        Clear() ;
    }
}

    private void Clear()
    {
        fadeBackGround.enabled = false;
        message.text = "";
    }
}

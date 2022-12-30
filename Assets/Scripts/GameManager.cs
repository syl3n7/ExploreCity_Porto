using System;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : Buttons
{
    private float lastWidth;
    private float lastHeight;

    void Start()
    {
        Screen.SetResolution(1080, 1920, false, 60);
    }

    void Update()
    {
        SetRatio(9, 16);
    }
    
    void SetRatio(float w, float h) //function to set the ratio of the screen to maintain the aspect of the resolution asked by the teacher (1080x1920)
    {
        if ((((float)Screen.width) / ((float)Screen.height)) > w / h)
        {
            Screen.SetResolution((int)(((float)Screen.height) * (w / h)), Screen.height, false);
        }
        else
        {
            Screen.SetResolution(Screen.width, (int)(((float)Screen.width) * (h / w)), false);
        }
    }
}

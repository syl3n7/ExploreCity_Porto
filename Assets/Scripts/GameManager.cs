using System;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    public Button dealButton;
    public Player player, dealer;
    
    private float lastWidth;
    private float lastHeight;


    void Start()
    {
        GameObject.Find("Deck").GetComponent<Deck>().Shuffle();
        dealButton.onClick.AddListener(() => Deal());
        Screen.SetResolution(1080, 1920, false, 60);
        
    }

    void Update()
    {

        SetRatio(9, 16);

    }

    private void Deal()
    {
        player.GetHand();
        dealer.GetHand();
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

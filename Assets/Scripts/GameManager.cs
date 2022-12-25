using System;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    public Button dealButton;
    public Player player, dealer;


    void Start()
    {
        GameObject.Find("Deck").GetComponent<Deck>().Shuffle();
        dealButton.onClick.AddListener(() => Deal());
    }

    void Update()
    {
        
    }

    private void Deal()
    {
        player.GetHand();
        dealer.GetHand();
    }
}

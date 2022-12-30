using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// This script is used in both the player and the dealer!!

public class Player : MonoBehaviour
{
    /*
    // Get other scripts
    public Card card;   
    public Deck deck;

    // Total value of player/dealer's hand
    public int handValue = 0;

    // Betting money
    private int money = 1000;

    // Player's Hand
    public GameObject[] hand;

    // Index of the next card (Hit button)
    public int cardIndex = 0;

    // AceList to switch the value of the aces when needed
    List<Card> aceList = new List<Card>();

    public void GetHand()
    {
        GetCard();
        GetCard();
    }


    // Add a hand to the player/dealer's hand
    public int GetCard()
    {
        // Get a card, use deal card to assign sprite and value to card on table
        int cardValue = deck.DealCard(hand[cardIndex].GetComponent<Card>());

        hand[cardIndex].GetComponent<Renderer>().enabled = true;

        // Add card value to running total of the hand
        handValue += cardValue;

        // If value is 1, it is an ace
        if(cardValue == 1)
        {
            aceList.Add(hand[cardIndex].GetComponent<Card>());
        }

        cardIndex++;
        return handValue;
    }
    */
}

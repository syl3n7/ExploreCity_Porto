using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deck : MonoBehaviour
{
    /*
    public Sprite[] cardSprites;
    protected int[] cardValues = new int[53];
    private int currentIndex = 0;

    void Start()
    {
        AssignCardValues();
    }

    void AssignCardValues() 
    {
        int num = 0;

        // loop trough all the cards
        for (int i = 0; i < cardSprites.Length; i++)
        {
            num = i;

            num %= 13;

            // if there's a remainder after the division then use the remainder unless  it's bigger than 10, in that case use 10
            if (num > 10 || num == 0)
            {
                num = 10;
            }

            cardValues[i] = num++;
        }
    }

    //https://stackoverflow.com/questions/13766209/efficient-swapping-of-elements-of-an-array-in-kava
    public void Shuffle()
    {
        for(int i = cardSprites.Length -1; i > 0; --i)
        {
            int k = Mathf.FloorToInt(Random.Range(0.0f, 1.0f) * cardSprites.Length - 1) + 1;

            Sprite face = cardSprites[i];
            cardSprites[i] = cardSprites[k];
            cardSprites[k] = face;

            int value = cardValues[i];
            cardValues[i] = cardValues[k];
            cardValues[k] = value;
        }

        currentIndex = 1;
    }

    public int DealCard(Card card)
    {
        // the cards are already shuffled :)
        card.SetSprite(cardSprites[currentIndex]);
        card.SetValue(cardValues[currentIndex]);

        currentIndex++;

        // to keep track of player's points
        return card.GetValue();
    }

    public Sprite GetCardBack()
    {
        //index 0 always contains the back of the card
        return cardSprites[0];
    }
    */
}

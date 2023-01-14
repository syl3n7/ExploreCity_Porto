using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.AI;

public class Player
{
    int money = 0;
    int tickets = 0;
    string name = null;
    string region = null;
    protected Sprite hat;
    protected Sprite head;
    protected Sprite eyes;
    protected Sprite mouth;
    protected Sprite legs;
    protected Sprite feet;
    
    Player(/*int money, int tickets, */ string name, string region)
    {
        money = 0;
        tickets = 5; //default 5 tickets at begginig of game
        this.name = name;
        this.region = region;
        hat = Resources.Load<Sprite>("Logos/github.png");
        head = Resources.Load<Sprite>("Logos/github.png");
        eyes = Resources.Load<Sprite>("Logos/github.png");
        mouth = Resources.Load<Sprite>("Logos/github.png");
        legs = Resources.Load<Sprite>("Logos/github.png");
        feet = Resources.Load<Sprite>("Logos/github.png");
    }

    public int AddMoney(int moneyToAdd)
    {
        money += moneyToAdd;

        return money;
    }

    //develop the rest of the player later today
}

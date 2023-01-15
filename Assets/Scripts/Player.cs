using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Experimental.AI;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    int _money = 0;
    int _tickets = 0; 
    double _level = 0;
    string _name = null;
    string _region = null;
    

    public Player(int m, int t, string n, string r)
    {
        _money = m;
        _tickets = t;
        _level = 1;
        _name = n;
        _region = r;
    }

    public int AddMoney(int moneyToAdd)
    {
        _money += moneyToAdd;
        _level += 0.3f;
        return _money;
    }

    public int AddTickets(int ticketsToAdd)
    {
        _tickets += ticketsToAdd;
        _level += 0.2f;
        return _tickets;
    }
    
    public string ChangeRegion(string regionToChangeTo)
    {
        _region = regionToChangeTo;
        PlayerPrefs.SetString("Region", regionToChangeTo);
        PlayerPrefs.Save();
        return _region;
    }

    public void NameChange(string nameToChangeTo)
    {
        _name = nameToChangeTo;
        PlayerPrefs.SetString("Name", nameToChangeTo);
        PlayerPrefs.Save();
        //return _name;
    }

    public Image ChangeColor(Image spriteToChange, Color newColor) // lembrar que sao dois argumentos para passsar
    {
        spriteToChange.color = newColor;

        return spriteToChange;
    }

    public void cleanPrefs()
    {
        PlayerPrefs.DeleteAll();
    }
}

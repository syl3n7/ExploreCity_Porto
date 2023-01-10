using System;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : Buttons
{
    

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void Logout()
    {
        PlayerPrefs.DeleteAll();
        SceneManager.LoadScene("LoginScreen");
    }
}

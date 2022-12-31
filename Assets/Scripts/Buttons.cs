using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Buttons : MonoBehaviour
{

    public TMP_Text pname;
    public TMP_Text region;
    public TMP_Text money;
    public TMP_Text tickets;
    public TMP_Text level;
    public TMP_Text rank;
    public TMP_Text xp;
    public TMP_Text gamesplayed;

    RangeInt r = new RangeInt();

    void Start()
    {
        string currentScene = SceneManager.GetActiveScene().ToString();
        if (currentScene == "MainMenu")
        {
            ReadUserInfo();
        }

        if (currentScene == "LoginScreen")
        {
            if (PlayerPrefs.GetString("PlayerName") != "" && PlayerPrefs.GetString("PlayerRegion") != "")
            {
                SceneManager.LoadScene("MainMenu");
            }
        }
    }

    public void LoadScene(string sCene)
    {
        SceneManager.LoadScene(sCene);
    }

    public void ReadUserInfo()
    {
        pname.text = PlayerPrefs.GetString("PlayerName");
        //region.name = PlayerPrefs.GetString("PlayerRegion");
    }

    public void SavePlayerNameRegion()
    {
        PlayerPrefs.SetString("PlayerName", pname.text);
        PlayerPrefs.SetString("PlayerRegion", region.text);
        Debug.Log(PlayerPrefs.GetString("PlayerName") + "\n" + PlayerPrefs.GetString("PlayerRegion"));
        PlayerPrefs.Save();
    }

    public void GenerateSaveGuest()
    {
        PlayerPrefs.SetString("PlayerName", "Player0" + r.ToString());
        PlayerPrefs.SetString("PlayerRegion", "WorldWide");
        Debug.Log(PlayerPrefs.GetString("PlayerName") + "\n" + PlayerPrefs.GetString("PlayerRegion"));
        PlayerPrefs.Save();
    }

    public void Expand(ContentSizeFitter content) { content.verticalFit = ContentSizeFitter.FitMode.PreferredSize; }

    public void Collapse(ContentSizeFitter content) { content.verticalFit = ContentSizeFitter.FitMode.MinSize; }
    
    public void ExitGame()
    {
        Application.Quit();
    }
}

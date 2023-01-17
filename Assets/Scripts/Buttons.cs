using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Buttons : MonoBehaviour
{
    public TMP_Text money;
    public TMP_Text tickets;
    public TMP_Text level;
    public TMP_Text rank;
    public TMP_Text xp;
    public TMP_Text gamesplayed;

    // RangeInt r = new RangeInt();
    
    // public void LoadScene(string sCene)
    // {
    //     SceneManager.LoadScene(sCene);
    // }

    // public void GenerateSaveGuest()
    // {
    //     string p = "Player0" + r.ToString();
    //     PlayerPrefs.SetString("PlayerName", p);
    //     string region = "Worldwide";
    //     PlayerPrefs.SetString("PlayerRegion", region);
    //     Debug.Log(PlayerPrefs.GetString("PlayerName") + "\n" + PlayerPrefs.GetString("PlayerRegion"));
    //     PlayerPrefs.Save();
    // }

    public void Expand(ContentSizeFitter content) { content.verticalFit = ContentSizeFitter.FitMode.PreferredSize; }

    public void Collapse(ContentSizeFitter content) { content.verticalFit = ContentSizeFitter.FitMode.MinSize; }
    
    public void ExitGame()
    {
        Application.Quit();
    }
}

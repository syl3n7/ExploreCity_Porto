using System;
using TMPro;
using UnityEditor;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;
using Button = UnityEngine.UI.Button;
using Image = UnityEngine.UI.Image;

public class GameManager : Buttons
{
    public GameObject panel;
    public BatteryStatus battery;
    public TMPro.TMP_InputField input;
    public TMPro.TMP_Text region_text;
    public Player p1;
    public TMPro.TMP_Text playername;
    public Image batteryimg;
    void Start()
    {
        p1 = new Player(1000,5, "placeholdername", "Worlwide");
    }

    void Update()
    {
        if (panel.activeSelf)
        {
            playername.text = PlayerPrefs.GetString("Name");
            
            if (battery == BatteryStatus.Charging) batteryimg.sprite = Resources.Load<Sprite>("bateriaCharging");
            else if (battery == BatteryStatus.Discharging) batteryimg.sprite = Resources.Load<Sprite>("bateriaDischarging");
            else batteryimg.sprite = Resources.Load<Sprite>("bateriaFull");
        }
    }
    
    public void SavePrefs()
    {
        p1.ChangeRegion(region_text.text);
        p1.NameChange(input.text);
        PlayerPrefs.Save();
    }

    public void LoadPrefs()
    {
        if (PlayerPrefs.HasKey("Money") && PlayerPrefs.HasKey("Region") && PlayerPrefs.HasKey("Name"))
        {
            p1.AddMoney(PlayerPrefs.GetInt("Money"));
            p1.ChangeRegion(PlayerPrefs.GetString("Region"));
            p1.NameChange(PlayerPrefs.GetString("Name"));
        }
    }

    public void Logout()
    {
        PlayerPrefs.DeleteAll();
        SceneManager.LoadScene("LoginScreen");
    }
}

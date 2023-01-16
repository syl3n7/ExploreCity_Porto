using System;
using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;
using Button = UnityEngine.UI.Button;
using Image = UnityEngine.UI.Image;
using Toggle = UnityEngine.UI.Toggle;

public class GameManager : Buttons
{
    public GameObject menuPanel;
    public BatteryStatus battery;
    public TMPro.TMP_InputField input;
    public TMPro.TMP_Text region_text;
    public Player p1;
    public TMPro.TMP_Text playername;
    public Image batteryimg;
    public GameObject toggleMusic;
    public GameObject toggleVibration;
    public GameObject CreateAccPanel;
    public GameObject LoginPanel;

    void Start()
    {
        p1 = new Player(1000,5, "placeholdername", "Worlwide");
    }

    void Update()
    {
        playername.text = PlayerPrefs.GetString("Name");
        //mudar a sprite da bateria de acordo com o que for o estado que o unity consegue entender, do equipamento onde a app corre.
        if (battery == BatteryStatus.Charging) batteryimg.sprite = Resources.Load<Sprite>("bateriaCharging");
        else if (battery == BatteryStatus.Discharging) batteryimg.sprite = Resources.Load<Sprite>("bateriaDischarging");
        else batteryimg.sprite = Resources.Load<Sprite>("bateriaFull"); // nao usar pasta Resources no futuro
    }
    public void Login()
    {
        if (PlayerPrefs.HasKey("Name")) menuPanel.SetActive(true);
        else
        {
            LoginPanel.SetActive(false);
            CreateAccPanel.SetActive(true);
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

    public void ToogleMusic() //alterar o estado do toggle da musica
    {
        Toggle TMtoggle = toggleMusic.GetComponentInChildren<Toggle>();
        Text TMtext = toggleMusic.GetComponentInChildren<Text>();
        Image TMimg = toggleMusic.GetComponentInChildren<Image>();
        if (!TMtoggle.isOn)
        {
            TMtext.text = "Desligado";
            TMimg.color = Color.red;

        }
        else
        {
            TMtext.text = "Ligado";
            TMimg.color = Color.blue;
        }
    }

    public void ToggleVibration()
    {
        Toggle TVtoggle = toggleVibration.GetComponentInChildren<Toggle>();
        Text TVtext = toggleVibration.GetComponentInChildren<Text>();
        Image TVimg = toggleVibration.GetComponentInChildren<Image>();
        if (!TVtoggle.isOn)
        {
            TVtext.text = "Desligado";
            TVimg.color = Color.red;
        }
        else
        {
            TVtext.text = "Ligado";
            TVimg.color = Color.blue;
        }
    }
    
}

using System.Net.Mime;
using System.Runtime.CompilerServices;
using System.Globalization;
using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : Buttons
{
    public GameObject menuPanel;
    public GameObject configsPanel;
    //public BatteryStatus battery;
    public TMPro.TMP_InputField input;
    public TMPro.TMP_Text region_text;
    public Player p1;
    public TMPro.TMP_Text playername;
    //public Image batteryimg;
    public GameObject toggleMusic;
    public GameObject toggleVibration;
    public GameObject CreateAccPanel;
    public GameObject LoginPanel;

    public int counterGamesPlayed;
    public int playerLevel;
    public int playerRank;
    public double playerXP;
    
    public AudioSource AudioSource;

    public Slider volumeSlider;

    //Value from the slider, and it converts to volume level
    private float volume = 0.3f;

    public Sprite Desativado;
    public Sprite Ativado;

    private int TicketsValue;
    private int TicketsAdd = 2;
    public TMP_Text TicketsText;
    public TMP_Text Tickets2Text;

    public Image card;

    public Sprite[] cardsFace;

    public Sprite[] cardsBack;

    private int ccounter;

    private int MoneyValue = 10;

    public TMP_Text MoneyText, MoneyText2;

    public Button[] StoreBttns;
    
    public void changeAvatarColor(Color color)
    {
        //colorImage.color = color;
    }
    
    void Start()
    {
        p1 = new Player(1000,5, "placeholdername", "Worlwide");
        volume = PlayerPrefs.GetFloat("volume");
        if (PlayerPrefs.HasKey("Name")) Login();
        AudioSource.volume = volume;
        volumeSlider.value = volume;
        StartCoroutine(AddTickets());
        TicketsValue = PlayerPrefs.GetInt("Tickets");
        MoneyValue = PlayerPrefs.GetInt("Money");
        TicketsText.text = PlayerPrefs.GetInt("Tickets").ToString();
        Tickets2Text.text = PlayerPrefs.GetInt("Tickets").ToString();
        MoneyText2.text = PlayerPrefs.GetInt("Money").ToString();
        MoneyText.text = PlayerPrefs.GetInt("Money").ToString();
    }

    void Update()
    {
        playername.text = PlayerPrefs.GetString("Name");
        
        // //mudar a sprite da bateria de acordo com o que for o estado que o unity consegue entender, do equipamento onde a app corre.
        // if (battery == BatteryStatus.Charging) batteryimg.sprite = Resources.Load<Sprite>("bateriaCharging");
        // else if (battery == BatteryStatus.Discharging) batteryimg.sprite = Resources.Load<Sprite>("bateriaDischarging");
        // else batteryimg.sprite = Resources.Load<Sprite>("bateriaFull"); // nao usar pasta Resources no futuro
        volume = volumeSlider.value;
        AudioSource.volume = volume;
        PlayerPrefs.SetFloat("volume", volume);

        TicketsText.text = TicketsValue.ToString();
        Tickets2Text.text = TicketsValue.ToString();
        PlayerPrefs.SetInt("Tickets", TicketsValue);

        MoneyText2.text = MoneyValue.ToString();
        MoneyText.text = MoneyValue.ToString();
        PlayerPrefs.SetInt("Money", MoneyValue);

        if (MoneyValue <= 0)
        {
            for (int i = 0; i < StoreBttns.Length; i++)
            {
                StoreBttns[i].interactable = false;
            }
        }
        else
        {
            for (int i = 0; i < StoreBttns.Length; i++)
            {
                StoreBttns[i].interactable = true;
            }
        } 
    }
    public void Login()
    {
        if (PlayerPrefs.HasKey("Name"))
        {
            menuPanel.SetActive(true);
            LoginPanel.SetActive(false);
            CreateAccPanel.SetActive(false);
        }
        else
        {
            menuPanel.SetActive(false);
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

    public void Logout()  //terminar sessao
    {
        PlayerPrefs.DeleteAll();
        menuPanel.SetActive(false);
        configsPanel.SetActive(false);
        LoginPanel.SetActive(true);
    }

    public void ToogleMusic() //alterar o estado do toggle da musica
    {
        Toggle TMtoggle = toggleMusic.GetComponentInChildren<Toggle>();
        Text TMtext = toggleMusic.GetComponentInChildren<Text>();
        Image TMimg = toggleMusic.GetComponentInChildren<Image>();
        if (!TMtoggle.isOn)
        {
            TMtext.text = "Desligado";
            TMimg.sprite = Desativado;
            AudioSource.mute = true;
        }
        else
        {
            TMtext.text = "Ligado";
            TMimg.sprite = Ativado;
            AudioSource.mute = false;
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
            TVimg.sprite = Desativado;
        }
        else
        {
            TVtext.text = "Ligado";
            TVimg.sprite = Ativado;
        }
    }
    
    public void volumeUpdater(float volumE)
    {
        volume = volumE;
    }

    public void Destroy(GameObject obj)
    {
        Destroy(obj);
    }

    public void AddMoney(int money)
    {
        MoneyValue += money;
        PlayerPrefs.Save();
        PlayerPrefs.Save();
    }

    public void RemoveTickets() //sempre que entrar num jogo perde 2 tickets.
    {
        TicketsValue -= TicketsAdd;
        PlayerPrefs.Save();
    }
    
    IEnumerator AddTickets()
    {
        yield return new WaitForSeconds(90);
        TicketsValue += TicketsAdd;
        StartCoroutine(AddTickets());
        PlayerPrefs.Save();
    }

    public void CallRevealCard()
    {
        StartCoroutine(Reveal());
    }
    
    IEnumerator Reveal()
    {
        yield return new WaitForSeconds(1.5f);
        card.color = new Color(255, 255, 255, 255);
        card.sprite = cardsFace[ccounter];
        yield return new WaitForSeconds(20);
        card.sprite = cardsBack[ccounter];
        ccounter++;
        yield return new WaitForSeconds(5);
        card.color = new Color(255, 255, 255, 0);
    }
}

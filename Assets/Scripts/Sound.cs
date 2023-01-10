using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sound : MonoBehaviour
{
    public AudioSource AudioSource;

    public Slider volumeSlider;

    //Value from the slider, and it converts to volume level
    private float volume = 1f;

    // Start is called before the first frame update
    void Start()
    {
        AudioSource.Play();
        volume = PlayerPrefs.GetFloat("volume");
        AudioSource.volume = volume;
        volumeSlider.value = volume;
    }

    // Update is called once per frame
    void Update()
    {
        AudioSource.volume = volume;
        PlayerPrefs.SetFloat("volume", volume);
    }

    public void volumeUpdater(float volumE)
    {
        volume = volumE;
    }
}

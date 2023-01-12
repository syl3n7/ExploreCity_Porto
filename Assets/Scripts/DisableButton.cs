using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;
using UnityEngine.UI;

public class DisableButton : MonoBehaviour
{
    public Button bt;
    public TMPro.TMP_Text text;

    public void Interactable()
    {
        bt.interactable = false;
        text.enabled = true;
    }
}

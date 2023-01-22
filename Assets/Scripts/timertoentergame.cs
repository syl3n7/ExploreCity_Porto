using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class timertoentergame : MonoBehaviour
{
    public GameObject InGame;
    public TMPro.TMP_Text importedplayername;
    public TMPro.TMP_Text playername;

    public GameObject sp1, sp2, sp3;
    public GameObject txt1, txt2, txt3;

    void Start()
    {
        StartCoroutine("timertoshowgame");
    }

    IEnumerator timertoshowgame()
    {
        importedplayername.text = playername.text;
        yield return new WaitForSeconds(2);
        sp1.SetActive(false);
        txt1.SetActive(true);
        yield return new WaitForSeconds(2);
        sp2.SetActive(false);
        txt2.SetActive(true);
        yield return new WaitForSeconds(2);
        sp3.SetActive(false);
        txt3.SetActive(true);
        yield return new WaitForSeconds(2);
        gameObject.SetActive(false);
        InGame.SetActive(true);
    }
    
}

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    private void Start()
    {
        StartCoroutine("panelTimer", 5.0f);
    }

    public IEnumerator panelTimer(float waitTime)
    {
        if (gameObject.activeSelf) yield break;
        yield return new WaitForSeconds(waitTime);
    } 
}

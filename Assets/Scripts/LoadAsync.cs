using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadAsync : MonoBehaviour
{
    public void StartRoutine(string scene)
    {
        StartCoroutine(LoadScene(scene));
    }
    public IEnumerator LoadScene(string scene)
    {
        yield return new WaitForSeconds(1f);
        SceneManager.LoadSceneAsync(scene);
    }
}
